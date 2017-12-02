namespace Bindding.SubForms
{
    partial class SF_StartupConfig
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
            this.uC_Keywords1 = new Bindding.SubForms.UserControls.UC_Keywords();
            this.uC_ChangeIP1 = new Bindding.SubForms.UserControls.UC_ChangeIP();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uC_Keywords1
            // 
            this.uC_Keywords1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_Keywords1.Location = new System.Drawing.Point(0, 60);
            this.uC_Keywords1.Name = "uC_Keywords1";
            this.uC_Keywords1.Size = new System.Drawing.Size(411, 228);
            this.uC_Keywords1.TabIndex = 1;
            // 
            // uC_ChangeIP1
            // 
            this.uC_ChangeIP1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_ChangeIP1.Location = new System.Drawing.Point(0, 0);
            this.uC_ChangeIP1.Name = "uC_ChangeIP1";
            this.uC_ChangeIP1.Size = new System.Drawing.Size(411, 60);
            this.uC_ChangeIP1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取  消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "确  定";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SF_StartupConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 339);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.uC_Keywords1);
            this.Controls.Add(this.uC_ChangeIP1);
            this.Name = "SF_StartupConfig";
            this.Text = "启动配置界面";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UC_ChangeIP uC_ChangeIP1;
        private UserControls.UC_Keywords uC_Keywords1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;


    }
}