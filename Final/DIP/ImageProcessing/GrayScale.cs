using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class GrayScale
    {
        public int[,,] Mean_Weight(int[,,] rgb,int width, int height)
        {
            for(int x=0; x <height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    int gray = (int)(rgb[x, y, 0] * 0.299 + rgb[x, y, 1] * 0.587 + rgb[x, y, 2] * 0.114);
                    rgb[x, y, 0] = gray;
                    rgb[x, y, 1] = gray;
                    rgb[x, y, 2] = gray;
                }
            }
            return rgb;
        }


        public int[,,] Mean_Value(int[,,] rgb, int width, int height)
        {
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    int gray = (int)((rgb[x, y, 0] + rgb[x, y, 1]  + rgb[x, y, 2])/3);
                    rgb[x, y, 0] = gray;
                    rgb[x, y, 1] = gray;
                    rgb[x, y, 2] = gray;
                }
            }
            return rgb;
        }


        public int[,,] Maxium(int[,,] rgb, int width, int height)
        {
            for (int x = 0; x < height; x++)
            {
                for (int y = 0; y < width; y++)
                {
                    int max = 0;
                    if(rgb[x, y, 0] > max)
                    {
                        max = rgb[x, y, 0];
                    }
                    if (rgb[x, y,1] > max)
                    {
                        max = rgb[x, y, 1];
                    }
                    if (rgb[x, y, 2] > max)
                    {
                        max = rgb[x, y, 2];
                    }

                    rgb[x, y, 0] = max;
                    rgb[x, y, 1] = max;
                    rgb[x, y, 2] = max;
                }
            }
            return rgb;
        }

    }
}
