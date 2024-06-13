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
    public partial class Taxcategory_Form : Form
    {
        public Taxcategory_Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_Form mf = new Manager_Form();
            mf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tax_category = textBox1.Text;
            float tax_percentage =float.Parse(textBox2.Text);
            TaxcategoryRepositry tcr = new TaxcategoryRepositry();
            Taxcategory tc = new Taxcategory(tax_category,tax_percentage);
            tcr.Add_Category(tc);
            Get_Taxcategories();
            MessageBox.Show("Taxcategory Added Sucessfully");
        }

        private void Taxcategory_Form_Load(object sender, EventArgs e)
        {
            Get_Taxcategories();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tax_category = comboBox1.Text;
            float tax_percentage =Convert.ToSingle( textBox3.Text);
            Taxcategory tcy = new Taxcategory();
            TaxcategoryRepositry tcyr=new TaxcategoryRepositry();
            foreach (var item in TaxcategoryRepositry.Taxcategories)
            {
                if (tax_category == item.Tax_category_name)
                {
                    tcy = tcyr.Get_category(item);
                    break;
                }
            }
            Taxcategory tcy_new = new Taxcategory(tcy.Tax_category_name,tax_percentage);
            tcyr.Edit_taxcategory(tcy_new);
            Get_Taxcategories();
            MessageBox.Show("Taxcategory Edited Sucessfully");
        }
        private void Get_Taxcategories()
        {
            foreach (var item in TaxcategoryRepositry.Taxcategories)
            {
                comboBox1.Items.Add(item.Tax_category_name);
            }
        }
    }
}
