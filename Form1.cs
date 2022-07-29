/*
  Custom Course Generator v1.0 Alpha 
  Created 7/14/22 
  Updated 7/27/22 
  By Boston R 
  

  Needs Adding{

    Lat and Long finder 
    Lat and Long Paster - 35.112235, -89.832678 - Will parse the data 
    Lat and Long OCR 
    Dialong 
    Angle Finder 
    Database Logger 

 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace CustomCourseGenerator
{
    public partial class CourseGenerator : Form 
    {
        public CourseGenerator()
        {
            InitializeComponent();
        }
        private void CourseGenerator_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(this.trackBar1.Value == 100)
            {
                this.Hide();
                Address f1 = new Address(); 
                f1.ShowDialog();
                this.Close(); 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
