using Bindding.ExcuteClasses;
using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;
using CefSharp.WinForms.Internals;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
using Newtonsoft.Json;
using WindowsInput;
using WindowsInput.Native;
using Bindding.ExcuteClasses.AboutParameter;

namespace Bindding.MainForms.UserControls
{
    /// <summary>
    /// 浏览器控件
    /// </summary>
    public partial class UC_Browser : BaseUserControl
    {
        private ChromiumWebBrowser browser;

        ///// <summary>
        ///// 为保证线程安全，确保顺序执行
        ///// </summary>
        //private readonly static object _locker = new object();

        /// <summary>
        /// 当前执行的是第几个
        /// </summary>
        private int _currentIndex = 0;

        #region 属性

        /// <summary>
        /// 当前执行的次数
        /// </summary>
        internal int _currentNum
        {
            get
            {
                return CommonParameter.CurrentLoopNum;
            }
            set
            {
                CommonParameter.CurrentLoopNum = value;
                OnChangeCurrentNum(value, null);
            }
        }

        internal bool _is_working { get; set; }

        #endregion 属性

        public UC_Browser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 开始点击事件
        /// </summary>
        internal void StartClick()
        {
            _currentNum = 1;
            _currentIndex = 0;
            _is_working = true;
            browser.Load(ConstParameter.SEARCH_ENGINES);
        }

        /// <summary>
        /// 结束点击事件
        /// </summary>
        internal void StopClick()
        {
            _currentNum = 1;
            _currentIndex = 0;
            _is_working = false;
        }

        internal void InitialBrower()
        {
            // Set the CachePath during initialization.
            var settings = new CefSettings()
            {
                UserAgent = CommonParameter.CurrentUserAgentValue
            };
            Cef.Initialize(settings);

            CommonFunction.DeleteCefsharpDirectory();
            browser = new ChromiumWebBrowser(ConstParameter.SEARCH_ENGINES)
            {
                Dock = DockStyle.Fill,
                BrowserSettings =
                   {
                       ApplicationCache = CefState.Disabled,
                       JavascriptOpenWindows = CefState.Enabled,
                       TabToLinks = CefState.Disabled
                   }
            };

            var mng = Cef.GetGlobalCookieManager();
            bool flag = mng.SetStoragePath(ConstParameter.CookiePath, true);

            toolStripContainer1.ContentPanel.Controls.Add(browser);

            browser.RequestHandler = new RequestHandler(); // 重写request
            browser.LoadingStateChanged += OnBrowserLoadingStateChanged;
            browser.AddressChanged += OnBrowserAddressChanged;
            browser.FrameLoadEnd += BeginSearch;
            var _lfsh = new LifeSpanHandler();  // 弹出框
            _lfsh.MyBeforPopup += MyBeforPopup;
            browser.LifeSpanHandler = _lfsh;
        }

        internal event EventHandler MyBeforPopup;

        /// <summary>
        /// 执行第二次的查询
        /// </summary>
        internal event EventHandler MyNextSearch;

        /// <summary>
        /// 加载完成以后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnBrowserLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            SetCanGoBack(args.CanGoBack);
            SetCanGoForward(args.CanGoForward);
            this.InvokeOnUiThreadIfRequired(() => SetIsLoading(!args.CanReload));

            if (_is_working && _currentNum > CommonParameter.ConfigParam.loop_count)
            {
                OnExcuteClickEnd(this, null);
                return;
            }

            if (!args.IsLoading && browser.Address != ConstParameter.SEARCH_ENGINES && _is_working && _currentNum <= CommonParameter.ConfigParam.loop_count)
            {
                // 点击 百度一下后，加载的页面
                Task.Factory.StartNew(() =>
                {
                    Monitor.Enter(CommonParameter.LokerObj);
                    // Monitor.Wait(CommonParameter.LokerObj);
                    Thread.Sleep(CommonParameter.ConfigParam.sleep_seconds.after_search.ToRandom());
                    this.RunJS("var _matchKey='" + CommonParameter.ConfigParam.key_match_list[_currentIndex].Value + ConstParameter.GET_BAIDU_LIST_JS);
                    Monitor.Exit(CommonParameter.LokerObj);
                });
            }
        }

        /// <summary>
        /// 执行js返回，执行的结果
        /// </summary>
        /// <param name="strJS"></param>
        private void RunJS(string strJS)
        {
            string returnValue = string.Empty;
            browser.EvaluateScriptAsync(strJS).ContinueWith(t =>
            {
                if (!t.IsFaulted)
                {
                    var response = t.Result;
                    if (response.Success && response.Result != null)
                    {
                        returnValue = response.Result.ToString();
                        if (!string.IsNullOrEmpty(returnValue))
                        {
                            this.AfterSearchSimClick(returnValue);
                        }
                    }
                    else
                    {
                        Thread.Sleep(2000);
                        browser.Load(ConstParameter.SEARCH_ENGINES);
                    }
                }
            });
        }

