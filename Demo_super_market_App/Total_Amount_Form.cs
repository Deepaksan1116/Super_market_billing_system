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
    public partial class Total_Amount_Form : Form
    {
        public Total_Amount_Form()
        {
            InitializeComponent();
        }
       
        private void Total_Amount_Form_Load(object sender, EventArgs e)
        {
            
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true; 
            dateTimePicker1.Width = 100;
            Controls.Add(dateTimePicker1);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BillRepositry br = new BillRepositry();
            DateTime time=dateTimePicker1.Value;
            double temp_time =br.Get_total_amount(time);
            label3.Text = temp_time.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_Form mf = new Manager_Form();
            mf.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
