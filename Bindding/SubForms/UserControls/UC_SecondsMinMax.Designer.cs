namespace Bindding.SubForms.UserControls
{
    partial class UC_SecondsMinMax
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_MinMax_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMin
            // 
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMin.Location = new System.Drawing.Point(92, 7);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(40, 21);
            this.txtMin.TabIndex = 0;
            this.txtMin.Text = "1000";
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMin.WordWrap = false;
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMin_KeyPress);
            this.txtMin.Leave += new System.EventHandler(this.txtMin_Leave);
            // 
            // txtMax
            // 
            this.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMax.Location = new System.Drawing.Point(157, 7);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(40, 21);
            this.txtMax.TabIndex = 1;
            this.txtMax.Text = "1000";
            this.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMax.WordWrap = false;
            this.txtMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMax_KeyPress);
            this.txtMax.Leave += new System.EventHandler(this.txtMax_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 99;
            this.label2.Text = "到";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 99;
            this.label3.Text = "毫秒 随机";
            // 
            // lb_MinMax_Title
            // 
            this.lb_MinMax_Title.AutoSize = true;
            this.lb_MinMax_Title.Location = new System.Drawing.Point(3, 11);
            this.lb_MinMax_Title.Name = "lb_MinMax_Title";
            this.lb_MinMax_Title.Size = new System.Drawing.Size(29, 12);
            this.lb_MinMax_Title.TabIndex = 99;
            this.lb_MinMax_Title.Text = "标题";
            this.lb_MinMax_Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UC_SecondsMinMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_MinMax_Title);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.MaximumSize = new System.Drawing.Size(268, 35);
            this.MinimumSize = new System.Drawing.Size(268, 35);
            this.Name = "UC_SecondsMinMax";
            this.Size = new System.Drawing.Size(268, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_MinMax_Title;
    }
}
