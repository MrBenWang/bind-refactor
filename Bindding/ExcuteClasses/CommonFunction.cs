using CefSharp;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Bindding.ExcuteClasses
{
    internal static class CommonFunction
    {
        #region GET方式实现

        public static string WebGet(string uri)
        {
            try
            {
                //构造一个Web请求的对象
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(uri);
                // 获得接口返回值68
                //获取web请求的响应的内容
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();

                //通过响应流构造一个StreamReader
                StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
                //string ReturnXml = HttpUtility.UrlDecode(reader.ReadToEnd());
                string ReturnXml = reader.ReadToEnd();
                reader.Close();
                myResponse.Close();
                return ReturnXml;
            }
            catch (Exception ex)
            {
                WriteLogInFile(ex.ToString(), LogType.RunLog);
                return string.Empty;
            }
        }

        public static string GetIpAddress()
        {
            string myip = WebGet("http://ip.chinaz.com/getip.aspx");
            if (!string.IsNullOrEmpty(myip))
            {
                dynamic _myjson = JsonConvert.DeserializeObject(myip);
                return string.Format("[{0}] {1}", _myjson.ip, _myjson.address);
            }

            return "未查询到当前IP";
        }

        #endregion GET方式实现

        #region 记录日志，配置文件

        internal static void WriteLogInFile(string strMsg, LogType _logType)
        {
            WriteLogInFile(strMsg, _logType, true);
        }

        internal static void WriteLogInFile(string strMsg, LogType _logType, bool _is_append)
        {
            string _strPath = string.Empty;
            switch (_logType)
            {
                case LogType.RunLog:
                    strMsg = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + strMsg;
                    _strPath = ConstParameter.LogTypePath.RunPath;
                    break;
            }

            using (StreamWriter sw = new StreamWriter(_strPath, _is_append, Encoding.UTF8))
            {
                sw.WriteLine(strMsg);
            }
        }

        internal static void ReadConfig()
        {
            if (File.Exists(ConstParameter.ConfigPath))
            {
                string _config = File.ReadAllText(ConstParameter.ConfigPath, Encoding.UTF8);
                CommonParameter.ConfigParam = JsonConvert.DeserializeObject<ConfigParam>(_config);
            }
            else
            {
                CommonParameter.ConfigParam = new ConfigParam();
            }
        }

        internal static void WriteConfig()
        {
            string _newConfig = JsonConvert.SerializeObject(CommonParameter.ConfigParam, Formatting.Indented);
            File.WriteAllText(ConstParameter.ConfigPath, _newConfig, Encoding.UTF8);
        }

        /// <summary>
        /// 读取运行参数
        /// </summary>
        internal static void ReadRunParam()
        {
            CommonParameter.RunParam = SqliteHelper.GetInstance.QryRunParams();
        }

        /// <summary>
        /// 写入运行参数
        /// </summary>
        internal static void WriteRunParam()
        {
            SqliteHelper.GetInstance.UpdateRunParams(CommonParameter.RunParam);
        }

        #endregion 记录日志，配置文件

        /// <summary>
        /// 快速后台执行 切换规则
        /// </summary>
        internal static string BackgroundDoWorkIpelfFast()
        {
            // 清除cookie
            Cef.GetGlobalCookieManager().DeleteCookiesAsync(string.Empty, string.Empty);

            // 切换分辨率
            CommonParameter.CurrentScreenResolutionIndex++;
            ScreenResolution.ChangeResolution(CommonParameter.CurrentScreenResolutionValue.Width, CommonParameter.CurrentScreenResolutionValue.Height, 0);
            CommonParameter.CurrentScreenWidth = CommonParameter.CurrentScreenResolutionValue.Width;
            CommonParameter.CurrentScreenHeight = CommonParameter.CurrentScreenResolutionValue.Height;

            // 切换头
            CommonParameter.CurrentUserAgentIndex++;

            // 切换IP: 获取当前的状态: 11 已连接 13 未连接
            var _curStatus = CommonParameter.IpelfCurrentInstance.IPStatus();

            if (_curStatus == "11" && !CommonParameter.IpelfCurrentInstance.IPDisConnect())
            {
                // 只有在已连接状态下，才断开连接
                return "IP精灵，断开连接失败.请检查IP精灵是否没有费用";
            }

            if (!CommonParameter.IpelfCurrentInstance.IPConnect())
            {
                return "IP精灵，连接失败.请检查IP精灵是否没有费用";
            }

            return string.Empty;
        }

        /// <summary>
        /// 在初始化前，清理文件夹
        /// </summary>
        internal static void DeleteCefsharpDirectory()
        {
            if (Directory.Exists(ConstParameter.CookiePath))
            {
                // 删除 上次的cookie
                Directory.Delete(ConstParameter.CookiePath, true);
            }

            // On Win7 this will create a directory in AppData.
            if (Directory.Exists(ConstParameter.CachePath))
            {
                Directory.Delete(ConstParameter.CachePath, true);
            }

            Directory.CreateDirectory(ConstParameter.CachePath);
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

        #region 模拟移动并点击事件

        /// <summary>
        /// 移动并左键点击
        /// </summary>
        internal static void SimMoveAndLefClick(int _x, int _y, bool _click)
        {
            var sim = new WindowsInput.InputSimulator();
            int sim_x = CommonParameter.FormX + _x + ConstParameter.RandomSeed.Next(10, 200);
            int sim_y = CommonParameter.FormY + ConstParameter.BrowerY + _y % 300 + ConstParameter.RandomSeed.Next(5, 15);

            if (_y > 300)
            {
                // 则需要滚动滑轮
                sim.Mouse
                    .VerticalScroll((-_y / 300) * 3)
                    .Sleep(CommonParameter.ConfigParam.simulate_speed.mouse_scroll.ToRandom()); // 必须先取整
            }

            sim.Mouse
                .MoveMouseTo(CommonParameter.CurrentScreenWidth * sim_x, CommonParameter.CurrentScreenHeight * sim_y)
                .Sleep(1000);

            if (_click)
            {
                sim.Mouse.LeftButtonClick();
            }
        }

        #endregion 模拟移动并点击事件
    }
}