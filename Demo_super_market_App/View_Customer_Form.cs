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
    public partial class View_Customer_Form : Form
    {
        public View_Customer_Form()
        {
            InitializeComponent();
        }

        private void Get_button_Click(object sender, EventArgs e)
        {
            string temp_cust = Cust_id_txt.Text;
            CustomerRepositry ctr = new CustomerRepositry();
            Customer new_cust = new Customer();
            new_cust=ctr.Get_customer_object(temp_cust);
            if (new_cust.Customer_name!= null)
            {
                label5.Text = new_cust.Customer_id.ToString();
                label6.Text = new_cust.Customer_name;
                label7.Text = new_cust.Phone_number;
                label16.Text = new_cust.Address.House_no;
                label17.Text = new_cust.Address.Street_name;
                label18.Text = new_cust.Address.Village_name;
                label19.Text = new_cust.Address.Taluk_name;
                label20.Text = new_cust.Address.District;
                label21.Text = new_cust.Address.Pincode;
            }
            else
            {
                if (temp_cust.Length > 9)
                {
                    MessageBox.Show("Phone number is not correct\n\n Please enter the correct phone number");
                }
                else
                {
                    MessageBox.Show("Customer ID is not correct\n\n Please enter the correct Customer ID");
                }
            }

        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Operator_Form opf = new Operator_Form();
            opf.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       
    }
}
