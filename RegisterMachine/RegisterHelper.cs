using System;
using System.Net;

namespace RegisterMachine
{
    internal class RegisterHelper
    {
        /// <summary>
        /// 获取网络时间
        /// </summary>
        /// <returns></returns>
        internal static DateTime getWebsiteDatetime()
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create("https://www.baidu.com");
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            return Convert.ToDateTime(myResponse.Headers["date"]);
        }
    }
}