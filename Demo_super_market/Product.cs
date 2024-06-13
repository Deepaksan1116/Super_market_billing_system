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
            if (Product_id > 0)
            {
                this._product_id = Product_id;
            }
            else
            {
                throw new FormatException("Please enter a number");
            }
            if (Product_name.Length >= 3 && Product_name.Length <= 50)
            {
                this._product_name = Product_name;
            }
            else
            {
                throw new ArgumentException("Invalid ProductName. ProductName must be between 3 and 50");
            }
            if (Category.Length >= 3 && Category.Length <= 15)
            {
                this._category = Category;
            }
            else
            {
                throw new ArgumentException("Invalid Category. Category must be between 3 and 15");
            }
            if (Unit_price > 0)
            {
                this._unit_price = Unit_price;
            }
            else
            {
                throw new FormatException("Please enter a number");
            }
            if (taxcategory.Length >= 2 && taxcategory.Length <= 10)
            {
                this._taxcategory = taxcategory;
            }
            else
            {
                throw new ArgumentException("Invalid Taxcategory. Taxcategory must be between 2 and 10");
            }
            if (Enum.IsDefined(typeof(Status), status))
            {
                this._status = status;
            }
            else
            {
                throw new Exception("Invalid status value");
            }
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
