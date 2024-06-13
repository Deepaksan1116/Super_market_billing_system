using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_super_market_App
{
    public partial class Manager_Form : Form
    {
        public Manager_Form()
        {
            InitializeComponent();
        }

        private void Product_button1_Click(object sender, EventArgs e)
        {
            Product_Form pf = new Product_Form();
            pf.Show();
        }

        private void Category_button2_Click(object sender, EventArgs e)
        {
            Category_Form cf = new Category_Form();
            cf.Show();
        }

        private void Taxcategory_button3_Click(object sender, EventArgs e)
        {
            Taxcategory_Form tcf = new Taxcategory_Form();
            tcf.Show();
        }

        private void Customer_button4_Click(object sender, EventArgs e)
        {
            Customer_Purchase_Form cpf = new Customer_Purchase_Form();
            cpf.Show();
        }

        private void Amount_button6_Click(object sender, EventArgs e)
        {
            Total_Amount_Form taf = new Total_Amount_Form();
            taf.Show();
        }

        private void Operator_button5_Click(object sender, EventArgs e)
        {
            Operator_Performance_Form opf = new Operator_Performance_Form();
            opf.Show();
        }

        private void Bill_button7_Click(object sender, EventArgs e)
        {
            
            Get_Bill_Form gbf = new Get_Bill_Form();
            gbf.Show();
        }
    }
}
