using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_super_market
{
    public class Customer
    {
        int _customer_id;
        string _customer_name;
        string _phone_number;
        string _email_id;
        Address _address;

        public int Customer_id
        {
            get { return _customer_id; }
        }

        public string Customer_name
        {
            get { return _customer_name; }
        }
        
        public string Phone_number
        {
            get { return _phone_number; }   
        }

        public string Email_id
        {
            get { return _email_id; }
        }
        
        public Address Address
        {
            get { return _address; }
            
        }

        public Customer()
        {

        }

        public Customer(int Customer_id,string Customer_name,string Phone_number,string Email_id,Address address)
        {
            this._customer_id = Customer_id;
            this._customer_name = Customer_name;
            this._phone_number = Phone_number;
            this._email_id = Email_id;
            this._address = address;
        }
        public Customer(int Customer_id)
        {
            this._customer_id = Customer_id;
        }
    }
}
