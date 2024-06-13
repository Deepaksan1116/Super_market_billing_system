using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo_super_market
{
   public class CustomerRepositry
    {
       public static Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
       public static List<Customer> customer_list = new List<Customer>();
        public static void Load_customers_dictionary()
        {
             string[] filecontent = File.ReadAllLines(Filepath.Customers_filepath);
             foreach (string item in filecontent)
             {
                 string[] item_value = item.Split('|');
                 Address adres=new Address(item_value[4],item_value[5],item_value[6],item_value[7],item_value[8],item_value[9]);
                 Customer cs = new Customer(Convert.ToInt32(item_value[0]), item_value[1], item_value[2], item_value[3], adres);
                 customers.Add(Convert.ToInt32(item_value[0]),cs);
                 customer_list.Add(cs);
             }
        }

        public void Add_customer(Customer cs)
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(Filepath.Customers_filepath, true);
            content = cs.Customer_id + "|" + cs.Customer_name + "|" + cs.Phone_number + "|" + cs.Email_id + "|" + cs.Address.House_no + "|" + cs.Address.Street_name + "|" + cs.Address.Village_name + "|" + cs.Address.Taluk_name + "|" + cs.Address.Pincode + "|" + cs.Address.District;
            sw.WriteLine(content);
            sw.Close();
            customer_list.Clear();
            customers.Clear();
            Load_customers_dictionary();
        }

        public void Edit_customer(Customer cs)
        {
            Customer cr = new Customer();
            int temp = 0;
            if (customers.ContainsKey(cs.Customer_id))
            {
                cr = customers[cs.Customer_id];
            }
            foreach (var item in customer_list)
            {
                if (item.Customer_id == cs.Customer_id)
                {
                    Customer cnew = new Customer(cr.Customer_id, cr.Customer_name, cs.Phone_number, cs.Email_id, cs.Address);
                    customer_list.RemoveAt(temp);
                    customer_list.Insert(temp, cnew);
                    write();
                    Load_customers_dictionary();
                    break;
                }
                temp++;
            }
        }

        public Customer Get_customer(Customer temp_cust)
        {
            Customer cust = new Customer();

            if (customers.ContainsKey(temp_cust.Customer_id))
            {
                cust = customers[temp_cust.Customer_id];
            }
            return cust;
        }

        public Customer Get_customer_object(string temp_cust)
        {
            Customer cust = new Customer();
            foreach (var item in customer_list)
            {
                if (item.Phone_number == temp_cust || item.Customer_id.ToString() == temp_cust)
                {
                    cust = item;
                }
            }
            return cust;
        }

        public static int Get_last_cust_id()
        {
            int temp = 0;
            foreach (var item in customer_list)
            {
                temp = item.Customer_id;
            }
            return temp;
        }

        public void write()
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(Filepath.Customers_filepath);
            foreach (var item in customer_list)
            {
                content = item.Customer_id + "|" + item.Customer_name + "|" + item.Phone_number + "|" + item.Email_id + "|" + item.Address.House_no + "|" + item.Address.Street_name + "|" + item.Address.Village_name + "|" + item.Address.Taluk_name + "|" + item.Address.Pincode + "|" + item.Address.District+"\n";
                sw.WriteLine(content);
            }
            sw.Close();
        }
       
    }
}
