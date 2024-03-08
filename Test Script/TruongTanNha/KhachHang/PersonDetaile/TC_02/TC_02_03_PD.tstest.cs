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

    public class TC_02_03_PD : BaseWebAiiTest
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
        public void Result(string kq,string rs){
            string myPath = "D:\\TNha.xlsx";
            int rowIndex = 19; // Giả sử vị trí dòng là 2
            int columnIndex = 9; // Giả sử vị trí cột là 1
            int workSheet = 5;
            
            ExcelWriter excelWriter = new ExcelWriter();
            excelWriter.WriteToExcelResult(myPath, rowIndex, columnIndex, kq,rs,workSheet);
        }
        
        [CodedStep(@"New Coded Step")]
        public void TC_02_03_PD_CodedStep()
        {
           // Lấy nội dung của phần tử 'x054564864556456ListItem'
            string citizenID = Pages.ThongtinCaNhan.x054564864556456ListItem.BaseElement.InnerText.Substring(11);
        
            // Kiểm tra và xử lý giá trị citizenID ở đây nếu cần
            Log.WriteLine("Citizen ID: " + citizenID);
            
            string connectionString = "data source=.;initial catalog=BookingAirLight;integrated security=True;MultipleActiveResultSets=True";            
            try{
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
    
                    using (SqlCommand command = new SqlCommand("SELECT * FROM KhachHang WHERE CCCD = @Cccd", connection))
                    {
                        command.Parameters.AddWithValue("@Cccd", citizenID);
            
                        int rowCount = 0;
                        string columnValue="";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                rowCount++;
                                columnValue = reader["CCCD"].ToString();
                            }
                        }
            
                        // Kiểm tra kết quả truy vấn
                        if (rowCount > 0)
                        {
                            // Kết quả kiểm tra là TRUE nếu có ít nhất một dòng dữ liệu trả về
                            Log.WriteLine("Truy vấn cơ sở dữ liệu thành công. Tài khoản đã được lưu trữ.");
                            Assert.IsTrue(true, "Kiểm tra cơ sở dữ liệu thành công.");
                            Result("Pass",columnValue);
                            
                        }
                        else
                        {
                            // Kết quả kiểm tra là FALSE nếu không có dòng dữ liệu nào trả về
                            Log.WriteLine("Truy vấn cơ sở dữ liệu thất bại. Tài khoản chưa được lưu trữ.");
                            Assert.IsTrue(false, "Kiểm tra cơ sở dữ liệu thất bại.");
                            Result("Fail",columnValue);
                        }
                    }
                }
            }catch(Exception e){
                Result("Fail",e.Message);
            }
             
        }
    
        [CodedStep(@"Verify 'InnerText' 'Exact' 'Citizen ID:054564864556456489' on 'x054564864556456ListItem'")]
        public void TC_02_03_PD_CodedStep1()
        {
            
            // Verify 'InnerText' 'Exact' 'Citizen ID:054564864556456489' on 'x054564864556456ListItem'
            Pages.ThongtinCaNhan.x054564864556456ListItem.AssertContent().InnerText(ArtOfTest.Common.StringCompareType.Exact, "Citizen ID:054564864556456489");
            
        }
    }
}
