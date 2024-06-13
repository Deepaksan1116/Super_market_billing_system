using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Demo_super_market
{
    public  class EmployeeRepositry
    {
        public static Dictionary<int, Employee> Employees = new Dictionary<int, Employee>();
        public static List<Employee> employee_list = new List<Employee>();

        public static void Load_employees_dictionary()
        {
            string[] filecontent = File.ReadAllLines(Filepath.Employees_filepath);
            foreach (string item in filecontent)
            {
                string[] item_value = item.Split('|');
                Address adres = new Address(item_value[7], item_value[8], item_value[9], item_value[10], item_value[11], item_value[12]);
                Employee es = new Employee(Convert.ToInt32(item_value[0]), item_value[1], item_value[2], (Employee_type)Enum.Parse(typeof(Employee_type), item_value[3]), item_value[4], (Current_status)Enum.Parse(typeof(Current_status), item_value[5]), item_value[6], adres);
                Employees.Add(Convert.ToInt32(item_value[0]), es);
                employee_list.Add(es);
            }
        }

        public void Add_employee(Employee es)
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(Filepath.Employees_filepath, true);
            content = es.Employee_id + "|" +
                es.Employee_name + "|" + es.Phone_number + "|" + es.Employee_type + "|"+es.Email_id+"|"+es.Current_status +"|"+ es.Password+"|"+es.Address.House_no + "|" + es.Address.Street_name + "|" + es.Address.Village_name + "|" + es.Address.Taluk_name + "|" + es.Address.Pincode + "|" + es.Address.District;
            sw.WriteLine(content);
            sw.Close();
            Employees.Clear();
            employee_list.Clear();
            Load_employees_dictionary();
        }

        public void Edit_employee(Employee temp_employee)
        {
            int temp = 0;
            foreach (var employee in employee_list)
            {
                if (employee.Employee_id == temp_employee.Employee_id)
                {
                    Employee emp_new = new Employee(temp_employee.Employee_id, temp_employee.Employee_name, temp_employee.Phone_number, temp_employee.Employee_type, temp_employee.Email_id, temp_employee.Current_status, temp_employee.Password, temp_employee.Address);
                    employee_list.RemoveAt(temp);
                    employee_list.Insert(temp, emp_new);
                    write();
                    Employees.Clear();
                    employee_list.Clear();
                    Load_employees_dictionary();
                    break;
                }
                temp++;
            }
        }
      

        public void write()
        {
            string content = string.Empty;
            StreamWriter sw = new StreamWriter(Filepath.Employees_filepath);
            foreach (var item in employee_list)
            {
                content = item.Employee_id + "|" + item.Employee_name + "|" + item.Phone_number + "|" + item.Employee_type + "|" + item.Email_id + "|" + item.Current_status + "|" + item.Password + "|" + item.Address.House_no + "|" + item.Address.Street_name + "|" + item.Address.Village_name + "|" + item.Address.Taluk_name + "|" + item.Address.Pincode + "|" + item.Address.District;
                sw.WriteLine(content);
            }
            sw.Close();
        }

        public Employee Get_Employee(Employee emp1)
        {
            Employee emp = new Employee();

            if (Employees.ContainsKey(emp1.Employee_id))
            {
                emp = Employees[emp1.Employee_id];
            }
            return emp;
        }
        public int Get_employee_id()
        {
            int temp = 0;
            foreach (var item in employee_list)
            {
                temp = item.Employee_id+1;
            }
            return temp;
        }

        public static bool Check_employee(int employeeid)
        {
            bool check = false;
            foreach (var item in employee_list)
            {
                if (employeeid == item.Employee_id)
                {
                    check = true;
                    break;
                }
            }

            return check;
        }
       
    }
}
