namespace RegisterMachine
{
    partial class RegisterForm
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
            this.btnReg = new System.Windows.Forms.Button();
            this.txtMachineNum = new System.Windows.Forms.TextBox();
            this.txtRegisterNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSevenDay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOneMonth = new System.Windows.Forms.Button();
            this.btnThreeMonth = new System.Windows.Forms.Button();
            this.btnOneYear = new System.Windows.Forms.Button();
            this.btnForever = new System.Windows.Forms.Button();
            this.dtp_exp = new System.Windows.Forms.DateTimePicker();
            this.btnSixMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("宋体", 14F);
            this.btnReg.Location = new System.Drawing.Point(98, 378);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(126, 36);
            this.btnReg.TabIndex = 0;
            this.btnReg.Text = "注   册";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtMachineNum
            // 
            this.txtMachineNum.Location = new System.Drawing.Point(13, 72);
            this.txtMachineNum.Multiline = true;
            this.txtMachineNum.Name = "txtMachineNum";
            this.txtMachineNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMachineNum.Size = new System.Drawing.Size(250, 300);
            this.txtMachineNum.TabIndex = 1;
            this.txtMachineNum.Click += new System.EventHandler(this.txtMachineNum_Click);
            // 
            // txtRegisterNum
            // 
            this.txtRegisterNum.Location = new System.Drawing.Point(279, 72);
            this.txtRegisterNum.Multiline = true;
            this.txtRegisterNum.Name = "txtRegisterNum";
            this.txtRegisterNum.ReadOnly = true;
            this.txtRegisterNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegisterNum.Size = new System.Drawing.Size(250, 300);
            this.txtRegisterNum.TabIndex = 2;
            this.txtRegisterNum.Click += new System.EventHandler(this.txtRegisterNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "机器码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F);
            this.label2.Location = new System.Drawing.Point(294, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "注册码";
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("宋体", 14F);
            this.btnCopy.Location = new System.Drawing.Point(366, 378);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(126, 36);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "复制注册码";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSevenDay
            // 
            this.btnSevenDay.Location = new System.Drawing.Point(279, 8);
            this.btnSevenDay.Name = "btnSevenDay";
            this.btnSevenDay.Size = new System.Drawing.Size(75, 23);
            this.btnSevenDay.TabIndex = 7;
            this.btnSevenDay.Text = "七天";
            this.btnSevenDay.UseVisualStyleBackColor = true;
            this.btnSevenDay.Click += new System.EventHandler(this.btnSevenDay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F);
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "到期日期";
            // 
            // btnOneMonth
            // 
            this.btnOneMonth.Location = new System.Drawing.Point(366, 8);
            this.btnOneMonth.Name = "btnOneMonth";
            this.btnOneMonth.Size = new System.Drawing.Size(75, 23);
            this.btnOneMonth.TabIndex = 10;
            this.btnOneMonth.Text = "一月";
            this.btnOneMonth.UseVisualStyleBackColor = true;
            this.btnOneMonth.Click += new System.EventHandler(this.btnOneMonth_Click);
            // 
            // btnThreeMonth
            // 
            this.btnThreeMonth.Location = new System.Drawing.Point(454, 8);
            this.btnThreeMonth.Name = "btnThreeMonth";
            this.btnThreeMonth.Size = new System.Drawing.Size(75, 23);
            this.btnThreeMonth.TabIndex = 11;
            this.btnThreeMonth.Text = "三个月";
            this.btnThreeMonth.UseVisualStyleBackColor = true;
            this.btnThreeMonth.Click += new System.EventHandler(this.btnThreeMonth_Click);
            // 
            // btnOneYear
            // 
            this.btnOneYear.Location = new System.Drawing.Point(366, 41);
            this.btnOneYear.Name = "btnOneYear";
            this.btnOneYear.Size = new System.Drawing.Size(75, 23);
            this.btnOneYear.TabIndex = 12;
            this.btnOneYear.Text = "一年";
            this.btnOneYear.UseVisualStyleBackColor = true;
            this.btnOneYear.Click += new System.EventHandler(this.btnOneYear_Click);
            // 
            // btnForever
            // 
            this.btnForever.Location = new System.Drawing.Point(51, 41);
            this.btnForever.Name = "btnForever";
            this.btnForever.Size = new System.Drawing.Size(75, 23);
            this.btnForever.TabIndex = 13;
            this.btnForever.Text = "永久";
            this.btnForever.UseVisualStyleBackColor = true;
            this.btnForever.Click += new System.EventHandler(this.btnForever_Click);
            // 
            // dtp_exp
            // 
            this.dtp_exp.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtp_exp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.dtp_exp.Location = new System.Drawing.Point(98, 8);
            this.dtp_exp.Name = "dtp_exp";
            this.dtp_exp.Size = new System.Drawing.Size(162, 26);
            this.dtp_exp.TabIndex = 14;
            this.dtp_exp.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnSixMonth
            // 
            this.btnSixMonth.Location = new System.Drawing.Point(279, 41);
            this.btnSixMonth.Name = "btnSixMonth";
            this.btnSixMonth.Size = new System.Drawing.Size(75, 23);
            this.btnSixMonth.TabIndex = 15;
            this.btnSixMonth.Text = "半年";
            this.btnSixMonth.UseVisualStyleBackColor = true;
            this.btnSixMonth.Click += new System.EventHandler(this.btnSixMonth_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 426);
            this.Controls.Add(this.btnSixMonth);
            this.Controls.Add(this.dtp_exp);
            this.Controls.Add(this.btnForever);
            this.Controls.Add(this.btnOneYear);
            this.Controls.Add(this.btnThreeMonth);
            this.Controls.Add(this.btnOneMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSevenDay);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegisterNum);
            this.Controls.Add(this.txtMachineNum);
            this.Controls.Add(this.btnReg);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtMachineNum;
        private System.Windows.Forms.TextBox txtRegisterNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSevenDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOneMonth;
        private System.Windows.Forms.Button btnThreeMonth;
        private System.Windows.Forms.Button btnOneYear;
        private System.Windows.Forms.Button btnForever;
        private System.Windows.Forms.DateTimePicker dtp_exp;
        private System.Windows.Forms.Button btnSixMonth;
    }
}