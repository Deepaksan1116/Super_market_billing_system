using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_super_market
{
    public class Product
    {
        int _product_id;
        string _product_name;
        string _category;
        double _unit_price;
        string _taxcategory;
        Status _status;

        public int Product_id
        {
            get { return _product_id; }    
        }

        public string Product_name
        {
            get { return _product_name; }
            
        }

        public string Category
        {
            get { return _category; }     
        }
        
        public double Unit_price
        {
            get { return _unit_price; }
            
        }
        public string Taxcategory
        {
            get { return _taxcategory; }
           
        }
        public Status Status
        {
            get { return _status; }
        }

        public Product()
        {
                
        }
        public Product(int Product_id,string Product_name,string Category,double Unit_price,string taxcategory,Status status)
        {
           
            this._product_id = Product_id;
            this._product_name = Product_name;
            this._category = Category;
            this._unit_price = Unit_price;
            this._taxcategory = taxcategory;
            this._status = status;
        }
        public Product(int Product_id)
        {
            this._product_id = Product_id;
        }


    }
   
    public enum Status
    { 
        active,
        discontinue,
    }
}
