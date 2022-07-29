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
    public partial class Form4 : Form
    {
        public static Form4 instance;
        public TextBox lat;
        public TextBox lon;

        public Form4()
        {
            InitializeComponent();
            instance = this;
            lat = LatText;
            lon = LongText; 

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            this.Hide(); 
            Editor editor = new Editor();
            editor.ShowDialog(); 
          
                this.Close(); 
              
 

        }
    }
}
