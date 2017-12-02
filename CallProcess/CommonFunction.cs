using Newtonsoft.Json;
using System;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace CallProcess
{
    internal static class CommonFunction
    {
        /// <summary>
        /// 重置运行数
        /// </summary>
        internal static void ResetRunNo()
        {
            string _path = Environment.CurrentDirectory + "\\bindding.db";
            if (File.Exists(_path))
            {
                var m_dbConnection = new SQLiteConnection("Data Source=bindding.db;Version=3;");
                m_dbConnection.Open();
                string sql = string.Format("UPDATE run_parameters SET CurLoopNo=1;");
                SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);
                cmd.ExecuteNonQuery();
                m_dbConnection.Close();
            }
        }
    }
}