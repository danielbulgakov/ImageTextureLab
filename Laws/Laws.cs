using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageTextureLab.Laws
{
    internal class Laws
    {
        private int[,] mult(int[] v1, int[] v2)
        {
            int[,] m = new int[5, 5];

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    m[i, j] = 0;

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    m[i, j] += v1[i] * v2[j];
            return m;
        }

        private Bitmap GetFilter(Bitmap sourceImage, int[,] kernel)
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap resImage = new Bitmap(width, height);

            for (int y = 0; y < sourceImage.Height; y++)
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    int radiusX = kernel.GetLength(0) / 2;
                    int radiusY = kernel.GetLength(1) / 2;
                    float resultR = 0, resultG = 0, resultB = 0;

                    for (int l = -radiusY; l <= radiusY; l++)
                        for (int k = -radiusX; k <= radiusX; k++)
                        {
                            int idX = clamp(x + k, 0, sourceImage.Width - 1);
                            int idY = clamp(y + l, 0, sourceImage.Height - 1);
                            Color neighborColor = sourceImage.GetPixel(idX, idY);
                            resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
                            resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
                            resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
                        }
                    resImage.SetPixel(x, y, Color.FromArgb(clamp((int)resultR, 0, 255),
                                         clamp((int)resultG, 0, 255),
                                         clamp((int)resultB, 0, 255)));
                }
            return resImage;
        }

        public Bitmap[] CalculateLaws(Bitmap sourceImage)
        {
            int width = sourceImage.Width;
            int height = sourceImage.Height;
            Bitmap resImage = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    int lm;
                    int s = 0, c = 0;
                    int radius = 7;
                    for (int l = -radius; l <= radius; l++)
                        for (int k = -radius; k <= radius; k++)
                        {
                            int idX = clamp(x + k, 0, sourceImage.Width - 1);
                            int idY = clamp(y + l, 0, sourceImage.Height - 1);

                            s += GetBrightness(sourceImage.GetPixel(idX, idY));
                            c++;
                        }
                    lm = clamp(s / c, 0, 255);
                    byte t = GetBrightness(sourceImage.GetPixel(x, y));
                    int res = clamp(t - lm, 0, 255);
                    Color color = Color.FromArgb(res, res, res);
                    resImage.SetPixel(x, y, color);
                }
            int[] L = { 1, 4, 6, 4, 1 };
            int[] E = { -1, -2, 0, 2, 1 };
            int[] S = { -1, 0, 2, 0, -1 };
            int[] R = { 1, -4, 6, -4, 1 };

            int[][] m = { L, E, S, R };
            int[,] mask;
            Bitmap[] result = { };
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    mask = mult(m[i], m[j]);
                    Bitmap Fk = GetFilter(resImage, mask);
                    result.Append(Fk);
                }

            return result;
        }

        public static byte clamp(float value, float min, float max)
        {
            return (byte)(Math.Min(Math.Max(min, value), max));
        }

        public static int clamp(int value, int min, int max)
        {
            return (int)(Math.Min(Math.Max(min, value), max));
        }

        private static byte GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
    }
}
