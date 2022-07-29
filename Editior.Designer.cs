
namespace CustomCourseGenerator
{
    partial class Editor
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
            this.LatTemp = new System.Windows.Forms.Label();
            this.LongTemp = new System.Windows.Forms.Label();
            this.Button12 = new System.Windows.Forms.Button();
            this.extBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpnBtn = new System.Windows.Forms.Button();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unlockEditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confrimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Previewer = new System.Windows.Forms.WebBrowser();
            this.Preview = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.DownBtn = new System.Windows.Forms.Button();
            this.LeftBtn = new System.Windows.Forms.Button();
            this.RightBtn = new System.Windows.Forms.Button();
            this.UpBtn = new System.Windows.Forms.Button();
            this.DialogBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LatTemp
            // 
            this.LatTemp.AutoSize = true;
            this.LatTemp.Font = new System.Drawing.Font("B612 Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatTemp.Location = new System.Drawing.Point(10, 32);
            this.LatTemp.Name = "LatTemp";
            this.LatTemp.Size = new System.Drawing.Size(24, 18);
            this.LatTemp.TabIndex = 0;
            this.LatTemp.Text = "- ";
            // 
            // LongTemp
            // 
            this.LongTemp.AutoSize = true;
            this.LongTemp.Font = new System.Drawing.Font("B612 Mono", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongTemp.Location = new System.Drawing.Point(13, 50);
            this.LongTemp.Name = "LongTemp";
            this.LongTemp.Size = new System.Drawing.Size(16, 18);
            this.LongTemp.TabIndex = 0;
            this.LongTemp.Text = "-";
            // 
            // Button12
            // 
            this.Button12.BackColor = System.Drawing.Color.White;
            this.Button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button12.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button12.Location = new System.Drawing.Point(8, 32);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(93, 37);
            this.Button12.TabIndex = 1;
            this.Button12.Text = "Grab";
            this.Button12.UseVisualStyleBackColor = false;
            this.Button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // extBtn
            // 
            this.extBtn.AutoEllipsis = true;
            this.extBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extBtn.Location = new System.Drawing.Point(323, 371);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(75, 23);
            this.extBtn.TabIndex = 3;
            this.extBtn.Text = "Export";
            this.extBtn.UseVisualStyleBackColor = true;
            this.extBtn.Click += new System.EventHandler(this.extBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.OpnBtn);
            this.panel1.Controls.Add(this.ClrBtn);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.extBtn);
            this.panel1.Location = new System.Drawing.Point(32, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 402);
            this.panel1.TabIndex = 4;
            // 
            // OpnBtn
            // 
            this.OpnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpnBtn.Location = new System.Drawing.Point(161, 371);
            this.OpnBtn.Name = "OpnBtn";
            this.OpnBtn.Size = new System.Drawing.Size(75, 23);
            this.OpnBtn.TabIndex = 7;
            this.OpnBtn.Text = "Open";
            this.OpnBtn.UseVisualStyleBackColor = true;
            this.OpnBtn.Click += new System.EventHandler(this.OpnBtn_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClrBtn.Location = new System.Drawing.Point(242, 371);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(75, 23);
            this.ClrBtn.TabIndex = 6;
            this.ClrBtn.Text = "Clear";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(385, 350);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Font = new System.Drawing.Font("Romantic", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1314, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unlockEditingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // unlockEditingToolStripMenuItem
            // 
            this.unlockEditingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.confrimToolStripMenuItem});
            this.unlockEditingToolStripMenuItem.Name = "unlockEditingToolStripMenuItem";
            this.unlockEditingToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.unlockEditingToolStripMenuItem.Text = "Unlock Editing";
            this.unlockEditingToolStripMenuItem.Click += new System.EventHandler(this.unlockEditingToolStripMenuItem_Click);
            // 
            // confrimToolStripMenuItem
            // 
            this.confrimToolStripMenuItem.Name = "confrimToolStripMenuItem";
            this.confrimToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.confrimToolStripMenuItem.Text = "Confrim";
            this.confrimToolStripMenuItem.Click += new System.EventHandler(this.confrimToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Previewer);
            this.panel2.Location = new System.Drawing.Point(514, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 402);
            this.panel2.TabIndex = 6;
            // 
            // Previewer
            // 
            this.Previewer.AllowWebBrowserDrop = false;
            this.Previewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Previewer.IsWebBrowserContextMenuEnabled = false;
            this.Previewer.Location = new System.Drawing.Point(0, 0);
            this.Previewer.MinimumSize = new System.Drawing.Size(20, 20);
            this.Previewer.Name = "Previewer";
            this.Previewer.ScriptErrorsSuppressed = true;
            this.Previewer.Size = new System.Drawing.Size(573, 402);
            this.Previewer.TabIndex = 0;
            // 
            // Preview
            // 
            this.Preview.AutoSize = true;
            this.Preview.Font = new System.Drawing.Font("Exo 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preview.Location = new System.Drawing.Point(536, 271);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(68, 24);
            this.Preview.TabIndex = 7;
            this.Preview.Text = "Preview";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Exo 2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(41, 271);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(92, 22);
            this.labelData.TabIndex = 8;
            this.labelData.Text = "Data Viewer";
            // 
            // DownBtn
            // 
            this.DownBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DownBtn.Location = new System.Drawing.Point(791, 206);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(75, 23);
            this.DownBtn.TabIndex = 9;
            this.DownBtn.Text = "Down";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.DownBtn_Click);
            // 
            // LeftBtn
            // 
            this.LeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LeftBtn.Location = new System.Drawing.Point(710, 177);
            this.LeftBtn.Name = "LeftBtn";
            this.LeftBtn.Size = new System.Drawing.Size(75, 23);
            this.LeftBtn.TabIndex = 10;
            this.LeftBtn.Text = "Left";
            this.LeftBtn.UseVisualStyleBackColor = true;
            this.LeftBtn.Click += new System.EventHandler(this.LeftBtn_Click);
            // 
            // RightBtn
            // 
            this.RightBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RightBtn.Location = new System.Drawing.Point(872, 177);
            this.RightBtn.Name = "RightBtn";
            this.RightBtn.Size = new System.Drawing.Size(75, 23);
            this.RightBtn.TabIndex = 11;
            this.RightBtn.Text = "Right";
            this.RightBtn.UseVisualStyleBackColor = true;
            this.RightBtn.Click += new System.EventHandler(this.RightBtn_Click);
            // 
            // UpBtn
            // 
            this.UpBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpBtn.Location = new System.Drawing.Point(791, 148);
            this.UpBtn.Name = "UpBtn";
            this.UpBtn.Size = new System.Drawing.Size(75, 23);
            this.UpBtn.TabIndex = 12;
            this.UpBtn.Text = "Up";
            this.UpBtn.UseVisualStyleBackColor = true;
            this.UpBtn.Click += new System.EventHandler(this.UpBtn_Click);
            // 
            // DialogBtn
            // 
            this.DialogBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DialogBtn.Location = new System.Drawing.Point(791, 177);
            this.DialogBtn.Name = "DialogBtn";
            this.DialogBtn.Size = new System.Drawing.Size(75, 23);
            this.DialogBtn.TabIndex = 13;
            this.DialogBtn.Text = "Mulit";
            this.DialogBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Button12);
            this.panel3.Controls.Add(this.LongTemp);
            this.panel3.Controls.Add(this.LatTemp);
            this.panel3.Location = new System.Drawing.Point(32, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 118);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitude and Longitude";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1314, 717);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DialogBtn);
            this.Controls.Add(this.UpBtn);
            this.Controls.Add(this.RightBtn);
            this.Controls.Add(this.LeftBtn);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LatTemp;
        private System.Windows.Forms.Label LongTemp;
        private System.Windows.Forms.Button Button12;
        private System.Windows.Forms.Button extBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button OpnBtn;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unlockEditingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confrimToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser Previewer;
        private System.Windows.Forms.Label Preview;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Button LeftBtn;
        private System.Windows.Forms.Button RightBtn;
        private System.Windows.Forms.Button UpBtn;
        private System.Windows.Forms.Button DialogBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}