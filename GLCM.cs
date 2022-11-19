using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTextureLab
{
    internal class GLCM // Count of pair intensivity in int. For alghorithms needs double.
    {
        public enum  GLCMType
        {
            Ghorizontal,
            Vertical,
            Diagonal 

        }
        public int CountPair(int weight, int height,GLCMType type)
        {
            switch (type){

                case GLCMType.Ghorizontal:
                    return (weight-1)*height;
                case GLCMType.Vertical:
                    return weight*(height-1);
                case GLCMType.Diagonal:
                    return (weight-1)*(height-1);
                default:
                    return -1;
            }
        }
        public int[,] GhorizontalGLCM(int[,] Intensivities)
        {
            int[,] result = Tools.ZerosMatrix(255);            

            for (int i = 0;i< Intensivities.GetLength(0); i++)
                for (int j = 0;j < Intensivities.GetLength(1)-1; j++)
                {
                    result[Intensivities[i, j], Intensivities[i, j + 1]]++;
                }

            return result;
        }

        public int[,] VerticalGLCM(int[,] Intensivities)
        {
            int[,] result = Tools.ZerosMatrix(255);

            for (int i = 0; i < Intensivities.GetLength(0)-1; i++)
                for (int j = 0; j < Intensivities.GetLength(1); j++)
                {
                    result[Intensivities[i, j], Intensivities[i+ 1, j]]++;
                }

            return result;
        }

        public int[,] DiagonalGLCM(int[,] Intensivities)
        {
            int[,] result = Tools.ZerosMatrix(255);

            for (int i = 0; i < Intensivities.GetLength(0) - 1; i++)
                for (int j = 0; j < Intensivities.GetLength(1) - 1; j++)
                {
                    result[Intensivities[i, j], Intensivities[i + 1, j + 1]]++;
                }

            return result;
        }

        public float Contrast(int[,] glcm, int count_pair)
        {
            float result = 0.0f;

            for(int i = 0;i < glcm.GetLength(0);i++)
                for(int j = 0;j < glcm.GetLength(1); j++)
                    result+= (i-j)*(i-j) * glcm[i,j];

            return result/ count_pair;
        }

        public float ASM(int [,] glcm, int count_pair)
        {
            float result = 0.0f;

            for (int i = 0; i < glcm.GetLength(0); i++)
                for (int j = 0; j < glcm.GetLength(1); j++)
                    result += glcm[i, j] * glcm[i, j];
            return result / (count_pair* count_pair);
        }

        public Tuple<float,float> Mean(int[,] glcm, int count_pair)
        {
            float resultI = 0.0f;
            float resultJ = 0.0f;

            for (int i = 0; i < glcm.GetLength(0); i++)
                for (int j = 0; j < glcm.GetLength(1); j++)
                {
                    resultI += i * glcm[i, j];
                    resultJ += j * glcm[i, j];
                }
            return Tuple.Create(resultI/ count_pair , resultJ/ count_pair);
        }

        
        public Tuple<float, float> Vaiance2(int[,] glcm, int count_pair, Tuple<float, float> means = null)
        {
            float resultI = 0.0f;
            float resultJ = 0.0f;
            if(means == null)
                means = Mean(glcm, count_pair);

            for (int i = 0; i < glcm.GetLength(0); i++)
                for (int j = 0; j < glcm.GetLength(1); j++)
                {
                    resultI += glcm[i, j] * (i - means.Item1) * (i - means.Item1);
                    resultI += glcm[i, j] * (j - means.Item2) * (j - means.Item2);
                }
            return Tuple.Create(resultI / count_pair, resultJ / count_pair);
        }

        public float Correlation(int[,] glcm, int count_pair)
        {
            float result = 0.0f;
            Tuple<float, float> means = Mean(glcm, count_pair);
            Tuple<float, float> vai = Vaiance2(glcm, count_pair,means);

            for (int i = 0; i < glcm.GetLength(0); i++)
                for (int j = 0; j < glcm.GetLength(1); j++)
                    result +=(float)( glcm[i, j] * (i -means.Item1) * (j - means.Item2) / Math.Sqrt(vai.Item1 * vai.Item2) );

            return result;

        }



    }
}
