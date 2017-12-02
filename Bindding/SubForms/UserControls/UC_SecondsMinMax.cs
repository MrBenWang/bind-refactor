using Bindding.ExcuteClasses;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bindding.SubForms.UserControls
{
    /// <summary>
    /// 毫秒最大，最小时间
    /// </summary>
    public partial class UC_SecondsMinMax : UserControl
    {
        public UC_SecondsMinMax()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 设置标题
        /// </summary>
        [Browsable(true)]
        [Description("文本框前的标题")]
        public string MyTitle
        {
            get { return lb_MinMax_Title.Text; }
            set { lb_MinMax_Title.Text = value; }
        }

        /// <summary>
        /// 设置最小最大的值
        /// </summary>
        public RandomMinMax MyMinMax
        {
            get
            {
                return new RandomMinMax()
                {
                    min_ms = Convert.ToInt32(txtMin.Text),
                    max_ms = Convert.ToInt32(txtMax.Text)
                };
            }
            set
            {
                txtMin.Text = value.min_ms.ToString();
                txtMax.Text = value.max_ms.ToString();
            }
        }

        /// <summary>
        /// 验证最小最大值
        /// </summary>
        internal bool VerifyMinMax()
        {
            if (Convert.ToInt32(txtMin.Text) > Convert.ToInt32(txtMax.Text))
            {
                MessageBox.Show(this.lb_MinMax_Title.Text + " 最小值不能大于最大值");
                return false;
            }

            return true;
        }

        private void txtMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字，回车，删除键
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtMax_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMax.Text))
            {
                txtMax.Text = "0"; // 如果是空的，则置为0
            }
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能输入数字，回车，删除键
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtMin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMin.Text))
            {
                txtMin.Text = "0"; // 如果是空的，则置为0
            }
        }
    }
}