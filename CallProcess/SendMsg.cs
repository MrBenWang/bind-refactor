using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CallProcess
{
    internal static class SendMsg
    {
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll", EntryPoint = "FindWindowEx")]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpClassName, string lpWindowName);

        /// <summary>
        /// 主界面的 停止按钮
        /// </summary>
        internal static void StopMainFormBtn()
        {
            const int BM_CLICK = 0xF5;
            IntPtr maindHwnd = FindWindow(null, "点击主界面"); // 获得 点击主界面 的句柄
            if (maindHwnd != IntPtr.Zero)
            {
                IntPtr childHwnd = FindWindowEx(maindHwnd, IntPtr.Zero, null, "停止点击");   //获得按钮的句柄
                if (childHwnd != IntPtr.Zero)
                {
                    SendMessage(childHwnd, BM_CLICK, 0, 0);     //发送点击按钮的消息
                }
                else
                {
                    MessageBox.Show("没有找到子窗口");
                }
            }
            else
            {
                MessageBox.Show("没有找到窗口");
            }
        }
    }
}