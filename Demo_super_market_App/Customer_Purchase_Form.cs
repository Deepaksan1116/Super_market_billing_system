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
    public partial class Customer_Purchase_Form : Form
    {
        public Customer_Purchase_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp_cust = textBox1.Text;
            CustomerRepositry customer_repo = new CustomerRepositry();

            Customer cust = new Customer();
            cust = customer_repo.Get_customer_object(temp_cust);
            if (cust.Customer_name != null)
            {
                label7.Text = cust.Customer_id.ToString();
                label8.Text = cust.Customer_name;
                label9.Text = cust.Phone_number;
                label10.Text = cust.Email_id;
                BillRepositry.Get_Customer_billnumber(cust.Customer_id);
                comboBox1.Items.Clear();
                foreach (var item in BillRepositry.bill_number_list)
                {
                    comboBox1.Items.Add(item);
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_Form mf = new Manager_Form();
            mf.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp_bill_number = comboBox1.SelectedItem.ToString();
            BillRepositry btr = new BillRepositry();
            string bill_output=btr.Get_Bill_output(temp_bill_number);
            richTextBox1.Clear();
            richTextBox1.AppendText(bill_output);
        }
    }
}
