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

    public class CustomerLogin : BaseWebAiiTest
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
    
        [CodedStep(@"Navigate to : 'https://localhost:44395/LoginUser/Login'")]
        public void CustomerLogin_CodedStep()
        {
            // Navigate to : 'https://localhost:44395/LoginUser/Login'
            this.ActiveBrowser.NavigateTo("https://localhost:44395/LoginUser/Login", true);
            
        }
    
        [CodedStep(@"Enter text 'kh01' in 'UserText' - DataDriven: [$(Col1)]")]
        public void CustomerLogin_CodedStep1()
        {
            Actions.SetText(Pages.HttpsLocalhost44395LoginU.UserText, "");
            Pages.HttpsLocalhost44395LoginU.UserText.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.HttpsLocalhost44395LoginU.UserText.Focus();
            Pages.HttpsLocalhost44395LoginU.UserText.MouseClick();
            Manager.Desktop.KeyBoard.TypeText(((string)(System.Convert.ChangeType(Data["Col1"], typeof(string)))), 50, 100, true);
            
        }
    
        [CodedStep(@"Keyboard (KeyPress) - Tab (1 times) on 'PasswordPassword'")]
        public void CustomerLogin_CodedStep2()
        {
            ActiveBrowser.ContentWindow.SetFocus();
            Pages.HttpsLocalhost44395LoginU.PasswordPassword.ScrollToVisible();
            Pages.HttpsLocalhost44395LoginU.PasswordPassword.Focus();
            ActiveBrowser.Manager.Desktop.KeyBoard.KeyPress(ArtOfTest.WebAii.Win32.KeyBoard.KeysFromString("Tab"), 150, 1);
            ActiveBrowser.WaitUntilReady();
            
        }
    
        [CodedStep(@"Enter text '123456' in 'PasswordPassword' - DataDriven: [$(Col2)]")]
        public void CustomerLogin_CodedStep3()
        {
            // Enter text '123456' in 'PasswordPassword'
            Actions.SetText(Pages.HttpsLocalhost44395LoginU.PasswordPassword, "");
            Pages.HttpsLocalhost44395LoginU.PasswordPassword.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.HttpsLocalhost44395LoginU.PasswordPassword.Focus();
            Pages.HttpsLocalhost44395LoginU.PasswordPassword.MouseClick();
            Manager.Desktop.KeyBoard.TypeText(((string)(System.Convert.ChangeType(Data["Col2"], typeof(string)))), 50, 100, true);
            
        }
    
        [CodedStep(@"Click 'LoginButtonTag'")]
        public void CustomerLogin_CodedStep4()
        {
            // Click 'LoginButtonTag'
            ActiveBrowser.Window.SetFocus();
            Pages.HttpsLocalhost44395LoginU.LoginButtonTag.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            Pages.HttpsLocalhost44395LoginU.LoginButtonTag.MouseClick(ArtOfTest.WebAii.Core.MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter);
            
        }
    
        [CodedStep(@"Verify 'TextContent' 'Contains' 'kh01' on 'Kh01Link' - DataDriven: [$(Col1)]")]
        public void CustomerLogin_CodedStep5()
        {
            // Verify 'TextContent' 'Contains' 'kh01' on 'Kh01Link'
            Pages.TrangChu.Kh01Link.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Contains, ((string)(System.Convert.ChangeType(Data["Col1"], typeof(string)))));
            
        }
    
        [CodedStep(@"Enter text '12345678' in 'PasswordPassword0' - DataDriven: [$(Password)]")]
        public void CustomerLogin_CodedStep6()
        {
            // Enter text '12345678' in 'PasswordPassword0'
            Actions.SetText(Pages.HttpsLocalhost44395LoginU.PasswordPassword0, "");
            Pages.HttpsLocalhost44395LoginU.PasswordPassword0.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.HttpsLocalhost44395LoginU.PasswordPassword0.Focus();
            Pages.HttpsLocalhost44395LoginU.PasswordPassword0.MouseClick();
            Manager.Desktop.KeyBoard.TypeText(((string)(System.Convert.ChangeType(Data["Password"], typeof(string)))), 50, 100, true);
            
        }
    }
}
