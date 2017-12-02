using Bindding.ExcuteClasses;
using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace Bindding.MainForms.UserControls
{
    /// <summary>
    /// 简单的浏览器控件只是 随机点击
    /// </summary>
    public partial class UC_SimpleBrower : BaseUserControl
    {
        public UC_SimpleBrower()
        {
            InitializeComponent();
            urlTextBox.Width = Math.Max(0, toolStrip1.Width - urlTextBox.Margin.Horizontal - 18);
        }

        #region 属性

        /// <summary>
        /// 设置Url地址
        /// </summary>
        internal string UrlText
        {
            set
            {
                browser.Load(value);
            }
        }

        /// <summary>
        /// 是否为主页面，如果false 则为二次点击界面
        /// </summary>
        [Browsable(true)]
        [Description("是否为二次点击的页面"), DefaultValue(true)]
        public bool SecondPage { get; set; }

        #endregion 属性

        private ChromiumWebBrowser browser;

        internal void InitialBrower()
        {
            browser = new ChromiumWebBrowser(ConstParameter.BLANK_PAGE)
            {
                Dock = DockStyle.Fill
            };

            toolStripContainer1.ContentPanel.Controls.Add(browser);
            var _lfsh = new LifeSpanHandler();  // 弹出框
            _lfsh.MyBeforPopup += MyBeforPopup;
            browser.RequestHandler = new RequestHandler(); // 重写request
            browser.LifeSpanHandler = _lfsh;
            browser.AddressChanged += OnBrowserAddressChanged;
            if (SecondPage)
            {
                browser.FrameLoadEnd += RandomMove;
            }
            else
            {
                browser.FrameLoadEnd += RandomClick;
            }
        }

        internal event EventHandler MyBeforPopup;

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => { urlTextBox.Text = args.Address; });
        }

        /// <summary>
        /// 随机点击
        /// </summary>
        private void RandomClick(object sender, FrameLoadEndEventArgs args)
        {
            if (args.Url == ConstParameter.BLANK_PAGE)
            {
                return;
            }

            string returnValue = string.Empty;
            browser.EvaluateScriptAsync(ConstParameter.GET_POPUP_RANDOM_A).ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;
                    if (response.Success && response.Result != null)
                    {
                        returnValue = response.Result.ToString();
                    }

                    this.SimMoveAndClick(returnValue);
                }
            });
        }

        /// <summary>
        /// 模拟移动 或者 点击 网址
        /// </summary>
        private void SimMoveAndClick(string _retStr)
        {
            ListContent _retData;
            if (string.IsNullOrEmpty(_retStr))
            {
                // 没有返回则不移动，因为重定向
                return;

                // 如果没有返回，只随机移动
                _retData = new ListContent();
                _retData.top = ConstParameter.RandomSeed.Next(300, 600);
                _retData.left = ConstParameter.RandomSeed.Next(200, 800);
            }
            else
            {
                _retData = JsonConvert.DeserializeObject<ListContent>(_retStr);
            }

            CommonFunction.SimMoveAndLefClick(_retData.left, _retData.top, true);

            // 执行点击事件
            if (!string.IsNullOrEmpty(_retStr))
            {
                browser.ExecuteScriptAsync("var _n=" + _retData.title + ConstParameter.GET_POPUP_CLICK_A);
            }
        }

        /// <summary>
        /// 随机移动，滚动滑轮
        /// </summary>
        private void RandomMove(object sender, FrameLoadEndEventArgs args)
        {
            if (args.Url == ConstParameter.BLANK_PAGE)
            {
                return;
            }

            this.InvokeOnUiThreadIfRequired(() =>
            {
                Monitor.Enter(CommonParameter.LokerObj);
                int _x = ConstParameter.RandomSeed.Next(300, 600);
                int _y = ConstParameter.RandomSeed.Next(200, 800);
                CommonFunction.SimMoveAndLefClick(_x, _y, false);
                Monitor.Pulse(CommonParameter.LokerObj);
                Monitor.Exit(CommonParameter.LokerObj);
            });
        }
    }
}