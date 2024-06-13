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
    public partial class Bill_Form : Form
    {
        string product_name= string.Empty;
        Bill temp_bill=new Bill();
        public Bill_Form()
        {
            InitializeComponent();
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Card");
            comboBox1.Items.Add("UPI");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BillRepositry btr = new BillRepositry();
            Bill temp_bill = new Bill();

            temp_bill = btr.Get_Next_Bill();
            if (temp_bill.Emp != null)
            {
                Cust_id_txt.Text = temp_bill.Cust.Customer_id.ToString();
                List<BillProduct> temp_list = temp_bill.Get_Bill_Product_List();
                listBox1.Items.Clear();
                listBox1.Items.Add("Product" + "\t" + "Qty" + "\t" + "Amount" + "\n");
                foreach (var item in temp_list)
                {
                    listBox1.Items.Add(item.product.Product_name + "\t" + item.Quantity + "\t" + item.Amount + "\n");
                }
            }
            else
            {
                MessageBox.Show("No bills found  Go to Previous bill or View Bill");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int product_id =Convert.ToInt32( textBox1.Text);
            int Quantity =(int) numericUpDown1.Value;
            Product pt = new Product(product_id);
            ProductRepositry product_repo = new ProductRepositry();
            Product pt_new = new Product();
            pt_new=product_repo.Get_product(pt);
            BillProduct bp = new BillProduct(pt_new,Quantity);
            temp_bill.Add_Billproduct(bp);
            
            int temp_Quantity=0;
            string temp_product_name=string.Empty;
            double temp_amount=0;
            List<BillProduct> temp_list = temp_bill.Get_Bill_Product_List();
            foreach (var item in temp_list)
            {
                temp_Quantity =item.Quantity;
                temp_product_name=item.product.Product_name;
                temp_amount=item.Amount;
            }
            listBox1.Items.Add(temp_product_name+"\t"+temp_Quantity+"\t"+temp_amount+"\n");
        }

        private void Bill_Form_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Product"+"\t"+"Qty"+"\t"+"Amount"+"\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string[] temp_string = listBox1.SelectedItem.ToString().Split('\t');
                label7.Text = temp_string[0];
                product_name = temp_string[0];
                numericUpDown2.Value = Convert.ToInt32(temp_string[1]);
                int temp_quantity = (int)numericUpDown2.Value;
            }
            else
            {
                MessageBox.Show("Please Select the Product");
            }

           

        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string[] temp_string = listBox1.SelectedItem.ToString().Split('\t');
                Product temp_product = new Product(Convert.ToInt32(temp_string[0]));
                ProductRepositry product_repo = new ProductRepositry();
                Product pt_new = new Product();
                pt_new = product_repo.Get_product(temp_product);
                temp_bill.Remove_Billproduct(pt_new);
                List<BillProduct> temp_list = temp_bill.Get_Bill_Product_List();
                listBox1.Items.Clear();
                listBox1.Items.Add("Product" + "\t" + "Qty" + "\t" + "Amount" + "\n");
                foreach (var item in temp_list)
                {
                    listBox1.Items.Add(item.product.Product_name + "\t" + item.Quantity + "\t" + item.Amount + "\n");
                }
            }
            else
            {
                MessageBox.Show("Please Select the Product");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int customer_id;
            if (listBox1.Items.Count > 1)
            {
                if (Cust_id_txt.Text == "")
                {
                    customer_id = 1001;
                }
                else
                {
                    customer_id = Convert.ToInt32(Cust_id_txt.Text);
                }
                int employee_id = Login_Form.employee_id;
                Customer temp_customer = new Customer(customer_id);
                Employee temp_employee = new Employee(employee_id);
                CustomerRepositry cust_repo = new CustomerRepositry();
                EmployeeRepositry emp_repo = new EmployeeRepositry();
                Customer cust = new Customer();
                Employee emp = new Employee();
                cust = cust_repo.Get_customer(temp_customer);
                emp = emp_repo.Get_Employee(temp_employee);
                temp_bill.Cust = cust;
                temp_bill.Emp = emp;

                BillRepositry bir = new BillRepositry();
                bir.Add_bill(temp_bill);
                temp_bill = new Bill();
                //temp_bill.Clear_product_list();
                listBox1.Items.Clear();
                textBox1.Clear();
                numericUpDown1.Value = 0;
                Cust_id_txt.Clear();
            }
            else
            {
                MessageBox.Show("Please Add the Products");
            }
        }

        private void View_Bill_Click(object sender, EventArgs e)
        {
            BillRepositry btr = new BillRepositry();
            Bill new_bill = new Bill();

           new_bill = btr.Get_first_Bill();
           if (new_bill.Emp != null)
           {
               Cust_id_txt.Text = new_bill.Cust.Customer_id.ToString();
               List<BillProduct> temp_list = new_bill.Get_Bill_Product_List();
               listBox1.Items.Clear();
               listBox1.Items.Add("Product" + "\t" + "Qty" + "\t" + "Amount" + "\n");
               //listBox1.DataSource = new_bill;
               foreach (var item in temp_list)
               {
                   listBox1.Items.Add(item.product.Product_name + "\t" + item.Quantity + "\t" + item.Amount + "\n");
               }
           }
           else
           {
               MessageBox.Show("No Bills Found");
           }
            
        }

        private void Previous_Bill_Button_Click(object sender, EventArgs e)
        {
            BillRepositry btr = new BillRepositry();
            Bill temp_bill = new Bill();

            temp_bill = btr.Get_Previous_Bill();
            if (temp_bill.Emp != null)
            {
                Cust_id_txt.Text = temp_bill.Cust.Customer_id.ToString();
                List<BillProduct> temp_list = temp_bill.Get_Bill_Product_List();
                listBox1.Items.Clear();
                listBox1.Items.Add("Product" + "\t" + "Qty" + "\t" + "Amount" + "\n");
                foreach (var item in temp_list)
                {
                    listBox1.Items.Add(item.product.Product_name + "\t" + item.Quantity + "\t" + item.Amount + "\n");
                }
            }
            else
            {
                MessageBox.Show("No bills found  Go to next bill or View Bill");
            }
        }

        private void Save_bill_button_Click(object sender, EventArgs e)
        {

            if (listBox1.Items.Count > 1)
            {
                if (Cust_id_txt.Text != null)
                {
                    if (comboBox1.Text == "")
                    {
                        int customer_id = Convert.ToInt32(Cust_id_txt.Text);
                        int employee_id = Login_Form.employee_id;
                        Customer temp_customer = new Customer(customer_id);
                        Employee temp_employee = new Employee(employee_id);
                        CustomerRepositry cust_repo = new CustomerRepositry();
                        EmployeeRepositry emp_repo = new EmployeeRepositry();
                        Customer cust = new Customer();
                        Employee emp = new Employee();
                        cust = cust_repo.Get_customer(temp_customer);
                        emp = emp_repo.Get_Employee(temp_employee);
                        temp_bill.Cust = cust;
                        temp_bill.Emp = emp;
                        temp_bill.Payment_type = comboBox1.SelectedItem.ToString();
                        BillRepositry btr = new BillRepositry();
                        //btr.Add_bill(temp_bill);

                        string bill_string = string.Empty;
                        btr.Create_Directory();
                        btr.Change_bill_number(temp_bill);

                        bill_string = btr.Bill_output(temp_bill);

                        btr.Create_Bill_file(bill_string);
                        double amount = temp_bill.TotalAmount;
                        btr.Write_total_amount(amount, temp_bill.Emp.Employee_id);
                        btr.Write_operator_performance(temp_bill);
                        btr.Create_customer_purchase_detail(temp_bill);
                        listBox1.Items.Clear();
                        textBox1.Clear();
                        numericUpDown1.Value = 0;
                        Cust_id_txt.Clear();
                        MessageBox.Show("Bill Save Sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("Please Select the Payment Type");
                    }
                }
                else
                {
                    MessageBox.Show("Please Give Customer Id");
                }
            }
            else
            {
                MessageBox.Show("Product list is Empty!  Please add the Products");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label7.Text != "")
            {
                int productid = ProductRepositry.Get_product_id_with_name(product_name);

                int temp_quantity = (int)numericUpDown2.Value;
                Product pt = new Product(Convert.ToInt32(productid));
                ProductRepositry product_repo = new ProductRepositry();
                Product pt_new = new Product();
                pt_new = product_repo.Get_product(pt);
                BillProduct temp_bill_product = new BillProduct(pt_new, temp_quantity);
                temp_bill.Edit_Billproduct(temp_bill_product);
                List<BillProduct> temp_list = temp_bill.Get_Bill_Product_List();
                listBox1.Items.Clear();
                listBox1.Items.Add("Product" + "\t" + "Qty" + "\t" + "Amount" + "\n");
                foreach (var item in temp_list)
                {
                    listBox1.Items.Add(item.product.Product_name + "\t" + item.Quantity + "\t" + item.Amount + "\n");
                }
            }
            else
            {
                MessageBox.Show("Please Select the Product");
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Operator_Form of = new Operator_Form();
            of.Show();
        }

        private void Add_customer_button_Click(object sender, EventArgs e)
        {
            Add_Customer_Form acf = new Add_Customer_Form();
            acf.Show();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            int employee_id = Login_Form.employee_id;
            BillRepositry Bill_repo=new BillRepositry();
            int temp = BillRepositry.Temp_Bills.Count;
            double amount = Bill_repo.Get_operator_total_amount(System.DateTime.Now,employee_id);

            if (temp == 0)
            {
                string title = "Bills";
                string content = "No Pending Bills";
                DialogResult dialog_result = MessageBox.Show(content, title, MessageBoxButtons.OKCancel);
                if (dialog_result == DialogResult.OK)
                {
                    MessageBox.Show("Total amount :" + amount);
                }
                else
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                string title = "Pending Bills";
                string content = temp + "   Pending Bills are here \n If you want logout";
                DialogResult dialog_result = MessageBox.Show(content,title,MessageBoxButtons.OKCancel);
                if (dialog_result == DialogResult.OK)
                {
                    MessageBox.Show("Total amount :" + amount);
                    Login_Form lf = new Login_Form();
                    lf.Show();
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
