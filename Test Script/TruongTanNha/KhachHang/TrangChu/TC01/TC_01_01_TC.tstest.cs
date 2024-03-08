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

    public class TC_01_01TC : BaseWebAiiTest
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
        
        [CodedStep(@"Verify 'Display:Width' style 'Exact' '1903px' on 'div_Header'")]
        public void TC_01_01_CodedStep1()
        {
            // Verify 'Display:Width' style 'Exact' '1903px' on 'div_Header'
            Pages.TrangChu1.div_Header.AssertStyle().Display(ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleDisplay.Width, "1903px", ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleType.Computed, ArtOfTest.Common.StringCompareType.Exact);          
        }
    
        [CodedStep(@"Verify 'Display:Width' style 'Exact' '1903px' on 'div_Header'")]
        public void TC_01_01_CodedStep()
        {
            // Verify 'Display:Width' style 'Exact' '1903px' on 'div_Header'
            Pages.TrangChu1.div_Header.AssertStyle().Display(ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleDisplay.Width, "1903px", ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleType.Computed, ArtOfTest.Common.StringCompareType.Exact);
        }
    
        [CodedStep(@"Verify 'Display:Height' style 'Exact' '51px' on 'div_Header'")]
        public void TC_01_01_CodedStep2()
        {
            // Verify 'Display:Height' style 'Exact' '51px' on 'div_Header'
            Pages.TrangChu1.div_Header.AssertStyle().Display(ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleDisplay.Height, "51px", ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleType.Computed, ArtOfTest.Common.StringCompareType.Exact);
            
        }
    
        [CodedStep(@"Verify 'Display:Width' style 'Exact' '1903px' on 'Div'")]
        public void TC_01_01_CodedStep3()
        {
            // Verify 'Display:Width' style 'Exact' '1903px' on 'Div'
            Pages.TrangChu.Div.AssertStyle().Display(ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleDisplay.Width, "1903px", ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleType.Computed, ArtOfTest.Common.StringCompareType.Exact);
        }
    
        [CodedStep(@"Verify 'Display:Height' style 'Exact' '51px' on 'Div'")]
        public void TC_01_01_CodedStep4()
        {
            // Verify 'Display:Height' style 'Exact' '51px' on 'Div'
            Pages.TrangChu.Div.AssertStyle().Display(ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleDisplay.Height, "51px", ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts.HtmlStyleType.Computed, ArtOfTest.Common.StringCompareType.Exact);
        }
        
    }
}
