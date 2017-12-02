using CefSharp;
using System;

namespace Bindding.MainForms.UserControls
{
    internal class LifeSpanHandler : ILifeSpanHandler
    {
        /// <summary>
        /// 弹出的事件
        /// </summary>
        internal event EventHandler MyBeforPopup;

        public bool DoClose(IWebBrowser browserControl, IBrowser browser)
        {
            return false;
        }

        public void OnAfterCreated(IWebBrowser browserControl, IBrowser browser)
        {
        }

        public void OnBeforeClose(IWebBrowser browserControl, IBrowser browser)
        {
        }

        public bool OnBeforePopup(IWebBrowser browserControl, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            if (MyBeforPopup != null)
            {
                MyBeforPopup(targetUrl, null);
            }

            newBrowser = null;
            return true;
        }
    }
}