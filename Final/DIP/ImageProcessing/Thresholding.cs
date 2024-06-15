using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Thresholding
    {
        public int[,,] change(int[,,]rgb ,int width,int height,int value)
        {
            for (int x = 0; x < height; x++)
            {
                for(int y=0; y< width;y++)
                {
                    rgb[x, y, 0] = rgb[x, y, 0] > value ? 255 : 0;
                    rgb[x, y, 1] = rgb[x, y, 1] > value ? 255 : 0;
                    rgb[x, y, 2] = rgb[x, y, 2] > value ? 255 : 0;
                }
            }

            return rgb;
        }
    
        public int[,,] otsu(int[,,]rgb ,int width ,int height)
        {
            double[] r = new double[256];
            double[] g = new double[256];
            double[] b = new double[256];

            for(int x =0; x<height;x++)
            {
                for (int y = 0; y < width; y++)
                {
                    r[rgb[x, y, 0]]++;
                    g[rgb[x, y, 1]]++;
                    b[rgb[x, y, 2]]++;
                }
            }

            int thershold_r = GetThreshold(r, width, height);
            int thershold_g = GetThreshold(g, width, height);
            int thershold_b = GetThreshold(b, width, height);

            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    rgb[x, y, 0] = rgb[x, y, 0] > thershold_r ? 255 : 0;
                    rgb[x, y, 1] = rgb[x, y, 1] > thershold_g ? 255 : 0;
                    rgb[x, y, 2] = rgb[x, y, 2] > thershold_b ? 255 : 0;
                }
            }

            return rgb;
        }
        
        
        public int GetThreshold(double[] band, int w ,int h)
        {
            for (int i= 0;i<band.Length;i++)
            {
                band[i] = band[i] / (w * h);
            }

            double mg = 0;
            for(int i=0;i<255;i++)
            {
                mg += i * band[i];
            }

            double bcv = 0;
            int threshold = 0;
            for (int i= 0; i < 255;i++)
            {
                double p = 0;
                double m = 0;
                for(int j=0;j<i;j++)
                {
                    p += band[j];
                    m += j * band[j];
                }
                if (p == 0) 
                {
                    continue;
                }

                double old_bcv = bcv;
                bcv = Math.Max(bcv, Math.Pow(mg * p - m, 2) / (p * (1 - p)));
                if(bcv>old_bcv)
                {
                    threshold = i;
                }
            }

            return threshold;
        }
    
    
    
    
    
    
    
    
    }
}
