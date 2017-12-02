using Bindding.ExcuteClasses;
using System.Windows.Forms;

namespace Bindding.SubForms.UserControls
{
    public partial class UC_AdslAccount : BaseConfigUserControl
    {
        protected override void InitData()
        {
            txt_AdslUserName.Text = CommonParameter.ConfigParam.adsl_info.username;
            txt_AdslPwd.Text = CommonParameter.ConfigParam.adsl_info.password;
        }

        protected override bool VerifyData()
        {
            if (string.IsNullOrEmpty(txt_AdslUserName.Text.Trim()))
            {
                MessageBox.Show("Adsl账户，不能为空!", "配置验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txt_AdslPwd.Text.Trim()))
            {
                MessageBox.Show("Adsl密码，不能为空!", "配置验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        protected override void UpdateData()
        {
            CommonParameter.ConfigParam.adsl_info.username = txt_AdslUserName.Text.Trim();
            CommonParameter.ConfigParam.adsl_info.password = txt_AdslPwd.Text.Trim();
        }
    }
}