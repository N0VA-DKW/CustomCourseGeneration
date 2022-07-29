
namespace CustomCourseGenerator
{
    partial class Form4
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
            this.LatText = new System.Windows.Forms.TextBox();
            this.LongText = new System.Windows.Forms.TextBox();
            this.Lat = new System.Windows.Forms.Label();
            this.Long = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Title3 = new System.Windows.Forms.Label();
            this.Caption = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LatText
            // 
            this.LatText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LatText.Location = new System.Drawing.Point(59, 186);
            this.LatText.Name = "LatText";
            this.LatText.Size = new System.Drawing.Size(100, 20);
            this.LatText.TabIndex = 0;
            // 
            // LongText
            // 
            this.LongText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LongText.Location = new System.Drawing.Point(249, 184);
            this.LongText.Name = "LongText";
            this.LongText.Size = new System.Drawing.Size(100, 20);
            this.LongText.TabIndex = 1;
            // 
            // Lat
            // 
            this.Lat.AutoSize = true;
            this.Lat.Font = new System.Drawing.Font("Simplex_IV25", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lat.Location = new System.Drawing.Point(81, 168);
            this.Lat.Name = "Lat";
            this.Lat.Size = new System.Drawing.Size(62, 15);
            this.Lat.TabIndex = 2;
            this.Lat.Text = "Latitude";
            // 
            // Long
            // 
            this.Long.AutoSize = true;
            this.Long.Font = new System.Drawing.Font("Simplex_IV25", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Long.Location = new System.Drawing.Point(264, 169);
            this.Long.Name = "Long";
            this.Long.Size = new System.Drawing.Size(72, 15);
            this.Long.TabIndex = 3;
            this.Long.Text = "Longitude";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(172, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Contiune";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Title3
            // 
            this.Title3.AutoSize = true;
            this.Title3.Font = new System.Drawing.Font("Blackford", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title3.Location = new System.Drawing.Point(85, 34);
            this.Title3.Name = "Title3";
            this.Title3.Size = new System.Drawing.Size(264, 74);
            this.Title3.TabIndex = 5;
            this.Title3.Text = "The Editor";
            // 
            // Caption
            // 
            this.Caption.AutoSize = true;
            this.Caption.Font = new System.Drawing.Font("SuperFrench", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Caption.Location = new System.Drawing.Point(149, 103);
            this.Caption.Name = "Caption";
            this.Caption.Size = new System.Drawing.Size(130, 13);
            this.Caption.TabIndex = 6;
            this.Caption.Text = "By Dinith Wijeratne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(193, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "V1.0";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(440, 325);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Caption);
            this.Controls.Add(this.Title3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Long);
            this.Controls.Add(this.Lat);
            this.Controls.Add(this.LongText);
            this.Controls.Add(this.LatText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LatText;
        private System.Windows.Forms.TextBox LongText;
        private System.Windows.Forms.Label Lat;
        private System.Windows.Forms.Label Long;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Title3;
        private System.Windows.Forms.Label Caption;
        private System.Windows.Forms.Label label1;
    }
}