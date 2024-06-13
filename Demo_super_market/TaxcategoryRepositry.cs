using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo_super_market
{
    public class TaxcategoryRepositry
    {
        public static List<Taxcategory> Taxcategories = new List<Taxcategory>();
        public static void Load_taxcategories()
        {
            string[] filecontent = File.ReadAllLines(Filepath.Taxcategory_filepath);
            foreach (var item in filecontent)
            {
                string[] item_value = item.Split('|');
                Taxcategory ty = new Taxcategory(item_value[0], float.Parse(item_value[1]));
                Taxcategories.Add(ty);
            }
        }
        public void Add_Category(Taxcategory ty)
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(Filepath.Taxcategory_filepath,true);
            content = ty.Tax_category_name + "|" + ty.Tax_percentage;
            sw.WriteLine(content);
            sw.Close();
            Taxcategories.Clear();
            Load_taxcategories();
        }
        public void Edit_taxcategory(Taxcategory ty)
        {
            int temp = 0;
            foreach (var item in Taxcategories)
            {
                if (ty.Tax_category_name == item.Tax_category_name)
                {
                    Taxcategory ty_new = new Taxcategory(item.Tax_category_name,ty.Tax_percentage);
                    Taxcategories.RemoveAt(temp);
                    Taxcategories.Insert(temp,ty_new);
                    Write();
                    Taxcategories.Clear();
                    Load_taxcategories();
                    break;
                }
                temp++;
            }
        }
        public void Remove_category(Taxcategory ty)
        {
            foreach (var item in Taxcategories)
            {
                if (ty.Tax_category_name== item.Tax_category_name)
                {
                    Taxcategories.Remove(item);
                    break;
                }
            }
        }
        public Taxcategory Get_category(Taxcategory ty)
        {
         Taxcategory temp_category = new Taxcategory();
            foreach (var item in Taxcategories)
            {
                if (ty.Tax_category_name == item.Tax_category_name)
                {
                    temp_category = item;
                    break;
                }
            }
            return temp_category;
        }
        public void Write()
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(Filepath.Taxcategory_filepath);
            foreach (var item in Taxcategories)
            {     
                content = item.Tax_category_name+ "|" + item.Tax_percentage;
                sw.WriteLine(content);   
            }
            sw.Close();
        }
        
    }
}
