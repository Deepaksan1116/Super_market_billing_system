using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Demo_super_market;
namespace Demo_super_market
{
   public  class CategoryRepositry
    {
        public static List<Category> categories = new List<Category>();
        public static void Load_Categories()
        {
            string[] filecontent = File.ReadAllLines(Filepath.Category_filepath);
            foreach (var item in filecontent)
            {
                string[] item_value = item.Split('|');
                Category cy = new Category(Convert.ToInt32(item_value[0]),item_value[1]);
                categories.Add(cy);
            }
        }
        public void Add_Category(Category cs)
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(Filepath.Category_filepath,true);
            content = cs.Category_id + "|"+cs.Category_name;
            sw.WriteLine(content);
            sw.Close();
            categories.Clear();
            Load_Categories();   
        }
        public void Remove_category(Category cy)
        {
            foreach (var item in categories)
            {
                if (cy.Category_name == item.Category_name)
                {
                    categories.Remove(item);
                    Write();
                    categories.Clear();
                    Load_Categories();         
                    break;
                }
            }
        }
        public Category Get_category(Category cy)
        {
            Category temp_category = new Category();
            foreach (var item in categories)
            {
                if (cy.Category_name == item.Category_name)
                {
                    temp_category = item;
                    break;
                }
            }
            return temp_category;
        }

        public static bool Check_category(string category_name)
        {
            bool check=false;
            foreach (var item in categories)
            {
                if (item.Category_name == category_name)
                {
                    check=true;
                    break;
                }
            }

            return check;
        }
        public void Write()
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(Filepath.Category_filepath);
            foreach (var item in categories)
            {
                content = item.Category_id + "|" + item.Category_name;
                sw.WriteLine(content);
            }
            sw.Close();
        }
        public static int Get_category_id()
        {
            int temp = 0;
            foreach (var item in categories)
            {
                temp = item.Category_id;
            }
            return temp;
        }
    }
}
