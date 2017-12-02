using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallProcess
{
    internal partial class form_reboot : Form
    {
        private const int WM_HOTKEY = 0x312; // 窗口消息：热键
        private const int WM_CREATE = 0x1; // 窗口消息：创建
        private const int WM_DESTROY = 0x2; // 窗口消息：销毁
        internal static bool IsRunning = true; // 判断是否在允许中

        internal form_reboot()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Form_Exit();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Form_Exit();
        }

        private void Form_Exit()
        {
            // 关闭浏览器窗口
            IsRunning = false;
            ControlProcess.CloseProcess();

            // 关闭当前窗体
            nti_reboot.Visible = false;
            this.Close();
            this.Dispose();
            Application.Exit();
        }

        private void hideMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void showMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void nti_reboot_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }

        private void form_reboot_Load(object sender, EventArgs e)
        {
            //注册热键Shift+S，Id号为100。HotKey.KeyModifiers.Shift也可以直接使用数字4来表示。
            SystemHotKey.RegHotKey(Handle, 100, SystemHotKey.KeyModifiers.Ctrl, Keys.F12);
            SystemHotKey.RegHotKey(Handle, 101, SystemHotKey.KeyModifiers.Ctrl, Keys.F11);
            Task.Factory.StartNew(() =>
            {
                while (IsRunning)
                {
                    ControlProcess.GetProcess();
                }
            });
        }

        protected override void WndProc(ref Message m)
        {
            //按快捷键
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case 100:
                            this.Form_Exit();
                            break;

                        case 101:
                            SendMsg.StopMainFormBtn();
                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void form_reboot_FormClosed(object sender, FormClosedEventArgs e)
        {
            SystemHotKey.UnRegHotKey(Handle, 100);
            SystemHotKey.UnRegHotKey(Handle, 101);

            // 关闭浏览器窗口
            ControlProcess.CloseProcess();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            SendMsg.StopMainFormBtn();
        }
    }
}