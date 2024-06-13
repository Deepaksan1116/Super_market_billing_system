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
    public partial class Add_Customer_Form : Form
    {
        public Add_Customer_Form()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Operator_Form opf = new Operator_Form();
            opf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string name = Name_txt.Text;
            string phonenumber = Phone_txt.Text;
            string email = Email_txt.Text;
            string house_no = Door_No_txt.Text;
            string street = Street_txt.Text;
            string village = Village_txt.Text;
            string taluk = Taluk_txt.Text;
            string district = District_txt.Text;
            string pincode = Pincode_txt.Text;

            if (name != string.Empty)
            {
                if (phonenumber != string.Empty)
                {
                    int cust_id = CustomerRepositry.Get_last_cust_id() + 1;
                    Address adres = new Address(house_no, street, village, taluk, pincode, district);
                    Customer cust = new Customer(cust_id, name, phonenumber, email, adres);
                    CustomerRepositry cr = new CustomerRepositry();
                    cr.Add_customer(cust);
                    MessageBox.Show("Customer Added Sucessfully");
                }
                else
                {
                    MessageBox.Show("Enter the Phone Number");
                }
            }
            else
            {
                MessageBox.Show("Enter the customer name");
            }
           
        }
    }
}
