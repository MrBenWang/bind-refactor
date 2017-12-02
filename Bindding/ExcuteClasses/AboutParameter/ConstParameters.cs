using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bindding.ExcuteClasses
{
    internal static partial class ConstParameter
    {
        #region Brower 相关参数

        /// <summary>
        /// 随机种子
        /// </summary>
        internal static Random RandomSeed = new Random();

        /// <summary>
        /// 我创建的拨号名
        /// </summary>
        internal static string EntryName = "my_entry_name";

        /// <summary>
        /// 浏览器距离窗体的高度
        /// </summary>
        internal const int BrowerY = 230;

        /// <summary>
        /// 搜索框距离窗体的x
        /// </summary>
        internal const int SearchX = 250;

        /// <summary>
        /// 搜索框距离窗体的y
        /// </summary>
        internal const int SearchY = 192;

        /// <summary>
        /// 默认的搜索引擎
        /// </summary>
        internal const string SEARCH_ENGINES = "https://www.baidu.com/";

        /// <summary>
        /// 空白页面
        /// </summary>
        internal const string BLANK_PAGE = "about:blank";

        /// <summary>
        /// 点击广告
        /// </summary>
        internal const bool CLICK_AD = true;

        internal const string Sqlite_DB_NAME = "bindding.db";

        internal static string CookiePath = Path.Combine(Environment.CurrentDirectory, Path.Combine("MyApplication", "cookies"));
        internal static string CachePath = Path.Combine(Environment.CurrentDirectory, Path.Combine("MyApplication", "cache"));

        #endregion Brower 相关参数

        #region 文件路径参数

        /// <summary>
        /// 配置文件路径
        /// </summary>
        internal static string ConfigPath = Environment.CurrentDirectory + "\\config.json";

        /// <summary>
        /// 日志类型的路径
        /// </summary>
        internal static class LogTypePath
        {
            internal static string LogDir = Path.Combine(Environment.CurrentDirectory, Path.Combine("MyApplication", "logs"));

            internal static string RunPath = Path.Combine(LogDir, "my_run.log");
        }

        #endregion 文件路径参数
    }

    /// <summary>
    /// 允许类型
    /// </summary>
    internal enum LogType
    {
        /// <summary>
        /// 运行日志
        /// </summary>
        RunLog = 1
    }
}