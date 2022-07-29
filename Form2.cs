using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack; 

namespace CustomCourseGenerator
{
    public partial class Address : Form
    {
        public static Address instance; 
        public Address()
        {
            InitializeComponent();
            instance = this; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Show map 
            form3.Show();
            string address = Convert.ToString(address1.Text); //Convert numbers to string from text box 
            try {
                StringBuilder mapsAddress = new StringBuilder();  //stribg builder to append 
                mapsAddress.Append("https://maps.google.com/maps?q=");
                address = address.Replace(" ", "+");
                mapsAddress.Append(address);
                Form3.instance.wbs.Navigate(Convert.ToString(mapsAddress)); //using data from form3 
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message.ToString(), "Error"); 
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit2_Click(object sender, EventArgs e) // Opens a new form to start editing 
        {
            this.Hide(); 
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close(); 
        }
    }
}
