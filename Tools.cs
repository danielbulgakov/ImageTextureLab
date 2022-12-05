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
        static public int Clamp(int a, int l, int r)
        {
            if (a > l && a < r) return a;
            return a > l ? r : l;
        }
        static public Bitmap Gray(Bitmap Image)
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

            //for (int i = 0; i < Image.Width; i++)
            //    for (int j = 0; j < Image.Height; j++)
            //    {
            //        int intensivity = imageC.GetPixel(i, j).R;
            //        intensivity = (int) ((intensivity - min) * 255 / (max - min));
            //        imageC.SetPixel(i, j, Color.FromArgb(intensivity, intensivity, intensivity)); //linear stretch
            //    }

            return imageC;
        }

        static public int[,] IntensivityMatrix(Bitmap Image)
        {
            int[,] Intensivities = new int[Image.Width, Image.Height];
            for (int i = 0; i < Image.Width; i++)
                for (int j = 0; j < Image.Height; j++)
                    Intensivities[i, j] = Image.GetPixel(i, j).R;

            return Intensivities;
        }

        static public int[,] ZerosMatrix(uint a)
        {
            if (a < 1) return null;
            int[,] Zeros = new int[a , a ];
            for (int i = 0; i < a; i++)
                for (int j = 0; j < a; j++)
                    Zeros[i, j] = 0;
            return Zeros;

        }

        static public int[,] MatrixPart(int[,] image, uint radius, uint x, uint y)
        {
            int[,] result = new int[Math.Min(x, radius) + 1 + Math.Min(radius, image.GetLength(0) - x-1), Math.Min(y, radius) + 1 + Math.Min(radius, image.GetLength(1) - y-1)];

            int i1 = 0, i2 = 0;

            for (int i = -(int)radius; i <= radius; i++)
            {
                
                for (int j = -(int)radius; j <= radius; j++)
                {
                    if (x + i >= 0 && x + i <= image.GetLength(0)-1 && y + j >= 0 && y + j <= image.GetLength(1) - 1)
                    {
                        result[i1, i2] = image[x + i, y + j];
                        i2++;
                    }
                }

                if (i2 != 0)
                {
                    i1++;
                    i2 = 0;
                }
            }

            return result;

        }

    }
}
