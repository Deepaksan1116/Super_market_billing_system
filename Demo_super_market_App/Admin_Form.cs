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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Employee_Form af = new Add_Employee_Form();
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit_store_detail_form esdf = new Edit_store_detail_form();
            esdf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Employee_Form eef = new Edit_Employee_Form();
            eef.Show();
        }
    }
}
