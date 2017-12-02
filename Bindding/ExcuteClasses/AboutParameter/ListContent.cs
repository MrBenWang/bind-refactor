namespace Bindding.ExcuteClasses
{
    public class ListContent
    {
        public string title { get; set; }

        public string link { get; set; }

        public string target { get; set; }

        public bool is_ad { get; set; }

        public int top { get; set; }

        public int left { get; set; }

        /// <summary>
        /// 用于列表展示
        /// </summary>
        public string ad_show
        {
            get
            {
                if (is_ad)
                {
                    return "√";
                }

                return string.Empty;
            }
        }
    }
}