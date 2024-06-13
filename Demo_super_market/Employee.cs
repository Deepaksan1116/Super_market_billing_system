using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_super_market
{
    public class Employee
    {
        int _employee_id;
        string _employee_name;
        string _phone_number;
        string _email_id;
        string _password;
        Employee_type _employee_type;
        Current_status _current_status;
        Address _address;

        public int Employee_id
        {
            get { return _employee_id; }
            
        }
       
        public string Employee_name
        {
            get { return _employee_name; }
            
        }

        public string Phone_number
        {
            get { return _phone_number; }
            
        }

        public string Email_id
        {
            get { return _email_id; }
        }

        public string Password
        {
            get { return _password; }
        }
        

        public Address Address
        {
            get { return _address; }
        }

        public Employee_type Employee_type
        {
            get { return _employee_type; }
        }

        public Current_status Current_status
        {
            get { return _current_status; }
           
        }
        public Employee()
        {
                
        }
        public Employee(int Employee_id)
        {
            this._employee_id = Employee_id;
        }

        public Employee(int Employee_id,string Employee_name,string Phone_number,Employee_type employee_type,string Email_id,Current_status current_status,string password,Address address)
        {
            this._employee_id = Employee_id;
            this._employee_name = Employee_name;
            this._phone_number = Phone_number;
            this._email_id = Email_id;
            this._employee_type = employee_type;
            this._current_status = current_status;
            this._address = address;
            this._password = password;
        }
    }
    public enum Employee_type
    { 
        manager,
        Operator,
        admin,
    }
    public enum Current_status
    {
        active,
        discontinue,
    }
}
