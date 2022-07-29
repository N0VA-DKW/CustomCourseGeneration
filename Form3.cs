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
    public partial class Form3 : Form
    {
        public static Form3 instance;
        public WebBrowser wbs; 
        public Form3()
        {
            InitializeComponent();
            instance = this;
            wbs = webBrowser1; 
        }
    }
}
