namespace Bindding.SubForms.UserControls
{
    partial class UC_AdslAccount
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
        protected override void InitializeComponent()
        {
            this.gb_adsl = new System.Windows.Forms.GroupBox();
            this.txt_AdslPwd = new System.Windows.Forms.TextBox();
            this.txt_AdslUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_adsl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_adsl
            // 
            this.gb_adsl.Controls.Add(this.txt_AdslPwd);
            this.gb_adsl.Controls.Add(this.txt_AdslUserName);
            this.gb_adsl.Controls.Add(this.label1);
            this.gb_adsl.Controls.Add(this.label2);
            this.gb_adsl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_adsl.Location = new System.Drawing.Point(0, 0);
            this.gb_adsl.Name = "gb_adsl";
            this.gb_adsl.Size = new System.Drawing.Size(320, 80);
            this.gb_adsl.TabIndex = 7;
            this.gb_adsl.TabStop = false;
            this.gb_adsl.Text = "ADSL(未开放)";
            // 
            // txt_AdslPwd
            // 
            this.txt_AdslPwd.Location = new System.Drawing.Point(67, 47);
            this.txt_AdslPwd.Name = "txt_AdslPwd";
            this.txt_AdslPwd.Size = new System.Drawing.Size(213, 21);
            this.txt_AdslPwd.TabIndex = 2;
            // 
            // txt_AdslUserName
            // 
            this.txt_AdslUserName.Location = new System.Drawing.Point(67, 20);
            this.txt_AdslUserName.Name = "txt_AdslUserName";
            this.txt_AdslUserName.Size = new System.Drawing.Size(213, 21);
            this.txt_AdslUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // UC_AdslAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_adsl);
            this.Name = "UC_AdslAccount";
            this.Size = new System.Drawing.Size(320, 80);
            this.gb_adsl.ResumeLayout(false);
            this.gb_adsl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_adsl;
        private System.Windows.Forms.TextBox txt_AdslPwd;
        private System.Windows.Forms.TextBox txt_AdslUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
