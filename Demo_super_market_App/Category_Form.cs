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
    public partial class Category_Form : Form
    {
        public Category_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string category_name = textBox1.Text;
            if (category_name != string.Empty)
            {
                if (CategoryRepositry.Check_category(category_name) == false)
                {
                    int categoey_id = CategoryRepositry.Get_category_id();
                    Category cy = new Category(categoey_id + 1, category_name);
                    CategoryRepositry cyr = new CategoryRepositry();
                    cyr.Add_Category(cy);
                    Get_Categories();
                    MessageBox.Show("Category Added Sucessfully");
                }
                else
                {
                    MessageBox.Show("This Category is Already Here");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Category");
            }
        }

        private void Category_Form_Load(object sender, EventArgs e)
        {
            Get_Categories();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_Form mf = new Manager_Form();
            mf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string category_name = comboBox1.Text;
                Category cy = new Category();
                CategoryRepositry cyr = new CategoryRepositry();
                foreach (var item in CategoryRepositry.categories)
                {
                    if (category_name == item.Category_name)
                    {
                        cy = cyr.Get_category(item);
                    }
                }
                cyr.Remove_category(cy);
                comboBox1.Items.Clear();
                Get_Categories();
                MessageBox.Show("Category Removed Sucessfully");
            }
            else
            {
                MessageBox.Show("Please Select the Category");
            }
        }
        private void Get_Categories()
        {
            foreach (var item in CategoryRepositry.categories)
            {
                comboBox1.Items.Add(item.Category_name);
            }
        }
    }
}
