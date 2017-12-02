using Bindding.ExcuteClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bindding.SubForms
{
    public partial class SF_AccountInfo : Form
    {
        public SF_AccountInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 更新配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.uC_AdslAccount1.VerifyAndSaveData())
            {
                return;
            }

            if (!this.uC_IpelfAccount1.VerifyAndSaveData())
            {
                return;
            }

            CommonFunction.WriteConfig();
            CommonFunction.WriteLogInFile("更新 连接账户信息!", LogType.RunLog);
            if (CommonParameter.IPElfIsInit)
            {
                MessageBox.Show("连接 账户更新成功！");
            }
            else
            {
                MessageBox.Show("连接 账户更新成功！需要重启软件！");
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}