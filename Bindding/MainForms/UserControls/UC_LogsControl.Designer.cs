namespace Bindding.MainForms.UserControls
{
    partial class UC_LogsControl
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
            this.btn_DelLog = new System.Windows.Forms.Button();
            this.btn_CleanLog = new System.Windows.Forms.Button();
            this.btn_ExportLog = new System.Windows.Forms.Button();
            this.uC_MyDataGridView_Style1 = new Bindding.MainForms.UserControls.UC_MyDataGridView_Style();
            this.lb_ip_address = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_DelLog
            // 
            this.btn_DelLog.Location = new System.Drawing.Point(253, 3);
            this.btn_DelLog.Name = "btn_DelLog";
            this.btn_DelLog.Size = new System.Drawing.Size(75, 23);
            this.btn_DelLog.TabIndex = 1;
            this.btn_DelLog.Text = "删除日志";
            this.btn_DelLog.UseVisualStyleBackColor = true;
            this.btn_DelLog.Click += new System.EventHandler(this.btn_DelLog_Click);
            // 
            // btn_CleanLog
            // 
            this.btn_CleanLog.Location = new System.Drawing.Point(334, 3);
            this.btn_CleanLog.Name = "btn_CleanLog";
            this.btn_CleanLog.Size = new System.Drawing.Size(75, 23);
            this.btn_CleanLog.TabIndex = 2;
            this.btn_CleanLog.Text = "清空日志";
            this.btn_CleanLog.UseVisualStyleBackColor = true;
            this.btn_CleanLog.Click += new System.EventHandler(this.btn_CleanLog_Click);
            // 
            // btn_ExportLog
            // 
            this.btn_ExportLog.Location = new System.Drawing.Point(415, 3);
            this.btn_ExportLog.Name = "btn_ExportLog";
            this.btn_ExportLog.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportLog.TabIndex = 3;
            this.btn_ExportLog.Text = "导出日志";
            this.btn_ExportLog.UseVisualStyleBackColor = true;
            this.btn_ExportLog.Click += new System.EventHandler(this.btn_ExportLog_Click);
            // 
            // uC_MyDataGridView_Style1
            // 
            this.uC_MyDataGridView_Style1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uC_MyDataGridView_Style1.Location = new System.Drawing.Point(0, 30);
            this.uC_MyDataGridView_Style1.Name = "uC_MyDataGridView_Style1";
            this.uC_MyDataGridView_Style1.Size = new System.Drawing.Size(520, 100);
            this.uC_MyDataGridView_Style1.TabIndex = 5;
            // 
            // lb_ip_address
            // 
            this.lb_ip_address.AutoSize = true;
            this.lb_ip_address.Location = new System.Drawing.Point(3, 8);
            this.lb_ip_address.Name = "lb_ip_address";
            this.lb_ip_address.Size = new System.Drawing.Size(89, 12);
            this.lb_ip_address.TabIndex = 6;
            this.lb_ip_address.Text = "未检测到IP地址";
            // 
            // UC_LogsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_ip_address);
            this.Controls.Add(this.uC_MyDataGridView_Style1);
            this.Controls.Add(this.btn_ExportLog);
            this.Controls.Add(this.btn_CleanLog);
            this.Controls.Add(this.btn_DelLog);
            this.Name = "UC_LogsControl";
            this.Size = new System.Drawing.Size(520, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_DelLog;
        private System.Windows.Forms.Button btn_CleanLog;
        private System.Windows.Forms.Button btn_ExportLog;
        private UC_MyDataGridView_Style uC_MyDataGridView_Style1;
        private System.Windows.Forms.Label lb_ip_address;
    }
}
