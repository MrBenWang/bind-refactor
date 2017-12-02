using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RegisterMachine
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (DateTime.Now.Date != RegisterHelper.getWebsiteDatetime().Date)
            {
                MessageBox.Show("系统时间不正确！请同步互联网时间！", "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Application.Run(new RegisterForm());
        }
    }
}