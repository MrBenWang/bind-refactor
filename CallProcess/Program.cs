using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace CallProcess
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
            if (!IsAdministrator())
            {
                MessageBox.Show("请以管理员身份运行！");
                return;
            }

            var instance = ControlProcess.RunningInstance();
            if (instance == null)
            {
                Application.Run(new form_reboot());
            }
            else
            {
                ControlProcess.HandleRunningInstance(instance); // 已经有一个实例在运行，激活它
            }
        }

        private static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}