
namespace CustomCourseGenerator
{
    partial class Up
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
            this.FeetLabelUp = new System.Windows.Forms.Label();
            this.FeetText2 = new System.Windows.Forms.TextBox();
            this.Enter2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpPreview = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FeetLabelUp
            // 
            this.FeetLabelUp.AutoSize = true;
            this.FeetLabelUp.Font = new System.Drawing.Font("Complex_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeetLabelUp.Location = new System.Drawing.Point(3, 9);
            this.FeetLabelUp.Name = "FeetLabelUp";
            this.FeetLabelUp.Size = new System.Drawing.Size(56, 23);
            this.FeetLabelUp.TabIndex = 2;
            this.FeetLabelUp.Text = "Feet";
            // 
            // FeetText2
            // 
            this.FeetText2.Location = new System.Drawing.Point(6, 33);
            this.FeetText2.Name = "FeetText2";
            this.FeetText2.Size = new System.Drawing.Size(118, 20);
            this.FeetText2.TabIndex = 3;
            this.FeetText2.TextChanged += new System.EventHandler(this.FeetText2_TextChanged);
            // 
            // Enter2
            // 
            this.Enter2.Font = new System.Drawing.Font("Complex_IV25", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter2.Location = new System.Drawing.Point(49, 57);
            this.Enter2.Name = "Enter2";
            this.Enter2.Size = new System.Drawing.Size(75, 31);
            this.Enter2.TabIndex = 4;
            this.Enter2.Text = "Enter";
            this.Enter2.UseVisualStyleBackColor = true;
            this.Enter2.Click += new System.EventHandler(this.Enter2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UpPreview);
            this.panel1.Location = new System.Drawing.Point(220, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 537);
            this.panel1.TabIndex = 5;
            // 
            // UpPreview
            // 
            this.UpPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpPreview.Location = new System.Drawing.Point(0, 0);
            this.UpPreview.MinimumSize = new System.Drawing.Size(20, 20);
            this.UpPreview.Name = "UpPreview";
            this.UpPreview.ScriptErrorsSuppressed = true;
            this.UpPreview.Size = new System.Drawing.Size(992, 537);
            this.UpPreview.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.Enter2);
            this.panel2.Controls.Add(this.FeetText2);
            this.panel2.Controls.Add(this.FeetLabelUp);
            this.panel2.Location = new System.Drawing.Point(30, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 102);
            this.panel2.TabIndex = 6;
            // 
            // Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Up";
            this.Text = "Up";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FeetLabelUp;
        private System.Windows.Forms.TextBox FeetText2;
        private System.Windows.Forms.Button Enter2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser UpPreview;
        private System.Windows.Forms.Panel panel2;
    }
}