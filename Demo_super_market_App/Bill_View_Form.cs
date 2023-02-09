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
    public partial class Bill_View_Form : Form
    {
        public Bill_View_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string billnumber = textBox1.Text;
            BillRepositry br = new BillRepositry();
            string str = br.Get_Bill_output(billnumber);
            richTextBox1.AppendText(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operator_Form of = new Operator_Form();
            of.Show();
        }

    }
}
