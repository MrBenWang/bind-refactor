using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bindding.MainForms;
using Bindding.ExcuteClasses;

namespace Bindding
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CommonFunction.ReadRunParam();
#if !DEBUG
            if (args.Length == 0)
            {
                MessageBox.Show("请从主程序[CallProcess.exe]启动！");
                return;
            }
            var instance = CommonFunction.RunningInstance();
            if (instance == null)
            {
                var isrunning = Convert.ToBoolean(args[0]);
                CheckedSystem(isrunning);

                CommonFunction.ReadConfig();
                CommonFunction.ReadRunParam();
                Application.Run(new MainForm(isrunning));
            }
            else
            {
                CommonFunction.HandleRunningInstance(instance); // 已经有一个实例在运行，激活它
            }
#else
            Application.Run(new MainForm(false));
#endif
        }

        /// <summary>
        /// 检查系统 方面
        /// </summary>
        /// <param name="_isrunning"></param>
        private static bool CheckedSystem(bool _isrunning)
        {
            try
            {
                var sim = new WindowsInput.InputSimulator();
                sim.Mouse.LeftButtonClick();
            }
            catch (Exception ex)
            {
                CommonFunction.WriteLogInFile(ex.ToString(), LogType.RunLog);
                MessageBox.Show("关闭杀毒软件，或者目录添加为白名单！", "配置异常", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            // 如果处在运行中，不需要再次启动 IP精灵
            CommonParameter.IPElfIsInit = _isrunning;
            if (!_isrunning)
            {
                var _retStr = CommonParameter.IpelfCurrentInstance.InitLogin();
                if (!string.IsNullOrEmpty(_retStr))
                {
                    MessageBox.Show(_retStr, "配置异常", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }

            if (DateTime.Now.Date != LicenseHelper.getWebsiteDatetime().Date)
            {
                MessageBox.Show("系统时间不正确！请同步互联网时间！", "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
    }
}