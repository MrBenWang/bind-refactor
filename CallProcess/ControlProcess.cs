using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CallProcess
{
    internal static class ControlProcess
    {
        private static bool _is_work = false;

        internal static void GetProcess()
        {
            var processes = Process.GetProcessesByName("Bindding");
            if (processes.Length == 1 && processes[0].Responding)
            {
                CommonFunction.ResetRunNo();
                processes[0].WaitForExit();
            }

            if (processes.Length == 0)
            {
                Process exep = new Process();
                exep.StartInfo.FileName = System.Environment.CurrentDirectory + "\\Bindding.exe";
                exep.StartInfo.Arguments = string.Format("{0}", _is_work.ToString());
                _is_work = true; // 第二次后，一直执行中
                exep.StartInfo.CreateNoWindow = true;
                exep.StartInfo.UseShellExecute = false;
                exep.Start();
                exep.WaitForExit();
            }
        }

        internal static void CloseProcess()
        {
            var processes = Process.GetProcessesByName("Bindding");
            if (processes.Length == 1)
            {
                processes[0].CloseMainWindow();
            }
        }

        #region 确保程序只运行一个实例

        /// <summary>
        /// 在进程中查找是否已经有实例在运行
        /// </summary>
        /// <returns></returns>
        internal static Process RunningInstance()
        {
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            //遍历与当前进程名称相同的进程列表
            foreach (Process process in processes)
            {
                //如果实例已经存在则忽略当前进程
                if (process.Id != current.Id)
                {
                    //保证要打开的进程同已经存在的进程来自同一文件路径
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\"") == current.MainModule.FileName)
                    {
                        //返回已经存在的进程
                        return process;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 已经有了就把它激活，并将其窗口放置最前端
        /// </summary>
        /// <param name="instance"></param>
        internal static void HandleRunningInstance(Process instance)
        {
            MessageBox.Show("已经在运行！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowWindowAsync(instance.MainWindowHandle, 1);  // 调用api函数，正常显示窗口
            SetForegroundWindow(instance.MainWindowHandle); // 将窗口放置最前端
        }

        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(System.IntPtr hWnd, int cmdShow);

        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(System.IntPtr hWnd);

        #endregion 确保程序只运行一个实例
    }
}