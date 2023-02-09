using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_super_market
{
    public class Store_detail
    {
        string _store_name;
        string _gst_number;
        string _phone_number;
        string _email_id;
        Address _address;

        public string Store_name
        {
            get { return _store_name; }
        }
       
        public string Gst_number
        {
            get { return _gst_number; }
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
        public Store_detail()
        {
                
        }
        public Store_detail(string storename,string gstnumber,string phonenumber,string emailid,Address address)
        {
            this._store_name = storename;
            this._gst_number = gstnumber;
            this._phone_number = phonenumber;
            this._email_id = emailid;
            this._address = address;
        }
    }
}
