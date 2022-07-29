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
    public partial class Left : Form
    {
        public Decimal leftNum; 
        public Left()
        {
            InitializeComponent();
        }

        private void FeetLabelUp_Click(object sender, EventArgs e)
        {

        }

        private void FeetText3_TextChanged(object sender, EventArgs e)
        {
            // Makes sure that the value doesn't come back as null 
            if (FeetText3.TextLength != 0)
            {

                decimal number = Convert.ToDecimal(Editor.instance.lon.Text);         // Convert label ToDecimal

                decimal rate = Editor.instance.longRate * Convert.ToInt64(FeetText3.Text);    // Convert Feet number to number and calutate the rate 

                leftNum = number - rate;  // Find new postion 

                // test2.Text = Convert.ToString(downNum);
                LeftPre.Navigate("https://www.google.com/maps/place/" + Editor.instance.lag.Text + ", " + leftNum + "/data=!3m1!1e3!"); //https://www.latlong.net/c/?lat=39.000000&long=-89.49534

            }
        }

        private void Enter3_Click(object sender, EventArgs e)
        {
            //Appends text to richtextbox or CSV file 
            //Appends Lat and Long data 
            Editor.instance.dataGps.AppendText("\n" + Editor.instance.lag.Text + ", " + leftNum + ", ");

            //Updates Lat numbers 
            Editor.instance.lon.Text = Convert.ToString(leftNum);

            //Closes 
            this.Hide();
            this.Close();
        }
    }
}
