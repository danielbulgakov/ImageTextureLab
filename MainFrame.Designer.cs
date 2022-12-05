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
            this.хкиРегионовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.вертикальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрастToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кореляцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрастToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aSMToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.кореляцияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.диагональнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрастToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aSMToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.кореляцияToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.meanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variancToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.хкиРегионовToolStripMenuItem});
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
            this.gLSMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вертикальнаяToolStripMenuItem,
            this.горизонтальнаяToolStripMenuItem,
            this.диагональнаяToolStripMenuItem});
            this.gLSMToolStripMenuItem.Name = "gLSMToolStripMenuItem";
            this.gLSMToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.gLSMToolStripMenuItem.Text = "GLCM";
            // 
            // лавсToolStripMenuItem
            // 
            this.лавсToolStripMenuItem.Name = "лавсToolStripMenuItem";
            this.лавсToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.лавсToolStripMenuItem.Text = "Лавс";
            // 
            // разрастаниеРегионовToolStripMenuItem
            // 
            this.разрастаниеРегионовToolStripMenuItem.Name = "разрастаниеРегионовToolStripMenuItem";
            this.разрастаниеРегионовToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.разрастаниеРегионовToolStripMenuItem.Text = "Разрастание регионов";
            // 
            // хкиРегионовToolStripMenuItem
            // 
            this.хкиРегионовToolStripMenuItem.Name = "хкиРегионовToolStripMenuItem";
            this.хкиРегионовToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.хкиРегионовToolStripMenuItem.Text = "Х-ки регионов";
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
            // вертикальнаяToolStripMenuItem
            // 
            this.вертикальнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрастToolStripMenuItem,
            this.aSMToolStripMenuItem,
            this.кореляцияToolStripMenuItem,
            this.meanToolStripMenuItem,
            this.variancToolStripMenuItem});
            this.вертикальнаяToolStripMenuItem.Name = "вертикальнаяToolStripMenuItem";
            this.вертикальнаяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вертикальнаяToolStripMenuItem.Text = "Диагональная";
            // 
            // горизонтальнаяToolStripMenuItem
            // 
            this.горизонтальнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрастToolStripMenuItem1,
            this.aSMToolStripMenuItem1,
            this.кореляцияToolStripMenuItem1});
            this.горизонтальнаяToolStripMenuItem.Name = "горизонтальнаяToolStripMenuItem";
            this.горизонтальнаяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.горизонтальнаяToolStripMenuItem.Text = "Горизонтальная";
            // 
            // контрастToolStripMenuItem
            // 
            this.контрастToolStripMenuItem.Name = "контрастToolStripMenuItem";
            this.контрастToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.контрастToolStripMenuItem.Text = "Контраст";
            this.контрастToolStripMenuItem.Click += new System.EventHandler(this.контрастToolStripMenuItem_Click);
            // 
            // aSMToolStripMenuItem
            // 
            this.aSMToolStripMenuItem.Name = "aSMToolStripMenuItem";
            this.aSMToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aSMToolStripMenuItem.Text = "ASM";
            this.aSMToolStripMenuItem.Click += new System.EventHandler(this.aSMToolStripMenuItem_Click);
            // 
            // кореляцияToolStripMenuItem
            // 
            this.кореляцияToolStripMenuItem.Name = "кореляцияToolStripMenuItem";
            this.кореляцияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.кореляцияToolStripMenuItem.Text = "Кореляция";
            this.кореляцияToolStripMenuItem.Click += new System.EventHandler(this.кореляцияToolStripMenuItem_Click);
            // 
            // контрастToolStripMenuItem1
            // 
            this.контрастToolStripMenuItem1.Name = "контрастToolStripMenuItem1";
            this.контрастToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.контрастToolStripMenuItem1.Text = "Контраст";
            // 
            // aSMToolStripMenuItem1
            // 
            this.aSMToolStripMenuItem1.Name = "aSMToolStripMenuItem1";
            this.aSMToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aSMToolStripMenuItem1.Text = "ASM";
            // 
            // кореляцияToolStripMenuItem1
            // 
            this.кореляцияToolStripMenuItem1.Name = "кореляцияToolStripMenuItem1";
            this.кореляцияToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.кореляцияToolStripMenuItem1.Text = "Кореляция";
            // 
            // диагональнаяToolStripMenuItem
            // 
            this.диагональнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контрастToolStripMenuItem2,
            this.aSMToolStripMenuItem2,
            this.кореляцияToolStripMenuItem2});
            this.диагональнаяToolStripMenuItem.Name = "диагональнаяToolStripMenuItem";
            this.диагональнаяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.диагональнаяToolStripMenuItem.Text = "Вертикальная";
            this.диагональнаяToolStripMenuItem.Click += new System.EventHandler(this.диагональнаяToolStripMenuItem_Click);
            // 
            // контрастToolStripMenuItem2
            // 
            this.контрастToolStripMenuItem2.Name = "контрастToolStripMenuItem2";
            this.контрастToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.контрастToolStripMenuItem2.Text = "Контраст";
            // 
            // aSMToolStripMenuItem2
            // 
            this.aSMToolStripMenuItem2.Name = "aSMToolStripMenuItem2";
            this.aSMToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.aSMToolStripMenuItem2.Text = "ASM";
            // 
            // кореляцияToolStripMenuItem2
            // 
            this.кореляцияToolStripMenuItem2.Name = "кореляцияToolStripMenuItem2";
            this.кореляцияToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.кореляцияToolStripMenuItem2.Text = "Кореляция";
            // 
            // meanToolStripMenuItem
            // 
            this.meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            this.meanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.meanToolStripMenuItem.Text = "Mean";
            this.meanToolStripMenuItem.Click += new System.EventHandler(this.meanToolStripMenuItem_Click);
            // 
            // variancToolStripMenuItem
            // 
            this.variancToolStripMenuItem.Name = "variancToolStripMenuItem";
            this.variancToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.variancToolStripMenuItem.Text = "Varianc";
            this.variancToolStripMenuItem.Click += new System.EventHandler(this.variancToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem хкиРегионовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрастToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кореляцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрастToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aSMToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem кореляцияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem диагональнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрастToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aSMToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem кореляцияToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem meanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variancToolStripMenuItem;
    }
}

