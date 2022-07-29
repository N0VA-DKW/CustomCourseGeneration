
namespace CustomCourseGenerator
{
    partial class Left
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
            this.Enter3 = new System.Windows.Forms.Button();
            this.FeetText3 = new System.Windows.Forms.TextBox();
            this.FeetLabelLeft = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftPre = new System.Windows.Forms.WebBrowser();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.Enter3);
            this.panel2.Controls.Add(this.FeetText3);
            this.panel2.Controls.Add(this.FeetLabelLeft);
            this.panel2.Location = new System.Drawing.Point(32, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 102);
            this.panel2.TabIndex = 7;
            // 
            // Enter3
            // 
            this.Enter3.Font = new System.Drawing.Font("Complex_IV25", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter3.Location = new System.Drawing.Point(49, 57);
            this.Enter3.Name = "Enter3";
            this.Enter3.Size = new System.Drawing.Size(75, 31);
            this.Enter3.TabIndex = 4;
            this.Enter3.Text = "Enter";
            this.Enter3.UseVisualStyleBackColor = true;
            this.Enter3.Click += new System.EventHandler(this.Enter3_Click);
            // 
            // FeetText3
            // 
            this.FeetText3.Location = new System.Drawing.Point(6, 33);
            this.FeetText3.Name = "FeetText3";
            this.FeetText3.Size = new System.Drawing.Size(118, 20);
            this.FeetText3.TabIndex = 3;
            this.FeetText3.TextChanged += new System.EventHandler(this.FeetText3_TextChanged);
            // 
            // FeetLabelLeft
            // 
            this.FeetLabelLeft.AutoSize = true;
            this.FeetLabelLeft.Font = new System.Drawing.Font("Complex_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeetLabelLeft.Location = new System.Drawing.Point(3, 9);
            this.FeetLabelLeft.Name = "FeetLabelLeft";
            this.FeetLabelLeft.Size = new System.Drawing.Size(56, 23);
            this.FeetLabelLeft.TabIndex = 2;
            this.FeetLabelLeft.Text = "Feet";
            this.FeetLabelLeft.Click += new System.EventHandler(this.FeetLabelUp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LeftPre);
            this.panel1.Location = new System.Drawing.Point(205, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 537);
            this.panel1.TabIndex = 8;
            // 
            // LeftPre
            // 
            this.LeftPre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPre.Location = new System.Drawing.Point(0, 0);
            this.LeftPre.MinimumSize = new System.Drawing.Size(20, 20);
            this.LeftPre.Name = "LeftPre";
            this.LeftPre.Size = new System.Drawing.Size(1007, 537);
            this.LeftPre.TabIndex = 0;
            // 
            // Left
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Left";
            this.Text = "Left";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Enter3;
        private System.Windows.Forms.TextBox FeetText3;
        private System.Windows.Forms.Label FeetLabelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser LeftPre;
    }
}