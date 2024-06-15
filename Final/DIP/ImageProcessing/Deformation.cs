using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Deformation
    {
        public int[,,] resize(int[,,] rgb, int width, int heigh, double scale, int select)
        {
            int[,,] rgb_result = new int[width, heigh, 3];
            scale = scale == 0 ? 1 : scale;
            if (select == 0)
            {
                scale = scale > 1 / scale ? scale : 1 / scale;
                int d1 = (int)(width - width / scale) / 2;
                int d2 = (int)(heigh - heigh / scale) / 2;
                for (int i = 0; i < width / scale; i++)
                {
                    for (int j = 0; j < heigh / scale; j++)
                    {
                        if (i + d1 < width && j + d2 < heigh && i + d1 > 0 && j + d2 > 0)
                        {
                            rgb_result[i + d1, j + d2, 0] = rgb[(int)(Math.Round(i * scale)), (int)(Math.Round(j * scale)), 0];
                            rgb_result[i + d1, j + d2, 1] = rgb[(int)(Math.Round(i * scale)), (int)(Math.Round(j * scale)), 1];
                            rgb_result[i + d1, j + d2, 2] = rgb[(int)(Math.Round(i * scale)), (int)(Math.Round(j * scale)), 2];
                        }

                    }
                }
            }
            else if (select == 1)
            {
                scale = scale < 1 / scale ? scale : 1 / scale;
                int d1 = (int)(width / scale - width) / 2;
                int d2 = (int)(heigh / scale - heigh) / 2;
                for (int i = 0; i < width / scale; i++)
                {
                    for (int j = 0; j < heigh / scale; j++)
                    {
                        if (i - d1 < width && j - d2 < heigh && i - d1 > 0 && j - d2 > 0)
                        {
                            rgb_result[i -d1, j - d2, 0] = rgb[(int)(Math.Round(i * scale)), (int)(Math.Round(j * scale)), 0];
                            rgb_result[i - d1, j - d2, 1] = rgb[(int)(Math.Round(i * scale)), (int)(Math.Round(j * scale)), 1];
                            rgb_result[i - d1, j - d2, 2] = rgb[(int)(Math.Round(i * scale)), (int)(Math.Round(j * scale)), 2];
                        }

                    }
                }
            }
            return rgb_result;
        }

    }
}
