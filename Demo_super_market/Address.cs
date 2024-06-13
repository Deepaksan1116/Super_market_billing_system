using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_super_market
{
   public class Address
    {
        string _house_no;
        string _street_name;
        string _village_name;
        string _taluk_name;
        string _pincode;
        string _district;

        public string House_no
        {
            get { return _house_no; }
        }

        public string Street_name
        {
            get { return _street_name; }
        }

        public string Village_name
        {
            get { return _village_name; }
        }

        public string Taluk_name
        {
            get { return _taluk_name; }
        }

        public string Pincode
        {
            get { return _pincode; }
        }

        public string District
        {
            get { return _district; }
        }

        public Address(string House_no,string Street_name,string Village_name,string Taluk_name,string Pincode,string District)
        {
            if (House_no.Length >= 1 && House_no.Length <= 6)
            {
                this._house_no = House_no;
            }
            if (Street_name.Length >= 4 && Street_name.Length <= 20)
            {
                this._street_name = Street_name;
            }
            if (Village_name.Length >= 4 && Village_name.Length <= 20)
            {
                this._village_name = Village_name;
            }
            if (Taluk_name.Length >= 4 && Taluk_name.Length <= 20)
            {
                this._taluk_name = Taluk_name;
            }
            if (Pincode.Length == 6)
            {
                 this._pincode = Pincode;
            }
            if (District.Length >= 4 && District.Length <= 20)
            {
                this._district = District;
            }    
        }
    }
}
