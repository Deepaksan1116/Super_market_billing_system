using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_super_market
{
   public class Bill
    {
        Customer cust;
        Employee emp;
        DateTime _billdate;
        List<BillProduct> bill_product_list;
       
        string _bill_number=string.Empty;
        double _totalAmount;
        string _payment_type;

        public Customer Cust
        {
            get { return cust; }
            set { cust = value; }
        }

        public Employee Emp
        {
            get { return emp; }
            set { emp = value; }
        }
        
        public string Payment_type
        {
            get { return _payment_type; }
            set { _payment_type = value; }
        }

        public string Bill_number
        {
            get
            {
                return _bill_number;
            }
            set
            {
              _bill_number = value; 
            }
        }

       
        public DateTime BillDate
        {
            get
            {
                return System.DateTime.Today;
            }
        }

        public string Time
        {
            get
            {
                return System.DateTime.Now.ToString("HH:mm:ss");
            }
        }

        public double TotalAmount
        {
            get
            {
                double total = 0;
                foreach (var b in bill_product_list)
                {
                    total += b.Amount;
                }
                return total;
            }
        }

        public Bill()
        {
            bill_product_list = new List<BillProduct>();    
        }
        
        public void Add_Billproduct(BillProduct bilt)
        {
            bill_product_list.Add(bilt);
        }

        public void Edit_Billproduct(BillProduct bilt)
        {
            int temp = 0;
            foreach (var item in bill_product_list)
            {
                if (bilt.product.Product_id == item.product.Product_id)
                {
                    bill_product_list.RemoveAt(temp);
                    bill_product_list.Insert(temp, bilt);
                    break;
                }
                temp++;
            }
        }

        public BillProduct Get_Billproduct(Product pt)
        {
            BillProduct temp_bill_product = new BillProduct();
            foreach (var p in bill_product_list)
            {
                if (p.product.Product_id == pt.Product_id)
                {
                    temp_bill_product = p;
                }
            }
            return temp_bill_product;
        }
        public List<BillProduct> Get_Bill_Product_List()
        {
            List<BillProduct> temp_list = new List<BillProduct>();
            foreach (var item in bill_product_list)
            {
                temp_list.Add(item);
            }
            return temp_list;
        }
        public void Remove_Billproduct(Product pt)
        {
            foreach (var b in bill_product_list)
            {
                if (pt.Product_id == b.product.Product_id)
                {
                    bill_product_list.Remove(b);
                    break;
                }
            }
        }
        public void Clear_product_list()
        {
            bill_product_list.Clear();
        }

       
    }

   
}
