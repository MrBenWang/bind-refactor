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
    public partial class UC_ChangeIP : BaseConfigUserControl
    {
        protected override void InitData()
        {
            switch (CommonParameter.ConfigParam.change_ip)
            {
                case ChangeIPType.ADSL:
                    rdBtnAdsl.Checked = true;
                    break;

                case ChangeIPType.IPElf:
                    rdBtnIP.Checked = true;
                    break;

                case ChangeIPType.NONE:
                    rbBtnNone.Checked = true;
                    break;
            }
        }

        protected override bool VerifyData()
        {
            if (rbBtnNone.Checked)
            {
                MessageBox.Show("切换IP方式，不能为未知!", "配置验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        protected override void UpdateData()
        {
            // 改变IP方式
            if (rdBtnAdsl.Checked)
            {
                CommonParameter.ConfigParam.change_ip = ChangeIPType.ADSL;
            }
            else if (rdBtnIP.Checked)
            {
                CommonParameter.ConfigParam.change_ip = ChangeIPType.IPElf;
            }
        }
    }
}