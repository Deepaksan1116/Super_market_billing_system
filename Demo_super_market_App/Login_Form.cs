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
    public partial class Login_Form : Form
    {
        public static int employee_id = 0;
        static int count = 0;
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            if (count == 0)
            {
                ProductRepositry.Load_products_dictionary();
                CustomerRepositry.Load_customers_dictionary();
                EmployeeRepositry.Load_employees_dictionary();
                CategoryRepositry.Load_Categories();
                TaxcategoryRepositry.Load_taxcategories();
            }
            count++;
            textBox1.Text = "2";
            textBox2.Text = "temp123";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            bool id_check = false;
            bool password_check = false;
            foreach (var item in EmployeeRepositry.employee_list)
            {
                
                if (item.Employee_id == Convert.ToInt32(textBox1.Text))
                {
                    id_check = true;
                    if (item.Password == textBox2.Text)
                    {
                        password_check = true;
                        if (item.Employee_type == (Employee_type)Enum.Parse(typeof(Employee_type), "admin"))
                        {
                            employee_id = Convert.ToInt32(textBox1.Text);
                            Admin_Form af = new Admin_Form();

                            af.Show();

                        }
                        else if (item.Employee_type == (Employee_type)Enum.Parse(typeof(Employee_type), "manager"))
                        {
                            employee_id = Convert.ToInt32(textBox1.Text);
                            Manager_Form mf = new Manager_Form();
                            mf.Show();


                        }
                        else if (item.Employee_type == (Employee_type)Enum.Parse(typeof(Employee_type), "Operator"))
                        {
                            employee_id = Convert.ToInt32(textBox1.Text);
                            Operator_Form of = new Operator_Form();
                            of.Show();

                        }
                    }
                   
                }
             
            }

            
             if(id_check == false)
             {
                 MessageBox.Show("Employee ID is Not Correct \n \n Please Enter a Correct Employee ID");
                
             }
             else if(password_check==false)
             {
                MessageBox.Show("Password is Not Correct \n \n Please Enter a Correct Password");
                 
             }
             
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
