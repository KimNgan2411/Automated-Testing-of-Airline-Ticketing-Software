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

    public class TC_02_05_PD : BaseWebAiiTest
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
            int rowIndex = 21; // Giả sử vị trí dòng là 2
            int columnIndex = 9; // Giả sử vị trí cột là 1
            int workSheet = 5;
            string result = kq; // Giá trị cần ghi vào cell
            string actualRS = rs;
            ExcelWriter excelWriter = new ExcelWriter();
            excelWriter.WriteToExcelResult(myPath, rowIndex, columnIndex, result,actualRS,workSheet);
        }
        [CodedStep(@"New Coded Step")]
        public void TC_02_05_PD_CodedStep()
        {
            // Lấy nội dung của phần tử 
            string value = Pages.ThongtinCaNhan.VestibulumPTag.BaseElement.InnerText;
            Log.WriteLine("Value: " + value.ToString());
            string connectionString = "data source=.;initial catalog=BookingAirLight;integrated security=True;MultipleActiveResultSets=True";            
            try{
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
    
                    using (SqlCommand command = new SqlCommand("SELECT * FROM KhachHang WHERE About = @About", connection))
                    {
                        command.Parameters.AddWithValue("@About", value.ToString());
            
                        int rowCount = 0;
                        string columnValue="";
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                rowCount++;
                                columnValue = reader["About"].ToString();
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
    
        [CodedStep(@"Verify 'InnerText' 'Exact' 'Vestibulum tristique, justo eu sollicitudin sagittis, metus dolor eleifend urna, quis scelerisque purus quam nec ligula. Suspendisse iaculis odio odio, ac vehicula nisi faucibus eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse posuere semper sem ac aliquet. Duis vel bibendum tellus, eu hendrerit sapien. Proin fringilla, enim vel lobortis viverra, augue orci fringilla diam, sed cursus elit mi vel lacus. Nulla facilisi. Fusce sagittis, magna non vehicula gravida, ante arcu pulvinar arcu, aliquet luctus arcu purus sit amet sem. Mauris blandit odio sed nisi porttitor egestas. Mauris in quam interdum purus vehicula rutrum quis in sem. Integer interdum lectus at nulla dictum luctus. Sed risus felis, posuere id condimentum non, egestas pulvinar enim. Praesent pretium risus eget nisi ullamcorper fermentum. Duis lacinia nisi ac rhoncus vestibulum.' on 'VestibulumPTag'")]
        public void TC_02_05_PD_CodedStep1()
        {
            // Verify 'InnerText' 'Exact' 'Vestibulum tristique, justo eu sollicitudin sagittis, metus dolor eleifend urna, quis scelerisque purus quam nec ligula. Suspendisse iaculis odio odio, ac vehicula nisi faucibus eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse posuere semper sem ac aliquet. Duis vel bibendum tellus, eu hendrerit sapien. Proin fringilla, enim vel lobortis viverra, augue orci fringilla diam, sed cursus elit mi vel lacus. Nulla facilisi. Fusce sagittis, magna non vehicula gravida, ante arcu pulvinar arcu, aliquet luctus arcu purus sit amet sem. Mauris blandit odio sed nisi porttitor egestas. Mauris in quam interdum purus vehicula rutrum quis in sem. Integer interdum lectus at nulla dictum luctus. Sed risus felis, posuere id condimentum non, egestas pulvinar enim. Praesent pretium risus eget nisi ullamcorper fermentum. Duis lacinia nisi ac rhoncus vestibulum.' on 'VestibulumPTag'
            Pages.ThongtinCaNhan.VestibulumPTag.AssertContent().InnerText(ArtOfTest.Common.StringCompareType.Exact, @"Vestibulum tristique, justo eu sollicitudin sagittis, metus dolor eleifend urna, quis scelerisque purus quam nec ligula. Suspendisse iaculis odio odio, ac vehicula nisi faucibus eu. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse posuere semper sem ac aliquet. Duis vel bibendum tellus, eu hendrerit sapien. Proin fringilla, enim vel lobortis viverra, augue orci fringilla diam, sed cursus elit mi vel lacus. Nulla facilisi. Fusce sagittis, magna non vehicula gravida, ante arcu pulvinar arcu, aliquet luctus arcu purus sit amet sem. Mauris blandit odio sed nisi porttitor egestas. Mauris in quam interdum purus vehicula rutrum quis in sem. Integer interdum lectus at nulla dictum luctus. Sed risus felis, posuere id condimentum non, egestas pulvinar enim. Praesent pretium risus eget nisi ullamcorper fermentum. Duis lacinia nisi ac rhoncus vestibulum.");
            
        }
    }
}
