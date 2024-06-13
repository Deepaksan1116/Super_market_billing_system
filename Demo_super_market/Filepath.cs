using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo_super_market
{
   public static class Filepath
    {
        static string Bill_year = System.DateTime.Now.Year.ToString();
        static string Bill_month = System.DateTime.Now.Date.ToString("MMMM");
        static string Bill_date = System.DateTime.Now.ToString("dd-MM-yyyy");
   
        public static string Products_filepath = @"D:\Super_market_billing\Products\Products.txt";
        public static string Customers_filepath = @"D:\Super_market_billing\Customers\Customers.txt";
        public static string Employees_filepath = @"D:\Super_market_billing\Employees\Employee.txt";
        public static string Store_filepath = @"D:\Super_market_billing\Store\Store_detail.txt";
        public static string Category_filepath = @"D:\Super_market_billing\Categories\Categories.txt";
        public static string Taxcategory_filepath = @"D:\Super_market_billing\Taxcategories\Taxcategory.txt";
        public static string Get_Total_Amount_Current_Workingday = @"D:\Super_market_billing\Amount\Current_Working_Day.txt";
        public static string Operator_performance = "D:\\Super_market_billing\\Operator\\";
        public static string Customer_purchases = "D:\\Super_market_billing\\Customers\\Customer_Purchases";
        public static string Bill_filepath = "D:\\Super_market_billing\\Bill\\" + Bill_year + "\\" + Bill_month + "\\" + Bill_date;
        public static string Text_filepath= Path.Combine(Bill_filepath, "Billnumber.txt");
       
    }
}