        /// <summary>
        /// 加载列表
        /// </summary>
        /// <param name="strData"></param>
        private void AfterSearchSimClick(string strData)
        {
            Monitor.Enter(CommonParameter.LokerObj);
            var _dataList = JsonConvert.DeserializeObject<List<ListContent>>(strData);
            bool _is_click = false;
            foreach (ListContent singleContent in _dataList)
            {
                // 模拟点击
                if (singleContent.is_ad == ConstParameter.CLICK_AD)
                {
                    var sim = new InputSimulator();
                    sim.Mouse
                        .VerticalScroll(20)
                        .Sleep(CommonParameter.ConfigParam.simulate_speed.mouse_scroll.ToRandom()); // 先到最顶层  1 = 100px；

                    CommonFunction.SimMoveAndLefClick(singleContent.left, singleContent.top, true);

                    // 记录日志
                    var _tmpLog = new ContentLog();
                    _tmpLog.ch_Key = CommonParameter.ConfigParam.key_match_list[_currentIndex].Key;
                    _tmpLog.ch_Website = singleContent.target;
                    _tmpLog.ch_Title = singleContent.title;
                    OnWriteLog(_tmpLog, null);
                    _is_click = true;
                    break; // 一次搜索，只点击一次
                }
            }

            _currentIndex++;
            if (_is_click)
            {
                Monitor.Wait(CommonParameter.LokerObj); // 点击成功需要等待
                MyNextSearch(null, null);
            }

            Thread.Sleep(CommonParameter.ConfigParam.sleep_seconds.baidu_search.ToRandom());
            Cef.GetGlobalCookieManager().DeleteCookiesAsync(string.Empty, string.Empty);
            Monitor.Exit(CommonParameter.LokerObj);
            browser.Load(ConstParameter.SEARCH_ENGINES);
        }

        private void BeginSearch(object sender, FrameLoadEndEventArgs args)
        {
            if (browser.Address == ConstParameter.SEARCH_ENGINES && _is_working && _currentNum <= CommonParameter.ConfigParam.loop_count)
            {
                if (_currentIndex < CommonParameter.ConfigParam.key_match_list.Count)
                {
                    // 移动到搜索框
                    int _x = CommonParameter.FormX + ConstParameter.SearchX + ConstParameter.RandomSeed.Next(50, 300);
                    int _y = CommonParameter.FormY + ConstParameter.BrowerY + ConstParameter.SearchY + ConstParameter.RandomSeed.Next(15, 20);
                    Task.Factory.StartNew(() =>
                    {
                        Monitor.Enter(CommonParameter.LokerObj); // 开始 搜索，需要锁定
                        var sim = new InputSimulator();
                        sim.Mouse
                           .MoveMouseTo(CommonParameter.CurrentScreenWidth * _x, CommonParameter.CurrentScreenHeight * _y)
                           .Sleep(CommonParameter.ConfigParam.simulate_speed.mouse_move_search_input.ToRandom())
                           .LeftButtonClick()
                           .Sleep(CommonParameter.ConfigParam.simulate_speed.mouse_click_search_input.ToRandom());
                        // 输入 搜索关键字
                        foreach (char _single in CommonParameter.ConfigParam.key_match_list[_currentIndex].Key)
                        {
                            sim.Keyboard
                                .TextEntry(_single)
                                .Sleep(CommonParameter.ConfigParam.simulate_speed.keyboard_keywords_speed.ToRandom());
                        }

                        sim.Keyboard.KeyPress(VirtualKeyCode.RETURN); // 按下回车键

                        Monitor.Pulse(CommonParameter.LokerObj);
                        Monitor.Exit(CommonParameter.LokerObj); // 输入搜索完成
                    });
                }
                else
                {
                    // 用于判断最后一次
                    if (_is_working && _currentNum >= CommonParameter.ConfigParam.loop_count)
                    {
                        OnExcuteClickEnd(this, null);
                        return;
                    }
                    var _msg = CommonFunction.BackgroundDoWorkIpelfFast();
                    if (!string.IsNullOrEmpty(_msg))
                    {
                        MessageBox.Show(_msg, "IP精灵异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _currentNum++;
                    OnExitApplcation(null, null);
                }
            }
        }

        #region 浏览的事件

        /// <summary>
        /// 执行点击完成后
        /// </summary>
        internal event EventHandler OnExcuteClickEnd;

        internal event EventHandler OnChangeCurrentNum;

        internal event EventHandler OnWriteLog;

        /// <summary>
        /// 执行一次后，需要关闭软件
        /// </summary>
        internal event EventHandler OnExitApplcation;

        #endregion 浏览的事件

        #region 浏览器的按钮

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => urlTextBox.Text = args.Address);
        }

        private void SetCanGoBack(bool canGoBack)
        {
            this.InvokeOnUiThreadIfRequired(() => backButton.Enabled = canGoBack);
        }

        private void SetCanGoForward(bool canGoForward)
        {
            this.InvokeOnUiThreadIfRequired(() => forwardButton.Enabled = canGoForward);
        }

        private void SetIsLoading(bool isLoading)
        {
            goButton.Text = isLoading ? "Stop" : "Go";
            goButton.Image = isLoading ?
                Bindding.Properties.Resources.nav_plain_red :
                Bindding.Properties.Resources.nav_plain_green;

            HandleToolStripLayout();
        }

        private void HandleToolStripLayout(object sender, LayoutEventArgs e)
        {
            HandleToolStripLayout();
        }

        private void HandleToolStripLayout()
        {
            var width = toolStrip1.Width;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (item != urlTextBox)
                {
                    width -= item.Width - item.Margin.Horizontal;
                }
            }
            urlTextBox.Width = Math.Max(0, width - urlTextBox.Margin.Horizontal - 18);
        }

        private void UrlTextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            LoadUrl(urlTextBox.Text);
        }

        private void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                browser.Load(url);
            }
        }

        private void GoButtonClick(object sender, EventArgs e)
        {
            LoadUrl(urlTextBox.Text);
        }

        private void BackButtonClick(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void ForwardButtonClick(object sender, EventArgs e)
        {
            browser.Forward();
        }

        #endregion 浏览器的按钮
    }
}