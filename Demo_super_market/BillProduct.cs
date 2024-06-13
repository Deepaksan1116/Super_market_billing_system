using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_super_market
{
    public class BillProduct
    {
        Product _product;

        public Product product
        {
            get { return _product; }
        }
        int _quantity;

        public int Quantity
        {
            get { return _quantity; }  
        }
        public BillProduct()
        {
               
        }
        public BillProduct(Product temp_product,int quantity)
        {
            this._product = temp_product;
            this._quantity = quantity;
            this._amount = Amount;
        }
        public BillProduct(int qty)
        {
            this._quantity = qty;
        }
        double _amount;
        public double Amount
        {
            get
            {
                return _product.Unit_price * _quantity;
            }
        }
    }
}
