using System.Collections.Generic;

namespace Bindding.ExcuteClasses
{
    internal static class CommonParameter
    {
        internal static object LokerObj = new object();

        #region 配置参数

        private static ConfigParam _configParam;

        internal static ConfigParam ConfigParam
        {
            get
            {
                if (_configParam == null)
                {
                    CommonFunction.ReadConfig();
                }

                return _configParam;
            }
            set
            {
                _configParam = value;
            }
        }

        #endregion 配置参数

        #region 运行参数

        internal static RunParameters RunParam { get; set; }

        #endregion 运行参数

        #region UserAgent

        private static IList<KeyValuePair<string, string>> _userAgentList;

        internal static IList<KeyValuePair<string, string>> UserAgentList
        {
            get
            {
                if (_userAgentList == null || _userAgentList.Count == 0)
                {
                    MySetUserAgent();
                }

                return _userAgentList;
            }
        }

        /// <summary>
        /// 我自己设置的
        /// </summary>
        private static void MySetUserAgent()
        {
            _userAgentList = new List<KeyValuePair<string, string>>();
            _userAgentList.Add(new KeyValuePair<string, string>("Chrome Windows", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36"));
            // _userAgentList.Add(new KeyValuePair<string, string>("Chrome Android", "Mozilla/5.0 (Linux; Android 6.0; Nexus 5 Build/MRA58N) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Mobile Safari/537.36"));
            // _userAgentList.Add(new KeyValuePair<string, string>("Chrome iPhone", "Mozilla/5.0 (iPhone; CPU iPhone OS 9_1 like Mac OS X) AppleWebKit/601.1 (KHTML, like Gecko) CriOS/58.0.3029.110 Mobile/13B143 Safari/601.1.46"));

            _userAgentList.Add(new KeyValuePair<string, string>("Edge Windows", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36 Edge/12.10240"));
            // _userAgentList.Add(new KeyValuePair<string, string>("Edge Mobile", "Mozilla/5.0 (Windows Phone 10.0; Android 4.2.1; Microsoft; Lumia 640 XL LTE) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Mobile Safari/537.36 Edge/12.10166"));

            _userAgentList.Add(new KeyValuePair<string, string>("Firefox Windows", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:46.0) Gecko/20100101 Firefox/46.0"));
            // _userAgentList.Add(new KeyValuePair<string, string>("Firefox Android", "Mozilla/5.0 (Android 4.4; Mobile; rv:46.0) Gecko/46.0 Firefox/46.0"));

            _userAgentList.Add(new KeyValuePair<string, string>("IE 11", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko"));
            _userAgentList.Add(new KeyValuePair<string, string>("IE 10", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; WOW64; Trident/6.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("IE 9", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)"));

            //_userAgentList.Add(new KeyValuePair<string, string>("Safari iPad", "Mozilla/5.0 (iPad; CPU OS 9_1 like Mac OS X) AppleWebKit/601.1.46 (KHTML, like Gecko) Version/9.0 Mobile/13B137 Safari/601.1"));
            //_userAgentList.Add(new KeyValuePair<string, string>("Safari iPhone", "Mozilla/5.0 (iPhone; CPU iPhone OS 9_1 like Mac OS X) AppleWebKit/601.1.46 (KHTML, like Gecko) Version/9.0 Mobile/13B137 Safari/601.1"));
            //_userAgentList.Add(new KeyValuePair<string, string>("Safari Mac", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_9_3) AppleWebKit/537.75.14 (KHTML, like Gecko) Version/7.0.3 Safari/7046A194A"));
        }

        private static void NewSetUserAgent()
        {
            _userAgentList = new List<KeyValuePair<string, string>>();
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP Google Chrome", "Mozilla/5.0 (Windows NT 5.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.81 Safari/537.36"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP FireFox", "Mozilla/5.0 (Windows NT 5.1; WOW64; rv:21.0) Gecko/20100101 Firefox/21.0"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP Opera", "Opera/9.80 (Windows NT 5.1; U; en) Presto/2.8.131 Version/11.11"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP 猎豹浏览器", "Mozilla/5.0 (Windows NT 5.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.154 Safari/537.36 LBBROWSER"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP 傲游浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Maxthon 2.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP 360浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; 360SE)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP 360极速浏览器", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1) ; QIHU 360EE"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP 搜狗高速浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; Trident/4.0; SE 2.X MetaSr 1.0; SE 2.X MetaSr 1.0; .NET CLR 2.0.50727; SE 2.X MetaSr 1.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP 百度浏览器", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; baidubrowser 1.x)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP QQ浏览器", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/534.36 (KHTML, like Gecko) Chrome/12.0.742.53 Safari/534.36 QQBrowser/6.5.9225.201"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP 世界之窗浏览器", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; The World)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP IE8.0", "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win XP IE9.0", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 5.1; Trident/5.0;)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 Google Chrome", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.81 Safari/537.36"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 FireFox", "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:21.0) Gecko/20100101 Firefox/21.0"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 Opera", "Opera/9.80 (Windows NT 6.1; U; en) Presto/2.8.131 Version/11.11"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 猎豹浏览器", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.154 Safari/537.36 LBBROWSER"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 傲游浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; Maxthon 2.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 360浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; 360SE)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 360极速浏览器", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 6.1; SV1) ; QIHU 360EE"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 搜狗高速浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; Trident/4.0; SE 2.X MetaSr 1.0; SE 2.X MetaSr 1.0; .NET CLR 2.0.50727; SE 2.X MetaSr 1.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 百度浏览器", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; baidubrowser 1.x)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 QQ浏览器", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/534.36 (KHTML, like Gecko) Chrome/12.0.742.53 Safari/534.36 QQBrowser/6.5.9225.201"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 世界之窗浏览器", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; The World)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 IE8.0", "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.1; Trident/4.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 IE9.0", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0;)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 IE 10.0", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/5.0;)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 7 IE 11.0", "Mozilla/5.0 (compatible; MSIE 11.0; Windows NT 6.1; Trident/5.0;)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 Google Chrome", "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.81 Safari/537.36"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 FireFox", "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:21.0) Gecko/20100101 Firefox/21.0"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 Opera", "Opera/9.80 (Windows NT 6.3; U; en) Presto/2.8.131 Version/11.11"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 猎豹浏览器", "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.154 Safari/537.36 LBBROWSER"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 傲游浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.3; Maxthon 2.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 360浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.3; 360SE)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 360极速浏览器", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 6.3; SV1) ; QIHU 360EE"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 搜狗高速浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.3; Trident/4.0; SE 2.X MetaSr 1.0; SE 2.X MetaSr 1.0; .NET CLR 2.0.50727; SE 2.X MetaSr 1.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 百度浏览器", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.3; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; baidubrowser 1.x)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 QQ浏览器", "Mozilla/5.0 (Windows NT 6.3) AppleWebKit/534.36 (KHTML, like Gecko) Chrome/12.0.742.53 Safari/534.36 QQBrowser/6.5.9225.201"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 世界之窗浏览器", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.3; The World)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 IE8.0", "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.3; Trident/4.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 IE9.0", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.3; Trident/5.0;)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 IE 10.0", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.3; Trident/5.0;)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 8 IE 11.0", "Mozilla/5.0 (compatible; MSIE 11.0; Windows NT 6.3; Trident/5.0;)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 Google Chrome", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.81 Safari/537.36"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 FireFox", "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:21.0) Gecko/20100101 Firefox/21.0"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 Opera", "Opera/9.80 (Windows NT 10.0; U; en) Presto/2.8.131 Version/11.11"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 猎豹浏览器", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.154 Safari/537.36 LBBROWSER"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 傲游浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; Maxthon 2.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 360浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; 360SE)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 360极速浏览器", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 10.0; SV1) ; QIHU 360EE"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 搜狗高速浏览器", " Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; Trident/4.0; SE 2.X MetaSr 1.0; SE 2.X MetaSr 1.0; .NET CLR 2.0.50727; SE 2.X MetaSr 1.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 百度浏览器", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; WOW64; Trident/4.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; baidubrowser 1.x)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 QQ浏览器", "Mozilla/5.0 (Windows NT 10.0) AppleWebKit/534.36 (KHTML, like Gecko) Chrome/12.0.742.53 Safari/534.36 QQBrowser/6.5.9225.201"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 世界之窗浏览器", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 10.0; The World)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 IE8.0", "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 10.0; Trident/4.0)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 IE9.0", "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 10.0; Trident/5.0;)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 IE 10.0", "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 10.0; Trident/5.0;)"));
            _userAgentList.Add(new KeyValuePair<string, string>("Win 10 IE 11.0", "Mozilla/5.0 (compatible; MSIE 11.0; Windows NT 10.0; Trident/5.0;)"));
        }

        private static int _currentUserAgentIndex = 0;

        internal static int CurrentUserAgentIndex
        {
            get
            {
                return _currentUserAgentIndex;
            }
            set
            {
                _currentUserAgentIndex = value % UserAgentList.Count;
            }
        }

        /// <summary>
        /// 当前的 消息头
        /// </summary>
        internal static string CurrentUserAgentValue
        {
            get
            {
                return UserAgentList[CurrentUserAgentIndex].Value;
            }
        }

        #endregion UserAgent

        #region Screen Resolution

        private static IList<ScreenSize> _screenResolutions;

        internal static IList<ScreenSize> ScreenResolutions
        {
            get
            {
                if (_screenResolutions == null || _screenResolutions.Count == 0)
                {
                    _screenResolutions = ScreenResolution.GetSupportedScreenResolutions(0);
                }

                return _screenResolutions;
            }
        }

        /// <summary>
        /// 当前的 分辨率
        /// </summary>
        internal static ScreenSize CurrentScreenResolutionValue
        {
            get
            {
                return ScreenResolutions[CurrentScreenResolutionIndex];
            }
        }

        private static int _currentScreenResolutionIndex = 0;

        internal static int CurrentScreenResolutionIndex
        {
            get
            {
                return _currentScreenResolutionIndex;
            }
            set
            {
                _currentScreenResolutionIndex = value % ScreenResolutions.Count;
            }
        }

        #region 屏幕分辨率属性

        private static double _ScreenWidth;

        internal static double CurrentScreenWidth
        {
            get
            {
                return 65535.0d / _ScreenWidth;
            }
            set
            {
                _ScreenWidth = value;
            }
        }

        private static double _ScreenHeight;

        internal static double CurrentScreenHeight
        {
            get
            {
                return 65535.0d / _ScreenHeight;
            }
            set
            {
                _ScreenHeight = value;
            }
        }

        #endregion 屏幕分辨率属性

        #endregion Screen Resolution

        #region IP精灵参数配置

        private static IIpelfControl _IpeflControl;

        internal static IIpelfControl IpelfCurrentInstance
        {
            get
            {
                if (_IpeflControl == null)
                {
                    string _myiptype = "ipelf_exe";

                    switch (_myiptype)
                    {
                        case "ipelf_dll":
                            _IpeflControl = new IpelfControlDll();
                            break;

                        case "ipelf_exe":
                            _IpeflControl = new IPElfControlExe();
                            break;
                    }
                }

                return _IpeflControl;
            }
        }

        private static List<string> _ipElfProvices;

        /// <summary>
        ///  获取IP精灵省份列表
        /// </summary>
        internal static List<string> GetIPElfProvices
        {
            get
            {
                if (_ipElfProvices == null || _ipElfProvices.Count == 0)
                {
                    _ipElfProvices = IpelfCurrentInstance.IPGetProvices();
                }

                return _ipElfProvices;
            }
        }

        /// <summary>
        /// 判断IP精灵是否已经初始化
        /// </summary>
        internal static bool IPElfIsInit { get; set; }

        private static string _ipElfUserInfo = string.Empty;

        /// <summary>
        /// 用户信息只能获取一次，多次会报错
        /// </summary>
        internal static string IPElfUserInfo
        {
            get
            {
                if (string.IsNullOrEmpty(_ipElfUserInfo))
                {
                    _ipElfUserInfo = IpelfCurrentInstance.IPGetUserInfo();
                }
                return _ipElfUserInfo;
            }
        }

        #endregion IP精灵参数配置

        #region 浏览器参数

        /// <summary>
        /// 当前循环次数
        /// </summary>
        internal static int CurrentLoopNum { get; set; }

        /// <summary>
        /// 窗体在桌面的坐标
        /// </summary>
        internal static int FormX { get; set; }

        internal static int FormY { get; set; }

        #endregion 浏览器参数
    }
}