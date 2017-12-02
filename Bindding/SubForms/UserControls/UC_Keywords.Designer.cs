namespace Bindding.SubForms.UserControls
{
    partial class UC_Keywords
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
            this.gb_keywords = new System.Windows.Forms.GroupBox();
            this.lb_matchNum = new System.Windows.Forms.Label();
            this.lb_keyNum = new System.Windows.Forms.Label();
            this.lb_LoopCount = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ckSearchMatches = new System.Windows.Forms.CheckBox();
            this.ckSearchKeys = new System.Windows.Forms.CheckBox();
            this.txtSearchMatches = new System.Windows.Forms.TextBox();
            this.txtSearchKeys = new System.Windows.Forms.TextBox();
            this.gb_keywords.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_keywords
            // 
            this.gb_keywords.Controls.Add(this.lb_matchNum);
            this.gb_keywords.Controls.Add(this.lb_keyNum);
            this.gb_keywords.Controls.Add(this.lb_LoopCount);
            this.gb_keywords.Controls.Add(this.label2);
            this.gb_keywords.Controls.Add(this.label1);
            this.gb_keywords.Controls.Add(this.ckSearchMatches);
            this.gb_keywords.Controls.Add(this.ckSearchKeys);
            this.gb_keywords.Controls.Add(this.txtSearchMatches);
            this.gb_keywords.Controls.Add(this.txtSearchKeys);
            this.gb_keywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_keywords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gb_keywords.Location = new System.Drawing.Point(0, 0);
            this.gb_keywords.Name = "gb_keywords";
            this.gb_keywords.Size = new System.Drawing.Size(410, 228);
            this.gb_keywords.TabIndex = 3;
            this.gb_keywords.TabStop = false;
            this.gb_keywords.Text = "搜索配置";
            // 
            // lb_matchNum
            // 
            this.lb_matchNum.AutoSize = true;
            this.lb_matchNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_matchNum.ForeColor = System.Drawing.Color.Fuchsia;
            this.lb_matchNum.Location = new System.Drawing.Point(293, 17);
            this.lb_matchNum.Name = "lb_matchNum";
            this.lb_matchNum.Size = new System.Drawing.Size(34, 16);
            this.lb_matchNum.TabIndex = 18;
            this.lb_matchNum.Text = "0行";
            // 
            // lb_keyNum
            // 
            this.lb_keyNum.AutoSize = true;
            this.lb_keyNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_keyNum.ForeColor = System.Drawing.Color.Fuchsia;
            this.lb_keyNum.Location = new System.Drawing.Point(104, 17);
            this.lb_keyNum.Name = "lb_keyNum";
            this.lb_keyNum.Size = new System.Drawing.Size(34, 16);
            this.lb_keyNum.TabIndex = 16;
            this.lb_keyNum.Text = "0行";
            // 
            // lb_LoopCount
            // 
            this.lb_LoopCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_LoopCount.FormattingEnabled = true;
            this.lb_LoopCount.ItemHeight = 16;
            this.lb_LoopCount.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lb_LoopCount.Location = new System.Drawing.Point(344, 36);
            this.lb_LoopCount.Name = "lb_LoopCount";
            this.lb_LoopCount.Size = new System.Drawing.Size(51, 180);
            this.lb_LoopCount.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(156, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 80);
            this.label2.TabIndex = 14;
            this.label2.Text = "一\r\n对\r\n一\r\n关\r\n系";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(342, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "循环次数";
            // 
            // ckSearchMatches
            // 
            this.ckSearchMatches.AutoSize = true;
            this.ckSearchMatches.Checked = true;
            this.ckSearchMatches.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ckSearchMatches.Location = new System.Drawing.Point(204, 19);
            this.ckSearchMatches.Name = "ckSearchMatches";
            this.ckSearchMatches.Size = new System.Drawing.Size(96, 16);
            this.ckSearchMatches.TabIndex = 8;
            this.ckSearchMatches.Tag = "圣导师";
            this.ckSearchMatches.Text = "点击匹配域名";
            this.ckSearchMatches.UseVisualStyleBackColor = true;
            // 
            // ckSearchKeys
            // 
            this.ckSearchKeys.AutoSize = true;
            this.ckSearchKeys.Checked = true;
            this.ckSearchKeys.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ckSearchKeys.Location = new System.Drawing.Point(25, 20);
            this.ckSearchKeys.Name = "ckSearchKeys";
            this.ckSearchKeys.Size = new System.Drawing.Size(84, 16);
            this.ckSearchKeys.TabIndex = 7;
            this.ckSearchKeys.Text = "搜索关键字";
            this.ckSearchKeys.UseVisualStyleBackColor = true;
            // 
            // txtSearchMatches
            // 
            this.txtSearchMatches.ForeColor = System.Drawing.Color.Black;
            this.txtSearchMatches.Location = new System.Drawing.Point(187, 36);
            this.txtSearchMatches.Multiline = true;
            this.txtSearchMatches.Name = "txtSearchMatches";
            this.txtSearchMatches.Size = new System.Drawing.Size(150, 181);
            this.txtSearchMatches.TabIndex = 5;
            this.txtSearchMatches.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchMatches_KeyPress);
            this.txtSearchMatches.Leave += new System.EventHandler(this.txtSearchMatches_Leave);
            // 
            // txtSearchKeys
            // 
            this.txtSearchKeys.ForeColor = System.Drawing.Color.Black;
            this.txtSearchKeys.Location = new System.Drawing.Point(6, 36);
            this.txtSearchKeys.Multiline = true;
            this.txtSearchKeys.Name = "txtSearchKeys";
            this.txtSearchKeys.Size = new System.Drawing.Size(144, 181);
            this.txtSearchKeys.TabIndex = 0;
            this.txtSearchKeys.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchKeys_KeyPress);
            this.txtSearchKeys.Leave += new System.EventHandler(this.txtSearchKeys_Leave);
            // 
            // UC_Keywords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_keywords);
            this.Name = "UC_Keywords";
            this.Size = new System.Drawing.Size(410, 228);
            this.gb_keywords.ResumeLayout(false);
            this.gb_keywords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_keywords;
        private System.Windows.Forms.CheckBox ckSearchMatches;
        private System.Windows.Forms.CheckBox ckSearchKeys;
        private System.Windows.Forms.TextBox txtSearchMatches;
        private System.Windows.Forms.TextBox txtSearchKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_LoopCount;
        private System.Windows.Forms.Label lb_keyNum;
        private System.Windows.Forms.Label lb_matchNum;
    }
}
