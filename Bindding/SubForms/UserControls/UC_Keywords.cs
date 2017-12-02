using Bindding.ExcuteClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bindding.SubForms.UserControls
{
    public partial class UC_Keywords : BaseConfigUserControl
    {
        protected override void InitData()
        {
            // 关键字信息
            var _list = CommonParameter.ConfigParam.key_match_list;
            txtSearchKeys.Text = string.Join(Environment.NewLine, _list.Select(s => s.Key));
            lb_keyNum.Text = _list.Count + "行";
            // 匹配域名
            txtSearchMatches.Text = string.Join(Environment.NewLine, _list.Select(s => s.Value));
            lb_matchNum.Text = _list.Count + "行";

            this.lb_LoopCount.SelectedIndex = this.lb_LoopCount.FindStringExact(CommonParameter.ConfigParam.loop_count.ToString());
        }

        protected override bool VerifyData()
        {
            if (string.IsNullOrEmpty(txtSearchKeys.Text.Trim()))
            {
                MessageBox.Show("关键字信息，不能为空!", "配置验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(txtSearchMatches.Text.Trim()))
            {
                MessageBox.Show("匹配域名信息，不能为空!", "配置验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtSearchKeys.Lines.Length != txtSearchMatches.Lines.Length)
            {
                MessageBox.Show("关键字和域名，数量不匹配!", "配置验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (this.lb_LoopCount.SelectedIndex < 0)
            {
                MessageBox.Show("请选择循环次数!", "配置验证", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        protected override void UpdateData()
        {
            var _newList = new List<KeyValuePair<string, string>>();
            KeyValuePair<string, string> _tmp;
            for (int i = 0; i < txtSearchKeys.Lines.Length; i++)
            {
                _tmp = new KeyValuePair<string, string>(txtSearchKeys.Lines[i], txtSearchMatches.Lines[i]);
                _newList.Add(_tmp);
            }

            CommonParameter.ConfigParam.loop_count = Convert.ToInt32(this.lb_LoopCount.Text);
            CommonParameter.ConfigParam.key_match_list = _newList;
        }

        private void txtSearchKeys_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lb_keyNum.Text = (txtSearchKeys.Lines.Length + 1).ToString() + "行";
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                lb_keyNum.Text = txtSearchKeys.Lines.Length.ToString() + "行";
            }
        }

        private void txtSearchKeys_Leave(object sender, EventArgs e)
        {
            lb_keyNum.Text = txtSearchKeys.Lines.Length.ToString() + "行";
        }

        private void txtSearchMatches_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                lb_matchNum.Text = (txtSearchMatches.Lines.Length + 1).ToString() + "行";
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                lb_matchNum.Text = txtSearchMatches.Lines.Length.ToString() + "行";
            }
        }

        private void txtSearchMatches_Leave(object sender, EventArgs e)
        {
            lb_matchNum.Text = txtSearchMatches.Lines.Length.ToString() + "行";
        }
    }
}