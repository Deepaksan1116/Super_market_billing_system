using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo_super_market
{
    public class StoredetailRepositry
    {
        Store_detail sd;

        public Store_detail Sd
        {
            get { return Load_stroe_detail(); }
        }
      
        public Store_detail Load_stroe_detail()
        {
            string[] filecontent = File.ReadAllLines(Filepath.Store_filepath);
            foreach (string item in filecontent)
            {
                 string[] item_value = item.Split('|');
                 Address adres = new Address(item_value[4], item_value[5], item_value[6], item_value[7], item_value[8], item_value[9]);
                  sd = new Store_detail(item_value[0], item_value[1], item_value[2], item_value[3], adres);
                
            }
            return sd;
        }
        public void Edit_store_detail(Store_detail sd)
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(Filepath.Store_filepath);
            content = sd.Store_name + "|" + sd.Gst_number + "|" + sd.Phone_number + "|" + sd.Email_id + "|" + sd.Address.House_no + "|" + sd.Address.Street_name + "|" + sd.Address.Village_name + "|" + sd.Address.Taluk_name + "|" + sd.Address.Pincode + "|" + sd.Address.District;
            sw.WriteLine(content);
            sw.Close();
            Load_stroe_detail();
        }

    }
}
