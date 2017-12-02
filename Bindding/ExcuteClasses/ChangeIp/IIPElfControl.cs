using System.Collections.Generic;

namespace Bindding.ExcuteClasses
{
    public interface IIpelfControl
    {
        string InitLogin();

        string IPGetUserInfo();

        List<string> IPGetProvices();

        List<string> IPGetCitys(string _provice);

        bool IPConnect();

        bool IPDisConnect();

        void IPUnInit();

        string IPStatus();
    }
}