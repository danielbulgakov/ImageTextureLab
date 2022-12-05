using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace ImageTextureLab.OwnSolution
{
    public class Region
    {
        public int Id { get; set; }
        public List<Tuple<int, int>> PixelList { get; private set; }
        public float IntensityVal = 1f;
        public Color color;
        private List<Color> allColors =  new List<Color>();
        private static Random rnd = new Random();
        
        public Region(int id)
        {
            GetAllColors();
            int num = rnd.Next(0, allColors.Count);
            this.Id = id;
            PixelList = new List<Tuple<int, int>>();
            color = allColors[num];
            
        }

        private List<Color> GetAllColors()
        {
      

            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                {
                    allColors.Add((Color)property.GetValue(null));
                }
            }

            return allColors;
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