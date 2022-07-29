
namespace CustomCourseGenerator
{
    partial class Down
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
            this.FeetText = new System.Windows.Forms.TextBox();
            this.Feetlabel = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DownPreWbs = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FeetText
            // 
            this.FeetText.Location = new System.Drawing.Point(33, 208);
            this.FeetText.Name = "FeetText";
            this.FeetText.Size = new System.Drawing.Size(118, 20);
            this.FeetText.TabIndex = 0;
            this.FeetText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Feetlabel
            // 
            this.Feetlabel.AutoSize = true;
            this.Feetlabel.Font = new System.Drawing.Font("Complex_IV25", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Feetlabel.Location = new System.Drawing.Point(65, 183);
            this.Feetlabel.Name = "Feetlabel";
            this.Feetlabel.Size = new System.Drawing.Size(56, 23);
            this.Feetlabel.TabIndex = 1;
            this.Feetlabel.Text = "Feet";
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Complex_IV25", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(54, 235);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 31);
            this.Enter.TabIndex = 2;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DownPreWbs);
            this.panel1.Location = new System.Drawing.Point(220, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 546);
            this.panel1.TabIndex = 3;
            // 
            // DownPreWbs
            // 
            this.DownPreWbs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownPreWbs.Location = new System.Drawing.Point(0, 0);
            this.DownPreWbs.MinimumSize = new System.Drawing.Size(20, 20);
            this.DownPreWbs.Name = "DownPreWbs";
            this.DownPreWbs.ScriptErrorsSuppressed = true;
            this.DownPreWbs.Size = new System.Drawing.Size(993, 546);
            this.DownPreWbs.TabIndex = 0;
            // 
            // Down
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1225, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Feetlabel);
            this.Controls.Add(this.FeetText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Down";
            this.Text = "Down";
            this.Load += new System.EventHandler(this.Down_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FeetText;
        private System.Windows.Forms.Label Feetlabel;
        private new System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser DownPreWbs;
    }
}