namespace Bindding.SubForms.UserControls
{
    partial class UC_IpelfAccount
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
            this.gb_ipelf = new System.Windows.Forms.GroupBox();
            this.btnShowExePath = new System.Windows.Forms.Button();
            this.txtExePath = new System.Windows.Forms.TextBox();
            this.linklbUserInfo = new System.Windows.Forms.LinkLabel();
            this.lbProviceCity = new System.Windows.Forms.Label();
            this.comboxIPCity = new System.Windows.Forms.ComboBox();
            this.comboxIPProvice = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IpPwd = new System.Windows.Forms.TextBox();
            this.txt_IPUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ipexeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gb_ipelf.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ipelf
            // 
            this.gb_ipelf.Controls.Add(this.btnShowExePath);
            this.gb_ipelf.Controls.Add(this.txtExePath);
            this.gb_ipelf.Controls.Add(this.linklbUserInfo);
            this.gb_ipelf.Controls.Add(this.lbProviceCity);
            this.gb_ipelf.Controls.Add(this.comboxIPCity);
            this.gb_ipelf.Controls.Add(this.comboxIPProvice);
            this.gb_ipelf.Controls.Add(this.label6);
            this.gb_ipelf.Controls.Add(this.label5);
            this.gb_ipelf.Controls.Add(this.txt_IpPwd);
            this.gb_ipelf.Controls.Add(this.txt_IPUser);
            this.gb_ipelf.Controls.Add(this.label3);
            this.gb_ipelf.Controls.Add(this.label4);
            this.gb_ipelf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_ipelf.Location = new System.Drawing.Point(0, 0);
            this.gb_ipelf.Name = "gb_ipelf";
            this.gb_ipelf.Size = new System.Drawing.Size(320, 180);
            this.gb_ipelf.TabIndex = 8;
            this.gb_ipelf.TabStop = false;
            this.gb_ipelf.Text = "IP精灵";
            // 
            // btnShowExePath
            // 
            this.btnShowExePath.Location = new System.Drawing.Point(222, 16);
            this.btnShowExePath.Name = "btnShowExePath";
            this.btnShowExePath.Size = new System.Drawing.Size(75, 23);
            this.btnShowExePath.TabIndex = 8;
            this.btnShowExePath.Text = "文件路径";
            this.btnShowExePath.UseVisualStyleBackColor = true;
            this.btnShowExePath.Click += new System.EventHandler(this.btnShowExePath_Click);
            // 
            // txtExePath
            // 
            this.txtExePath.Location = new System.Drawing.Point(23, 18);
            this.txtExePath.Name = "txtExePath";
            this.txtExePath.ReadOnly = true;
            this.txtExePath.Size = new System.Drawing.Size(193, 21);
            this.txtExePath.TabIndex = 13;
            // 
            // linklbUserInfo
            // 
            this.linklbUserInfo.AutoSize = true;
            this.linklbUserInfo.Location = new System.Drawing.Point(45, 103);
            this.linklbUserInfo.Name = "linklbUserInfo";
            this.linklbUserInfo.Size = new System.Drawing.Size(53, 12);
            this.linklbUserInfo.TabIndex = 11;
            this.linklbUserInfo.TabStop = true;
            this.linklbUserInfo.Text = "账户信息";
            // 
            // lbProviceCity
            // 
            this.lbProviceCity.AutoSize = true;
            this.lbProviceCity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbProviceCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbProviceCity.Location = new System.Drawing.Point(104, 99);
            this.lbProviceCity.Name = "lbProviceCity";
            this.lbProviceCity.Size = new System.Drawing.Size(42, 16);
            this.lbProviceCity.TabIndex = 10;
            this.lbProviceCity.Text = "省份";
            // 
            // comboxIPCity
            // 
            this.comboxIPCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxIPCity.FormattingEnabled = true;
            this.comboxIPCity.Location = new System.Drawing.Point(180, 125);
            this.comboxIPCity.Name = "comboxIPCity";
            this.comboxIPCity.Size = new System.Drawing.Size(104, 20);
            this.comboxIPCity.TabIndex = 8;
            // 
            // comboxIPProvice
            // 
            this.comboxIPProvice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxIPProvice.FormattingEnabled = true;
            this.comboxIPProvice.Location = new System.Drawing.Point(57, 125);
            this.comboxIPProvice.Name = "comboxIPProvice";
            this.comboxIPProvice.Size = new System.Drawing.Size(82, 20);
            this.comboxIPProvice.TabIndex = 7;
            this.comboxIPProvice.SelectedIndexChanged += new System.EventHandler(this.comboxIPProvice_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "城市";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "省份";
            // 
            // txt_IpPwd
            // 
            this.txt_IpPwd.Location = new System.Drawing.Point(56, 72);
            this.txt_IpPwd.Name = "txt_IpPwd";
            this.txt_IpPwd.Size = new System.Drawing.Size(241, 21);
            this.txt_IpPwd.TabIndex = 2;
            // 
            // txt_IPUser
            // 
            this.txt_IPUser.Location = new System.Drawing.Point(56, 45);
            this.txt_IPUser.Name = "txt_IPUser";
            this.txt_IPUser.Size = new System.Drawing.Size(241, 21);
            this.txt_IPUser.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "账号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码";
            // 
            // ipexeFileDialog
            // 
            this.ipexeFileDialog.FileName = "ipjl.exe";
            this.ipexeFileDialog.Filter = "IP精灵执行文件|*.exe";
            this.ipexeFileDialog.Title = "请选择IP精灵的执行文件";
            // 
            // UC_IpelfAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_ipelf);
            this.Name = "UC_IpelfAccount";
            this.Size = new System.Drawing.Size(320, 180);
            this.gb_ipelf.ResumeLayout(false);
            this.gb_ipelf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ipelf;
        private System.Windows.Forms.Button btnShowExePath;
        private System.Windows.Forms.TextBox txtExePath;
        private System.Windows.Forms.LinkLabel linklbUserInfo;
        private System.Windows.Forms.Label lbProviceCity;
        private System.Windows.Forms.ComboBox comboxIPCity;
        private System.Windows.Forms.ComboBox comboxIPProvice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IpPwd;
        private System.Windows.Forms.TextBox txt_IPUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog ipexeFileDialog;
    }
}
