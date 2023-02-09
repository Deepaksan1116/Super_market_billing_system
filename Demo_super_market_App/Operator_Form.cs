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
    public partial class Operator_Form : Form
    {
        public Operator_Form()
        {
            InitializeComponent();
        }

        private void New_bill_button_Click(object sender, EventArgs e)
        {
            Bill_Form bf = new Bill_Form();
            bf.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Customer_Form acf = new Add_Customer_Form();
            acf.Show();
           
        }

        private void View_customer_button_Click(object sender, EventArgs e)
        {
            View_Customer_Form vcf = new View_Customer_Form();
            vcf.Show();
            
        }

        private void performance_button_Click(object sender, EventArgs e)
        {
            Own_performance_Form opf = new Own_performance_Form();
            opf.Show();
            
        }

        private void View_bill_button_Click(object sender, EventArgs e)
        {
            Bill_View_Form bvf = new Bill_View_Form();
            bvf.Show();
            
        }
    }
}
