namespace Bindding.MainForms.UserControls
{
    partial class UC_MyDataGridView_Style
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_style = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_style)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_style
            // 
            this.dgv_style.AllowUserToResizeRows = false;
            this.dgv_style.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_style.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_style.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_style.Location = new System.Drawing.Point(0, 0);
            this.dgv_style.MultiSelect = false;
            this.dgv_style.Name = "dgv_style";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_style.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_style.RowTemplate.Height = 23;
            this.dgv_style.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_style.Size = new System.Drawing.Size(466, 198);
            this.dgv_style.TabIndex = 0;
            this.dgv_style.TabStop = false;
            this.dgv_style.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_style_DataBindingComplete);
            // 
            // UC_MyDataGridView_Style
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_style);
            this.Name = "UC_MyDataGridView_Style";
            this.Size = new System.Drawing.Size(466, 198);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_style)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_style;
    }
}
