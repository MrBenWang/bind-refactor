using System;
using System.Collections.Generic;

namespace Bindding.ExcuteClasses
{
    /// <summary>
    /// IP精灵 控制 dll 方式
    /// </summary>
    internal class IpelfControlDll : IIpelfControl
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
            int retCode = IPDevices.IPInit(_name, _pwd, (_param) =>
            {
                CommonFunction.WriteLogInFile(_param.ToString() + "  " + Enum.GetName(typeof(CONNSTATE), _param), LogType.RunLog);
                return 0;
            });

            switch (retCode)
            {
                case 0: // 成功
                    CommonParameter.IPElfIsInit = true;
                    break;

                case 1:
                    CommonFunction.WriteLogInFile("IP精灵 初始化失败", LogType.RunLog);
                    return "IP精灵 初始化失败";

                case 2:
                    CommonFunction.WriteLogInFile("IP精灵 初始化失败", LogType.RunLog);
                    return "IP精灵 用户名或密码验证失败";
            }

            return string.Empty;
        }

        public string IPGetUserInfo()
        {
            return IPDevices.IPGetUserInfo();
        }

        public List<string> IPGetProvices()
        {
            string _provices = IPDevices.IPGetProvices();
            List<string> _provicesList = new List<string>(_provices.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
            return _provicesList;
        }

        public List<string> IPGetCitys(string _provice)
        {
            string _cities = IPDevices.IPGetCitys(_provice);
            List<string> __citiesList = new List<string>(_cities.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
            return __citiesList;
        }

        /// <summary>
        /// 混播链接 默认一天，使用openvpn
        /// </summary>
        /// <returns></returns>
        public bool IPConnect()
        {
            string _provice = CommonParameter.ConfigParam.ipelf_info.provice;
            string _city = CommonParameter.ConfigParam.ipelf_info.city;
            int _code = IPDevices.IPHbConnect(
                _provice == "所有" ? string.Empty : _provice,
                _city == "所有" ? string.Empty : _city, 1, VPN_LINKPATTERN.SEVPN);
            if (_code == 0)
            {
                return true;
            }
            else
            {
                CommonFunction.WriteLogInFile(string.Format("混播连接失败，{0}。参数 {1},{2}", Enum.GetName(typeof(ERROR_TYPE), _code), _provice, _city), LogType.RunLog);
                return false;
            }
        }

        public bool IPDisConnect()
        {
            int _code = IPDevices.IPDisConnect(VPN_LINKPATTERN.SEVPN);
            if (_code == 0)
            {
                return true;
            }
            else
            {
                CommonFunction.WriteLogInFile("混播断开连接失败:" + Enum.GetName(typeof(ERROR_TYPE), _code), LogType.RunLog);
                return false;
            }
        }

        public string IPStatus()
        {
            return "暂无设计";
        }

        /// <summary>
        /// 软件退出
        /// </summary>
        public void IPUnInit()
        {
            if (!CommonParameter.IPElfIsInit)
            {
                return;
            }

            if (IPDevices.IPUnInit() == 0)
            {
                CommonFunction.WriteLogInFile("IP精灵,正常退出！", LogType.RunLog);
            }
            else
            {
                CommonFunction.WriteLogInFile("IP精灵,退出失败！", LogType.RunLog);
            }
        }
    }
}