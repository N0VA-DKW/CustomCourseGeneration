using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper; 

namespace CustomCourseGenerator
{
    public partial class Editor : Form
    {
        public static Editor instance;

        //  public Label lon;
        public Label lon;
        public Label lag;
        public Decimal latRate;
        public Decimal longRate;
        public RichTextBox dataGps; 
        //public Label lag; 
        public Editor()
        {

            InitializeComponent();
            instance = this;
            // string lona;
            // string lat; 
            lon = LongTemp;
            lag = LatTemp;
            latRate = 0.000003m;
            longRate = 0.000004m;
            dataGps = richTextBox1; 
            //   lon = LongTemp;
            // lag = LatTemp; 

        }


        //Grabber 
        private void Button12_Click(object sender, EventArgs e)
        {
            //Gets Long and Lat from form4 
            LongTemp.Text = Form4.instance.lon.Text;
            LatTemp.Text = Form4.instance.lat.Text;

            //Add First Line to TextFile 
            richTextBox1.Text = "Latitude, Longitude, TurnAng";
            //Adds values to the texts 
            richTextBox1.AppendText("\n" + Convert.ToString(LatTemp.Text) + ", " + Convert.ToString(LongTemp.Text) + ", " + "0");

            //Create a preview to view the first point
            StringBuilder previewStr = new StringBuilder();
            previewStr.Append("https://www.latlong.net/c/?lat="); // 45.23562&lng=45.23562
            previewStr.Append(Convert.ToString(LatTemp.Text) + "&long=" + Convert.ToString(LongTemp.Text));
            Previewer.Navigate(Convert.ToString(previewStr));

            //Hides Button 
            this.Button12.Visible = false;

            //string LastWayLong = LongTemp.Text; 
            //Convert.ToDemical(LastWayLong) 
            //string LastwayLat
            //string NewWay

        }

        private void Editor_Load(object sender, EventArgs e)
        {
            //gpsBindingSource1.DataSource = new List<Gps>();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Export 
        private void extBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = ".TXT|*.txt|.CSV|*.csv";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filep = saveFileDialog1.FileName;
                TextWriter writer = new StreamWriter(filep);
                writer.Write(richTextBox1.Text);
                writer.Close();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //Clear 
        private void ClrBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
        }

        private void unlockEditingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void confrimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
        }

        private void OpnBtn_Click(object sender, EventArgs e)
        {
            Stream myStream;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    string strfilename = openFileDialog1.FileName;
                    string filetext = File.ReadAllText(strfilename);
                    richTextBox1.Text = filetext;

                }
            }

        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            Down bad = new Down(); // Down Bad 
            bad.ShowDialog(); 
        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            Left andright = new Left();
            andright.ShowDialog(); 
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            Up andaway = new Up();
            andaway.ShowDialog(); 
        }

        private void RightBtn_Click(object sender, EventArgs e)
        {
            Right toleft = new Right();
            toleft.ShowDialog(); 
        }



        /* 
          Code for Grabber 

          private void Addtest_Click(object sender, EventArgs e)
          {
            if(richTextBox1.Text != null)
           {

               richTextBox1.AppendText("\n" + Convert.ToString(LatTemp.Text) + ", " + Convert.ToString(LongTemp.Text) + ", " + "0"); 
           }
          }
       */


    }


}
