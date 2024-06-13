using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo_super_market;

namespace Demo_super_market_App
{
    public partial class Edit_Employee_Form : Form
    {
        public Edit_Employee_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  employee_id=Convert.ToInt32(textBox1.Text);
            string password = textBox2.Text;
            Employee emp = new Employee();
            EmployeeRepositry epr=new EmployeeRepositry();
            foreach (Employee em in EmployeeRepositry.employee_list)
            {
                if (employee_id == em.Employee_id && password == em.Password)
                {
                    emp = epr.Get_Employee(em);
                }
            }
            label9.Text = emp.Employee_id.ToString();
            label11.Text = emp.Employee_name;
            comboBox1.Text = emp.Employee_type.ToString();
            textBox5.Text = emp.Phone_number;
            textBox6.Text = emp.Email_id;
            comboBox2.Text = emp.Current_status.ToString();
            House_number_txt.Text = emp.Address.House_no;
            street_name_txt.Text = emp.Address.Street_name;
            village_name_txt.Text = emp.Address.Village_name;
            district_txt.Text = emp.Address.District;
            pincode_txt.Text = emp.Address.Pincode;
            taluk_name_txt.Text = emp.Address.Taluk_name;

        }

        private void Edit_Employee_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int employee_id =Convert.ToInt32(textBox3.Text);
            string password = textBox4.Text;
             Employee emp = new Employee();
            EmployeeRepositry epr=new EmployeeRepositry();
            foreach (Employee em in EmployeeRepositry.employee_list)
            {
                if (employee_id == em.Employee_id)
                {
                    emp = epr.Get_Employee(em);
                }
            }
            EmployeeRepositry employee_repo = new EmployeeRepositry();
            Employee emp_new=new Employee(employee_id,emp.Employee_name,emp.Phone_number,emp.Employee_type,emp.Email_id,emp.Current_status,password,emp.Address);
            employee_repo.Edit_employee(emp_new);
            MessageBox.Show("Password Reset Sucessfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int employee_id = Convert.ToInt32(textBox1.Text);
            
            string password = textBox2.Text;
            string temp_designation = comboBox1.Text;

            string email = textBox6.Text;
            string phone_number = textBox5.Text;
            string current_sta = comboBox2.Text.ToLower();
            Employee_type designation = (Employee_type)Enum.Parse(typeof(Employee_type), temp_designation);
            Current_status status = (Current_status)Enum.Parse(typeof(Current_status), current_sta);
            string house_no = House_number_txt.Text;
            string street_name = street_name_txt.Text;
            string village_name = village_name_txt.Text;
            string taluk_name = taluk_name_txt.Text;
            string district = district_txt.Text;
            string pincode = pincode_txt.Text;

            Employee emp = new Employee();
            EmployeeRepositry epr = new EmployeeRepositry();
            foreach (Employee em in EmployeeRepositry.employee_list)
            {
                if (employee_id == em.Employee_id && password == em.Password)
                {
                    emp = epr.Get_Employee(em);
                }
            }
            EmployeeRepositry employee_repo = new EmployeeRepositry();
            Address adres = new Address(house_no, street_name, village_name, taluk_name, pincode, district);
            Employee emp_new = new Employee(employee_id, emp.Employee_name, phone_number, designation, email, status, emp.Password, adres);
            employee_repo.Edit_employee(emp_new);
            MessageBox.Show("Edited Sucessfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Form af = new Admin_Form();
            af.Show();
        }
    }
}
