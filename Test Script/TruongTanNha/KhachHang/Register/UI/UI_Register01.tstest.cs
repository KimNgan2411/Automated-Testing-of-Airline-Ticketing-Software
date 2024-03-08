using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.TelerikUI.Blazor;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using ArtOfTest.WebAii.DesktopAutomation;
using ArtOfTest.WebAii.DesktopAutomation.Controls;
using ArtOfTest.WebAii.DesktopAutomation.FindExpressions;

namespace TestProject1
{

    public class UI_Register01 : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        [CodedStep(@"New Coded Step")]
        public void UI_Register01_CodedStep()
        {
           // Điều hướng đến trang web
            ActiveBrowser.NavigateTo("https://www.google.com/");
        
            
            // Tìm nút tìm kiếm theo XPath và nhấp vào nó
            Element input = ActiveBrowser.Find.ByXPath("//textarea[@id='APjFqb']");
            ActiveBrowser.Actions.SetText(input,"toi la Nha Truong day");
            Element btnSearch = ActiveBrowser.Find.ByXPath("(//input[@name='btnK'])[2]");
            ActiveBrowser.Actions.Click(btnSearch);
            string title = ActiveBrowser.PageTitle;
            Log.WriteLine("Tieu de cua ban "+ title);
            System.Threading.Thread.Sleep(1000);
            Assert.AreEqual("toi la Nha Truong day",title);
        }
    }
}
