namespace Bindding.SubForms.UserControls
{
    partial class UC_SimulateSpeed
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
            this.uc_k_keyword = new UC_SecondsMinMax();
            this.uc_m_click_search = new UC_SecondsMinMax();
            this.uc_m_move_search = new UC_SecondsMinMax();
            this.uc_m_scroll = new UC_SecondsMinMax();

            Bindding.ExcuteClasses.RandomMinMax randomMinMax4 = new Bindding.ExcuteClasses.RandomMinMax();
            Bindding.ExcuteClasses.RandomMinMax randomMinMax3 = new Bindding.ExcuteClasses.RandomMinMax();
            Bindding.ExcuteClasses.RandomMinMax randomMinMax2 = new Bindding.ExcuteClasses.RandomMinMax();
            Bindding.ExcuteClasses.RandomMinMax randomMinMax1 = new Bindding.ExcuteClasses.RandomMinMax();
            this.gb_simulate = new System.Windows.Forms.GroupBox();
            this.gb_simulate.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_simulate
            // 
            this.gb_simulate.Controls.Add(this.uc_k_keyword);
            this.gb_simulate.Controls.Add(this.uc_m_click_search);
            this.gb_simulate.Controls.Add(this.uc_m_move_search);
            this.gb_simulate.Controls.Add(this.uc_m_scroll);
            this.gb_simulate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_simulate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_simulate.Location = new System.Drawing.Point(0, 0);
            this.gb_simulate.Name = "gb_simulate";
            this.gb_simulate.Size = new System.Drawing.Size(288, 173);
            this.gb_simulate.TabIndex = 4;
            this.gb_simulate.TabStop = false;
            this.gb_simulate.Text = "模拟操作时间(毫秒)";
            // 
            // uc_m_scroll
            // 
            this.uc_m_scroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_m_scroll.ForeColor = System.Drawing.Color.Black;
            this.uc_m_scroll.Location = new System.Drawing.Point(3, 17);
            this.uc_m_scroll.MaximumSize = new System.Drawing.Size(268, 35);
            this.uc_m_scroll.MinimumSize = new System.Drawing.Size(268, 35);
            randomMinMax4.max_ms = 1000;
            randomMinMax4.min_ms = 1000;
            this.uc_m_scroll.MyMinMax = randomMinMax4;
            this.uc_m_scroll.MyTitle = "鼠标滑轮一次";
            this.uc_m_scroll.Name = "uc_m_scroll";
            this.uc_m_scroll.Size = new System.Drawing.Size(268, 35);
            this.uc_m_scroll.TabIndex = 0;
            // 
            // uc_m_move_search
            // 
            this.uc_m_move_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_m_move_search.ForeColor = System.Drawing.Color.Black;
            this.uc_m_move_search.Location = new System.Drawing.Point(3, 52);
            this.uc_m_move_search.MaximumSize = new System.Drawing.Size(268, 35);
            this.uc_m_move_search.MinimumSize = new System.Drawing.Size(268, 35);
            randomMinMax3.max_ms = 1000;
            randomMinMax3.min_ms = 1000;
            this.uc_m_move_search.MyMinMax = randomMinMax3;
            this.uc_m_move_search.MyTitle = "鼠标移到搜索框";
            this.uc_m_move_search.Name = "uc_m_move_search";
            this.uc_m_move_search.Size = new System.Drawing.Size(268, 35);
            this.uc_m_move_search.TabIndex = 1;
            // 
            // uc_m_click_search
            // 
            this.uc_m_click_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_m_click_search.ForeColor = System.Drawing.Color.Black;
            this.uc_m_click_search.Location = new System.Drawing.Point(3, 87);
            this.uc_m_click_search.MaximumSize = new System.Drawing.Size(268, 35);
            this.uc_m_click_search.MinimumSize = new System.Drawing.Size(268, 35);
            randomMinMax2.max_ms = 1000;
            randomMinMax2.min_ms = 1000;
            this.uc_m_click_search.MyMinMax = randomMinMax2;
            this.uc_m_click_search.MyTitle = "鼠标点击搜索框";
            this.uc_m_click_search.Name = "uc_m_click_search";
            this.uc_m_click_search.Size = new System.Drawing.Size(268, 35);
            this.uc_m_click_search.TabIndex = 2;
            // 
            // uc_k_keyword
            // 
            this.uc_k_keyword.Dock = System.Windows.Forms.DockStyle.Top;
            this.uc_k_keyword.ForeColor = System.Drawing.Color.Black;
            this.uc_k_keyword.Location = new System.Drawing.Point(3, 122);
            this.uc_k_keyword.MaximumSize = new System.Drawing.Size(268, 35);
            this.uc_k_keyword.MinimumSize = new System.Drawing.Size(268, 35);
            randomMinMax1.max_ms = 1000;
            randomMinMax1.min_ms = 1000;
            this.uc_k_keyword.MyMinMax = randomMinMax1;
            this.uc_k_keyword.MyTitle = "键盘输入每个字";
            this.uc_k_keyword.Name = "uc_k_keyword";
            this.uc_k_keyword.Size = new System.Drawing.Size(268, 35);
            this.uc_k_keyword.TabIndex = 3;
            // 
            // UC_SimulateSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_simulate);
            this.Name = "UC_SimulateSpeed";
            this.Size = new System.Drawing.Size(288, 173);
            this.gb_simulate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_simulate;
        private UC_SecondsMinMax uc_k_keyword;
        private UC_SecondsMinMax uc_m_click_search;
        private UC_SecondsMinMax uc_m_move_search;
        private UC_SecondsMinMax uc_m_scroll;


    }
}
