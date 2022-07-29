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
    public partial class Up : Form
    {
        public Decimal upNum;
        public Up()
        {
            InitializeComponent();
        }

        private void FeetText2_TextChanged(object sender, EventArgs e)
        {
            // Makes sure that the value doesn't come back as null 
            if (FeetText2.TextLength != 0)
            {
           
                decimal number = Convert.ToDecimal(Editor.instance.lag.Text);         // Convert label ToDecimal
            
                decimal rate = Editor.instance.latRate * Convert.ToInt64(FeetText2.Text);    // Convert Feet number to number and calutate the rate 
             
                upNum = number + rate;  // Find new postion 

                // test2.Text = Convert.ToString(downNum);
                UpPreview.Navigate("https://www.google.com/maps/place/" + upNum + ", " + Editor.instance.lon.Text + "/data=!3m1!1e3!"); //https://www.latlong.net/c/?lat=39.000000&long=-89.49534

            }
        }

        private void Enter2_Click(object sender, EventArgs e)
        {
            //Appends text to richtextbox or CSV file 
            //Appends Lat and Long data 
            Editor.instance.dataGps.AppendText("\n" + upNum + ", " + Editor.instance.lon.Text + ", ");

            //Updates Lat numbers 
            Editor.instance.lag.Text = Convert.ToString(upNum);
            
            //Closes 
            this.Hide();
            this.Close();
        }
    }
}
