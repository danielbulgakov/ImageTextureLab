using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTextureLab
{
    public partial class Form1 : Form
    {
        Bitmap image;

        public Form1()
        {
            InitializeComponent();
            int[,] a = new int[4, 4]{{ 0, 0,1,1},
                                     { 0,0,1,1},
                                     { 0,2,2,2},
                                     { 2,2,3,3}};
            int[,] resGh = new GLCM().GhorizontalGLCM(a);
            int[,] resVe = new GLCM().VerticalGLCM(a);
            int[,] resD = new GLCM().DiagonalGLCM(a);
            int c = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string imagePath;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "image files|*.jpg;*.png";
            dialog.Title = "Open an Image File.";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName;
                image = new Bitmap(imagePath);
                this.pictureBox1.Image = new Bitmap(imagePath);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
