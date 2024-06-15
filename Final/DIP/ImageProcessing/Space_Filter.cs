using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    class Space_Filter
    {
        public int[,,] Median_Filter( int[,,]rgb ,int width,int height )
        {
            int[,,] rgb_result = new int[height, width, 3];
            int[] median = new int[9];
            for(int x=1;x<height-1;x++)
            {
                for (int y = 1; y < width-1; y++)
                {
                    //r
                   
                    int Med_r = FindMaskAll(rgb, x, y, 0, 0); 
                    //
                    
                    
                    int Med_g = FindMaskAll(rgb, x, y, 1, 0); 
                    //b
                   
                    int Med_b = FindMaskAll(rgb, x, y,2, 0); 
                    rgb_result[x, y, 0] = Med_r;
                    rgb_result[x, y, 1] = Med_g;
                    rgb_result[x, y, 2] = Med_b;
                }
            }

            return rgb_result;
        }


        public int[,,] Mean_Filter(int[,,] rgb, int width, int height)
        {
            int[,,] rgb_result = new int[height, width, 3];
            int[] mean = new int[9];
            for (int x = 1; x < height - 1; x++)
            {
                for (int y = 1; y < width - 1; y++)
                {
                   
                    int mean_r = FindMaskAll(rgb, x, y, 0, 1); ;

                    //g
                   
                    int mean_g = FindMaskAll(rgb, x, y, 1, 1); ;
                    //b
                   
                    int mean_b = FindMaskAll(rgb, x, y, 2, 1); ;


                    rgb_result[x, y, 0] = mean_r;
                    rgb_result[x, y, 1] = mean_g;
                    rgb_result[x, y, 2] = mean_b;
                }
            }
            return rgb_result;
        }



        public int[,,] Max_Filter(int[,,] rgb, int width, int height)
        {
            int[,,] rgb_result = new int[height, width, 3];
            int[] min = new int[9];
            for (int x = 1; x < height - 1; x++)
            {
                for (int y = 1; y < width - 1; y++)
                {
                    int max_r =FindMaskAll(rgb, x, y, 0,2);
                    int max_g = FindMaskAll(rgb, x, y, 1, 2);
                    int max_b = FindMaskAll(rgb, x, y, 2, 2);
                    rgb_result[x, y, 0] = max_r;
                    rgb_result[x, y, 1] = max_g;
                    rgb_result[x, y, 2] = max_b;

                }
            }
            return rgb_result;
        }



        public int[,,] Min_Filter(int[,,] rgb, int width, int height)
        {
            int[,,] rgb_result = new int[height, width, 3];
            int[] min = new int[9];
            for (int x = 1; x < height - 1; x++)
            {
                for (int y = 1; y < width - 1; y++)
                {
                    int min_r = FindMaskAll(rgb, x, y, 0,3);
                    int min_g = FindMaskAll(rgb, x, y, 1,3);
                    int min_b = FindMaskAll(rgb, x, y, 2,3);
                    rgb_result[x, y, 0] = min_r;
                    rgb_result[x, y, 1] = min_g;
                    rgb_result[x, y, 2] = min_b;

                }
            }
            return rgb_result;
        }






        // type 3 : 最小值
        // type 2 : 最大值
        // type 1 : 平均值
        // type 0 : 中位數

        private int FindMaskAll(int[,,] rgb, int x, int y, int channel, int type)
        {
            int[] A = new int[9];
            int answer=0;
            A[0] = rgb[x - 1, y - 1, channel];
            A[1] = rgb[x - 1, y, channel];
            A[2] = rgb[x - 1, y + 1, channel];
            A[3] = rgb[x, y - 1, channel];
            A[4] = rgb[x, y, channel];
            A[5] = rgb[x, y + 1, channel];
            A[6] = rgb[x + 1, y - 1, channel];
            A[7] = rgb[x + 1, y, channel];
            A[8] = rgb[x + 1, y + 1, channel];

           if (type ==3)
            {
             Array.Sort(A);
                answer= A[0];
                
            }

            if (type == 2)
            {
                Array.Sort(A);
                answer = A[8];
            }
            if (type == 0)
            {
                Array.Sort(A);
                answer = A[4];
            }
            if(type==1)
            {
                int sum = (int)(A.Sum() / 9);
                answer = sum;
            }

            return answer;

        }



        private int FindMaskMed(int [,,]rgb ,int x, int y, int channel)
        {
            int[] median = new int[9];
            median[0] = rgb[x - 1, y - 1, channel];
            median[1] = rgb[x - 1, y, channel];
            median[2] = rgb[x - 1, y + 1, channel];
            median[3] = rgb[x, y - 1, channel];
            median[4] = rgb[x, y, channel];
            median[5] = rgb[x, y + 1, channel];
            median[6] = rgb[x + 1, y - 1, channel];
            median[7] = rgb[x + 1, y, channel];
            median[8] = rgb[x + 1, y + 1, channel];
            Array.Sort(median);
            return median[4];
        }

        private int FindMaskMean(int[,,] rgb, int x, int y, int channel)
        {
            int[] mean = new int[9];
            mean[0] = rgb[x - 1, y - 1, channel];
            mean[1] = rgb[x - 1, y, channel];
            mean[2] = rgb[x - 1, y + 1, channel];
            mean[3] = rgb[x, y - 1, channel];
            mean[4] = rgb[x, y, channel];
            mean[5] = rgb[x, y + 1, channel];
            mean[6] = rgb[x + 1, y - 1, channel];
            mean[7] = rgb[x + 1, y, channel];
            mean[8] = rgb[x + 1, y + 1, channel];
            int sum= (int)(mean.Sum() / 9);
            
            return sum;
        }

        private int FindMaskMax(int[,,] rgb, int x, int y, int channel)
        {
            int[] max = new int[9];
            max[0] = rgb[x - 1, y - 1, channel];
            max[1] = rgb[x - 1, y, channel];
            max[2] = rgb[x - 1, y + 1, channel];
            max[3] = rgb[x, y - 1, channel];
            max[4] = rgb[x, y, channel];
            max[5] = rgb[x, y + 1, channel];
            max[6] = rgb[x + 1, y - 1, channel];
            max[7] = rgb[x + 1, y, channel];
            max[8] = rgb[x + 1, y + 1, channel];
            Array.Sort(max);
            return max[8];
        }

        private int FindMaskMin(int[,,] rgb, int x, int y, int channel)
        {
            int[] min = new int[9];
            min[0] = rgb[x - 1, y - 1, channel];
            min[1] = rgb[x - 1, y, channel];
            min[2] = rgb[x - 1, y + 1, channel];
            min[3] = rgb[x, y - 1, channel];
            min[4] = rgb[x, y, channel];
            min[5] = rgb[x, y + 1, channel];
            min[6] = rgb[x + 1, y - 1, channel];
            min[7] = rgb[x + 1, y, channel];
            min[8] = rgb[x + 1, y + 1, channel];
            Array.Sort(min);
            return min[0];
        }




    }
}
