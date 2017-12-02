namespace Bindding.MainForms.UserControls
{
    partial class UC_BrowserTabs
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
            this.uc_tab_browsers = new System.Windows.Forms.TabControl();
            this.tb_search_page = new System.Windows.Forms.TabPage();
            this.uc_search_page = new Bindding.MainForms.UserControls.UC_Browser();
            this.tb_pop_page = new System.Windows.Forms.TabPage();
            this.uc_pop_page = new Bindding.MainForms.UserControls.UC_SimpleBrower();
            this.tb_second_page = new System.Windows.Forms.TabPage();
            this.uc_second_page = new Bindding.MainForms.UserControls.UC_SimpleBrower();
            this.uc_tab_browsers.SuspendLayout();
            this.tb_search_page.SuspendLayout();
            this.tb_pop_page.SuspendLayout();
            this.tb_second_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // uc_tab_browsers
            // 
            this.uc_tab_browsers.Controls.Add(this.tb_search_page);
            this.uc_tab_browsers.Controls.Add(this.tb_pop_page);
            this.uc_tab_browsers.Controls.Add(this.tb_second_page);
            this.uc_tab_browsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_tab_browsers.Location = new System.Drawing.Point(0, 0);
            this.uc_tab_browsers.Name = "uc_tab_browsers";
            this.uc_tab_browsers.SelectedIndex = 0;
            this.uc_tab_browsers.Size = new System.Drawing.Size(862, 514);
            this.uc_tab_browsers.TabIndex = 0;
            // 
            // tb_search_page
            // 
            this.tb_search_page.Controls.Add(this.uc_search_page);
            this.tb_search_page.Location = new System.Drawing.Point(4, 22);
            this.tb_search_page.Name = "tb_search_page";
            this.tb_search_page.Padding = new System.Windows.Forms.Padding(3);
            this.tb_search_page.Size = new System.Drawing.Size(854, 488);
            this.tb_search_page.TabIndex = 0;
            this.tb_search_page.Text = "搜索";
            this.tb_search_page.UseVisualStyleBackColor = true;
            // 
            // uc_search_page
            // 
            this.uc_search_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_search_page.Location = new System.Drawing.Point(3, 3);
            this.uc_search_page.Name = "uc_search_page";
            this.uc_search_page.Size = new System.Drawing.Size(848, 482);
            this.uc_search_page.TabIndex = 0;
            // 
            // tb_pop_page
            // 
            this.tb_pop_page.Controls.Add(this.uc_pop_page);
            this.tb_pop_page.Location = new System.Drawing.Point(4, 22);
            this.tb_pop_page.Name = "tb_pop_page";
            this.tb_pop_page.Padding = new System.Windows.Forms.Padding(3);
            this.tb_pop_page.Size = new System.Drawing.Size(854, 488);
            this.tb_pop_page.TabIndex = 1;
            this.tb_pop_page.Text = "弹出界面";
            this.tb_pop_page.UseVisualStyleBackColor = true;
            // 
            // uc_pop_page
            // 
            this.uc_pop_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_pop_page.Location = new System.Drawing.Point(3, 3);
            this.uc_pop_page.Name = "uc_pop_page";
            this.uc_pop_page.SecondPage = false;
            this.uc_pop_page.Size = new System.Drawing.Size(848, 482);
            this.uc_pop_page.TabIndex = 0;
            // 
            // tb_second_page
            // 
            this.tb_second_page.Controls.Add(this.uc_second_page);
            this.tb_second_page.Location = new System.Drawing.Point(4, 22);
            this.tb_second_page.Name = "tb_second_page";
            this.tb_second_page.Size = new System.Drawing.Size(854, 488);
            this.tb_second_page.TabIndex = 2;
            this.tb_second_page.Text = "二次点击界面";
            this.tb_second_page.UseVisualStyleBackColor = true;
            // 
            // uc_second_page
            // 
            this.uc_second_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_second_page.Location = new System.Drawing.Point(0, 0);
            this.uc_second_page.Name = "uc_second_page";
            this.uc_second_page.SecondPage = true;
            this.uc_second_page.Size = new System.Drawing.Size(854, 488);
            this.uc_second_page.TabIndex = 0;
            // 
            // UC_BrowserTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uc_tab_browsers);
            this.Name = "UC_BrowserTabs";
            this.Size = new System.Drawing.Size(862, 514);
            this.uc_tab_browsers.ResumeLayout(false);
            this.tb_search_page.ResumeLayout(false);
            this.tb_pop_page.ResumeLayout(false);
            this.tb_second_page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl uc_tab_browsers;
        private System.Windows.Forms.TabPage tb_search_page;
        private System.Windows.Forms.TabPage tb_pop_page;
        private System.Windows.Forms.TabPage tb_second_page;
        private UC_Browser uc_search_page;
        private UC_SimpleBrower uc_pop_page;
        private UC_SimpleBrower uc_second_page;
    }
}
