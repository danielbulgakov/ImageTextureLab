using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageTextureLab.OwnSolution
{
    public class Region
    {
        public int Id { get; set; }
        public List<Tuple<int, int>> PixelList { get; private set; }

        public Region(int id)
        {
            this.Id = id;
            PixelList = new List<Tuple<int, int>>();
        }

        public int GetSize() { return PixelList.Count; }

        public void AddRegion(Region reg) { PixelList.AddRange(reg.PixelList); }

        public void AddPixel(int x, int y)
        {
            PixelList.Add(new Tuple<int, int>(x, y));
        }

        public int Intensity(Bitmap image)
        {
            int sum = 0;
            foreach (var p in PixelList) 
            { 
                sum += Tools.ImageTools.GetBrightness(image.GetPixel(p.Item1, p.Item2)); 
            }
            return sum / PixelList.Count;
        }
    }

}