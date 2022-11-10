
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
        public static int RegionPerimeter(Region r)
        {
            throw new NotImplementedException();
            var list = r.PixelList;
            list.Sort();

            bool isBorder = false;
            int borderCount = 0;
            

            return -1;
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