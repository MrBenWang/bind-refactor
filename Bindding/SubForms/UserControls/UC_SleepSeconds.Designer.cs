namespace Bindding.SubForms.UserControls
{
    partial class UC_SleepSeconds
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
            this.uc_after_search = new UC_SecondsMinMax();
            this.uc_baidu_search = new UC_SecondsMinMax();
            this.uc_popup = new UC_SecondsMinMax();
            this.uc_recon = new UC_SecondsMinMax();

            Bindding.ExcuteClasses.RandomMinMax randomMinMax4 = new Bindding.ExcuteClasses.RandomMinMax();
            Bindding.ExcuteClasses.RandomMinMax randomMinMax3 = new Bindding.ExcuteClasses.RandomMinMax();
            Bindding.ExcuteClasses.RandomMinMax randomMinMax2 = new Bindding.ExcuteClasses.RandomMinMax();
            Bindding.ExcuteClasses.RandomMinMax randomMinMax1 = new Bindding.ExcuteClasses.RandomMinMax();
            this.gb_SleepSeconds = new System.Windows.Forms.GroupBox();
            this.gb_SleepSeconds.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_SleepSeconds
            // 
            this.gb_SleepSeconds.Controls.Add(this.uc_recon);
            this.gb_SleepSeconds.Controls.Add(this.uc_popup);
            this.gb_SleepSeconds.Controls.Add(this.uc_baidu_search);
            this.gb_SleepSeconds.Controls.Add(this.uc_after_search);
            this.gb_SleepSeconds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_SleepSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_SleepSeconds.Location = new System.Drawing.Point(0, 0);
            this.gb_SleepSeconds.Name = "gb_SleepSeconds";
            this.gb_SleepSeconds.Size = new System.Drawing.Size(290, 178);
            this.gb_SleepSeconds.TabIndex = 4;
            this.gb_SleepSeconds.TabStop = false;
            this.gb_SleepSeconds.Text = "搜素间隔时间(毫秒)";
            // 
            // uc_after_search
            // 
            this.uc_after_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_after_search.ForeColor = System.Drawing.Color.Black;
            this.uc_after_search.Location = new System.Drawing.Point(3, 17);
            this.uc_after_search.MaximumSize = new System.Drawing.Size(268, 35);
            this.uc_after_search.MinimumSize = new System.Drawing.Size(268, 35);
            randomMinMax4.max_ms = 1000;
            randomMinMax4.min_ms = 1000;
            this.uc_after_search.MyMinMax = randomMinMax4;
            this.uc_after_search.MyTitle = "查询后等待点击";
            this.uc_after_search.Name = "uc_after_search";
            this.uc_after_search.Size = new System.Drawing.Size(268, 35);
            this.uc_after_search.TabIndex = 0;
            // 
            // uc_baidu_search
            // 
            this.uc_baidu_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_baidu_search.ForeColor = System.Drawing.Color.Black;
            this.uc_baidu_search.Location = new System.Drawing.Point(3, 52);
            this.uc_baidu_search.MaximumSize = new System.Drawing.Size(268, 35);
            this.uc_baidu_search.MinimumSize = new System.Drawing.Size(268, 35);
            randomMinMax3.max_ms = 1000;
            randomMinMax3.min_ms = 1000;
            this.uc_baidu_search.MyMinMax = randomMinMax3;
            this.uc_baidu_search.MyTitle = "下次查询等待";
            this.uc_baidu_search.Name = "uc_baidu_search";
            this.uc_baidu_search.Size = new System.Drawing.Size(268, 35);
            this.uc_baidu_search.TabIndex = 1;
            // 
            // uc_popup
            // 
            this.uc_popup.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_popup.ForeColor = System.Drawing.Color.Black;
            this.uc_popup.Location = new System.Drawing.Point(3, 87);
            this.uc_popup.MaximumSize = new System.Drawing.Size(268, 35);
            this.uc_popup.MinimumSize = new System.Drawing.Size(268, 35);
            randomMinMax2.max_ms = 1000;
            randomMinMax2.min_ms = 1000;
            this.uc_popup.MyMinMax = randomMinMax2;
            this.uc_popup.MyTitle = "弹出页面存在";
            this.uc_popup.Name = "uc_popup";
            this.uc_popup.Size = new System.Drawing.Size(268, 35);
            this.uc_popup.TabIndex = 2;
            // 
            // uc_recon
            // 
            this.uc_recon.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_recon.ForeColor = System.Drawing.Color.Black;
            this.uc_recon.Location = new System.Drawing.Point(3, 122);
            this.uc_recon.MaximumSize = new System.Drawing.Size(268, 35);
            this.uc_recon.MinimumSize = new System.Drawing.Size(268, 35);
            randomMinMax1.max_ms = 1000;
            randomMinMax1.min_ms = 1000;
            this.uc_recon.MyMinMax = randomMinMax1;
            this.uc_recon.MyTitle = "adsl等待重连";
            this.uc_recon.Name = "uc_recon";
            this.uc_recon.Size = new System.Drawing.Size(268, 35);
            this.uc_recon.TabIndex = 3;
            // 
            // UC_SleepSeconds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_SleepSeconds);
            this.Name = "UC_SleepSeconds";
            this.Size = new System.Drawing.Size(290, 178);
            this.gb_SleepSeconds.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SleepSeconds;
        private UC_SecondsMinMax uc_recon;
        private UC_SecondsMinMax uc_popup;
        private UC_SecondsMinMax uc_baidu_search;
        private UC_SecondsMinMax uc_after_search;
    }
}
