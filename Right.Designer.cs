
namespace CustomCourseGenerator
{
    partial class Right
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.Enter4 = new System.Windows.Forms.Button();
            this.FeetText4 = new System.Windows.Forms.TextBox();
            this.FeetLabelRight = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RightPre = new System.Windows.Forms.WebBrowser();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.Enter4);
            this.panel2.Controls.Add(this.FeetText4);
            this.panel2.Controls.Add(this.FeetLabelRight);
            this.panel2.Location = new System.Drawing.Point(53, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 102);
            this.panel2.TabIndex = 8;
            // 
            // Enter4
            // 
            this.Enter4.Font = new System.Drawing.Font("Complex_IV25", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter4.Location = new System.Drawing.Point(49, 57);
            this.Enter4.Name = "Enter4";
            this.Enter4.Size = new System.Drawing.Size(75, 31);
            this.Enter4.TabIndex = 4;
            this.Enter4.Text = "Enter";
            this.Enter4.UseVisualStyleBackColor = true;
            this.Enter4.Click += new System.EventHandler(this.Enter4_Click);
            // 
            // FeetText4
            // 
            this.FeetText4.Location = new System.Drawing.Point(6, 33);
            this.FeetText4.Name = "FeetText4";
            this.FeetText4.Size = new System.Drawing.Size(118, 20);
            this.FeetText4.TabIndex = 3;
            this.FeetText4.TextChanged += new System.EventHandler(this.FeetText4_TextChanged);
            // 
            // FeetLabelRight
            // 
            this.FeetLabelRight.AutoSize = true;
            this.FeetLabelRight.Font = new System.Drawing.Font("Complex_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeetLabelRight.Location = new System.Drawing.Point(3, 9);
            this.FeetLabelRight.Name = "FeetLabelRight";
            this.FeetLabelRight.Size = new System.Drawing.Size(56, 23);
            this.FeetLabelRight.TabIndex = 2;
            this.FeetLabelRight.Text = "Feet";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RightPre);
            this.panel1.Location = new System.Drawing.Point(212, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 535);
            this.panel1.TabIndex = 9;
            // 
            // RightPre
            // 
            this.RightPre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPre.Location = new System.Drawing.Point(0, 0);
            this.RightPre.MinimumSize = new System.Drawing.Size(20, 20);
            this.RightPre.Name = "RightPre";
            this.RightPre.Size = new System.Drawing.Size(997, 535);
            this.RightPre.TabIndex = 0;
            // 
            // Right
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Right";
            this.Text = "Right";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Enter4;
        private System.Windows.Forms.TextBox FeetText4;
        private System.Windows.Forms.Label FeetLabelRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser RightPre;
    }
}