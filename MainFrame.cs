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

        private void контрастToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Radius = 3;
            Bitmap startimage = Tools.Gray(new Bitmap(pictureBox1.Image));
            int[,] image = Tools.IntensivityMatrix(startimage);

            float[,] resimagef = new float[image.GetLength(0), image.GetLength(1)];

            Bitmap resimage = new Bitmap(startimage);

            for (uint i = 0; i < resimagef.GetLength(0); i++)
                for (uint j = 0; j < resimagef.GetLength(1); j++)
                {
                    int[,] part = Tools.MatrixPart(image, (uint)Radius, i, j);
                    int[,] g = GLCM.DiagonalGLCM(part);
                    resimagef[i, j] = GLCM.Contrast(g, GLCM.CountPair(part.GetLength(0), part.GetLength(1), GLCM.GLCMType.Diagonal));
                }

            float min = resimagef[0, 0];
            float max = resimagef[0, 0];

            for (int i = 0; i < resimagef.GetLength(0); i++)
                for (int j = 0; j < resimagef.GetLength(1); j++)
                {
                    if (resimagef[i, j] > max) max = resimagef[i, j];
                    if (resimagef[i, j] < min) min = resimagef[i, j];
                }

            for (int i = 0; i < resimagef.GetLength(0); i++)
                for (int j = 0; j < resimagef.GetLength(1); j++)
                {
                    int intensivity = (int)((resimagef[i, j] - min) * 255 / (max - min));
                    resimage.SetPixel(i, j, Color.FromArgb(intensivity, intensivity, intensivity));
                }

            pictureBox1.Image = resimage;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void диагональнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aSMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Radius = 3;
            Bitmap startimage = Tools.Gray(new Bitmap(pictureBox1.Image));
            int[,] image = Tools.IntensivityMatrix(startimage);

            float[,] resimagef = new float[image.GetLength(0), image.GetLength(1)];

            Bitmap resimage = new Bitmap(startimage);

            for (uint i = 0; i < resimagef.GetLength(0); i++)
                for (uint j = 0; j < resimagef.GetLength(1); j++)
                {
                    int[,] part = Tools.MatrixPart(image, (uint)Radius, i, j);
                    int[,] g = GLCM.DiagonalGLCM(part);
                    resimagef[i, j] = GLCM.ASM(g, GLCM.CountPair(part.GetLength(0), part.GetLength(1), GLCM.GLCMType.Diagonal));
                }

            float min = resimagef[0, 0];
            float max = resimagef[0, 0];

            for (int i = 0; i < resimagef.GetLength(0); i++)
                for (int j = 0; j < resimagef.GetLength(1); j++)
                {
                    if (resimagef[i, j] > max) max = resimagef[i, j];
                    if (resimagef[i, j] < min) min = resimagef[i, j];
                }

            for (int i = 0; i < resimagef.GetLength(0); i++)
                for (int j = 0; j < resimagef.GetLength(1); j++)
                {
                    int intensivity = (int)((resimagef[i, j] - min) * 255 / (max - min));
                    resimage.SetPixel(i, j, Color.FromArgb(intensivity, intensivity, intensivity));
                }

            pictureBox1.Image = resimage;
        }

        private void кореляцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Radius = 3;
            Bitmap startimage = Tools.Gray(new Bitmap(pictureBox1.Image));
            int[,] image = Tools.IntensivityMatrix(startimage);

            float[,] resimagef = new float[image.GetLength(0), image.GetLength(1)];

            Bitmap resimage = new Bitmap(startimage);

            for (uint i = 0; i < resimagef.GetLength(0); i++)
                for (uint j = 0; j < resimagef.GetLength(1); j++)
                {
                    int[,] part = Tools.MatrixPart(image, (uint)Radius, i, j);
                    int[,] g = GLCM.DiagonalGLCM(part);
                    resimagef[i, j] = GLCM.Correlation(g, GLCM.CountPair(part.GetLength(0), part.GetLength(1), GLCM.GLCMType.Diagonal));
                }

            float min = resimagef[0, 0];
            float max = resimagef[0, 0];

            for (int i = 0; i < resimagef.GetLength(0); i++)
                for (int j = 0; j < resimagef.GetLength(1); j++)
                {
                    if (resimagef[i, j] > max) max = resimagef[i, j];
                    if (resimagef[i, j] < min) min = resimagef[i, j];
                }

            for (int i = 0; i < resimagef.GetLength(0); i++)
                for (int j = 0; j < resimagef.GetLength(1); j++)
                {
                    
                    
                        int intensivity = (int)((resimagef[i, j] - min) * 255 / (max - min));
                        resimage.SetPixel(i, j, Color.FromArgb(intensivity, intensivity, intensivity));
                    
                }

            pictureBox1.Image = resimage;
        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Radius = 3;
            Bitmap startimage = Tools.Gray(new Bitmap(pictureBox1.Image));
            int[,] image = Tools.IntensivityMatrix(startimage);

            float[,] resimagef = new float[image.GetLength(0), image.GetLength(1)];

            Bitmap resimage = new Bitmap(startimage);

            for (uint i = 0; i < resimagef.GetLength(0); i++)
                for (uint j = 0; j < resimagef.GetLength(1); j++)
                {
                    int[,] part = Tools.MatrixPart(image, (uint)Radius, i, j);
                    int[,] g = GLCM.DiagonalGLCM(part);
                    Tuple<float,float> tmp = GLCM.Mean(g, GLCM.CountPair(part.GetLength(0), part.GetLength(1), GLCM.GLCMType.Diagonal));
                    resimagef[i, j] = tmp.Item1 + tmp.Item2;
                }

            float min = resimagef[0, 0];
            float max = resimagef[0, 0];

            for (int i = 0; i < resimagef.GetLength(0); i++)
                for (int j = 0; j < resimagef.GetLength(1); j++)
                {
                    if (resimagef[i, j] > max) max = resimagef[i, j];
                    if (resimagef[i, j] < min) min = resimagef[i, j];
                }

            for (int i = 0; i < resimagef.GetLength(0); i++)
                for (int j = 0; j < resimagef.GetLength(1); j++)
                {
                    int intensivity = (int)((resimagef[i, j] - min) * 255 / (max - min));
                    resimage.SetPixel(i, j, Color.FromArgb(intensivity, intensivity, intensivity));
                }

            pictureBox1.Image = resimage;
        }

        private void variancToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Radius = 3;
            Bitmap startimage = Tools.Gray(new Bitmap(pictureBox1.Image));
            int[,] image = Tools.IntensivityMatrix(startimage);

            float[,] resimagef = new float[image.GetLength(0), image.GetLength(1)];

            Bitmap resimage = new Bitmap(startimage);

            for (uint i = 0; i < resimagef.GetLength(0); i++)
                for (uint j = 0; j < resimagef.GetLength(1); j++)
                {
                    int[,] part = Tools.MatrixPart(image, (uint)Radius, i, j);
                    int[,] g = GLCM.DiagonalGLCM(part);
                    Tuple<float, float> tmp = GLCM.Mean(g, GLCM.CountPair(part.GetLength(0), part.GetLength(1), GLCM.GLCMType.Diagonal));
                    Tuple<float, float> tmp2 = GLCM.Variance2(g, GLCM.CountPair(part.GetLength(0), part.GetLength(1), GLCM.GLCMType.Diagonal), tmp);
                    resimagef[i, j] = tmp2.Item1 + tmp2.Item2;
                }

            float min = resimagef[0, 0];
            float max = resimagef[0, 0];

            for (int i = 0; i < resimagef.GetLength(0); i++)
                for (int j = 0; j < resimagef.GetLength(1); j++)
                {
                    if (resimagef[i, j] > max) max = resimagef[i, j];
                    if (resimagef[i, j] < min) min = resimagef[i, j];
                }

            for (int i = 0; i < resimagef.GetLength(0); i++)
                for (int j = 0; j < resimagef.GetLength(1); j++)
                {
                    int intensivity = (int)((resimagef[i, j] - min) * 255 / (max - min));
                    resimage.SetPixel(i, j, Color.FromArgb(intensivity, intensivity, intensivity));
                }

            pictureBox1.Image = resimage;
        }
    }
    
}
