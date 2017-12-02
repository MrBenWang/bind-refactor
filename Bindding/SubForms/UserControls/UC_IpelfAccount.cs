using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bindding.ExcuteClasses;

namespace Bindding.SubForms.UserControls
{
    public partial class UC_IpelfAccount : BaseConfigUserControl
    {
        protected override void InitData()
        {
            txt_IPUser.Text = CommonParameter.ConfigParam.ipelf_info.username;
            txt_IpPwd.Text = CommonParameter.ConfigParam.ipelf_info.password;
            lbProviceCity.Text = CommonParameter.ConfigParam.ipelf_info.provice + " " + CommonParameter.ConfigParam.ipelf_info.city;

            // 文件存在，才能运行IP精灵
            string _path = CommonParameter.ConfigParam.ipelf_info.soft_path;
            if (System.IO.File.Exists(_path))
            {
                txtExePath.Text = CommonParameter.ConfigParam.ipelf_info.soft_path;
                this.comboxIPProvice.DataSource = CommonParameter.GetIPElfProvices;
                this.comboxIPProvice.SelectedIndex = this.comboxIPProvice.FindStringExact(CommonParameter.ConfigParam.ipelf_info.provice);
            }
            else
            {
                this.comboxIPProvice.DataSource = new List<string>(new string[1] { "所有" });
            }
        }

        /// <summary>
        /// 更新 IP精灵账户信息
        /// </summary>
        protected override void UpdateData()
        {
            VerifyData();
            CommonParameter.ConfigParam.ipelf_info.username = txt_IPUser.Text.Trim();
            CommonParameter.ConfigParam.ipelf_info.password = txt_IpPwd.Text.Trim();
            CommonParameter.ConfigParam.ipelf_info.soft_path = txtExePath.Text;
            CommonParameter.ConfigParam.ipelf_info.provice = this.comboxIPProvice.SelectedValue.ToString().Trim();
            CommonParameter.ConfigParam.ipelf_info.city = this.comboxIPCity.SelectedValue.ToString().Trim();
        }

        /// <summary>
        /// 验证保存的数据
        /// </summary>
        /// <returns></returns>
        protected override bool VerifyData()
        {
            if (string.IsNullOrEmpty(txt_IPUser.Text.Trim()))
            {
                MessageBox.Show("IP精灵账户，不能为空!", "配置验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txt_IpPwd.Text.Trim()))
            {
                MessageBox.Show("IP精灵密码，不能为空!", "配置验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtExePath.Text.Trim()))
            {
                MessageBox.Show("IP精灵文件路径，不能为空!", "配置验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// 选择文件路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowExePath_Click(object sender, EventArgs e)
        {
            var _dialogResult = this.ipexeFileDialog.ShowDialog();
            if (_dialogResult == DialogResult.OK)
            {
                txtExePath.Text = this.ipexeFileDialog.FileName.Replace("\\", "/");
            }
        }

        private void comboxIPProvice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboxIPProvice.SelectedValue.ToString() == "所有")
            {
                this.comboxIPCity.DataSource = new List<string>(new string[1] { "所有" });
            }
            else
            {
                this.comboxIPCity.DataSource = CommonParameter.IpelfCurrentInstance.IPGetCitys(this.comboxIPProvice.SelectedValue.ToString());
                this.comboxIPCity.SelectedIndex = this.comboxIPCity.FindStringExact(CommonParameter.ConfigParam.ipelf_info.city);
            }
        }
    }
}