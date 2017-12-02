using Bindding.ExcuteClasses;
using System;
using System.Windows.Forms;

namespace Bindding.SubForms
{
    public partial class SF_StartupConfig : Form
    {
        public SF_StartupConfig()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.uC_ChangeIP1.VerifyAndSaveData())
            {
                return;
            }

            if (!this.uC_Keywords1.VerifyAndSaveData())
            {
                return;
            }

            CommonFunction.WriteConfig();
            CommonFunction.WriteLogInFile("更新 启动配置信息!", LogType.RunLog);
            MessageBox.Show("更新[启动配置信息]成功！");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}