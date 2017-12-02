namespace Bindding.MainForms.UserControls
{
    partial class UC_KeyList
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
            this.lbTotalNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCurrentNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uC_MyDataGridView_Style1 = new Bindding.MainForms.UserControls.UC_MyDataGridView_Style();
            this.SuspendLayout();
            // 
            // lbTotalNum
            // 
            this.lbTotalNum.AutoSize = true;
            this.lbTotalNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTotalNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTotalNum.Location = new System.Drawing.Point(112, 11);
            this.lbTotalNum.Name = "lbTotalNum";
            this.lbTotalNum.Size = new System.Drawing.Size(26, 16);
            this.lbTotalNum.TabIndex = 21;
            this.lbTotalNum.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "次 共";
            // 
            // lbCurrentNum
            // 
            this.lbCurrentNum.AutoSize = true;
            this.lbCurrentNum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCurrentNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbCurrentNum.Location = new System.Drawing.Point(48, 11);
            this.lbCurrentNum.Name = "lbCurrentNum";
            this.lbCurrentNum.Size = new System.Drawing.Size(17, 16);
            this.lbCurrentNum.TabIndex = 19;
            this.lbCurrentNum.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "第";
            // 
            // uC_MyDataGridView_Style1
            // 
            this.uC_MyDataGridView_Style1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uC_MyDataGridView_Style1.Location = new System.Drawing.Point(0, 30);
            this.uC_MyDataGridView_Style1.Name = "uC_MyDataGridView_Style1";
            this.uC_MyDataGridView_Style1.Size = new System.Drawing.Size(180, 100);
            this.uC_MyDataGridView_Style1.TabIndex = 0;
            // 
            // UC_KeyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTotalNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCurrentNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uC_MyDataGridView_Style1);
            this.Name = "UC_KeyList";
            this.Size = new System.Drawing.Size(180, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_MyDataGridView_Style uC_MyDataGridView_Style1;
        private System.Windows.Forms.Label lbTotalNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCurrentNum;
        private System.Windows.Forms.Label label3;
    }
}
