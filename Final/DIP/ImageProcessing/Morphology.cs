using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Morphology
    {
        public int[,,] dilation(int[,,]rgb ,int width,int height,int n)
        {
            int[,,] rgb_result = new int[width, height, 3];
            for(int x=n/2;x<height-(n/2);x++)
            {
                for (int y = n / 2; y < width - (n / 2); y++)
                {
                    for (int chnnel = 0; chnnel < 3; chnnel++)
                    {
                        if(rgb[x,y,chnnel]==255)
                        {
                            for(int i=x-(n/2);i<=x+(n/2);i++)
                            {
                                for (int j = y - (n / 2); j <= y + (n / 2); j++)
                                {
                                    rgb_result[i, j,chnnel] = 255;
                                }
                            }

                        }
                    }
                }
            }
            return rgb_result;
        }

        public int[,,] erosion(int[,,] rgb, int width, int height, int n)
        {
            int[,,] rgb_result = new int[width, height, 3];
            for (int x = n / 2; x < height - (n / 2); x++)
            {
                for (int y = n / 2; y < width - (n / 2); y++)
                {
                    for (int chnnel = 0; chnnel < 3; chnnel++)
                    {
                        if (rgb[x, y, chnnel] == 255)
                        {
                            int flag = 0;
                            for (int i = x - (n / 2); i <= x + (n / 2); i++)
                            {
                                for (int j = y - (n / 2); j <= y + (n / 2); j++)
                                {
                                    if (rgb[i, j, chnnel] != 255) flag = 1;
                                }
                                if (flag == 1) break;
                            }
                            if (flag == 0) rgb_result[x, y, chnnel] = 255;
                         }
                    }
                }
            }
            return rgb_result;
        }

    }
}
