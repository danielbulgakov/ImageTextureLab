namespace ImageTextureLab
{
    partial class Form1
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
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gLSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лавсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разрастаниеРегионовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
=======
            this.хкиРегионовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> main
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.gLSMToolStripMenuItem,
            this.лавсToolStripMenuItem,
            this.разрастаниеРегионовToolStripMenuItem,
            this.отменаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // gLSMToolStripMenuItem
            // 
            this.gLSMToolStripMenuItem.Name = "gLSMToolStripMenuItem";
            this.gLSMToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.gLSMToolStripMenuItem.Text = "GLCM";
            // 
            // лавсToolStripMenuItem
            // 
            this.лавсToolStripMenuItem.Name = "лавсToolStripMenuItem";
            this.лавсToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.лавсToolStripMenuItem.Text = "Лавс";
            this.лавсToolStripMenuItem.Click += new System.EventHandler(this.лавсToolStripMenuItem_Click);
            // 
            // разрастаниеРегионовToolStripMenuItem
            // 
            this.разрастаниеРегионовToolStripMenuItem.Name = "разрастаниеРегионовToolStripMenuItem";
            this.разрастаниеРегионовToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.разрастаниеРегионовToolStripMenuItem.Text = "Разрастание регионов";
            this.разрастаниеРегионовToolStripMenuItem.Click += new System.EventHandler(this.разрастаниеРегионовToolStripMenuItem_Click);
            // 
            // отменаToolStripMenuItem
            // 
<<<<<<< HEAD
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.отменаToolStripMenuItem.Text = "Отмена";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.отменаToolStripMenuItem_Click);
=======
            this.хкиРегионовToolStripMenuItem.Name = "хкиРегионовToolStripMenuItem";
            this.хкиРегионовToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.хкиРегионовToolStripMenuItem.Text = "Х-ки регионов";
>>>>>>> main
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.отменаToolStripMenuItem.Text = "Отмена";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.отменаToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(687, 669);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(711, 712);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem gLSMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лавсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разрастаниеРегионовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
    }
}

