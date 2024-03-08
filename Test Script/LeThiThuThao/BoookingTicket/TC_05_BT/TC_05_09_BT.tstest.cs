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

    public class TC_05_09_BT : BaseWebAiiTest
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
        public void TC_05_09_BT_CodedStep()
        {
            string myPath = "D:\\TNha.xlsx";
            int rowIndex = 73; // Giả sử vị trí dòng là 2
            int columnIndex = 9; // Giả sử vị trí cột là 1
            int workSheet = 6;
            string result = "Pass"; // Giá trị cần ghi vào cell
            
            ExcelWriter excelWriter = new ExcelWriter();
            excelWriter.WriteToExcel(myPath, rowIndex, columnIndex, result,workSheet);
        }
        
    
        [CodedStep(@"New Coded Step")]
        public void TC_05_09_BT_CodedStep1()
        {
             string myPath = "D:\\TNha.xlsx";
            int rowIndex = 73; // Giả sử vị trí dòng là 2
            int columnIndex = 9; // Giả sử vị trí cột là 1
            int workSheet = 6;
            string result = "Fail"; // Giá trị cần ghi vào cell
            
            ExcelWriter excelWriter = new ExcelWriter();
            excelWriter.WriteToExcel(myPath, rowIndex, columnIndex, result,workSheet);
        }
    }
}
