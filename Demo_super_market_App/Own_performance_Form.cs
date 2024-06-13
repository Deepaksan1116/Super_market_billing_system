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
    public partial class Own_performance_Form : Form
    {
        public Own_performance_Form()
        {
            InitializeComponent();
        }

        private void Own_performance_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int employee_id = Login_Form.employee_id;
            BillRepositry br = new BillRepositry();
            DateTime time = dateTimePicker1.Value;
            double temp_amount = br.Get_operator_total_amount(time,employee_id);
            label3.Text = temp_amount.ToString();
        }
    }
}
