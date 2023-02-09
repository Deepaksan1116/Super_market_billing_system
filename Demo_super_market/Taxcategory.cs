using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_super_market
{
    public class Taxcategory
    {
        string _tax_category_name;
        float _tax_percentage;

        public string Tax_category_name
        {
            get { return _tax_category_name; }
            
        }

        public float Tax_percentage
        {
            get { return _tax_percentage; }
        }

        public Taxcategory()
        {

        }
        public Taxcategory(string taxcategoryname,float taxpercentage)
        {
            this._tax_category_name = taxcategoryname;
            this._tax_percentage = taxpercentage;
        }

       
    }
}
