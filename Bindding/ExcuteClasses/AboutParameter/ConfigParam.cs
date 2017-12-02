using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bindding.ExcuteClasses
{
    /// <summary>
    /// 配置信息的类
    /// </summary>
    public class ConfigParam
    {
        /// <summary>
        /// 切换IP方式
        /// </summary>
        public ChangeIPType change_ip { get; set; }

        /// <summary>
        /// 循环次数
        /// </summary>
        public int loop_count { get; set; }

        /// <summary>
        /// 查询关键词(key,match)
        /// </summary>
        public List<KeyValuePair<string, string>> key_match_list { get; set; }

        /// <summary>
        /// IP精灵信息
        /// </summary>
        public IpelfInfo ipelf_info { get; set; }

        public AdslInfo adsl_info { get; set; }

        /// <summary>
        /// 所有睡眠时间
        /// </summary>
        public SleepSeconds sleep_seconds { get; set; }

        /// <summary>
        /// 模拟操作的速度
        /// </summary>
        public SimulateSpeed simulate_speed { get; set; }
    }

    public class IpelfInfo
    {
        public string soft_path { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string provice { get; set; }
        public string city { get; set; }
    }

    public class AdslInfo
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class SleepSeconds
    {
        /// <summary>
        /// 多少庙后等待查询
        /// </summary>
        public RandomMinMax after_search { get; set; }

        public RandomMinMax baidu_search { get; set; }

        /// <summary>
        /// 弹出的页面展示时间
        /// </summary>
        public RandomMinMax pop_up { get; set; }

        /// <summary>
        /// 重连时间
        /// </summary>
        public RandomMinMax recon_time { get; set; }
    }

    public enum ChangeIPType
    {
        /// <summary>
        /// ADSL 拨号
        /// </summary>
        ADSL = 1,

        /// <summary>
        /// 按键精灵
        /// </summary>
        IPElf = 2,

        /// <summary>
        /// 未知
        /// </summary>
        NONE = -1
    }

    /// <summary>
    /// 模拟操作速度(随机时间范围)
    /// </summary>
    public class SimulateSpeed
    {
        /// <summary>
        /// 鼠标滚动滑轮
        /// </summary>
        public RandomMinMax mouse_scroll { get; set; }

        /// <summary>
        /// 鼠标移动到搜索框
        /// </summary>
        public RandomMinMax mouse_move_search_input { get; set; }

        /// <summary>
        /// 鼠标移动到搜索框 后，点击等待时间
        /// </summary>
        public RandomMinMax mouse_click_search_input { get; set; }

        /// <summary>
        /// 输入关键字的时间
        /// </summary>
        public RandomMinMax keyboard_keywords_speed { get; set; }
    }

    /// <summary>
    /// 点击数据最小，最大的范围
    /// </summary>
    public class RandomMinMax
    {
        /// <summary>
        /// 最小毫秒
        /// </summary>
        public int min_ms { get; set; }

        /// <summary>
        /// 最大毫秒数
        /// </summary>
        public int max_ms { get; set; }

        public int ToRandom()
        {
            return ConstParameter.RandomSeed.Next(min_ms, max_ms);
        }
    }
}