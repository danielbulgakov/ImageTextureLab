using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTextureLab
{
    internal class Tools
    {
        public int Clamp(int a, int l, int r)
        {
            if (a > l && a < r) return a;
            return a > l ? r : l;
        }
        public Bitmap Gray(Bitmap Image)
        {
            int max = 0, min = 255;
            Bitmap imageC = new Bitmap(Image.Width, Image.Height);

            for (int i = 0; i < Image.Width; i++)
                for (int j = 0; j < Image.Height; j++)
                {
                    Color color = Image.GetPixel(i, j);
                    int x = (int)(color.R * 0.299 + color.G*0.587 + color.B* 0.114);
                    if(x > max) max = x;
                    if (x < min) min = x;
                    imageC.SetPixel(i, j, Color.FromArgb(x,x,x));   // To grey
                }

            for (int i = 0; i < Image.Width; i++)
                for (int j = 0; j < Image.Height; j++)
                {
                    int intensivity = imageC.GetPixel(i, j).R;
                    intensivity = (int) ((intensivity - min) * 255 / (max - min));
                    imageC.SetPixel(i, j, Color.FromArgb(intensivity, intensivity, intensivity)); //linear stretch
                }

            return imageC;
        }

    }
}
