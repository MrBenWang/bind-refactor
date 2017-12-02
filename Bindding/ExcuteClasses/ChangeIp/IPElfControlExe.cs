using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Xml;

namespace Bindding.ExcuteClasses
{
    /// <summary>
    /// IP精灵 控制 exe 方式
    /// </summary>
    internal class IPElfControlExe : IIpelfControl
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public string InitLogin()
        {
            if (CommonParameter.IPElfIsInit)
            {
                return string.Empty;
            }

            string _name = CommonParameter.ConfigParam.ipelf_info.username;
            string _pwd = CommonParameter.ConfigParam.ipelf_info.password;
            string _path = CommonParameter.ConfigParam.ipelf_info.soft_path;

            if (!System.IO.File.Exists(_path))
            {
                return "IP精灵文件路径不正确，请确认[IP精灵]文件路径!";
            }

            Process exep = new Process();
            exep.StartInfo.FileName = _path;
            exep.StartInfo.Arguments = string.Format("-user={0} -pwd={1} -force", _name, _pwd);
            exep.StartInfo.CreateNoWindow = true;
            exep.StartInfo.UseShellExecute = false;
            exep.Start();
            CommonParameter.IPElfIsInit = true;
            return string.Empty;
        }

        public bool IPConnect()
        {
            string _provice = CommonParameter.ConfigParam.ipelf_info.provice;
            string _city = CommonParameter.ConfigParam.ipelf_info.city;
            string _geturl = string.Format("http://127.0.0.1:8222/hbconnect/?province={0}{1}&linktype=2", _provice, (_provice == "所有" ? string.Empty : "&city=" + _city));
            string _xml = CommonFunction.WebGet(_geturl);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(_xml);

            var node = xmldoc.SelectSingleNode("/root/code");
            if (node.InnerText == "0")
            {
                string _isconnect = string.Empty;
                int _i = 0;

                // 三分钟的连接时间
                while (_i < 120)
                {
                    this.IPStatus(out _isconnect);
                    if (_isconnect == "11")
                    {
                        break; // 检测到链接状态 已建立，
                    }

                    _i++;
                    Thread.Sleep(1000);
                }

                if (_isconnect != "11")
                {
                    throw new Exception("IP精灵，无法正常连接!请确认网络和软件正常");
                }

                return true;
            }

            return false;
        }

        public bool IPDisConnect()
        {
            string _xml = CommonFunction.WebGet("http://127.0.0.1:8222/disconnect/");
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(_xml);

            var node = xmldoc.SelectSingleNode("/root/code");
            if (node.InnerText == "0")
            {
                string _isconnect = string.Empty;
                int _i = 0;
                while (_i < 60)
                {
                    this.IPStatus(out _isconnect);
                    if (_isconnect == "13")
                    {
                        break; // 检测到链接状态 已断开，
                    }

                    _i++;
                    Thread.Sleep(1000);
                }

                if (_isconnect != "13")
                {
                    throw new Exception("IP精灵，无法正常断开连接!请确认软件正常");
                }

                return true;
            }

            return false;
        }

        public List<string> IPGetCitys(string _provice)
        {
            string _xml = CommonFunction.WebGet("http://127.0.0.1:8222/hblines/?province=" + _provice);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(_xml);

            var nodelist = xmldoc.SelectNodes("/root/lines/line");
            var _list = new List<string>();
            foreach (XmlElement node in nodelist)
            {
                _list.Add(node.GetAttribute("name"));
            }

            return _list;
        }

        public List<string> IPGetProvices()
        {
            string _xml = CommonFunction.WebGet("http://127.0.0.1:8222/hblines/");
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(_xml);

            var nodelist = xmldoc.SelectNodes("/root/lines/line");
            var _list = new List<string>();
            foreach (XmlElement node in nodelist)
            {
                _list.Add(node.GetAttribute("name"));
            }

            return _list;
        }

        public string IPGetUserInfo()
        {
            string _name = CommonParameter.ConfigParam.ipelf_info.username;
            return string.Format("用户名:{0}\r\n", _name);
        }

        public string IPStatus()
        {
            string _isConnect;
            this.IPStatus(out _isConnect);
            return _isConnect;
        }

        /// <summary>
        /// 内部使用
        /// </summary>
        /// <param name="_isConnect"></param>
        /// <returns></returns>
        private string IPStatus(out string _isConnect)
        {
            string _xml = CommonFunction.WebGet("http://127.0.0.1:8222/getstate/");
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(_xml);

            _isConnect = xmldoc.SelectSingleNode("/root/state").InnerText;
            if (xmldoc.SelectSingleNode("/root/state").InnerText == "11")
            {
                string _ip = xmldoc.SelectSingleNode("/root/ip").InnerText;
                string _content = xmldoc.SelectSingleNode("/root/lineinfo").InnerText;
                return string.Format("{0}({1})", _ip, _content);
            }
            else
            {
                return xmldoc.SelectSingleNode("/root/info").InnerText;
            }
        }

        public void IPUnInit()
        {
            if (!CommonParameter.IPElfIsInit)
            {
                return; // 没有启动直接退出
            }

            CommonFunction.WebGet("http://127.0.0.1:8222/logout/");
        }
    }
}