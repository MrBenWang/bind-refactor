namespace Bindding.SubForms
{
    partial class SF_RegisterForm
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegisterNum = new System.Windows.Forms.TextBox();
            this.txtMachineNum = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnReReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(122, 352);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(129, 30);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "复  制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(303, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "注 册 码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "机 器 码";
            // 
            // txtRegisterNum
            // 
            this.txtRegisterNum.Location = new System.Drawing.Point(289, 46);
            this.txtRegisterNum.Multiline = true;
            this.txtRegisterNum.Name = "txtRegisterNum";
            this.txtRegisterNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegisterNum.Size = new System.Drawing.Size(250, 300);
            this.txtRegisterNum.TabIndex = 8;
            this.txtRegisterNum.Click += new System.EventHandler(this.txtRegisterNum_Click);
            // 
            // txtMachineNum
            // 
            this.txtMachineNum.Location = new System.Drawing.Point(15, 46);
            this.txtMachineNum.Multiline = true;
            this.txtMachineNum.Name = "txtMachineNum";
            this.txtMachineNum.ReadOnly = true;
            this.txtMachineNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMachineNum.Size = new System.Drawing.Size(250, 300);
            this.txtMachineNum.TabIndex = 7;
            this.txtMachineNum.Click += new System.EventHandler(this.txtMachineNum_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("宋体", 9F);
            this.btnReg.Location = new System.Drawing.Point(395, 352);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(120, 30);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "注   册";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("宋体", 14F);
            this.lbTitle.Location = new System.Drawing.Point(88, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(86, 19);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "未 注 册";
            // 
            // btnReReg
            // 
            this.btnReReg.Location = new System.Drawing.Point(331, 5);
            this.btnReReg.Name = "btnReReg";
            this.btnReReg.Size = new System.Drawing.Size(113, 23);
            this.btnReReg.TabIndex = 13;
            this.btnReReg.Text = "清除注册信息";
            this.btnReReg.UseVisualStyleBackColor = true;
            this.btnReReg.Click += new System.EventHandler(this.btnReReg_Click);
            // 
            // SF_RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 391);
            this.Controls.Add(this.btnReReg);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegisterNum);
            this.Controls.Add(this.txtMachineNum);
            this.Controls.Add(this.btnReg);
            this.Name = "SF_RegisterForm";
            this.Text = "注册界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegisterNum;
        private System.Windows.Forms.TextBox txtMachineNum;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnReReg;
    }
}