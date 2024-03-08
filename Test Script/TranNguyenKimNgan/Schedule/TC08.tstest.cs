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
using System.Globalization;

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

    public class TC08 : BaseWebAiiTest
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
        public void TC08_CodedStep()
        {
            HtmlTable myTable = ActiveBrowser.Find.ById<HtmlTable>("datatablesSimple");
            IList<HtmlTableRow> myList = myTable.Find.AllByTagName<HtmlTableRow>("tr");//Collect all rows.
            List<string> cellValues = new List<string>();
            List<DateTime> dateValues = new List<DateTime>();
            for (int i=2; i<myList.Count; i++)
    {
        Log.WriteLine(myList[i].Cells[3].InnerText.ToString());
        string cellValue = myList[i].Cells[3].InnerText.Trim();
        DateTime date;
        if (DateTime.TryParseExact(cellValue, "MM/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
        {
            dateValues.Add(date);
        }
    }

    bool isSortedDescendingByDate = IsSortedDescendingByDate(dateValues);
    if (isSortedDescendingByDate)
    {
        Log.WriteLine("Các giá trị đã được sắp xếp theo thứ tự ngày tháng giảm dần.");
    }
    else
    {
        Log.WriteLine("Các giá trị không được sắp xếp theo thứ tự ngày tháng giảm dần.");
    }
}

private bool IsSortedDescendingByDate(List<DateTime> values)
{
    for (int i = 1; i < values.Count; i++)
    {
        if (values[i - 1] < values[i])
        {
            return false;
        }
    }
    return true;
}
    
    }
}