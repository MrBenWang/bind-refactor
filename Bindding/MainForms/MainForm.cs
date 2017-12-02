using Bindding.ExcuteClasses;
using Bindding.ExcuteClasses.AboutParameter;
using Bindding.MainForms.UserControls;
using CefSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CefSharp.WinForms.Internals;
using System.Threading;

namespace Bindding.MainForms
{
    public partial class MainForm : Form
    {
        public MainForm(bool _is_working)
        {
            InitializeComponent();
            // this.TopMost = true;

            this.uC_LogsControl1.InitLoadLogs();
            CommonParameter.CurrentScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            CommonParameter.CurrentScreenHeight = Screen.PrimaryScreen.Bounds.Height;
            this.uc_browser_tabs.main_browser.OnExcuteClickEnd += _excuteClickEnd;
            this.uc_browser_tabs.main_browser.OnChangeCurrentNum += _changeCurrentNum;
            this.uc_browser_tabs.main_browser.OnWriteLog += _writeLog;
            this.uc_browser_tabs.main_browser.OnExitApplcation += _exitApplication;
            this.uC_MenuTitle1.OnStartupClosed += _menuStartupClosed;

            #region 初始化窗体的参数

            this.CurrentNumber = CommonParameter.CurrentLoopNum;
            this.uc_browser_tabs.main_browser._is_working = _is_working;
            this.btnBeginClick.Enabled = !_is_working;
            this.btnStopClick.Enabled = _is_working;

            #endregion 初始化窗体的参数

            this.ValidationInfo();
        }

        /// <summary>
        /// 检测注册信息
        /// </summary>
        private void ValidationInfo()
        {
            var _v_info = LicenseHelper.ValidationGetInfo();
            var _is_reg = true;
            if (_v_info == null)
            {
                MessageBox.Show("未注册！请联系作者！");
                _is_reg = false;
            }
            else if (_v_info.LicenseAttributes["m"] != LicenseHelper.getMachineKey())
            {
                MessageBox.Show("本机未注册！");
                _is_reg = false;
            }
            else if (_v_info.ExpirationDate < DateTime.Now.Date)
            {
                MessageBox.Show("注册时间已过期！");
                _is_reg = false;
            }

            if (!_is_reg)
            {
                this.DisableAllControl();
            }
        }

        internal int CurrentNumber
        {
            set
            {
                this.uC_KeyList1.MyCurrentNum = value;
            }
        }

        #region 浏览器执行的事件

        private void _excuteClickEnd(object sender, EventArgs args)
        {
            DialogResult dr = MessageBox.Show("执行完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                // 还原最大的分辨率
                CommonParameter.CurrentScreenResolutionIndex = 0;
                //this.InvokeOnUiThreadIfRequired(() => this.comboxResolutions.SelectedIndex = CommonParameter.CurrentScreenResolutionIndex);
                ScreenResolution.ChangeResolution(CommonParameter.CurrentScreenResolutionValue.Width, CommonParameter.CurrentScreenResolutionValue.Height, 0);
                btnStopClick_Click(null, null);
            }
        }

        /// <summary>
        /// 刷新当前执行的次数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>

        private void _changeCurrentNum(object sender, EventArgs args)
        {
            this.uC_KeyList1.MyCurrentNum = (int)sender;
        }

        private void _writeLog(object sender, EventArgs args)
        {
            var _tmp = (ContentLog)sender;
            this.InvokeOnUiThreadIfRequired(() => { this.uC_LogsControl1.AddNewLog(_tmp); });
        }

        private void _exitApplication(object sender, EventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                Thread.Sleep(3000);
                this.Close();
            });
        }

        #endregion 浏览器执行的事件

        #region 菜单栏事件

        /// <summary>
        /// 启动页面 关闭界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void _menuStartupClosed(object sender, EventArgs args)
        {
            this.uC_KeyList1.RefreshData();
        }

        #endregion 菜单栏事件

        #region 窗体执行事件

        private void btnBeginClick_Click(object sender, EventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                btnBeginClick.Enabled = false;
                btnStopClick.Enabled = true;
                this.uc_browser_tabs.main_browser.StartClick();
            });
        }

        private void btnStopClick_Click(object sender, EventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() =>
            {
                CommonParameter.CurrentScreenResolutionIndex = 0;
                ScreenResolution.ChangeResolution(CommonParameter.CurrentScreenResolutionValue.Width, CommonParameter.CurrentScreenResolutionValue.Height, 0);

                btnBeginClick.Enabled = true;
                btnStopClick.Enabled = false;
                this.uc_browser_tabs.main_browser.StopClick();
            });
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // CommonParameter.IpelfCurrentInstance.IPUnInit();
            Cef.GetGlobalCookieManager().DeleteCookiesAsync(string.Empty, string.Empty);
            Cef.Shutdown();
            CommonFunction.WriteRunParam();
            CommonFunction.WriteLogInFile("软件关闭!", LogType.RunLog);
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            var _form = ((Form)sender).Location;
            CommonParameter.FormX = _form.X;
            CommonParameter.FormY = _form.Y;
        }

        #endregion 窗体执行事件

        /// <summary>
        /// 禁用所有控件
        /// </summary>
        private void DisableAllControl()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Name == "uC_MenuTitle1")
                {
                    ctrl.Enabled = true;
                }
                else
                {
                    ctrl.Enabled = false;
                }
            }
        }
    }
}