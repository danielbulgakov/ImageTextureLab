using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageTextureLab.OwnSolution
{
    internal class RegionMap
    {
        private readonly List<Region> _regionList;
        private readonly Bitmap _sourceImage;
        private readonly int [, ] _imageMask;
        private int _regionCounter;
        
        public RegionMap(Bitmap image)
        {
            _sourceImage = image;
            _regionList = new List<Region>();
            _imageMask = new int[image.Width, image.Height];
            _regionCounter = 0;
        }

        public void AddNewRegion(int x, int y)
        {
            int id = ++_regionCounter;
            Region reg = new Region(id);

            _imageMask[x, y] = id;
            reg.AddPixel(x, y, _sourceImage);
            _regionList.Add(reg);
        }

        public void AddToRegion(int x, int y, Region reg)
        {
            _imageMask[x, y] = reg.Id;
            reg.AddPixel(x, y, _sourceImage);
        }

        public Region GetRegion(int x, int y)
        {
            int id = _imageMask[x, y];
            return _regionList.Find(r => r.Id == id);
        }

        public float GetIntensity(int x, int y)
        {
            int id = _imageMask[x, y];
            var reg = _regionList.Find(r => r.Id == id);
            

            return reg.Intensity();

        }

        public Color GetColor(int x, int y)
        {
            int id = _imageMask[x, y];
            var reg = _regionList.Find(r => r.Id == id);


            return reg.color;
        }

        public void MergeRegions(Region reg1, Region reg2)
        {
            if (reg1 == reg2) return;
            if (reg1.GetSize() < reg2.GetSize())
            {
                reg2.AddRegion(reg1);
                foreach (var pix in reg1.PixelList)
                {
                    _imageMask[pix.Item1, pix.Item2] = reg2.Id;
                }
                _regionList.Remove(reg1);
            }
            else
            {
                reg1.AddRegion(reg2);
                foreach (var pix in reg2.PixelList)
                {
                    _imageMask[pix.Item1, pix.Item2] = reg1.Id;
                }
                _regionList.Remove(reg2);
            }
        }

        public void Print()
        {
            Console.WriteLine();
            Console.Write(@"{{{{");
            for (int i = 0; i < _sourceImage.Height; i++)
            {

                for (int j = 0; j < _sourceImage.Width; j++)
                {
                    Console.Write(_imageMask[j, i] + @", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(@"}}}}");


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
                    image.SetPixel(x, y, map.GetColor(x,y));

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
                    int difX = 0, difY = 0, difXy = 0;
                    int ofX = x - 1, ofY = y - 1; 

                    if (x > 0) difX = Math.Abs(pixI - (int)map.GetIntensity(ofX, y));
                    if (y > 0) difY = Math.Abs(pixI - (int)map.GetIntensity(x, ofY));
                    if (x > 0 && y > 0) difXy = Math.Abs(difX - difY);

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
                        if (difXy <= thr)
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
