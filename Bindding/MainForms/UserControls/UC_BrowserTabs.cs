using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CefSharp.WinForms.Internals;
using Bindding.ExcuteClasses;

namespace Bindding.MainForms.UserControls
{
    public partial class UC_BrowserTabs : BaseUserControl
    {
        public UC_BrowserTabs()
        {
            InitializeComponent();
            this.uc_search_page.MyNextSearch += (o1, e1) =>
            {
                this.InvokeOnUiThreadIfRequired(() =>
                {
                    this.uc_tab_browsers.SelectTab(0);
                });
            };

            this.uc_search_page.MyBeforPopup += (o1, e1) =>
            {
                this.InvokeOnUiThreadIfRequired(() =>
                {
                    this.uc_pop_page.UrlText = o1.ToString();
                    this.uc_tab_browsers.SelectTab(1);
                });
            };

            this.uc_pop_page.MyBeforPopup += (o1, e1) =>
            {
                this.InvokeOnUiThreadIfRequired(() =>
                {
                    this.uc_second_page.UrlText = o1.ToString();
                    this.uc_tab_browsers.SelectTab(2);
                });
            };

            if (!DesignMode)
            {
                this.uc_search_page.InitialBrower();
                this.uc_pop_page.InitialBrower();
                this.uc_second_page.InitialBrower();
            }
        }

        internal UC_Browser main_browser
        {
            get
            {
                return this.uc_search_page;
            }
        }
    }
}