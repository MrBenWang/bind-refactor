using Bindding.ExcuteClasses;
using Bindding.ExcuteClasses.AboutParameter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bindding.MainForms.UserControls
{
    public partial class UC_LogsControl : BaseUserControl
    {
        private DataGridView dgv_Logs;
        private SqliteHelper _sqlite;

        public UC_LogsControl()
        {
            InitializeComponent();
            this.dgv_Logs = this.uC_MyDataGridView_Style1.MyDataGridView;
            this.dgv_Logs.MultiSelect = true;
            this.dgv_Logs.Columns.AddRange(this.HeaderList);

            if (!DesignMode)
            {
                _sqlite = SqliteHelper.GetInstance;
                this.lb_ip_address.Text = CommonFunction.GetIpAddress();
            }

            // 日志目录不存在
            if (!Directory.Exists(ConstParameter.LogTypePath.LogDir))
            {
                Directory.CreateDirectory(ConstParameter.LogTypePath.LogDir);
            }
        }

        #region 设置表头

        private DataGridViewColumn[] _headerlist;
        private DataGridViewTextBoxColumn ch_No;
        private DataGridViewTextBoxColumn ch_Time;
        private DataGridViewTextBoxColumn ch_Key;
        private DataGridViewTextBoxColumn ch_Title;
        private DataGridViewTextBoxColumn ch_Website;

        private DataGridViewColumn[] HeaderList
        {
            get
            {
                if (_headerlist == null)
                {
                    this.ch_No = new DataGridViewTextBoxColumn();
                    this.ch_Time = new DataGridViewTextBoxColumn();
                    this.ch_Key = new DataGridViewTextBoxColumn();
                    this.ch_Title = new DataGridViewTextBoxColumn();
                    this.ch_Website = new DataGridViewTextBoxColumn();

                    //
                    // ch_No
                    //
                    this.ch_No.DataPropertyName = "ch_No";
                    this.ch_No.Frozen = true;
                    this.ch_No.HeaderText = "编号";
                    this.ch_No.Name = "ch_No";
                    this.ch_No.ReadOnly = true;
                    this.ch_No.Width = 40;
                    //
                    // ch_Time
                    //
                    this.ch_Time.DataPropertyName = "ch_Time";
                    this.ch_Time.Frozen = true;
                    this.ch_Time.HeaderText = "时间";
                    this.ch_Time.Name = "ch_Time";
                    this.ch_Time.Width = 100;
                    this.ch_Time.DefaultCellStyle.Format = "MM/dd HH:mm:ss";
                    //
                    // ch_Key
                    //
                    this.ch_Key.DataPropertyName = "ch_Key";
                    this.ch_Key.HeaderText = "关键词";
                    this.ch_Key.Name = "ch_Key";
                    this.ch_Key.Width = 80;
                    //
                    // ch_Title
                    //
                    this.ch_Title.DataPropertyName = "ch_Title";
                    this.ch_Title.HeaderText = "标题信息";
                    this.ch_Title.Name = "ch_Title";
                    this.ch_Title.Width = 160;
                    //
                    // ch_Websit
                    //
                    this.ch_Website.DataPropertyName = "ch_Website";
                    DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
                    dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    this.ch_Website.DefaultCellStyle = dataGridViewCellStyle2;
                    this.ch_Website.HeaderText = "网址";
                    this.ch_Website.Name = "ch_Website";
                    this.ch_Website.Width = 140;

                    _headerlist = new DataGridViewColumn[] {
                this.ch_No,
                this.ch_Time,
                this.ch_Key,
                this.ch_Title,
                this.ch_Website};
                }
                return _headerlist;
            }
        }

        #endregion 设置表头

        /// <summary>
        /// 刷新表格
        /// </summary>
        private void RefreshTable()
        {
            this.dgv_Logs.DataSource = _sqlite.QryClickLogs();
        }

        /// <summary>
        /// 初始化加载 日志
        /// </summary>
        internal void InitLoadLogs()
        {
            this.RefreshTable();
        }

        internal void AddNewLog(ContentLog _newLog)
        {
            _newLog.ch_Time = DateTime.Now;
            _sqlite.InsertClickLog(_newLog);
            this.RefreshTable();
        }

        /// <summary>
        /// 删除已选中的日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DelLog_Click(object sender, EventArgs e)
        {
            if (this.dgv_Logs.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选中要删除的日志");
                return;
            }
            for (int i = this.dgv_Logs.SelectedRows.Count; i > 0; i--)
            {
                _sqlite.DeleteClickLog(dgv_Logs.SelectedRows[i - 1].Cells["ch_No"].Value.ToString());
            }

            this.RefreshTable();
        }

        /// <summary>
        /// 清空日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CleanLog_Click(object sender, EventArgs e)
        {
            DialogResult _r = MessageBox.Show("确定要清除所有日志吗？", "清除提示", MessageBoxButtons.OKCancel);
            if (_r == DialogResult.OK)
            {
                _sqlite.DeleteAllCliclLogs();
                this.dgv_Logs.DataSource = new List<ContentLog>();
            }
        }

        private void btn_ExportLog_Click(object sender, EventArgs e)
        {
            this.RefreshTable();
            var _dataSource = (List<ContentLog>)this.dgv_Logs.DataSource;
            if (_dataSource.Count == 0)
            {
                MessageBox.Show("没有日志内容，不需要导出！", "导出日志");
                return;
            }

            StringBuilder _sb = new StringBuilder();
            string _strTemplate = string.Empty;
            for (int i = 0; i < this.HeaderList.Length; i++)
            {
                _strTemplate += this.HeaderList[i].HeaderText + ":[{" + i + "}]\t";
            }

            _strTemplate += Environment.NewLine;
            foreach (ContentLog _tmploop in _dataSource)
            {
                _sb.Append(string.Format(
                    _strTemplate,
                    _tmploop.ch_No,
                    _tmploop.ch_Time,
                    _tmploop.ch_Key,
                    _tmploop.ch_Title,
                    _tmploop.ch_Website));
            }

            SaveFileDialog _sfd = new SaveFileDialog();
            _sfd.Filter = "文本文件(.txt)|*.txt";
            _sfd.FilterIndex = 1;
            if (_sfd.ShowDialog() == DialogResult.OK && _sfd.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(_sfd.FileName, false, Encoding.UTF8))
                {
                    sw.Write(_sb.ToString());
                }
            }
        }
    }
}