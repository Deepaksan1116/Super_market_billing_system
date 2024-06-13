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
    public partial class Edit_store_detail_form : Form
    {
        public Edit_store_detail_form()
        {
            InitializeComponent();
        }

        private void Edit_store_detail_form_Load(object sender, EventArgs e)
        {
            StoredetailRepositry store_repo = new StoredetailRepositry();
            Store_detail sd_new=new Store_detail();
            sd_new = store_repo.Sd;
            textBox1.Text = sd_new.Store_name;
            textBox2.Text = sd_new.Gst_number;
            textBox3.Text = sd_new.Phone_number;
            textBox4.Text = sd_new.Email_id;
            textBox5.Text = sd_new.Address.House_no;
            textBox6.Text = sd_new.Address.Street_name;
            textBox7.Text = sd_new.Address.Village_name;
            textBox8.Text = sd_new.Address.Taluk_name;
            textBox9.Text = sd_new.Address.District;
            textBox10.Text = sd_new.Address.Pincode;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string store_name = textBox1.Text;
            string gst_number = textBox2.Text;
            string phone_number = textBox3.Text;
            string emailid = textBox4.Text;
            string shop_number = textBox5.Text;
            string street_name = textBox6.Text;
            string village_name = textBox7.Text;
            string taluk_name = textBox8.Text;
            string district = textBox9.Text;
            string pincode = textBox10.Text;
            Address a1 = new Address(shop_number, street_name, village_name, taluk_name, pincode, district);
            Store_detail sd = new Store_detail(store_name, gst_number, phone_number, emailid, a1);
            StoredetailRepositry store_repo = new StoredetailRepositry();
            store_repo.Edit_store_detail(sd);
            MessageBox.Show("Edited Sucessfully");
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            Admin_Form af = new Admin_Form();
            af.Show();
        }
    }
}
