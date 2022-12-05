
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageTextureLab.OwnSolution
{
    
    public class RegionParams
    {
        public static int RegionSquare(Region r)
        {
            return r.PixelList.Count;
        }

        public static int RegionPerimeter(Region r)
        {
            int perimeter = 0;

            for (int i = 0; i < r.PixelList.Count; i++)
            {
                perimeter += (4 - pixelneighbourCount(r, i));
            }

            return perimeter;
        }
        private static int pixelneighbourCount(Region r, int regListInd)
        {
            int count = 0;

            var watchingPixel = r.PixelList[regListInd];

            if (r.PixelList.Find(p => p.Item1 == watchingPixel.Item1 - 1) != null) count++;
            else if (r.PixelList.Find(p => p.Item2 == watchingPixel.Item2 - 1) != null) count++;
            else if (r.PixelList.Find(p => p.Item1 == watchingPixel.Item1 + 1) != null) count++;
            else if (r.PixelList.Find(p => p.Item2 == watchingPixel.Item2 + 1) != null) count++;

            return count;
        }

        public static int RegionDiscreteMomentum(Region r, int x, int y, Bitmap image)
        {
            int momentum = 0;

            foreach (var pix in r.PixelList)
            {
                int k = 0;
                int br = Tools.ImageTools.GetBrightness(image.GetPixel(pix.Item1, pix.Item2));
                if (br < 10) k = 1;
                momentum += (int)Math.Pow(pix.Item1, x) *
                            (int)Math.Pow(pix.Item2, y) *
                            k;

            }

            return momentum;
        }
        
        
    }
}