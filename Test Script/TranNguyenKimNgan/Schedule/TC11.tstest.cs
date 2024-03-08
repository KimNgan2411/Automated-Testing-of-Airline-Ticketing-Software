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

    public class TC11 : BaseWebAiiTest
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
        public void TC11_CodedStep()
        {
            HtmlTable myTable = ActiveBrowser.Find.ById<HtmlTable>("datatablesSimple");
            IList<HtmlTableRow> myList = myTable.Find.AllByTagName<HtmlTableRow>("tr");//Collect all rows.
            List<string> cellValues = new List<string>();

            for (int i=2; i<myList.Count; i++)
            {
                    string cellValue = myList[i].Cells[4].InnerText.Trim();
                        if (IsValidDuration(cellValue))
                                cellValues.Add(cellValue); 
            }
            

    bool isSortedAscendingByDuration = IsSortedAscendingByDuration(cellValues);
    if (isSortedAscendingByDuration)
    {
        Log.WriteLine("Các giá trị thời lượng giờ đã được sắp xếp theo thứ tự tăng dần.");
    }
    else
    {
        Log.WriteLine("Các giá trị thời lượng giờ không được sắp xếp theo thứ tự tăng dần.");
    }
}

private bool IsSortedAscendingByDuration(List<string> values)
{
    for (int i = 1; i < values.Count; i++)
    {
        if (!CompareDurations(values[i - 1], values[i]))
        {
            return false;
        }
    }
    return true;
}

private bool CompareDurations(string duration1, string duration2)
{
    // Logic để so sánh thứ tự tăng dần của thời lượng giờ
    // Ở đây, chúng ta sử dụng một logic đơn giản, bạn có thể phát triển logic này để so sánh các thời lượng giờ phức tạp hơn
    // Đây chỉ là một ví dụ cơ bản để minh họa cách tiếp cận

    if (duration1.Contains("giờ") && duration2.Contains("phút"))
    {
        return false;
    }
    else if (duration1.Contains("phút") && duration2.Contains("giây"))
    {
        return false;
    }
    else if (duration1.Contains("giờ") && duration2.Contains("giây"))
    {
        return false;
    }
    else
    {
        return true;
    }
}

private bool IsValidDuration(string duration)
{
    // Logic để xác định nếu chuỗi có thể được hiểu là thời lượng giờ
    // Ở đây, chúng ta sử dụng một logic đơn giản, bạn có thể phát triển logic này để xác định các mẫu thời lượng giờ phức tạp hơn

    if (duration.Contains("giờ") || duration.Contains("phút") || duration.Contains("giây"))
    {
        return true;
    }

    return false;
}
    }
}
