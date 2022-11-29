using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageTextureLab.OwnSolution
{
    public class Region
    {
        public int Id { get; set; }
        public List<Tuple<int, int>> PixelList { get; private set; }
        public float IntensityVal = 1f;

        public Region(int id)
        {
            this.Id = id;
            PixelList = new List<Tuple<int, int>>();
        }

        public int GetSize() { return PixelList.Count; }

        public void AddRegion(Region reg) 
        {
            this.IntensityVal = (this.IntensityVal * PixelList.Count + reg.IntensityVal * reg.PixelList.Count ) /
                                (reg.PixelList.Count + PixelList.Count);      
            PixelList.AddRange(reg.PixelList);
        }

        public void AddPixel(int x, int y, Bitmap image)
        {
            PixelList.Add(new Tuple<int, int>(x, y));
            addIntensity(x, y, image);
        }

        public float Intensity()
        {
            return IntensityVal;
        }

        private void addIntensity(int x, int y, Bitmap image)
        {
            this.IntensityVal = (this.IntensityVal * (PixelList.Count - 1) +
                Tools.ImageTools.GetBrightness(image.GetPixel(x, y))) / PixelList.Count;
        }
    }

}