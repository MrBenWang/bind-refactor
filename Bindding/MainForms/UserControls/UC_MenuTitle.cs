using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bindding.ExcuteClasses;
using Bindding.SubForms;

namespace Bindding.MainForms.UserControls
{
    /// <summary>
    /// 标题控件
    /// </summary>
    public partial class UC_MenuTitle : BaseUserControl
    {
        internal event EventHandler OnStartupClosed;

        public UC_MenuTitle()
        {
            InitializeComponent();
        }

        private void tsmi_config_startup_Click(object sender, EventArgs e)
        {
            SF_StartupConfig _myform = new SF_StartupConfig();
            _myform.StartPosition = FormStartPosition.CenterParent;
            _myform.FormClosed += (o1, e1) => OnStartupClosed(null, null);
            _myform.ShowDialog();
        }

        private void tsmi_config_account_Click(object sender, EventArgs e)
        {
            SF_AccountInfo _myform = new SF_AccountInfo();
            _myform.StartPosition = FormStartPosition.CenterParent;
            _myform.FormClosed += (o1, e1) =>
            {
                if (!string.IsNullOrEmpty(CommonParameter.ConfigParam.ipelf_info.soft_path)
                    && !CommonParameter.IPElfIsInit)
                {
                    // IP精灵 已经配置路径，并且没有启动的情况下；关闭软件
                }
            };
            _myform.ShowDialog();
        }

        private void tsmi_config_timespan_Click(object sender, EventArgs e)
        {
            SF_ConfigForm _myform = new SF_ConfigForm();
            _myform.StartPosition = FormStartPosition.CenterParent;
            _myform.ShowDialog();
        }

        private void tsmi_registere_Click(object sender, EventArgs e)
        {
            SF_RegisterForm _myform = new SF_RegisterForm();
            _myform.StartPosition = FormStartPosition.CenterParent;
            _myform.ShowDialog();
        }

        private void tsmi_version_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                this,
                "版本1.0\r\n发布日期:2017/03/29\r\n联系QQ:123456！",
                "版本信息",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}