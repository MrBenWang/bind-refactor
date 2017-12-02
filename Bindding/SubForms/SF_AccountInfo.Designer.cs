namespace Bindding.SubForms
{
    partial class SF_AccountInfo
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
            this.uC_AdslAccount1 = new Bindding.SubForms.UserControls.UC_AdslAccount();
            this.uC_IpelfAccount1 = new Bindding.SubForms.UserControls.UC_IpelfAccount();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uC_AdslAccount1
            // 
            this.uC_AdslAccount1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_AdslAccount1.Location = new System.Drawing.Point(0, 0);
            this.uC_AdslAccount1.Name = "uC_AdslAccount1";
            this.uC_AdslAccount1.Size = new System.Drawing.Size(321, 80);
            this.uC_AdslAccount1.TabIndex = 0;
            // 
            // uC_IpelfAccount1
            // 
            this.uC_IpelfAccount1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_IpelfAccount1.Location = new System.Drawing.Point(0, 80);
            this.uC_IpelfAccount1.Name = "uC_IpelfAccount1";
            this.uC_IpelfAccount1.Size = new System.Drawing.Size(321, 165);
            this.uC_IpelfAccount1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(34, 266);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "确  定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(183, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SF_AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 310);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.uC_IpelfAccount1);
            this.Controls.Add(this.uC_AdslAccount1);
            this.Name = "SF_AccountInfo";
            this.Text = "账户配置信息";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UC_AdslAccount uC_AdslAccount1;
        private UserControls.UC_IpelfAccount uC_IpelfAccount1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}