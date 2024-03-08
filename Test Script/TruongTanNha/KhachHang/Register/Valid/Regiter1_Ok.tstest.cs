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
using System.Data;
using System.Data.SqlClient;

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

    public class Regiter1_Ok : BaseWebAiiTest
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
        public void Regiter1_Ok_CodedStep()
        {
             // Thực hiện truy vấn cơ sở dữ liệu
                string username  = "tannha123456789";
                string connectionString = "data source=.;initial catalog=BookingAirLight;integrated security=True;MultipleActiveResultSets=True"; // Thay thế bằng chuỗi kết nối cơ sở dữ liệu thực tế
        
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
    
                    using (SqlCommand command = new SqlCommand("SELECT * FROM KhachHang WHERE Username = @Username", connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
            
                        int rowCount = 0;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                rowCount++;
                            }
                        }
            
                        // Kiểm tra kết quả truy vấn
                        if (rowCount > 0)
                        {
                            // Kết quả kiểm tra là TRUE nếu có ít nhất một dòng dữ liệu trả về
                            Log.WriteLine("Truy vấn cơ sở dữ liệu thành công. Tài khoản đã được lưu trữ.");
                            Assert.IsTrue(true, "Kiểm tra cơ sở dữ liệu thành công.");
                        }
                        else
                        {
                            // Kết quả kiểm tra là FALSE nếu không có dòng dữ liệu nào trả về
                            Log.WriteLine("Truy vấn cơ sở dữ liệu thất bại. Tài khoản chưa được lưu trữ.");
                            Assert.IsTrue(false, "Kiểm tra cơ sở dữ liệu thất bại.");
                        }
                    }
                }
        }
    
        [CodedStep(@"Verify 'TextContent' 'Contains' 'tannha123@gmail.com' on 'Tannha123GmailListItem'")]
        public void Regiter1_Ok_CodedStep1()
        {
            // Verify 'TextContent' 'Contains' 'tannha123@gmail.com' on 'Tannha123GmailListItem'
            Pages.ThongtinCaNhan.Tannha123GmailListItem.AssertContent().TextContent(ArtOfTest.Common.StringCompareType.Contains, "tannha123@gmail.com");
            
        }
    
        [CodedStep(@"Enter text '123456' in 'PasswordPassword'")]
        public void Regiter1_Ok_CodedStep2()
        {
            // Enter text '123456' in 'PasswordPassword'
            Actions.SetText(Pages.HttpsLocalhost44395LoginU.PasswordPassword, "");
            Pages.HttpsLocalhost44395LoginU.PasswordPassword.ScrollToVisible(ArtOfTest.WebAii.Core.ScrollToVisibleType.ElementCenterAtWindowCenter);
            ActiveBrowser.Window.SetFocus();
            Pages.HttpsLocalhost44395LoginU.PasswordPassword.Focus();
            Pages.HttpsLocalhost44395LoginU.PasswordPassword.MouseClick();
            Manager.Desktop.KeyBoard.TypeText("123456", 50, 100, true);
            
        }
    }
}
