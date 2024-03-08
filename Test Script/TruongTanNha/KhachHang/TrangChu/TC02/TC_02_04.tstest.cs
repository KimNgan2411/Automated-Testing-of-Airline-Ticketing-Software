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

    public class TC_02_04 : BaseWebAiiTest
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
        public void TC_02_04_CodedStep()
        {
            ActiveBrowser.NavigateTo("https://localhost:44395/");
            Element selection = ActiveBrowser.Find.ByXPath("//select[@id='from']");   
            ActiveBrowser.Actions.SelectDropDown(selection, 2);  
            
            Element selection2 = ActiveBrowser.Find.ByXPath("//select[@id='to']");   
            ActiveBrowser.Actions.SelectDropDown(selection2,2);
        }
    
        [CodedStep(@"New Coded Step")]
        public void TC_02_04_CodedStep1()
        {
            Element selection = ActiveBrowser.Find.ByXPath("/html/body/section[1]/div/div/div[2]/section/div/div/form/div/div[1]/fieldset/select");   
            ActiveBrowser.Actions.SelectDropDown(selection, 3);
            
        }
    }
}
