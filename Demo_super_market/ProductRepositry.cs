using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo_super_market
{
    public  class ProductRepositry
    {
       public  static Dictionary<int, Product> products = new Dictionary<int, Product>();
        public static List<Product> product_list = new List<Product>();
        public static void Load_products_dictionary()
        {
            string[] filecontent = File.ReadAllLines(Filepath.Products_filepath);
            foreach (string item in filecontent)
            {
                string[] item_value = item.Split('|');
                Product pt = new Product(Convert.ToInt32(item_value[0]), item_value[1], item_value[2], Convert.ToDouble(item_value[3]),item_value[4], (Status)Enum.Parse(typeof(Status), item_value[5]));
                products.Add(Convert.ToInt32(item_value[0]), pt);
                product_list.Add(pt);
            }
        }

        public void Add_product(Product pt)
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(Filepath.Products_filepath, true);
            content = pt.Product_id + "|" + pt.Product_name + "|" + pt.Category + "|" + pt.Unit_price + "|" + pt.Taxcategory + "|" + pt.Status;
            sw.WriteLine(content);
            sw.Close();
            products.Clear();
            product_list.Clear();
            Load_products_dictionary();
        }

        public void Edit_product(Product pt)
        {
            int temp = 0;
    
            foreach (var item in product_list)
            {

                if (item.Product_id ==pt.Product_id )
                {
                    Product pr = new Product(pt.Product_id, pt.Product_name, pt.Category, pt.Unit_price,pt.Taxcategory,pt.Status);
                    product_list.RemoveAt(temp);
                    product_list.Insert(temp, pr);
                    write();
                    products.Clear();
                    product_list.Clear();
                    Load_products_dictionary();
                    break;
                }
                temp++;
            }
        }

        public Product Get_product(Product temp_pt)
        {
            Product pt = new Product();
            if (products.ContainsKey(temp_pt.Product_id))
            {
                pt = products[temp_pt.Product_id];
            }
            return pt;
        }

        public void write()
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(Filepath.Products_filepath);
            foreach (var item in product_list)
            {
                 content = item.Product_id + "|" + item.Product_name + "|" + item.Category + "|" + item.Unit_price + "|" + item.Taxcategory + "|" + item.Status;
                 sw.WriteLine(content);
            }
            sw.Close();
        }
        public static int Get_product_id_with_name(string name)
        {
            int temp = 0;
            foreach (var item in product_list)
            {
                if (name == item.Product_name)
                {
                    temp = item.Product_id;
                }
            }
            return temp;
        }
        public static int Get_product_id()
        {
            int temp = 0;
            foreach (var item in product_list)
            {
                temp = item.Product_id;
            }
            return temp;
        }

        public static bool Check_product(string productname)
        {
            bool check = false;
            foreach (var item in product_list)
            {
                if (productname == item.Product_name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
    }
}
