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

    public class TC10 : BaseWebAiiTest
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
        public void TC10_CodedStep()
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
            

    bool isSortedDescendingByDuration = IsSortedDescendingByDuration(cellValues);
    if (isSortedDescendingByDuration)
    {
        Log.WriteLine("Các giá trị thời lượng giờ đã được sắp xếp theo thứ tự giảm dần.");
    }
    else
    {
        Log.WriteLine("Các giá trị thời lượng giờ không được sắp xếp theo thứ tự giảm dần.");
    }
}

private bool IsValidDuration(string duration)
{
    // Kiểm tra nếu chuỗi có thể hiểu là thời lượng giờ
    // Đây là một ví dụ đơn giản, cần phát triển thêm để xác định chuỗi thời lượng giờ
    // Ở đây, chúng ta sử dụng một số điều kiện cơ bản để xác định mẫu thời lượng giờ
    // Bạn có thể mở rộng logic này để xác định các mẫu phức tạp hơn
    if (duration.Contains("giờ") || duration.Contains("phút") || duration.Contains("giây"))
    {
        return true;
    }

    return false;
}

private bool IsSortedDescendingByDuration(List<string> values)
{
    // Sắp xếp chuỗi theo thứ tự giảm dần dựa trên thời lượng giờ
    // Đây là một logic đơn giản, cần phát triển thêm để xử lý các trường hợp phức tạp hơn
    // Bạn có thể thay đổi logic này để xử lý nhiều trường hợp hơn
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
    // Đây là một phương pháp đơn giản để so sánh thời lượng giờ
    // Bạn cần phát triển logic này để so sánh các thời lượng giờ phức tạp hơn
    // Ở đây, chúng ta so sánh các chuỗi thời lượng giờ với nhau để xác định thứ tự giảm dần
    if (duration1.Contains("giờ") && duration2.Contains("phút"))
    {
        return true;
    }
    else if (duration1.Contains("phút") && duration2.Contains("giây"))
    {
        return true;
    }
    else if (duration1.Contains("giờ") && duration2.Contains("giây"))
    {
        return true;
    }
    else
    {
        return false;
    }
}
    }
}
