using Bindding.ExcuteClasses;
using System;
using System.Windows.Forms;

namespace Bindding.SubForms
{
    public partial class SF_ConfigForm : Form
    {
        public SF_ConfigForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.uC_SimulateSpeed1.VerifyAndSaveData())
            {
                return;
            }

            if (!this.uC_SleepSeconds1.VerifyAndSaveData())
            {
                return;
            }

            CommonFunction.WriteConfig();
            CommonFunction.WriteLogInFile("更新 时间间隔配置信息!", LogType.RunLog);
            MessageBox.Show("时间间隔配置，更新成功！");
            this.Close();
        }
    }
}