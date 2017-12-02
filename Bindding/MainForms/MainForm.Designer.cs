using Bindding.MainForms.UserControls;
namespace Bindding.MainForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStopClick = new System.Windows.Forms.Button();
            this.btnBeginClick = new System.Windows.Forms.Button();
            this.uC_KeyList1 = new Bindding.MainForms.UserControls.UC_KeyList();
            this.uC_LogsControl1 = new Bindding.MainForms.UserControls.UC_LogsControl();
            this.uc_browser_tabs = new Bindding.MainForms.UserControls.UC_BrowserTabs();
            this.uC_MenuTitle1 = new Bindding.MainForms.UserControls.UC_MenuTitle();
            this.SuspendLayout();
            // 
            // btnStopClick
            // 
            this.btnStopClick.Enabled = false;
            this.btnStopClick.Location = new System.Drawing.Point(228, 60);
            this.btnStopClick.Name = "btnStopClick";
            this.btnStopClick.Size = new System.Drawing.Size(75, 23);
            this.btnStopClick.TabIndex = 8;
            this.btnStopClick.Text = "停止点击";
            this.btnStopClick.UseVisualStyleBackColor = true;
            this.btnStopClick.Click += new System.EventHandler(this.btnStopClick_Click);
            // 
            // btnBeginClick
            // 
            this.btnBeginClick.Location = new System.Drawing.Point(228, 31);
            this.btnBeginClick.Name = "btnBeginClick";
            this.btnBeginClick.Size = new System.Drawing.Size(75, 23);
            this.btnBeginClick.TabIndex = 7;
            this.btnBeginClick.Text = "开始点击";
            this.btnBeginClick.UseVisualStyleBackColor = true;
            this.btnBeginClick.Click += new System.EventHandler(this.btnBeginClick_Click);
            // 
            // uC_KeyList1
            // 
            this.uC_KeyList1.Location = new System.Drawing.Point(12, 23);
            this.uC_KeyList1.Name = "uC_KeyList1";
            this.uC_KeyList1.Size = new System.Drawing.Size(180, 130);
            this.uC_KeyList1.TabIndex = 3;
            // 
            // uC_LogsControl1
            // 
            this.uC_LogsControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uC_LogsControl1.Location = new System.Drawing.Point(341, 25);
            this.uC_LogsControl1.Name = "uC_LogsControl1";
            this.uC_LogsControl1.Size = new System.Drawing.Size(523, 128);
            this.uC_LogsControl1.TabIndex = 2;
            // 
            // uc_browser_tabs
            // 
            this.uc_browser_tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uc_browser_tabs.Location = new System.Drawing.Point(0, 153);
            this.uc_browser_tabs.Name = "uc_browser_tabs";
            this.uc_browser_tabs.Size = new System.Drawing.Size(864, 482);
            this.uc_browser_tabs.TabIndex = 1;
            // 
            // uC_MenuTitle1
            // 
            this.uC_MenuTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_MenuTitle1.Location = new System.Drawing.Point(0, 0);
            this.uC_MenuTitle1.Name = "uC_MenuTitle1";
            this.uC_MenuTitle1.Size = new System.Drawing.Size(864, 25);
            this.uC_MenuTitle1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 635);
            this.ControlBox = false;
            this.Controls.Add(this.btnStopClick);
            this.Controls.Add(this.btnBeginClick);
            this.Controls.Add(this.uC_KeyList1);
            this.Controls.Add(this.uC_LogsControl1);
            this.Controls.Add(this.uc_browser_tabs);
            this.Controls.Add(this.uC_MenuTitle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "点击主界面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_MenuTitle uC_MenuTitle1 ;
        private UC_BrowserTabs uc_browser_tabs ;
        private UC_LogsControl uC_LogsControl1 ;
        private UC_KeyList uC_KeyList1 ;
        private System.Windows.Forms.Button btnStopClick;
        private System.Windows.Forms.Button btnBeginClick;

    }
}