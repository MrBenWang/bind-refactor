namespace Bindding.MainForms
{
    partial class TestUCForm
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
            this.uC_LogsControl1 = new Bindding.MainForms.UserControls.UC_LogsControl();
            this.SuspendLayout();
            // 
            // uC_LogsControl1
            // 
            this.uC_LogsControl1.Location = new System.Drawing.Point(139, 39);
            this.uC_LogsControl1.Name = "uC_LogsControl1";
            this.uC_LogsControl1.Size = new System.Drawing.Size(577, 236);
            this.uC_LogsControl1.TabIndex = 0;
            // 
            // TestUCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 399);
            this.Controls.Add(this.uC_LogsControl1);
            this.Name = "TestUCForm";
            this.Text = "TestUCForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UC_LogsControl uC_LogsControl1;



    }
}