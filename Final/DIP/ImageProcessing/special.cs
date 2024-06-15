using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class special
    {
        public int[,,] error_diffusion(int[,,]rgb,int width,int height)
        {
            int threshold = 128;
            int[] Er = new int[3];
            for(int x=0;x<height;x++)
            {
                for (int y = 0; y <width; y++)
                {
                    for (int channel= 0; channel < 3; channel++)
                    {
                        if(rgb[x,y,channel]< threshold)
                        {
                            Er[channel] = rgb[x, y, channel] - 0;
                            rgb[x, y, channel] = 0;
                        }
                        else
                        {
                            Er[channel] = rgb[x, y, channel] - 255;
                            rgb[x, y, channel] = 255;
                        }
                        if(x>0&&y>0&&x<height-1&&y<width-1)
                        {
                            rgb[x, y + 1, channel] += (int)(Er[channel] * (float)(7.0 / 16.0));
                            rgb[x+1, y-1, channel] += (int)(Er[channel] * (float)(3.0 / 16.0));
                            rgb[x+1, y, channel] += (int)(Er[channel] * (float)(5.0 / 16.0));
                            rgb[x+1, y+1, channel] += (int)(Er[channel] * (float)(1.0 / 16.0));
                        }
                    }
                }
            }
            return rgb;
        }
   
    }
}
