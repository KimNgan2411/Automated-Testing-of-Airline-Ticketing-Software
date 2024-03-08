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

    public class TC_04_PD : BaseWebAiiTest
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
    
        [CodedStep(@"Enter text '012354898566420' in 'CCCDNumber' - DataDriven: [$(CitizenID)]")]
        public void TC_04_PD_CodedStep()
        {
            // Enter text '012354898566420' in 'CCCDNumber'
            Actions.SetText(Pages.EditProfile.CCCDNumber, "");
            Pages.EditProfile.CCCDNumber.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.EditProfile.CCCDNumber.Focus();
            Pages.EditProfile.CCCDNumber.MouseClick();
            Manager.Desktop.KeyBoard.TypeText(((string)(System.Convert.ChangeType(Data["CitizenID"], typeof(string)))), 50, 100, true);
            
        }
        public void Result(string kq,string rs,int row){
            string myPath = "D:\\TNha.xlsx";
            int rowIndex = row; // Giả sử vị trí dòng là 2
            int columnIndex = 9; // Giả sử vị trí cột là 1
            int workSheet = 5;
            string result = kq; // Giá trị cần ghi vào cell
            string actualRS = rs;
            ExcelWriter excelWriter = new ExcelWriter();
            excelWriter.WriteToExcelResult(myPath, rowIndex, columnIndex, result,actualRS,workSheet);
        }
        [CodedStep(@"New Coded Step")]
        public void TC_04_PD_CodedStep1()
        {
            string rowvalue = (string)Data["Row"];
            int intValue = int.Parse(rowvalue);
            try{
                var name = Pages.ThongtinCaNhan.NameElement.BaseElement.InnerText.ToString();
                var date = Pages.ThongtinCaNhan.x20020126ListItem.BaseElement.InnerText.ToString();
                var email = Pages.ThongtinCaNhan.TannhaGmailListItem.BaseElement.InnerText.ToString();
                var phone = Pages.ThongtinCaNhan.x95483159ListItem.BaseElement.InnerText.ToString();
                var cccd = Pages.ThongtinCaNhan.x49875365841558ListItem.BaseElement.InnerText.ToString();
                var gender = Pages.ThongtinCaNhan.ListItem.BaseElement.InnerText.ToString();
                Log.WriteLine("Name: "+name+",Date: "+ date +", Email: "+ email+", Phone: "+ phone+", CCCD: "+ cccd+", Gender: "+ gender);
                if(name.Substring(7).Equals(Data["Name"]) && date.Substring(16).Equals(Data["Date"]) && email.Substring(8).Equals(Data["Email"]) && phone.Substring(8).Equals("Phone") && cccd.Substring(13).Equals(Data["CitizenID"]) && gender.Substring(9).Equals(Data["Gender"])){
                    Result("Pass","Khop voi yeu cau",intValue);       
                }else{
                     Result("Fail","Khong khop voi yeu cau",intValue);
                }
            }catch(Exception e){
                Log.WriteLine("Loi: "+ e.Message);
                Result("Fail",e.Message,intValue);
            }
        }
    
        [CodedStep(@"Verify 'TextContent' 'Contains' '012354898566420' on 'x012354898566420ListItem'")]
        public void TC_04_PD_CodedStep2()
        {
            // Verify 'TextContent' 'Contains' '012354898566420' on 'x012354898566420ListItem'
            Pages.ThongtinCaNhan.x012354898566420ListItem.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Contains, "012354898566420");
            
        }
    }
}
