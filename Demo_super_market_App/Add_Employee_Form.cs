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
    public partial class Add_Employee_Form : Form
    {
        public Add_Employee_Form()
        {
            InitializeComponent();
        }

        private void Add_Employee_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeRepositry emr = new EmployeeRepositry();
            string name = textBox1.Text;
            string email = textBox2.Text;
            string phone_number = textBox3.Text;
            string temp_designation = comboBox1.SelectedItem.ToString();
            Employee_type designation = (Employee_type)Enum.Parse(typeof(Employee_type), temp_designation);
            Current_status status=(Current_status)Enum.Parse(typeof(Current_status),"active");
            string house_no=textBox5.Text;
            string street_name = textBox6.Text;
            string village_name = textBox7.Text;
            string taluk_name = textBox8.Text;
            string district = textBox9.Text;
            string pincode = textBox10.Text;
            string password=textBox4.Text;
            int emp_id =emr.Get_employee_id();
            Address a1=new Address(house_no,street_name,village_name,taluk_name,pincode,district);
            Employee emp1 = new Employee(emp_id,name,phone_number,designation,email,status,password,a1);
          
            emr.Add_employee(emp1);
            MessageBox.Show("Employee Added Sucessfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Form af = new Admin_Form();
            af.Show();
        }
    }
}
