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
    public partial class Operator_Performance_Form : Form
    {
        public Operator_Performance_Form()
        {
            InitializeComponent();
            Employee_id_txt.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Employee_id_txt.Text != string.Empty)
            {
                int employee_id = Convert.ToInt32(Employee_id_txt.Text);
                if (EmployeeRepositry.Check_employee(employee_id) == true)
                {
                    BillRepositry bill_repo = new BillRepositry();
                    bill_repo.Get_Operator_performance_amount(employee_id);
                    double amount = 0;
                    listBox1.Items.Add("Date" + "\t" + "Amount");
                    foreach (var item in BillRepositry.operator_performance_amount)
                    {
                        string[] item_value = item.Split('|');
                        listBox1.Items.Add(item_value[0] + "\t" + item_value[2]);
                        amount += Convert.ToDouble(item_value[2]);
                    }
                    label14.Text = amount.ToString();
                    int count = 1;
                    double week1 = 0;
                    foreach (var item in BillRepositry.operator_performance_amount)
                    {
                        string[] item_value = item.Split('|');
                        week1 += Convert.ToDouble(item_value[2]);
                        if (count == 7)
                        {
                            label9.Text = week1.ToString();
                        }
                        else if (count == 14)
                        {
                            label10.Text = week1.ToString();
                        }
                        else if (count == 28)
                        {
                            label11.Text = week1.ToString();
                        }
                        else if (count > 28)
                        {
                            label12.Text = week1.ToString();
                        }
                    }
                    if (count < 7)
                    {
                        label9.Text = week1.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Employee ID");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Employee ID");
            }
        }
    }
}
