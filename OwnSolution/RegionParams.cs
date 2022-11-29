
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageTextureLab.OwnSolution
{
    
    public class RegionParams
    {
        // not tested yet.
        public static int RegionSquare(Region r)
        {
            return r.PixelList.Count;
        }

        // not tested yet.
        // является медленной версией т.к. постоянное обращается для поиска в лист
        // для ускоренитя можно создать матрицу по точкам региона.
        public static int RegionPerimeter(Region r)
        {
            int perimeter = 0;

            for (int i = 0; i < r.PixelList.Count; i++)
            {
                perimeter += pixelneighbourCount(r, i) < 4 ? 1 : 0 ;
            }

            return perimeter;
        }
        private static int pixelneighbourCount(Region r, int regListInd)
        {
            int count = 0;

            var watchingPixel = r.PixelList[regListInd];

            if (r.PixelList.Find(p => p.Item1 == watchingPixel.Item1 - 1 && p.Item2 == watchingPixel.Item2) != null) count++;
            if (r.PixelList.Find(p => p.Item2 == watchingPixel.Item2 - 1 && p.Item1 == watchingPixel.Item1) != null) count++;
            if (r.PixelList.Find(p => p.Item1 == watchingPixel.Item1 + 1 && p.Item2 == watchingPixel.Item2) != null) count++;
            if (r.PixelList.Find(p => p.Item2 == watchingPixel.Item2 + 1 && p.Item1 == watchingPixel.Item1) != null) count++;

            return count;
        }

        public static int RegionDiscreteMomentum(Region r, int x, int y, Bitmap image)
        {
            int momentum = 0;

            foreach (var pix in r.PixelList)
            {
                momentum += (int)Math.Pow(pix.Item1, x) *
                            (int)Math.Pow(pix.Item2, y) *
                            Tools.ImageTools.GetBrightness(image.GetPixel(x ,y));

            }

            return momentum;
        }
        
        
    }
}