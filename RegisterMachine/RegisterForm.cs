using EasyLicense.Lib.License;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace RegisterMachine
{
    public partial class RegisterForm : Form
    {
        private RegisterHelper reg;

        public RegisterForm()
        {
            InitializeComponent();
            reg = new RegisterHelper();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegisterNum.Text))
            {
                MessageBox.Show("未生成注册码！");
                return;
            }

            Clipboard.SetDataObject(txtRegisterNum.Text);
            MessageBox.Show("复制成功");
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMachineNum.Text))
                {
                    MessageBox.Show("机器码为空！");
                    return;
                }

                if (dtp_exp.Value < DateTime.Now)
                {
                    MessageBox.Show("过期时间小于当前时间！", "警 告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var privateKey = txtMachineNum.Text;
                var _xmlDoc = new XmlDocument();
                _xmlDoc.LoadXml(privateKey);
                var _newKey = _xmlDoc.SelectSingleNode("/Root/PrivateKey").InnerXml;
                var _id = _xmlDoc.SelectSingleNode("/Root/Params/id").InnerText;
                var _name = _xmlDoc.SelectSingleNode("/Root/Params/name").InnerText;
                var _expDate = _xmlDoc.SelectSingleNode("/Root/Params/expirationDate").InnerText;
                var _machineKey = _xmlDoc.SelectSingleNode("/Root/Params/dictionary").InnerText;

                var generator = new LicenseGenerator(_newKey);
                var dictionary = new Dictionary<string, string>();
                dictionary.Add("m", _machineKey);

                // generate the license
                var license = generator.Generate(_name, Guid.Parse(_id), dtp_exp.Value, dictionary, LicenseType.Standard);

                txtRegisterNum.Text = license;
            }
            catch (Exception ex)
            {
                MessageBox.Show("注册失败,异常:" + ex.Message, "提示", MessageBoxButtons.OK);
            }
        }

        private void btnSevenDay_Click(object sender, EventArgs e)
        {
            dtp_exp.Value = DateTime.Now.AddDays(7);
        }

        private void btnOneMonth_Click(object sender, EventArgs e)
        {
            dtp_exp.Value = DateTime.Now.AddMonths(1);
        }

        private void btnThreeMonth_Click(object sender, EventArgs e)
        {
            dtp_exp.Value = DateTime.Now.AddMonths(3);
        }

        private void btnSixMonth_Click(object sender, EventArgs e)
        {
            dtp_exp.Value = DateTime.Now.AddMonths(6);
        }

        private void btnOneYear_Click(object sender, EventArgs e)
        {
            dtp_exp.Value = DateTime.Now.AddYears(1);
        }

        private void btnForever_Click(object sender, EventArgs e)
        {
            dtp_exp.Value = DateTime.Now.AddYears(99);
        }

        private void txtMachineNum_Click(object sender, EventArgs e)
        {
            txtMachineNum.SelectAll();
        }

        private void txtRegisterNum_Click(object sender, EventArgs e)
        {
            txtRegisterNum.SelectAll();
        }
    }
}