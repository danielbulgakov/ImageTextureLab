using ImageTextureLab.OwnSolution;
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
        Bitmap prevImage;

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

        private bool ImageIsNull()
        {
            if (pictureBox1.Image == null) MessageBox.Show("Загрузите фото.", "Ошибка!");
            return pictureBox1.Image == null;
        }

        private void разрастаниеРегионовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImageIsNull()) return;
            prevImage = new Bitmap(pictureBox1.Image);
            Cursor.Current = Cursors.WaitCursor;
            var g = new GrowingRegion();
            this.pictureBox1.Image = g.Compute((Bitmap)pictureBox1.Image);
            Cursor.Current = Cursors.Default;
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImageIsNull()) return;
            this.pictureBox1.Image = prevImage;
        }
    }
}
