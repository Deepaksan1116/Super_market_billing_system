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
    public partial class Get_Bill_Form : Form
    {
        public Get_Bill_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string billnumber = textBox1.Text;
            if (billnumber != string.Empty)
            {
                BillRepositry br = new BillRepositry();
                string str = br.Get_Bill_output(billnumber);
                if (str != "")
                {
                    richTextBox1.AppendText(str);
                }
                else
                {
                    MessageBox.Show("Bill Number is Not Correct \n\n Please enter a correct bill number");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Bill Number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_Form mf = new Manager_Form();
            mf.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Get_Bill_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
