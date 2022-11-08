using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTextureLab
{
    internal class GLCM // Count of pair intensivity in int. For alghorithms needs double.
    {
        public int[,] IntensivityMatrix(Bitmap Image)
        {
            int[,] Intensivities = new int[Image.Width, Image.Height];
            for (int i = 0; i < Image.Width; i++)
                for(int j = 0; j < Image.Height; j++)
                    Intensivities[i, j] = Image.GetPixel(i, j).R;

            return Intensivities;
        }

        private int[,] ZerosMatrix(int a)
        {
            if (a < 1) return null;
            int[,] Zeros = new int[a, a];
            for (int i = 0; i < 255; i++)
                for (int j = 0; j < 255; j++)
                    Zeros[i, j] = 0;
            return Zeros;

        }

        public int[,] GhorizontalGLCM(int[,] Intensivities)
        {
            int[,] result = ZerosMatrix(255);            

            for (int i = 0;i< Intensivities.GetLength(0); i++)
                for (int j = 0;j < Intensivities.GetLength(1)-1; j++)
                {
                    result[Intensivities[i, j], Intensivities[i, j + 1]]++;
                }

            return result;
        }

        public int[,] VerticalGLCM(int[,] Intensivities)
        {
            int[,] result = ZerosMatrix(255);

            for (int i = 0; i < Intensivities.GetLength(0)-1; i++)
                for (int j = 0; j < Intensivities.GetLength(1); j++)
                {
                    result[Intensivities[i, j], Intensivities[i+ 1, j]]++;
                }

            return result;
        }

        public int[,] DiagonalGLCM(int[,] Intensivities)
        {
            int[,] result = ZerosMatrix(255);

            for (int i = 0; i < Intensivities.GetLength(0) - 1; i++)
                for (int j = 0; j < Intensivities.GetLength(1) - 1; j++)
                {
                    result[Intensivities[i, j], Intensivities[i + 1, j + 1]]++;
                }

            return result;
        }

    }
}
