using Bindding.ExcuteClasses;
using System;
using System.IO;
using System.Windows.Forms;

namespace Bindding.SubForms
{
    public partial class SF_RegisterForm : Form
    {
        public SF_RegisterForm()
        {
            InitializeComponent();

            var _v_info = LicenseHelper.ValidationGetInfo();
            if (_v_info != null)
            {
                var _days = _v_info.ExpirationDate - DateTime.Now;
                lbTitle.Text = string.Format("还有 {0} 天使用期！", _days.Days.ToString());
                btnReg.Text = "重 新 注 册";
            }
            else
            {
                txtMachineNum.Text = LicenseHelper.GetOnwerPrivateKey();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMachineNum.Text))
            {
                MessageBox.Show("机器码为空！");
                return;
            }

            Clipboard.SetDataObject(txtMachineNum.Text);
            MessageBox.Show("复制成功");
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegisterNum.Text))
            {
                MessageBox.Show("注册码为空！");
                return;
            }

            File.WriteAllText("license.lic", txtRegisterNum.Text);
            var _v_info = LicenseHelper.ValidationGetInfo();
            if (_v_info != null)
            {
                LicenseHelper.RegsterIsSuccess(true);
                MessageBox.Show("注册成功！");
                this.Close();
            }
            else
            {
                LicenseHelper.RegsterIsSuccess(false);
                MessageBox.Show("注册失败！", "提示", MessageBoxButtons.OK);
            }
        }

        private void txtRegisterNum_Click(object sender, EventArgs e)
        {
            txtRegisterNum.SelectAll();
        }

        private void txtMachineNum_Click(object sender, EventArgs e)
        {
            txtMachineNum.SelectAll();
        }

        private void btnReReg_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("如果重新注册，将会重新计算日期！\r\n确定[重新注册]?", "警 告", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                result = MessageBox.Show("确定[重新注册]?", "警 告", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                return;
            }

            txtMachineNum.Text = LicenseHelper.GetOnwerPrivateKey();
        }
    }
}