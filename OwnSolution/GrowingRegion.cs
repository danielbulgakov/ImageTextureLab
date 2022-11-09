using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTextureLab.OwnSolution.GrowingRegion
{
    internal class RegionMap
    {
        private List<Region> regionList;
        private Bitmap sourceImage;
        private int [, ] imageMask;
        private int regionCounter = 0;
        
        public RegionMap(Bitmap image)
        {
            sourceImage = image;
            regionList = new List<Region>();
            imageMask = new int[image.Width, image.Height];
        }

        public void AddNewRegion(int x, int y)
        {
            int id = ++regionCounter;
            var reg = new Region(id);

            imageMask[x, y] = id;
            reg.AddPixel(x, y);
            regionList.Add(reg);
        }

        public void AddToRegion(int x, int y, Region reg)
        {
            imageMask[x, y] = reg.id;
            reg.AddPixel(x, y);
        }

        public Region GetRegion(int x, int y)
        {
            int id = imageMask[x, y];
            return regionList.Find(r => r.id == id);
        }

        public int GetIntensity(int x, int y)
        {
            int id = imageMask[x, y];
            var reg = regionList.Find(r => r.id == id);
            

            return reg.Intensity(sourceImage);

        }

        public void MergeRegions(Region reg1, Region reg2)
        {
            if (reg1 == reg2) return;
            if (reg1.GetSize() < reg2.GetSize())
            {
                reg2.AddRegion(reg1);
                foreach (var pix in reg1.pixelList)
                {
                    imageMask[pix.Item1, pix.Item2] = reg2.id;
                }
                regionList.Remove(reg1);
            }
            else
            {
                reg1.AddRegion(reg2);
                foreach (var pix in reg2.pixelList)
                {
                    imageMask[pix.Item1, pix.Item2] = reg1.id;
                }
                regionList.Remove(reg2);
            }
        }

        public void Print()
        {
            Console.WriteLine();
            Console.Write("{{{{");
            for (int i = 0; i < sourceImage.Height; i++)
            {

                for (int j = 0; j < sourceImage.Width; j++)
                {
                    Console.Write(imageMask[j, i] + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("}}}}");
            //Console.WriteLine();
            //Console.Write("^^^^");
            //for (int i = 0; i < sourceImage.Height; i++)
            //{

            //    for (int j = 0; j < sourceImage.Width; j++)
            //    {
            //        Console.Write(GetIntensity(j, i) + ", ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("^^^^");

        }


    }

    internal class Region
    {
        public int id { get; set; }
        public List<Tuple<int, int>> pixelList { get; private set; }

        public Region(int id)
        {
            this.id = id;
            pixelList = new List<Tuple<int, int>>();
        }

        public int GetSize() { return pixelList.Count; }

        public void AddRegion(Region reg) { pixelList.AddRange(reg.pixelList); }

        public void AddPixel(int x, int y)
        {
            pixelList.Add(new Tuple<int, int>(x, y));
        }

        public int Intensity(Bitmap image)
        {
            int sum = 0;
            foreach (var p in pixelList) 
            { 
                sum += Tools.ImageTools.GetBrightness(image.GetPixel(p.Item1, p.Item2)); 
            }
            return sum / pixelList.Count;
        }
    }

    internal class GrowingRegion
    {

        public Bitmap Compute(Bitmap image, int threshold = 8)
        {
            Bitmap resImage = new Bitmap(image.Width, image.Height);
            RegionMap regionMap = ComputeMask(image, threshold);
            return ComputeImage(resImage, regionMap);
        }

        private Bitmap ComputeImage(Bitmap image, RegionMap map)
        {
            map.Print();
            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    image.SetPixel(x, y, Color.FromArgb(map.GetIntensity(x, y),
                                   map.GetIntensity(x, y), map.GetIntensity(x, y)));

                }
            map.Print();
            
            return image;
        }

        private RegionMap ComputeMask(Bitmap image, int thr)
        {
            RegionMap map = new RegionMap(image);

            for (int y = 0; y < image.Height; y++)
                for (int x = 0; x < image.Width; x++)
                {
                    int pixI = Tools.ImageTools.GetBrightness(image.GetPixel(x, y));
                    int difX = 0, difY = 0, difXY = 0;
                    int ofX = x - 1, ofY = y - 1; 

                    if (x > 0) difX = Math.Abs(pixI - map.GetIntensity(ofX, y));
                    if (y > 0) difY = Math.Abs(pixI - map.GetIntensity(x, ofY));
                    if (x > 0 && y > 0) difXY = Math.Abs(difX - difY);

                    if (x == 0 && y == 0)
                    {
                        map.AddNewRegion(x, y);
                        continue;
                    }
                    if (x == 0)
                    {
                        if (Math.Abs(pixI - map.GetIntensity(x, ofY)) < thr) 
                            map.AddToRegion(x, y, map.GetRegion(x, ofY));
                        else map.AddNewRegion(x, y);
                        continue;
                    }
                    if (y == 0)
                    {
                        if (Math.Abs(pixI - map.GetIntensity(ofX, y)) < thr) 
                            map.AddToRegion(x, y, map.GetRegion(ofX, y));
                        else map.AddNewRegion(x, y);
                        continue;
                    }

                    if (difX > thr && difY > thr) map.AddNewRegion(x, y);
                    if (difX <= thr != difY <= thr)
                    {
                        if (difX <= thr) map.AddToRegion(x, y, map.GetRegion(ofX, y));
                        else map.AddToRegion(x, y, map.GetRegion(x, ofY));
                    }
                    if (difX <= thr && difY <= thr)
                    {
                        if (difXY <= thr)
                        {
                            map.AddToRegion(x, y, map.GetRegion(ofX, y));
                            map.MergeRegions(map.GetRegion(ofX, y), map.GetRegion(x, ofY));
                        }
                        else
                        {
                            if (Math.Abs(map.GetIntensity(ofX, y) - thr) <
                                Math.Abs(map.GetIntensity(x, ofY) - thr)) 
                                map.AddToRegion(x, y, map.GetRegion(ofX, y));
                            else map.AddToRegion(x, y, map.GetRegion(x, ofY));
                        }
                    }
                    

                }

            return map;
        }
    }

}
