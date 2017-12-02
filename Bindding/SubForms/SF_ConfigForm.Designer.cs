namespace Bindding.SubForms
{
    partial class SF_ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uC_SleepSeconds1 = new Bindding.SubForms.UserControls.UC_SleepSeconds();
            this.uC_SimulateSpeed1 = new Bindding.SubForms.UserControls.UC_SimulateSpeed();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uC_SleepSeconds1
            // 
            this.uC_SleepSeconds1.Location = new System.Drawing.Point(0, 12);
            this.uC_SleepSeconds1.Name = "uC_SleepSeconds1";
            this.uC_SleepSeconds1.Size = new System.Drawing.Size(277, 165);
            this.uC_SleepSeconds1.TabIndex = 0;
            // 
            // uC_SimulateSpeed1
            // 
            this.uC_SimulateSpeed1.Location = new System.Drawing.Point(283, 12);
            this.uC_SimulateSpeed1.Name = "uC_SimulateSpeed1";
            this.uC_SimulateSpeed1.Size = new System.Drawing.Size(283, 165);
            this.uC_SimulateSpeed1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(312, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(163, 199);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "确  定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SF_ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 234);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.uC_SimulateSpeed1);
            this.Controls.Add(this.uC_SleepSeconds1);
            this.Name = "SF_ConfigForm";
            this.Text = "时间间隔配置界面";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UC_SleepSeconds uC_SleepSeconds1;
        private UserControls.UC_SimulateSpeed uC_SimulateSpeed1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}