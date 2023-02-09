using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_super_market
{
    public class Category
    {
        int _category_id;

        public int Category_id
        {
            get { return _category_id; }
           
        }
        string _category_name;

        public string Category_name
        {
            get { return _category_name; }
        }
        public Category()
        {
                
        }
        public Category(int Categoryid,string Categoryname)
        {
            this._category_id = Categoryid;
            this._category_name = Categoryname;
        }
    }
}
