using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCourseGenerator
{
    public partial class Down : Form
    {
        public Decimal downNum; 
        public Down()
        {
            InitializeComponent();
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //    test2.Text = Convert.ToString(FeetText.Text); 
            if (FeetText.TextLength != 0)
            {
                decimal number = Convert.ToDecimal(Editor.instance.lag.Text);
                decimal rate = Editor.instance.latRate * Convert.ToInt32(FeetText.Text);
                downNum = number - rate;
                // test2.Text = Convert.ToString(downNum);
                //                DownPreWbs.Navigate("https://www.latlong.net/c/?lat=" + downNum + "&long=" + Editor.instance.lon.Text); //https://www.latlong.net/c/?lat=39.000000&long=-89.49534
                DownPreWbs.Navigate("https://www.google.com/maps/place/" + downNum + ", " + Editor.instance.lon.Text + "/data=!3m1!1e3!"); 
            }
        }

        private void Down_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editor.instance.dataGps.AppendText("\n" + downNum + ", " + Editor.instance.lon.Text + ", "); 
            Editor.instance.lag.Text = Convert.ToString(downNum);
            this.Hide();
            this.Close(); 
        }
    }
}
