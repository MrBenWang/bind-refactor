namespace Bindding.MainForms.UserControls
{
    partial class UC_MenuTitle
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
            this.menuTitle = new System.Windows.Forms.MenuStrip();
            this.tsmi_main_config = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_config_startup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_config_account = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmi_config_timespan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_main_help = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_registere = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_version = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitle
            // 
            this.menuTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_main_config,
            this.tsmi_main_help});
            this.menuTitle.Location = new System.Drawing.Point(0, 0);
            this.menuTitle.Name = "menuTitle";
            this.menuTitle.Size = new System.Drawing.Size(150, 25);
            this.menuTitle.TabIndex = 3;
            this.menuTitle.Text = "menuStrip1";
            // 
            // tsmi_main_config
            // 
            this.tsmi_main_config.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_config_startup,
            this.tsmi_config_account,
            this.toolStripSeparator1,
            this.tsmi_config_timespan});
            this.tsmi_main_config.Name = "tsmi_main_config";
            this.tsmi_main_config.Size = new System.Drawing.Size(44, 21);
            this.tsmi_main_config.Text = "配置";
            // 
            // tsmi_config_startup
            // 
            this.tsmi_config_startup.Name = "tsmi_config_startup";
            this.tsmi_config_startup.Size = new System.Drawing.Size(152, 22);
            this.tsmi_config_startup.Text = "启动参数";
            this.tsmi_config_startup.Click += new System.EventHandler(this.tsmi_config_startup_Click);
            // 
            // tsmi_config_account
            // 
            this.tsmi_config_account.Name = "tsmi_config_account";
            this.tsmi_config_account.Size = new System.Drawing.Size(152, 22);
            this.tsmi_config_account.Text = "账户信息";
            this.tsmi_config_account.Click += new System.EventHandler(this.tsmi_config_account_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmi_config_timespan
            // 
            this.tsmi_config_timespan.Name = "tsmi_config_timespan";
            this.tsmi_config_timespan.Size = new System.Drawing.Size(152, 22);
            this.tsmi_config_timespan.Text = "模拟时间间隔";
            this.tsmi_config_timespan.Click += new System.EventHandler(this.tsmi_config_timespan_Click);
            // 
            // tsmi_main_help
            // 
            this.tsmi_main_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_registere,
            this.tsmi_version});
            this.tsmi_main_help.Name = "tsmi_main_help";
            this.tsmi_main_help.Size = new System.Drawing.Size(44, 21);
            this.tsmi_main_help.Text = "帮助";
            // 
            // tsmi_registere
            // 
            this.tsmi_registere.Name = "tsmi_registere";
            this.tsmi_registere.Size = new System.Drawing.Size(100, 22);
            this.tsmi_registere.Text = "注册";
            this.tsmi_registere.Click += new System.EventHandler(this.tsmi_registere_Click);
            // 
            // tsmi_version
            // 
            this.tsmi_version.Name = "tsmi_version";
            this.tsmi_version.Size = new System.Drawing.Size(100, 22);
            this.tsmi_version.Text = "版本";
            this.tsmi_version.Click += new System.EventHandler(this.tsmi_version_Click);
            // 
            // UC_MenuTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuTitle);
            this.Name = "UC_MenuTitle";
            this.Size = new System.Drawing.Size(150, 25);
            this.menuTitle.ResumeLayout(false);
            this.menuTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuTitle;
        private System.Windows.Forms.ToolStripMenuItem tsmi_main_config;
        private System.Windows.Forms.ToolStripMenuItem tsmi_config_startup;
        private System.Windows.Forms.ToolStripMenuItem tsmi_config_account;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_config_timespan;
        private System.Windows.Forms.ToolStripMenuItem tsmi_main_help;
        private System.Windows.Forms.ToolStripMenuItem tsmi_registere;
        private System.Windows.Forms.ToolStripMenuItem tsmi_version;
    }
}
