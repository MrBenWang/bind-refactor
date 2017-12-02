using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bindding.ExcuteClasses
{
    /// <summary>
    /// 运行时的参数，需要保存到硬盘中
    /// </summary>
    public class RunParameters
    {
        public int CurUserAgentIndex
        {
            get
            {
                return CommonParameter.CurrentUserAgentIndex;
            }
            set
            {
                CommonParameter.CurrentUserAgentIndex = value;
            }
        }

        public int CurScrRslIndex
        {
            get
            {
                return CommonParameter.CurrentScreenResolutionIndex;
            }
            set
            {
                CommonParameter.CurrentScreenResolutionIndex = value;
            }
        }

        public int CurLoopNo
        {
            get
            {
                return CommonParameter.CurrentLoopNum;
            }
            set
            {
                CommonParameter.CurrentLoopNum = value;
            }
        }
    }
}