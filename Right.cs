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
    public partial class Right : Form
    {
        public Decimal rightNum;
        public Right()
        {
            InitializeComponent();
        }

        private void FeetText4_TextChanged(object sender, EventArgs e)
        {
            // Makes sure that the value doesn't come back as null 
            if (FeetText4.TextLength != 0)
            {

                decimal number = Convert.ToDecimal(Editor.instance.lon.Text);         // Convert label ToDecimal

                decimal rate = Editor.instance.longRate * Convert.ToInt64(FeetText4.Text);    // Convert Feet number to number and calutate the rate 

                rightNum = number + rate;  // Find new postion 

                // test2.Text = Convert.ToString(downNum);
                RightPre.Navigate("https://www.google.com/maps/place/" + Editor.instance.lag.Text + ", " + rightNum + "/data=!3m1!1e3!"); //https://www.latlong.net/c/?lat=39.000000&long=-89.49534

            }
        }

        private void Enter4_Click(object sender, EventArgs e)
        {
            //Appends text to richtextbox or CSV file 
            //Appends Lat and Long data 
            Editor.instance.dataGps.AppendText("\n" + Editor.instance.lag.Text + ", " + rightNum + ", ");

            //Updates Lat numbers 
            Editor.instance.lon.Text = Convert.ToString(rightNum);

            //Closes 
            this.Hide();
            this.Close();
        }
    }
}
