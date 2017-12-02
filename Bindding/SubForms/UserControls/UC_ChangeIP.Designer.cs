namespace Bindding.SubForms.UserControls
{
    partial class UC_ChangeIP
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
            this.gb_changeIp = new System.Windows.Forms.GroupBox();
            this.rbBtnNone = new System.Windows.Forms.RadioButton();
            this.rdBtnIP = new System.Windows.Forms.RadioButton();
            this.rdBtnAdsl = new System.Windows.Forms.RadioButton();
            this.gb_changeIp.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_changeIp
            // 
            this.gb_changeIp.Controls.Add(this.rbBtnNone);
            this.gb_changeIp.Controls.Add(this.rdBtnIP);
            this.gb_changeIp.Controls.Add(this.rdBtnAdsl);
            this.gb_changeIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_changeIp.Location = new System.Drawing.Point(0, 0);
            this.gb_changeIp.Name = "gb_changeIp";
            this.gb_changeIp.Size = new System.Drawing.Size(285, 60);
            this.gb_changeIp.TabIndex = 5;
            this.gb_changeIp.TabStop = false;
            this.gb_changeIp.Text = "切换IP方式";
            // 
            // rbBtnNone
            // 
            this.rbBtnNone.AutoSize = true;
            this.rbBtnNone.Location = new System.Drawing.Point(158, 20);
            this.rbBtnNone.Name = "rbBtnNone";
            this.rbBtnNone.Size = new System.Drawing.Size(47, 16);
            this.rbBtnNone.TabIndex = 2;
            this.rbBtnNone.Text = "未知";
            this.rbBtnNone.UseVisualStyleBackColor = true;
            this.rbBtnNone.Visible = false;
            // 
            // rdBtnIP
            // 
            this.rdBtnIP.AutoSize = true;
            this.rdBtnIP.Checked = true;
            this.rdBtnIP.Location = new System.Drawing.Point(19, 20);
            this.rdBtnIP.Name = "rdBtnIP";
            this.rdBtnIP.Size = new System.Drawing.Size(59, 16);
            this.rdBtnIP.TabIndex = 1;
            this.rdBtnIP.TabStop = true;
            this.rdBtnIP.Text = "IP精灵";
            this.rdBtnIP.UseVisualStyleBackColor = true;
            // 
            // rdBtnAdsl
            // 
            this.rdBtnAdsl.AutoSize = true;
            this.rdBtnAdsl.Location = new System.Drawing.Point(93, 20);
            this.rdBtnAdsl.Name = "rdBtnAdsl";
            this.rdBtnAdsl.Size = new System.Drawing.Size(47, 16);
            this.rdBtnAdsl.TabIndex = 0;
            this.rdBtnAdsl.Text = "ADSL";
            this.rdBtnAdsl.UseVisualStyleBackColor = true;
            this.rdBtnAdsl.Visible = false;
            // 
            // UC_ChangeIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_changeIp);
            this.Name = "UC_ChangeIP";
            this.Size = new System.Drawing.Size(285, 60);
            this.gb_changeIp.ResumeLayout(false);
            this.gb_changeIp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_changeIp;
        private System.Windows.Forms.RadioButton rdBtnIP;
        private System.Windows.Forms.RadioButton rdBtnAdsl;
        private System.Windows.Forms.RadioButton rbBtnNone;
    }
}
