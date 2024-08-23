namespace BT2_1
{
    partial class frmChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lêHữuThịnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiBai4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lêHữuThịnhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lêHữuThịnhToolStripMenuItem
            // 
            this.lêHữuThịnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiBai1,
            this.TsmiBai2,
            this.TsmiBai3,
            this.TsmiBai4});
            this.lêHữuThịnhToolStripMenuItem.Name = "lêHữuThịnhToolStripMenuItem";
            this.lêHữuThịnhToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.lêHữuThịnhToolStripMenuItem.Text = "Lê Hữu Thịnh";
            // 
            // TsmiBai1
            // 
            this.TsmiBai1.Image = global::BT2_1.Properties.Resources.Note1;
            this.TsmiBai1.Name = "TsmiBai1";
            this.TsmiBai1.Size = new System.Drawing.Size(180, 22);
            this.TsmiBai1.Text = "Bài 1";
            this.TsmiBai1.Click += new System.EventHandler(this.TsmiBai1_Click);
            // 
            // TsmiBai2
            // 
            this.TsmiBai2.Image = global::BT2_1.Properties.Resources.Note2;
            this.TsmiBai2.Name = "TsmiBai2";
            this.TsmiBai2.Size = new System.Drawing.Size(180, 22);
            this.TsmiBai2.Text = "Bài 2";
            this.TsmiBai2.Click += new System.EventHandler(this.TsmiBai2_Click);
            // 
            // TsmiBai3
            // 
            this.TsmiBai3.Image = global::BT2_1.Properties.Resources.Note3;
            this.TsmiBai3.Name = "TsmiBai3";
            this.TsmiBai3.Size = new System.Drawing.Size(180, 22);
            this.TsmiBai3.Text = "Bài 3";
            this.TsmiBai3.Click += new System.EventHandler(this.TsmiBai3_Click);
            // 
            // TsmiBai4
            // 
            this.TsmiBai4.Image = global::BT2_1.Properties.Resources.Car2;
            this.TsmiBai4.Name = "TsmiBai4";
            this.TsmiBai4.Size = new System.Drawing.Size(180, 22);
            this.TsmiBai4.Text = "Bài 4";
            this.TsmiBai4.Click += new System.EventHandler(this.TsmiBai4_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lêHữuThịnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsmiBai1;
        private System.Windows.Forms.ToolStripMenuItem TsmiBai2;
        private System.Windows.Forms.ToolStripMenuItem TsmiBai3;
        private System.Windows.Forms.ToolStripMenuItem TsmiBai4;
    }
}

