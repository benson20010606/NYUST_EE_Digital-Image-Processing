using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Contrast
    {
        public int[,,] negative(int[,,] rgb ,int width ,int height)
        {
            for(int x=0; x<height; x++) 
            {
                for (int y = 0; y < width; y++) 
                {
                    rgb[x, y, 0] = 255 - rgb[x, y, 0];
                    rgb[x, y, 1] = 255 - rgb[x, y, 1];
                    rgb[x, y, 2] = 255 - rgb[x, y, 2];
                }
            }

            return rgb;
        }


        public int[,,] Log(int[,,]rgb ,int width,int height )
        {
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    rgb[x, y, 0] = (int)(40 * Math.Log(rgb[x, y, 0] + 1));
                    rgb[x, y, 1] = (int)(40 * Math.Log(rgb[x, y, 1] + 1));
                    rgb[x, y, 2] = (int)(40 * Math.Log(rgb[x, y, 2] + 1));
                }
            }
            return rgb;
        }

        public int[,,] histogram(int[,,] rgb, int width, int height,int pixel)
        {
            int[] r = new int[256];
            int[] g = new int[256];
            int[] b = new int[256];

            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    r[rgb[x, y, 0]]++;
                    g[rgb[x, y, 1]]++;
                    b[rgb[x, y, 2]]++;
                }
            }

            int sum_r = 0;
            int sum_g = 0;
            int sum_b = 0;

            for (int i = 0; i < 256; i++)
             {
                sum_r = sum_r + r[i];
                r[i] = (int)((float)sum_r / (float)pixel * 255.0);
                sum_g = sum_g + g[i];
                g[i] = (int)((float)sum_g / (float)pixel * 255.0);
                sum_b = sum_b + b[i];
                b[i] = (int)((float)sum_b / (float)pixel * 255.0);
              }

            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    rgb[x, y, 0]= r[rgb[x, y, 0]];
                    rgb[x, y, 1] = g[rgb[x, y, 1]];
                    rgb[x, y, 2] = b[rgb[x, y, 2]];
                }
            }

            return rgb;
        }



    }
}
