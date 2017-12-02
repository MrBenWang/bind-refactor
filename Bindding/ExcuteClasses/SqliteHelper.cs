using Bindding.ExcuteClasses.AboutParameter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.IO;

namespace Bindding.ExcuteClasses
{
    /// <summary>
    /// sqlite操作类
    /// </summary>
    internal class SqliteHelper
    {
        private static SqliteHelper _current;
        private SQLiteConnection m_dbConnection;

        /// <summary>
        /// 是否存在数据库文件
        /// </summary>
        private bool _is_exist_file = false;

        internal static SqliteHelper GetInstance
        {
            get
            {
                if (_current == null)
                {
                    _current = new SqliteHelper();
                }

                return _current;
            }
        }

        private SqliteHelper()
        {
            CreateNewDatabase();
            ConnectToDatabase();
        }

        private void CreateNewDatabase()
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\" + ConstParameter.Sqlite_DB_NAME))
            {
                SQLiteConnection.CreateFile(Environment.CurrentDirectory + "\\" + ConstParameter.Sqlite_DB_NAME);
            }
            else
            {
                _is_exist_file = true;
            }
        }

        /// <summary>
        /// 创建数据表
        /// </summary>
        private void CreateTables()
        {
            // 创建日志表
            var sql = "create table click_logs(ch_No INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE, ch_Time DATETIME, ch_Key NVARCHAR(50), ch_Title NVARCHAR(200), ch_Website TEXT);";
            var command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            // 创建运行状态表
            // 当前表头索引，当前分辨率索引，当前循环次数
            // {"CurUserAgentIndex":0,"CurScrRslIndex":0,"CurLoopNo":1}
            sql = "create table run_parameters(CurUserAgentIndex INT, CurScrRslIndex INT, CurLoopNo INT);";
            sql += "insert into run_parameters values(0,0,1);";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            // 创建注册信息
        }

        private void ConnectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=" + ConstParameter.Sqlite_DB_NAME + ";Version=3;");
            m_dbConnection.Open();
            if (!_is_exist_file)
            {
                CreateTables(); // 刚刚新建的，需要创建表
            }
        }

        #region 日志操作

        /// <summary>
        /// 插入数据
        /// </summary>
        internal void InsertClickLog(ContentLog _entity)
        {
            string sql = string.Format("insert into click_logs values (null,@time,@key,@title,@website);");
            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);
            cmd.Parameters.Add(new SQLiteParameter("@time", _entity.ch_Time));
            cmd.Parameters.Add(new SQLiteParameter("@key", _entity.ch_Key));
            cmd.Parameters.Add(new SQLiteParameter("@title", _entity.ch_Title));
            cmd.Parameters.Add(new SQLiteParameter("@website", _entity.ch_Website));

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除日志
        /// </summary>
        /// <param name="_no"></param>
        internal void DeleteClickLog(string _no)
        {
            string sql = string.Format("delete from click_logs where ch_No=@ch_No;");
            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);
            cmd.Parameters.Add(new SQLiteParameter("@ch_No", _no));

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 删除所有日志
        /// </summary>
        internal void DeleteAllCliclLogs()
        {
            string sql = string.Format("delete from click_logs;");
            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <returns></returns>
        internal List<ContentLog> QryClickLogs()
        {
            string sql = "SELECT ch_No, ch_Time, ch_Key, ch_Title, ch_Website FROM click_logs order by ch_No desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            var _ret = new List<ContentLog>();
            while (reader.Read())
            {
                _ret.Add(new ContentLog()
                {
                    ch_Key = reader["ch_Key"].ToString(),
                    ch_No = reader["ch_No"].ToString(),
                    ch_Time = Convert.ToDateTime(reader["ch_Time"]),
                    ch_Title = reader["ch_Title"].ToString(),
                    ch_Website = reader["ch_Website"].ToString()
                });
            }

            return _ret;
        }

        #endregion 日志操作

        #region 运行状态

        /// <summary>
        /// 更新运行参数
        /// </summary>
        /// <param name="_entity"></param>
        internal void UpdateRunParams(RunParameters _entity)
        {
            string sql = string.Format("UPDATE run_parameters SET CurUserAgentIndex=@user_agent, CurScrRslIndex=@scr_rsl, CurLoopNo=@loop_no;");
            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);
            cmd.Parameters.Add(new SQLiteParameter("@user_agent", _entity.CurUserAgentIndex));
            cmd.Parameters.Add(new SQLiteParameter("@scr_rsl", _entity.CurScrRslIndex));
            cmd.Parameters.Add(new SQLiteParameter("@loop_no", _entity.CurLoopNo));

            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 查询运行参数
        /// </summary>
        /// <returns></returns>
        internal RunParameters QryRunParams()
        {
            string sql = "SELECT CurUserAgentIndex, CurScrRslIndex, CurLoopNo FROM run_parameters limit 0,1";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            RunParameters _ret = null;
            while (reader.Read())
            {
                _ret = new RunParameters()
                {
                    CurLoopNo = Convert.ToInt32(reader["CurLoopNo"]),
                    CurScrRslIndex = Convert.ToInt32(reader["CurScrRslIndex"]),
                    CurUserAgentIndex = Convert.ToInt32(reader["CurUserAgentIndex"])
                };
            }

            return _ret;
        }

        #endregion 运行状态
    }
}