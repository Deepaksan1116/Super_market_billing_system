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
    public partial class Product_Form : Form
    {
        public Product_Form()
        {
            InitializeComponent();
            textBox2.Text ="0";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Product_Form_Load(object sender, EventArgs e)
        {
            
            foreach (var item in CategoryRepositry.categories)
            {
                comboBox1.Items.Add(item.Category_name);
            }

            foreach (var item in TaxcategoryRepositry.Taxcategories)
            {
                comboBox2.Items.Add(item.Tax_category_name);
                comboBox4.Items.Add(item.Tax_category_name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_Form mf = new Manager_Form();
            mf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string product_name = textBox1.Text;
            string category = comboBox1.Text;
            double unit_price =Convert.ToDouble(textBox2.Text);
            string tax_category = comboBox2.Text;
            Status status = (Status)Enum.Parse(typeof(Status), "active");
            if (product_name != string.Empty)
            {
                if (ProductRepositry.Check_product(product_name) == false)
                {
                    int product_id = ProductRepositry.Get_product_id();
                    if (category != string.Empty)
                    {
                        if (unit_price > 0)
                        {
                            Product pt = new Product(product_id + 1, product_name, category, unit_price, tax_category, status);
                            ProductRepositry ptr = new ProductRepositry();
                            ptr.Add_product(pt);
                            MessageBox.Show("Product Added Sucessfully");
                        }
                        else
                        {
                            MessageBox.Show("Please give the unitprice");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please give the category");
                    }
                }
                else
                {
                    MessageBox.Show("This Product is Already Here");
                }
            }
            else
            {
                MessageBox.Show("Please Enter the Product Name");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Product_id_txt.Text != string.Empty)
            {
                double unit_price = Convert.ToDouble(textBox3.Text);
                string tax_category = comboBox4.Text;
                Status status = (Status)Enum.Parse(typeof(Status), comboBox5.Text);
                int product_id = Convert.ToInt32(Product_id_txt.Text);
                Product pt = new Product();
                ProductRepositry ptr = new ProductRepositry();
                foreach (var item in ProductRepositry.product_list)
                {
                    if (product_id == item.Product_id)
                    {
                        pt = ptr.Get_product(item);
                        break;
                    }
                }
                ProductRepositry product_repo = new ProductRepositry();
                Product pt_new = new Product(pt.Product_id, pt.Product_name, pt.Category, unit_price, tax_category, status);
                product_repo.Edit_product(pt_new);
                MessageBox.Show("Product Edited Sucessfully");
            }
            else
            {
                MessageBox.Show("Please Give the Product ID");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Product_id_txt.Text != string.Empty)
            {
                int product_id = Convert.ToInt32(Product_id_txt.Text);
                bool productid_check = false;
                Product pt = new Product();
                ProductRepositry ptr = new ProductRepositry();
                foreach (var item in ProductRepositry.product_list)
                {
                    if (product_id == item.Product_id)
                    {
                        pt = ptr.Get_product(item);
                        productid_check = true;
                        break;
                    }
                }
                if (productid_check == true)
                {
                    textBox3.Text = pt.Unit_price.ToString();
                    comboBox4.Text = pt.Taxcategory;
                    comboBox5.Text = pt.Status.ToString();
                    label13.Text = pt.Product_name;
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Product ID");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Product ID");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
