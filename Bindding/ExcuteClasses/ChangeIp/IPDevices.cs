using System.Runtime.InteropServices;

namespace Bindding.ExcuteClasses
{
    internal delegate int InitCallBack(int _result);

    internal static class IPDevices
    {
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="_name">用户名</param>
        /// <param name="_pwd">密码</param>
        /// <param name="_callback">注册的回调函数</param>
        /// <returns>返回 0成功，返回其它失败，1初始化失败，2用户名密码验证失败</returns>
        [DllImport("ipDevices.dll", EntryPoint = "IPInit", CallingConvention = CallingConvention.StdCall)]
        internal static extern int IPInit(string _name, string _pwd, InitCallBack _callback);

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns>返回用户基本信息以\r\n 分割</returns>
        [DllImport("ipDevices.dll", EntryPoint = "IPGetUserInfo", CallingConvention = CallingConvention.StdCall)]
        internal static extern string IPGetUserInfo();

        /// <summary>
        /// 获取普通线路列表
        /// </summary>
        /// <returns>返回线路列表，每条线路以\r\n区分开，返回数据空为失败</returns>
        [DllImport("ipDevices.dll", EntryPoint = "IPGetLines", CallingConvention = CallingConvention.StdCall)]
        internal static extern string IPGetLines();

        /// <summary>
        /// 获取混拨省份列表
        /// </summary>
        /// <returns>返回混拨省份列表，每个省份以\r\n区分开，返回数据空为失败</returns>
        [DllImport("ipDevices.dll", EntryPoint = "IPGetProvices", CallingConvention = CallingConvention.StdCall)]
        internal static extern string IPGetProvices();

        /// <summary>
        /// 根据省份名获取混拨城市列表
        /// </summary>
        /// <param name="_provice">传入省份名称</param>
        /// <returns>返回混拨城市列表，每条线路以\r\n区分开，返回数据空为失败</returns>
        [DllImport("ipDevices.dll", EntryPoint = "IPGetCitys", CallingConvention = CallingConvention.StdCall)]
        internal static extern string IPGetCitys(string _provice);

        /// <summary>
        /// 普通线路的连接
        /// 注意：只有在回调函数中状态值为0，或者22，23时才能连接
        /// </summary>
        /// <param name="_serverName">服务器名称</param>
        /// <param name="_linkType" >连接方式，见上面的枚举</param>
        /// <returns>返回 0为调用成功，其它为调用失败，调用成功后可以在回调函数中看到具体的连接返回</returns>
        [DllImport("ipDevices.dll", EntryPoint = "IPConnect", CallingConvention = CallingConvention.StdCall)]
        internal static extern int IPConnect(string _serverName, VPN_LINKPATTERN _linkType);

        /// <summary>
        /// 混拨线路的连接
        /// 注意：只有在回调函数中状态值为0，或者22，23时才能连接
        /// </summary>
        /// <param name="_provice">混拨省份名称 为空为所有线路</param>
        /// <param name="_city">混拨城市名称</param>
        /// <param name="_date">几天内不重复IP</param>
        /// <param name="_linkType">连接方式，见上面的枚举</param>
        /// <returns>返回 0为调用成功，其它为调用失败，调用成功后可以在回调函数中看到具体的连接返回</returns>
        [DllImport("ipDevices.dll", EntryPoint = "IPHbConnect", CallingConvention = CallingConvention.StdCall)]
        internal static extern int IPHbConnect(string _provice, string _city, int _date, VPN_LINKPATTERN _linkType);

        /// <summary>
        /// 断开连接
        /// </summary>
        /// <param name="_linkType">linkType：连接方式，见上面的枚举</param>
        /// <returns>正常返回0  注意：状态为11的时候为连接成功，可以使用该函数</returns>
        [DllImport("ipDevices.dll", EntryPoint = "IPDisConnect", CallingConvention = CallingConvention.StdCall)]
        internal static extern int IPDisConnect(VPN_LINKPATTERN _linkType);

        /// <summary>
        /// 正常退出，退出登录
        /// </summary>
        /// <returns>正常返回0</returns>
        [DllImport("ipDevices.dll", EntryPoint = "IPUnInit", CallingConvention = CallingConvention.StdCall)]
        internal static extern int IPUnInit();
    }

    internal enum CONNSTATE
    {
        SE_INIT = 1,  // 1:初始化
        SE_GETDEIVCES = 2, // 2：获取驱动
        SE_INSTALLDEVICES = 3, // 3：安装驱动.
        SE_INSTALLERR = 4, // 4：安装驱动失败
        SE_CERTAUTH = 5, // 5: 服务器证书验证
        SE_USERAUTH = 6, // 6:用户身份验证
        SE_SESSCONNECTION = 7, // 7:建立会话
        SE_REDIRECT = 8, // 8:重定向连接
        SE_SESSCONNECTING = 9, // 9: 会话建立
        SE_SESSCONNECTED = 10, // 10:会话建立成功
        SE_CONNECTEDSUSS = 11, // 11:sevpn连接已经建立
        SE_STARTDISCONNECT = 20, // 20: 断开中
        SE_DISCONNECTED = 21, // 21: 已断开
        SE_CONNECTERROR = 22, // 22: 连接失败
        SE_UNKNOWNERROR = 23, // 23: 已断开

        // 以下是L2TP的连接断开状态
        OPENPORT = 100,		// 打开端口

        PORTOPENED = 101,		// 端口打开
        CONNECTDEVICE = 102,		// 连接设备
        DEVICECONNECTED = 103,		// 连接设备中
        ALLDEVICESCONNECTED = 104, // 设备已连接
        AUTHENTICATE = 105,			// 开始认证
        AUTHNOTIFY = 106,		// 认证中
        AUTHPROJECT = 107,		// 认证项目
        PROJECTED = 108,		// 已认证项目
        AUTHENTICATED = 109,	// 认证通过
        UNKNOWN = 110,
        CONNECTED = 111,		// 连接成功
        DISCONNECTING = 112,	// 断开连接中
        DISCONNECTED = 113,		// 已断开
        CONNECTING = 114,		// 连接中
        CONNECTFAILED = 115,	// 连接失败

        UNKNOWN_MSG = 120,
    };

    internal enum ERROR_TYPE
    {
        SUSS = 0,
        INIT_ERROR = 1,  // 未初始化，或者初始化失败
        AUTH_ERROR = 2,  // 用户验证失败或者失效
        DEVICE_ERROR = 3,  // 所给的服务ID不正确，可能是未找到该服务器
        LINE_ERROR = 4,  // 获取线路失败
        LINEING = 5,  // 已经在连接中
        LINE_DIAL = 6,  // 线路在拨号中

        //LINE_DIAL = 6,  // 没有符合条件的线路连接
        PARAM_ERROR = 100, //参数错误
    };

    internal enum VPN_LINKPATTERN
    {
        SEVPN,
        L2TP,
        PPTP,
        OPENVPN
    };
}