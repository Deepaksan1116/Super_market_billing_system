using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Demo_super_market
{
    public class BillRepositry
    {

        string str = string.Empty;
        int number = 0;
        int temp_number = 0;
        public static int index = 0;
        string day = System.DateTime.Now.ToString("dd");
        string month = System.DateTime.Now.ToString("MM");
        string year = System.DateTime.Now.ToString("yy");

        public static List<Bill> Temp_Bills = new List<Bill>();
        static List<string> performance_amount = new List<string>();
        public static List<string> operator_performance_amount = new List<string>();
        public static List<string> bill_number_list = new List<string>();
      

        public void Add_bill(Bill temp_bill)
        {
            Temp_Bills.Add(temp_bill);
        }

        public void Remove_Bill(Bill temp_bill)
        {
            foreach (var item in Temp_Bills)
            {
                if (item.Bill_number == temp_bill.Bill_number)
                {
                    Temp_Bills.Remove(item);
                    break;
                }
            }
        }

        public  int Get_temp_bill_number()
        {
            int temp = 0;
            foreach (var item in Temp_Bills)
            {
                temp =Convert.ToInt32( item.Bill_number);
            }
            return temp;
        }

        public Bill Get_Bill(Bill temp_bill)
        {
            Bill bil = new Bill();
            foreach (var bill in Temp_Bills)
            {
                if (bill.Bill_number == temp_bill.Bill_number)
                {
                    bil = bill;
                }
            }
            return bil;
        }

        public void Create_customer_purchase_detail(Bill temp_bill)
        {
            string filepath = Filepath.Customer_purchases + "\\" + temp_bill.Cust.Customer_id + "\\";
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            string text_file_path=Path.Combine(filepath,"Purchase.txt");
            if (!File.Exists(text_file_path))
            {
                using (StreamWriter sw = File.CreateText(text_file_path))
                {
                    sw.WriteLine(temp_bill.Bill_number);
                }
            }
            else
            {
                StreamWriter temp_writer = new StreamWriter(text_file_path,true);
                 string temp = temp_bill.Bill_number;
                    temp_writer.WriteLine(temp);
                    temp_writer.Close();
            }
        }

        public string Bill_output(Bill temp_bill)
        {
             string str = string.Empty;
           StoredetailRepositry sd = new StoredetailRepositry();
            List<BillProduct> bill_product_list=temp_bill.Get_Bill_Product_List();
           str += "      "+sd.Sd.Store_name + "\n";
           str += "      "+sd.Sd.Address.House_no + "," + sd.Sd.Address.Street_name + "\n";
           str += "      "+sd.Sd.Address.District + "," + sd.Sd.Address.Pincode + "\n";
           str += "      "+ sd.Sd.Email_id + "\n";
           str += "      "+sd.Sd.Phone_number + "\n";
           str += "_____________________________________" + "\n" + "\n";
           str += "Bill Number : " + temp_bill.Bill_number + "\n";
           str += "GST Number  : " + sd.Sd.Gst_number + "\n";
           str += "Date        : " + temp_bill.BillDate + "\n";
           str += "Cust ID     : " + temp_bill.Cust.Customer_id + "\n";
           str += "Emp ID      : " + temp_bill.Emp.Employee_id + "\n";
           str += "_____________________________________" + "\n" + "\n";
           str += "Product name" + "     " + "Price" + "  " + "QTY" + "    " + "Amount" + "\n";
           foreach (var b in bill_product_list)
           {
           str += b.product.Product_name + "      "+ b.product.Unit_price + "\t" + "\t" + b.Quantity + "\t" + "\t" + b.Amount + "\n";
           }
           str += "Total                " + "\t" + "\t" + "\t" + temp_bill.TotalAmount + "\n";
           str += "_____________________________________" + "\n";
           str += "Payment type : " + temp_bill.Payment_type;

            return str;
        }

        public void Create_Directory()
        {
            if (!Directory.Exists(Filepath.Bill_filepath))
            {
                Directory.CreateDirectory(Filepath.Bill_filepath);
            }
            if (!File.Exists(Filepath.Text_filepath))
            {
                using (StreamWriter sw = File.CreateText(Filepath.Text_filepath))
                {
                    sw.WriteLine("0");
                    temp_number = 1;
                }
            }
            else
            {
                str = File.ReadAllText(Filepath.Text_filepath);
                number = Convert.ToInt32(str);
                temp_number = number + 1;
            }
        }

        public void Change_bill_number(Bill temp_bill)
        {
            string temp_bill_number = "B" + day + month + year + temp_number;
            temp_bill.Bill_number = temp_bill_number;
        }

        public void Create_Bill_file(string bill_output)
        {
            string bill_file = Path.Combine(Filepath.Bill_filepath, "B"+day+month+year+ temp_number + ".txt");
            if (!File.Exists(bill_file))
            {
                using (StreamWriter sw = File.CreateText(bill_file))
                {
                    sw.WriteLine(bill_output);
                }
                using (StreamWriter st = File.CreateText(Filepath.Text_filepath))
                {
                    st.WriteLine(temp_number);
                }
              
            }
        }

        public void Write_total_amount(double amount,int id)
        {
            string time = System.DateTime.Now.ToString("HH:mm:ss");
            string temp=string.Empty;
            string date = System.DateTime.Now.ToString("dd-MM-yyyy");
            string temp_date = string.Empty;
            string[] filecontent = File.ReadAllLines(Filepath.Get_Total_Amount_Current_Workingday);
            foreach (var item in filecontent)
            {
                string[] item_value = item.Split('|');
                temp_date = item_value[2];
            }
            if (temp_date == date)
            {
                StreamWriter sw = new StreamWriter(Filepath.Get_Total_Amount_Current_Workingday, true);
                temp = time + "|" + amount + "|" + date+"|"+id;
                sw.WriteLine(temp);
                sw.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter(Filepath.Get_Total_Amount_Current_Workingday);
                temp = time + "|" + amount + "|" + date+"|"+id;
                sw.WriteLine(temp);
                sw.Close();
            }

        }

        public double Get_total_amount(DateTime time)
        {
            double amount = 0;
            string[] filecontent = File.ReadAllLines(Filepath.Get_Total_Amount_Current_Workingday);
            foreach (var item in filecontent)
            {
                string[] item_value = item.Split('|');
                if (time ==Convert.ToDateTime(item_value[0])||Convert.ToDateTime(item_value[0])<=time)
                {

                    amount +=Convert.ToDouble(item_value[1]);
                    break;
                }
            }
            return amount;
        }

        public double Get_operator_total_amount(DateTime time,int id)
        {
            double amount = 0;
            string[] filecontent = File.ReadAllLines(Filepath.Get_Total_Amount_Current_Workingday);
            foreach (var item in filecontent)
            {
                string[] item_value = item.Split('|');
                if (Convert.ToInt32(item_value[3]) == id)
                {
                    if (time == Convert.ToDateTime(item_value[0]) || Convert.ToDateTime(item_value[0]) <= time)
                    {

                        amount += Convert.ToDouble(item_value[1]);
                        
                    }
                }
            }
            return amount;
        }
        
        public void Write_operator_performance(Bill temp_bill)
        {
            int temp_index=0;
            double temp_amount = 0;
            double amount=0;
            string content = string.Empty;
            string temp_date = string.Empty;
            string temp_time = string.Empty;
            string temp_entry = string.Empty;
            string temp_content=string.Empty;
            string time = System.DateTime.Now.ToString("HH:mm:ss");
            string date = System.DateTime.Now.ToString("dd-MM-yyyy");
            string employee_filepath = Filepath.Operator_performance+temp_bill.Emp.Employee_id;
            if (!Directory.Exists(employee_filepath))
            {
                Directory.CreateDirectory(employee_filepath);
            }
            
            string filecreate_path = Path.Combine(employee_filepath,"Performance.txt");
            if (!File.Exists(filecreate_path))
            {
                using (StreamWriter stream_writer = File.CreateText(filecreate_path))
                {
                    content = date + "|" + time + "|" + temp_bill.TotalAmount;
                    stream_writer.WriteLine(content);
                }
            }
            else
            {
                
                Load_performance_amount(filecreate_path);             
                string[] filecontent = File.ReadAllLines(filecreate_path);
                foreach (var item in filecontent)
                {
                    string [] item_value=item.Split('|');
                    temp_date = item_value[0];
                    temp_time = item_value[1];
                    temp_amount =Convert.ToDouble(item_value[2]);
                    temp_entry = item;
                }
                if (temp_date != date)
                {
                    StreamWriter sw = new StreamWriter(filecreate_path,true);
                    content = date + "|" + time + "|" + temp_bill.TotalAmount;
                    sw.WriteLine(content);
                    sw.Close();
                }
                else if(date==temp_date&&time!=temp_time)
                {
                    foreach (var item in performance_amount)
                    {
                        if (temp_entry == item)
                        {
                            amount =temp_amount+temp_bill.TotalAmount;
                            temp_content =date+"|"+time+"|"+amount;
                            performance_amount.RemoveAt(temp_index);
                            performance_amount.Insert(temp_index,temp_content);
                            write_performance_amount(filecreate_path);
                            performance_amount.Clear();
                            Load_performance_amount(filecreate_path);
                            break;
                        }
                        temp_index++;
                    }
                }
            }
        }

        public void Get_Operator_performance_amount(int id)
        {
           
            string filepath = Filepath.Operator_performance+"\\"+id+"\\"+"Performance.txt";
            string[] filecontent = File.ReadAllLines(filepath);
            foreach (var item in filecontent)
            {
                operator_performance_amount.Add(item);
            }
        }

        public  void Load_performance_amount(string filepath)
        {
            string[] filecontent = File.ReadAllLines(filepath);
            foreach (var item in filecontent)
            {
                performance_amount.Add(item);
            }
            
        }

        private void write_performance_amount(string filepath)
        {
            string temp_content = string.Empty;
            StreamWriter sw = new StreamWriter(filepath);
            foreach (var item in performance_amount)
            {
                temp_content = item;
                sw.WriteLine(temp_content);
            }
           
            sw.Close();
         
        }

        public string Get_Bill_output(string billnumber)
        {
            char[] input = billnumber.ToCharArray();
            string date = input[1].ToString() + input[2].ToString();
            string month = input[3].ToString() + input[4].ToString();
            string year = input[5].ToString() + input[6].ToString();
            string number = input[7].ToString();
            string year1 = 20 + year;
            string day=date+"-"+month+"-"+year1;
            int temp1 = Convert.ToInt32(month);
            string month1=Get_monthname(temp1);
            string str = "";
            string filepath = "D:\\Super_market_billing\\Bill\\"+year1+"\\"+month1+"\\"+day+"\\"+billnumber+".txt";
            if (File.Exists(filepath))
            {
                 str = File.ReadAllText(filepath);
            }
            return str;
        }

        private string Get_monthname(int month)
        {
            string res = string.Empty;
            switch (month)
            { 
                case 01:
                res="January";
                break;
            case 02:
                res = "February";
                break;
            case 03:
                res = "March";
                break;
            case 04:
                res = "April";
                break;
            case 05:
                res = "May";
                break;
            case 06:
                res = "June";
                break;
            case 07:
                res = "July";
                break;
            case 08:
                res = "August";
                break;
            case 09:
                res = "September";
                break;
            case 10:
                res = "October";
                break;
            case 11:
                res = "November";
                break;
            case 12:
                res = "December";
                break;       
                    
        }
        return res;
            }
        public Bill Get_Next_Bill()
        {
            int count = 0;
            Bill bil = new Bill();
            foreach (var item in Temp_Bills)
            {
               
                if(count==index+1)
                {
                    bil = item;
                    index = count;
                    break;
                }
                count++;
                
            }
            return bil;
        }

        public Bill Get_first_Bill()
        {
            int index = 0;
            Bill temp_bill = new Bill();
            foreach (var item in Temp_Bills)
            {
                if (index == 0)
                {
                    temp_bill = item;
                    index = 0;
                    break;
                }
                
            }
            return temp_bill;
        }
        public Bill Get_Previous_Bill()
        {
            int count = 0;
            Bill bil = new Bill();
            foreach (var item in Temp_Bills)
            {

                if (count == index - 1)
                {
                    bil = item;
                    index = count;
                    break;
                }
                count++;

            }
            return bil;
        }

        public static void Get_Customer_billnumber(int id)
        {
            string filepath = Filepath.Customer_purchases+"\\" + id+"\\"+"Purchase.txt";
            string[] filecontent = File.ReadAllLines(filepath);
            foreach (var item in filecontent)
            {
                bill_number_list.Add(item);
            }
        }

    }
}
