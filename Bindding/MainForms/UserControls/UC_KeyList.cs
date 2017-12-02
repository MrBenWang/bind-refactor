using Bindding.ExcuteClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bindding.MainForms.UserControls
{
    public partial class UC_KeyList : BaseUserControl
    {
        private DataGridView dgv_keys;

        public UC_KeyList()
        {
            InitializeComponent();
            this.dgv_keys = this.uC_MyDataGridView_Style1.MyDataGridView;
            this.dgv_keys.Columns.AddRange(InitDGVHeader());
            if (!DesignMode)
            {
                this.dgv_keys.DataSource = this.DGVDataSource;
            }
        }

        public int MyCurrentNum
        {
            set
            {
                if (this.IsHandleCreated)
                {
                    this.lbCurrentNum.Invoke(new Action(() => { this.lbCurrentNum.Text = value.ToString(); }));
                }
                else
                {
                    this.lbCurrentNum.Text = value.ToString();
                }
            }
        }

        #region 设置表头

        private DataGridViewTextBoxColumn ch_key;
        private DataGridViewTextBoxColumn ch_value;

        private DataGridViewColumn[] InitDGVHeader()
        {
            this.ch_key = new DataGridViewTextBoxColumn();
            this.ch_value = new DataGridViewTextBoxColumn();

            //
            // key
            //
            this.ch_key.DataPropertyName = "Key";
            this.ch_key.Frozen = true;
            this.ch_key.HeaderText = "关键字";
            this.ch_key.Name = "ch_No";
            this.ch_key.ReadOnly = true;
            this.ch_key.Width = 80;
            //
            // value
            //
            this.ch_value.DataPropertyName = "Value";
            this.ch_value.Frozen = true;
            this.ch_value.HeaderText = "匹配域名";
            this.ch_value.Name = "ch_Time";
            this.ch_value.Width = 100;

            var _columns = new DataGridViewColumn[] {
                this.ch_key,
                this.ch_value};

            return _columns;
        }

        #endregion 设置表头

        private BindingList<KeyValuePair<string, string>> _dataSource;

        private BindingList<KeyValuePair<string, string>> DGVDataSource
        {
            get
            {
                if (_dataSource == null)
                {
                    this.RefreshData();
                }

                return _dataSource;
            }
        }

        internal void RefreshData()
        {
            this.lbTotalNum.Text = CommonParameter.ConfigParam.loop_count.ToString();
            _dataSource = new BindingList<KeyValuePair<string, string>>();
            CommonParameter.ConfigParam.key_match_list.ForEach(x =>
            {
                _dataSource.Add(new KeyValuePair<string, string>(x.Key, x.Value));
            });

            this.dgv_keys.DataSource = _dataSource;
        }
    }
}