using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTextureLab.Tools
{
    internal class ImageTools
    {
        public static int[] GetHistogramArray(Bitmap image)
        {
            int[] hist = new int[256];

            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    Color color = image.GetPixel(x, y);
                    hist[color.R]++;
                }
            return hist;
        }

        public static Bitmap GrayScaleImage(Bitmap sourceImage)
        {
            Bitmap resImage = sourceImage;

            int width = resImage.Width;
            int height = resImage.Height;

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    Color color = resImage.GetPixel(x, y);
                    byte gray = (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
                    resImage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }

            return resImage;
        }

        public static byte ClampByte(float value, float min, float max)
        {
            return (byte)(Math.Min(Math.Max(min, value), max));
        }

        public static int ClampInt(float value, float min, float max)
        {
            return (int)(Math.Min(Math.Max(min, value), max));
        }

        public static byte GetBrightness(Color color)
        {
            return (byte)(.299 * color.R + .587 * color.G + .114 * color.B);
        }
    }
}
