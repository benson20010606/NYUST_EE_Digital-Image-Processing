using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.IO;


namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap img;
        Bitmap img_origin;
        Stack<Bitmap> StepStack = new Stack<Bitmap>();
        public Form1()
        {
            
            InitializeComponent();
            comboBox2.SelectedIndex = 0;
        }
        
        public void InitForm()
        {
            O_R_Band.Image = null;
            O_G_Band.Image = null;
            O_B_Band.Image = null;
            H_B_img.Image = null;
            H_G_img.Image = null;
            H_R_img.Image = null;
        }
        Mat img_mat;
        //int count=0;
        private void OpenButton_Click(object sender, EventArgs e)
        {
           //if(count==0)  //可以寫在load裡面 這樣就不會因為沒有設count而卡住
           //{ 
           //     Task t =new Task(() =>
           //     {
           //         while (true)
           //         {
           //             this.Invoke((MethodInvoker)delegate  // 委派  這樣執行續才使用UI上的原件
           //             {
           //                 lbl_time.Text = DateTime.Now.ToString();
           //             });
           //         }
           //     });
           //     t.Start();
               
           //}
           // count++;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Image File";
            openFileDialog.Filter = "jpg file (*.jpg)|*.jpg|All file(*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                InitForm();
                img = new Bitmap(Image.FromFile(openFileDialog.FileName));
                img_origin = new Bitmap(img);

                img_mat = new Mat(openFileDialog.FileName, ImreadModes.AnyColor);
                Mat[] mats = Cv2.Split(img_mat);
                try
                {
                    Cv2.ImShow("b", mats[0]);
                    Cv2.ImShow("g", mats[1]);
                    Cv2.ImShow("r", mats[2]);
                }
                catch
                {
                   // MessageBox.Show("error");
                }
                
                
                
                
                StepStack.Push(img);
                original_img.Image = img_origin;

                O_PhotoWH.Text = "" + img.Width.ToString() + "x" + img.Height.ToString();
                
                Bitmap[] rgbbang = ShowBand(img_origin);
                O_R_Band.Image = rgbbang[0];
                O_G_Band.Image = rgbbang[1];
                O_B_Band.Image = rgbbang[2];

                Bitmap[] his = Histogram(img_origin);
                H_R_img.Image = his[0];
                H_G_img.Image = his[1];
                H_B_img.Image = his[2];
            }
        }

        //basic function
        public Bitmap[] ShowBand(Bitmap img)
        {
            int[,,] rgb = GetRGBData(img);
            int height = img.Height;
            int width = img.Width;
            int temp = 0;
            int[,,] RBand = new int[height, width, 3];
            int[,,] GBand = new int[height, width, 3];
            int[,,] BBand = new int[height, width, 3];

            Bitmap[] rgbband = new Bitmap[3];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //RBand
                    temp = rgb[i, j, 0];
                    RBand[i, j, 0] = temp;
                    RBand[i, j, 1] = temp;
                    RBand[i, j, 2] = temp;
                    //GBand
                    temp = rgb[i, j, 1];
                    GBand[i, j, 0] = temp;
                    GBand[i, j, 1] = temp;
                    GBand[i, j, 2] = temp;
                    //BBand
                    temp = rgb[i, j, 2];
                    BBand[i, j, 0] = temp;
                    BBand[i, j, 1] = temp;
                    BBand[i, j, 2] = temp;
                }
            }
            //RBand setting
            rgbband[0] = SetRGBData(RBand);
            //GBand setting
            rgbband[1] = SetRGBData(GBand);
            //BBand setting
            rgbband[2] = SetRGBData(BBand);

            return rgbband;
        }

        public static int[,,] GetRGBData(Bitmap bitImg)
        {
            int height = bitImg.Height;
            int width = bitImg.Width;
            //鎖住Bitmap整個影像內容
            BitmapData bitmapData = bitImg.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            //取得影像資料的起始位置
            IntPtr imgPtr = bitmapData.Scan0;
            //影像scan的寬度
            int stride = bitmapData.Stride;
            //影像陣列的實際寬度
            int widthByte = width * 3;
            //所Padding的Byte數
            int skipByte = stride - widthByte;
            //設定預定存放的rgb三維陣列
            int[,,] rgbData = new int[height, width, 3];

            #region 讀取RGB資料
            //注意C#的GDI+內的影像資料順序為BGR, 非一般熟悉的順序RGB
            //因此我們把順序調回原來的陣列順序排放BGR->RGB
            unsafe
            {
                byte* p = (byte*)imgPtr;
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        //B Channel
                        rgbData[j, i, 2] = p[0];
                        p++;
                        //G Channel
                        rgbData[j, i, 1] = p[0];
                        p++;
                        //R Channel
                        rgbData[j, i, 0] = p[0];
                        p++;
                    }
                    p += skipByte;
                }
            }

            //解開記憶體鎖
            bitImg.UnlockBits(bitmapData);

            #endregion

            return rgbData;
        }

        public static Bitmap SetRGBData(int[,,] rgbData)
        {
            Bitmap bitImg;
            int height = rgbData.GetLength(0);
            int width = rgbData.GetLength(1);
            bitImg = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            BitmapData bitmapData = bitImg.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            IntPtr imgPtr = bitmapData.Scan0;
            int stride = bitmapData.Stride;
            int widthByte = width * 3;
            int skipByte = stride - widthByte;

            unsafe
            {
                byte* p = (byte*)(void*)imgPtr;
                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        //B Channel
                        p[0] = (byte)rgbData[j, i, 2];
                        p++;
                        //G Channel
                        p[0] = (byte)rgbData[j, i, 1];
                        p++;
                        //R Channel
                        p[0] = (byte)rgbData[j, i, 0];
                        p++;
                    }
                    p += skipByte;
                }
            }
            //解開記憶體鎖
            bitImg.UnlockBits(bitmapData);
            return bitImg;
        }

        public Bitmap[] Histogram(Bitmap img)
        {
            int[] origin_r = new int[256];
            int[] origin_g = new int[256];
            int[] origin_b = new int[256];
            int height = img.Height;
            int width = img.Width;
            Bitmap[] his = new Bitmap[3];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixelColor = img.GetPixel(x, y);
                    origin_r[pixelColor.R]++;
                    origin_g[pixelColor.G]++;
                    origin_b[pixelColor.B]++;
                }
            }

            int max_times = 0;
            for (int i = 0; i < 256; i++)
            {
                if (max_times < origin_r[i])
                    max_times = origin_r[i];
                if (max_times < origin_g[i])
                    max_times = origin_g[i];
                if (max_times < origin_b[i])
                    max_times = origin_b[i];
            }

            Bitmap imgR = new Bitmap(256, 100);
            for (int x = 0; x < imgR.Width; x++)
            {
                for (int y = 0; y < (int)(((float)origin_r[x] / max_times) * 100); y++)
                {
                    imgR.SetPixel(x, imgR.Height - y - 1, Color.FromArgb(255, 0, 0));
                }
            }
            his[0] = imgR;

            Bitmap imgG = new Bitmap(256, 100);
            for (int x = 0; x < imgG.Width; x++)
            {
                for (int y = 0; y < (int)(((float)origin_g[x] / max_times) * 100); y++)
                {
                    imgG.SetPixel(x, imgG.Height - y - 1, Color.FromArgb(0, 255, 0));
                }
            }
            his[1] = imgG;

            Bitmap imgB = new Bitmap(256, 100);
            for (int x = 0; x < imgB.Width; x++)
            {
                for (int y = 0; y < (int)(((float)origin_b[x] / max_times) * 100); y++)
                {
                    imgB.SetPixel(x, imgB.Height - y - 1, Color.FromArgb(0, 0, 255));
                }
            }
            his[2] = imgB;

            return his;
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Image";
            saveFileDialog.InitialDirectory = @"D:\";
            saveFileDialog.Filter = "jpg files(*.jpg)|*.jpg";

            Bitmap result = new Bitmap(ResultImg.Image);// result 的圖檔 
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                result.Save(saveFileDialog.FileName, ImageFormat.Jpeg); // result 的圖檔 
            }
        }
        
        GrayScale grayScale = new GrayScale();

        private void Btn_mean_weig_Click(object sender, EventArgs e)
        {
            #region Opencv
            Mat gray_mat = img_mat.Clone();
            Cv2.CvtColor(img_mat, gray_mat, ColorConversionCodes.BGR2GRAY);
            Cv2.ImShow("GRAY", gray_mat);
            #endregion

            int[,,] rgb = GetRGBData(img);
            int[,,] rgb_result = grayScale.Mean_Weight(rgb, img.Width, img.Height);
            Bitmap img_result = SetRGBData(rgb_result);
            ResultImg.Image = img_result;
            result_text.Text = "" + img_result.Width.ToString() + "x" + img_result.Height.ToString();
            StepStack.Push(img_result);
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_result);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_result);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
        }


        private void Btn_mean_value_Click(object sender, EventArgs e)
        {
            int[,,] rgb = GetRGBData(img);
            int[,,] rgb_result = grayScale.Mean_Value(rgb, img.Width, img.Height);
            Bitmap img_result = SetRGBData(rgb_result);
            result_text.Text = "" + img_result.Width.ToString() + "x" + img_result.Height.ToString();
            ResultImg.Image = img_result;
            StepStack.Push(img_result);
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_result);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_result);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion

        }

        private void Btn_maxium_Click(object sender, EventArgs e)
        {
            int[,,] rgb = GetRGBData(img);
            int[,,] rgb_result = grayScale.Maxium(rgb, img.Width, img.Height);
            Bitmap img_result = SetRGBData(rgb_result);
            ResultImg.Image = img_result;
            result_text.Text = "" + img_result.Width.ToString() + "x" + img_result.Height.ToString();
            StepStack.Push(img_result);
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_result);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_result);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion

        }

        private void Btn_undo_Click(object sender, EventArgs e)
        {
            if (StepStack.Count > 0)
                StepStack.Pop();
            if (StepStack.Count > 0)
            {
                img=StepStack.Pop();
                ResultImg.Image = img;
                #region 顯示RGB三通道影像
                Bitmap[] rgbBand = ShowBand(img);
                Result_R.Image = rgbBand[0];
                Result_G.Image = rgbBand[1];
                Result_B.Image = rgbBand[2];
                #endregion
                #region 顯示RGB三通道直方圖
                Bitmap[] histogram = Histogram(img);
                Result_H_R.Image = histogram[0];
                Result_H_G.Image = histogram[1];
                Result_H_B.Image = histogram[2];
                #endregion
                StepStack.Push(img);
            }
            else if(StepStack.Count==0)
            {
                StepStack.Push(img_origin);
            }
        }

        private void btn_org_Click(object sender, EventArgs e)
        {
            ResultImg.Image = img_origin;
            result_text.Text = "" + ResultImg.Width.ToString() + "x" + ResultImg.Height.ToString();
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_origin);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion
            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_origin);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
            StepStack.Clear();
            StepStack.Push(img_origin);
            img = img_origin;
        }
        

        Contrast contrast = new Contrast();

        private void btn_Negative_Click(object sender, EventArgs e)
        {

            #region Opencv
            Mat negative_mat = img_mat.Clone();
            Mat[] split = Cv2.Split(negative_mat);
            split[0] = 255 - split[0];
            split[1] = 255 - split[1];
            split[2] = 255 - split[2];
            Cv2.Merge(split, negative_mat);
            Cv2.ImShow("Hist", negative_mat);

            #endregion

            int[,,] rgb = GetRGBData(img);
            int[,,] rgb_result = contrast.negative(rgb, img.Width, img.Height);
            Bitmap img_result = SetRGBData(rgb_result);
            ResultImg.Image = img_result;
            result_text.Text = "" + img_result.Width.ToString() + "x" + img_result.Height.ToString();
            StepStack.Push(img_result);


            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_result);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_result);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            int[,,] rgb = GetRGBData(img);
            int[,,] rgb_result = contrast.Log(rgb, img.Width, img.Height);
            Bitmap img_result = SetRGBData(rgb_result);
            ResultImg.Image = img_result;
            result_text.Text = "" + img_result.Width.ToString() + "x" + img_result.Height.ToString();
            StepStack.Push(img_result);
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_result);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_result);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
        }

        private void btn_Histogram_equ_Click(object sender, EventArgs e)
        {
            #region Opencv
            Mat his_mat = img_mat.Clone();
            Mat[] split = Cv2.Split(his_mat);
            Cv2.EqualizeHist(split[0], split[0]);
            Cv2.EqualizeHist(split[1], split[1]);
            Cv2.EqualizeHist(split[2], split[2]);
            Cv2.Merge(split, his_mat);
            Cv2.ImShow("Hist", his_mat);
            
            #endregion



            int[,,] rgb = GetRGBData(img);
            int[,,] rgb_result = contrast.histogram(rgb, img.Width, img.Height,(img.Width*img.Height));
            Bitmap img_result = SetRGBData(rgb_result);
            ResultImg.Image = img_result;
            result_text.Text = "" + img_result.Width.ToString() + "x" + img_result.Height.ToString();
            StepStack.Push(img_result);
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_result);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_result);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
        }

        Space_Filter space_filter = new Space_Filter();
        private void btn_Median_Click(object sender, EventArgs e)
        {

            #region Opencv
            Mat med_mat = img_mat.Clone();
            int kernel = 3; //遮罩  11會模糊
            Cv2.MedianBlur(med_mat, med_mat, kernel);
            Cv2.ImShow("med",med_mat);
            #endregion

            int[,,] rgb = GetRGBData(img);
            int[,,] rgb_result = space_filter.Median_Filter(rgb, img.Width, img.Height);
            Bitmap img_result = SetRGBData(rgb_result);
            ResultImg.Image = img_result;
            result_text.Text = "" + img_result.Width.ToString() + "x" + img_result.Height.ToString();
            StepStack.Push(img_result);
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_result);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_result);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
        }

        private void btn_Mean_Click(object sender, EventArgs e)
        {

            #region Opencv
            Mat mean_mat = img_mat.Clone();
            int kernel = 11; //遮罩  11會模糊
            Cv2.Blur(mean_mat, mean_mat, new OpenCvSharp.Size(kernel,kernel));
            Cv2.ImShow("mean", mean_mat);
            #endregion

            int[,,] rgb = GetRGBData(img);
            int[,,] rgb_result = space_filter.Mean_Filter(rgb, img.Width, img.Height);
            Bitmap img_result = SetRGBData(rgb_result);
            ResultImg.Image = img_result;
            result_text.Text = "" + img_result.Width.ToString() + "x" + img_result.Height.ToString();
            StepStack.Push(img_result);
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_result);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_result);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            int[,,] rgb = GetRGBData(img);
            int[,,] rgb_result = space_filter.Max_Filter(rgb, img.Width, img.Height);
            Bitmap img_result = SetRGBData(rgb_result);
            ResultImg.Image = img_result;
            result_text.Text = "" + img_result.Width.ToString() + "x" + img_result.Height.ToString();
            StepStack.Push(img_result);
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_result);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_result);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            int[,,] rgb = GetRGBData(img);
            int[,,] rgb_result = space_filter.Min_Filter(rgb, img.Width, img.Height);
            Bitmap img_result = SetRGBData(rgb_result);
            ResultImg.Image = img_result;
            result_text.Text = "" + img_result.Width.ToString() + "x" + img_result.Height.ToString();
            StepStack.Push(img_result);
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_result);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_result);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
        }

        Thresholding thresholding = new Thresholding();
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_value.Text = trackBar1.Value.ToString();
            
        }
        Bitmap img_t;

        private void Thresholding_Change_Click(object sender, EventArgs e)
        {   int value = trackBar1.Value;
            int[,,] rgb = GetRGBData(img);
            int[,,] rgb_result = thresholding.change(rgb, img.Width, img.Height,value);

            #region Opencv
            Mat threshold_mat = img_mat.Clone();
  
            Cv2.CvtColor(threshold_mat, threshold_mat, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(threshold_mat, threshold_mat,value,255, ThresholdTypes.Binary);
            Cv2.ImShow("threshold", threshold_mat);
            #endregion


           
            Bitmap img_result = SetRGBData(rgb_result);
            img_t = img_result;
            ResultImg.Image = img_result;
            result_text.Text = "" + img_result.Width.ToString() + "x" + img_result.Height.ToString();
            StepStack.Push(img_result);
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_result);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_result);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
        }

        private void Thresholding_Apply_Click(object sender, EventArgs e)
        {
      
            img = img_t;
        }

        private void btn_Otsu_Click(object sender, EventArgs e)
        {

            #region Opencv
            Mat otsu_mat = img_mat.Clone();
            int value = 128; //遮罩  11會模糊
            Cv2.CvtColor(otsu_mat, otsu_mat, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(otsu_mat, otsu_mat,value, 255,ThresholdTypes.Otsu);
            Cv2.ImShow("otsu", otsu_mat);
            #endregion


            Thresholding thresholding = new Thresholding();
            int[,,] rgb = GetRGBData(img);
            img = SetRGBData(thresholding.otsu(rgb, img.Width, img.Height));
            ResultImg.Image = img;
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
            result_text.Text = "" + img.Width.ToString() + "x" + img.Height.ToString();
            StepStack.Push(img);

        }

        private void btn_Rotate_Click(object sender, EventArgs e)
        {
            int theta = Convert.ToInt32(comboBox1.Text);
            Bitmap imgBitmap = img_origin;
            Bitmap imgRotate = new Bitmap(img_origin.Width, img_origin.Height);

            #region Opencv
            Mat rot_mat = img_mat.Clone();
            Cv2.Rotate(rot_mat, rot_mat, RotateFlags.Rotate90Clockwise);
            Cv2.ImShow("rotate", rot_mat);
            #endregion


            for (int i=0;i<imgBitmap.Width;i++)
            {
                for (int j = 0; j < imgBitmap.Height; j++)
                {
                    int x = i - imgBitmap.Width / 2;
                    int y = j - imgBitmap.Height / 2;
                    double x_rotate = x * Math.Cos(theta * Math.PI / 180) - y * Math.Sin(theta * Math.PI / 180);
                    double y_rotate = x * Math.Sin(theta * Math.PI / 180) + y * Math.Cos(theta * Math.PI / 180);
                    int xout = (int)(x_rotate + img_origin.Width / 2);
                    int yout = (int)(y_rotate + img_origin.Height / 2);
                    xout = xout < 0 ? 0 : xout;
                    yout = yout < 0 ? 0 : yout;
                    xout = xout == imgBitmap.Width ? imgBitmap.Width - 1 : xout;
                    yout = yout == imgBitmap.Width ? imgBitmap.Height - 1 : yout;
                    Color color = imgBitmap.GetPixel(i, j);
                    if (xout < imgBitmap.Width && yout < imgBitmap.Height)
                        imgRotate.SetPixel(xout, yout, color);

                }
            }
            ResultImg.Image = imgRotate;
        }

        private void btn_Wrapping_Click(object sender, EventArgs e)
        {
            Bitmap imgBitmap = img_origin;
            Bitmap imgWrap = new Bitmap(img_origin.Width, img_origin.Height);
            int radius = img_origin.Width / 2;
            for (int i = 0; i < imgBitmap.Width; i++)
            {
                for (int j = 0; j < imgBitmap.Height; j++)
                {
                    int xout = i - radius;
                    int yout = j - radius;
                    xout = xout == 0 ? xout + 1 : xout;
                    yout = yout == 0 ? yout + 1 : yout;
                    double dout = Math.Sqrt(Math.Pow( xout, 2) + Math.Pow(yout, 2));
                    if (dout > radius)
                        continue;
                    double din = ((radius * 2) / Math.PI) * Math.Asin(dout / radius);
                    int ix = (int)(((din * xout) / dout + radius));
                    int iy = (int)(((din * yout) / dout + radius));
                    Color color = imgBitmap.GetPixel(ix, iy);
                    imgWrap.SetPixel(i, j, color);

                }
            }
            ResultImg.Image = imgWrap;
        }


        Bitmap img_state;
        private void resize_Click(object sender, EventArgs e)
        {
           
            Deformation g =new Deformation();
            Double scale = Convert.ToDouble(resize_time.Text);
            int[,,] rgb = GetRGBData(img);


            #region Opencv
            Mat resize_image = img_mat.Clone();
            Cv2.Resize(resize_image, resize_image,new OpenCvSharp.Size(),2, 0.5,InterpolationFlags.Linear); /// 2長  0.5 寬    InterpolationFlags.Linear 線性內插
            Cv2.ImShow("rotate", resize_image);
            #endregion



            if (small.Checked)
            {
                img_state = SetRGBData(g.resize(rgb, img.Width, img.Height, scale, 0));
            }
            else if (big.Checked)
            {
                img_state = SetRGBData(g.resize(rgb, img.Width, img.Height, scale, 1));

            }

            ResultImg.Image = img_state;
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_state);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion 

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_state);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
            result_text.Text = "" + img.Width.ToString() + "x" + img.Height.ToString();
            StepStack.Push(img_state);
        }

        private void btn_error_diffusion_Click(object sender, EventArgs e)
        {
            special sp = new special();
            img_state = img;
            int[,,] rgb = GetRGBData(img);
            img_state = SetRGBData(sp.error_diffusion(rgb, img.Width, img.Height));
            ResultImg.Image = img_state;
            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_state);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion 

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_state);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
            result_text.Text = "" + img.Width.ToString() + "x" + img.Height.ToString();
            StepStack.Push(img_state);
        }

        private void Dilation_btn_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(Kernal_size.Text);
            Morphology mor = new Morphology();
            img_state = img;
            int[,,] rgb = GetRGBData(img);
            img_state = SetRGBData(mor.dilation(rgb, img.Width, img.Height, n));
            ResultImg.Image = img_state;

            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_state);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion 

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_state);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
            result_text.Text = "" + img.Width.ToString() + "x" + img.Height.ToString();
            StepStack.Push(img_state);
        }

        private void Eroion_btn_Click(object sender, EventArgs e)
        {
            #region 演算
            int n = Convert.ToInt32(Kernal_size.Text);
            Morphology mor = new Morphology();
            img_state = img;
            int[,,] rgb = GetRGBData(img);
            img_state = SetRGBData(mor.erosion(rgb, img.Width, img.Height, n));
            ResultImg.Image = img_state;

            #region 顯示RGB三通道影像
            Bitmap[] rgbBand = ShowBand(img_state);
            Result_R.Image = rgbBand[0];
            Result_G.Image = rgbBand[1];
            Result_B.Image = rgbBand[2];
            #endregion 

            #region 顯示RGB三通道直方圖
            Bitmap[] histogram = Histogram(img_state);
            Result_H_R.Image = histogram[0];
            Result_H_G.Image = histogram[1];
            Result_H_B.Image = histogram[2];
            #endregion
            result_text.Text = "" + img.Width.ToString() + "x" + img.Height.ToString();
            StepStack.Push(img_state);
            #endregion

        }

        private void CV_erosin_Click(object sender, EventArgs e)
        {
            Mat erosin_img = img_mat.Clone();
            int size = 3;
            Mat se = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(size, size), new OpenCvSharp.Point(-1, -1));
            Cv2.Erode(erosin_img, erosin_img, se);
            Cv2.ImShow("Erosin", erosin_img);
        }

        private void CV_dilation_Click(object sender, EventArgs e)
        {
            Mat dilation_img = img_mat.Clone();
            int size = 3;
            Mat se = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(size, size), new OpenCvSharp.Point(-1, -1));
            Cv2.Dilate(dilation_img,dilation_img, se);
            Cv2.ImShow("Dilation", dilation_img);
        }

        private void Morph_open_btn_Click(object sender, EventArgs e)
        {
            Mat erosin_img = img_mat.Clone();
            Mat dilation_img = img_mat.Clone();
            int n = Convert.ToInt32(Kernal_size.Text);
            #region 先侵蝕再膨脹
            Mat se = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(n, n), new OpenCvSharp.Point(-1, -1));
            Cv2.Erode(erosin_img, erosin_img, se);
            Cv2.Dilate(erosin_img, dilation_img, se);
            Cv2.ImShow("Open", dilation_img);
            #endregion
            
            #region Open 函式
            Mat open_img = img_mat.Clone();
            Cv2.MorphologyEx(open_img, open_img, MorphTypes.Open, se);
            Cv2.ImShow("open_1", open_img);
            #endregion
        }

        private void Morph_close_btn_Click(object sender, EventArgs e)
        {
            Mat erosin_img = img_mat.Clone();
            Mat dilation_img = img_mat.Clone();
            int n = Convert.ToInt32(Kernal_size.Text);

            #region 先膨脹再侵蝕
            Mat se = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(n, n), new OpenCvSharp.Point(-1, -1));
            Cv2.Dilate(dilation_img, dilation_img, se);
            Cv2.Erode(dilation_img, erosin_img, se);
            Cv2.ImShow("Close", erosin_img);
            #endregion
            
            #region Close 函式
            Mat open_img = img_mat.Clone();
            Cv2.MorphologyEx(open_img, open_img, MorphTypes.Close, se);
            Cv2.ImShow("close_1", open_img);
            #endregion
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            img = (Bitmap)ResultImg.Image;
            img_state= (Bitmap)ResultImg.Image;
            img_mat = BitmapConverter.ToMat(img_state);
            original_img.Image= ResultImg.Image;
        }

        private void Canny_btn_Click(object sender, EventArgs e)
        {
            Mat canny_mat = img_mat.Clone();
            Cv2.CvtColor(canny_mat, canny_mat, ColorConversionCodes.BGR2GRAY);
            Cv2.Canny(canny_mat, canny_mat, 100, 200);
            img_state = BitmapConverter.ToBitmap(canny_mat);
            Cv2.ImShow("Canny", canny_mat);
        }

        private void FindContours_btn_Click(object sender, EventArgs e)
        {
            OpenCvSharp.Point[][] contours;
            HierarchyIndex[] hierarchly;
            Mat contour_mat = img_mat.Clone();

            Cv2.CvtColor(contour_mat, contour_mat, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(contour_mat, contour_mat, 240, 255, ThresholdTypes.BinaryInv);
            Mat se = Cv2.GetStructuringElement(MorphShapes.Cross, new OpenCvSharp.Size(3, 3), new OpenCvSharp.Point(-1, -1));
            
            Cv2.MorphologyEx(contour_mat, contour_mat, MorphTypes.Close, se);
            Cv2.FindContours(contour_mat,out contours,out hierarchly,RetrievalModes.Tree,ContourApproximationModes.ApproxSimple,new OpenCvSharp.Point(0,0));

            Mat src = BitmapConverter.ToMat(img_origin).Clone();
            for (int i=0;i<contours.Length;i++)
            {
                Scalar color = new Scalar(0, 0, 255);
                Cv2.DrawContours(src, contours, i, color, 2, LineTypes.Link8, hierarchly);
                Cv2.ImShow("findcontour", src);
            }
            Cv2.ImShow("findcontour", src);

        }

        CircleSegment[] cs;
        private void Hough_Circles_btn_Click(object sender, EventArgs e)
        {
            Mat HoughCircles = img_mat.Clone();
            Cv2.CvtColor(HoughCircles, HoughCircles, ColorConversionCodes.BGR2GRAY);
            Cv2.MedianBlur(HoughCircles, HoughCircles, 11);
            cs = Cv2.HoughCircles(HoughCircles, HoughModes.Gradient, 1, 50, 70, 30, 10, 60);
            for(int i=0; i<cs.Count();i++)
            {
                Cv2.Circle(HoughCircles, (int)cs[i].Center.X, (int)cs[i].Center.Y, (int) cs[i].Radius, new Scalar(0, 0, 255), 2, LineTypes.AntiAlias);
                Cv2.Circle(HoughCircles, (int)cs[i].Center.X, (int)cs[i].Center.Y, 3, new Scalar(0, 0, 255), 2, LineTypes.AntiAlias);
            }
            Cv2.ImShow("HoughCircles", HoughCircles);
        }

        int index = 0;
        private void btn_forward_Click(object sender, EventArgs e)
        {
            index--;
            index = index < 0 ? cs.Count() - 1 : index;
            Rect roi = new Rect((int)cs[index].Center.X - (int)cs[index].Radius, (int)cs[index].Center.Y - (int)cs[index].Radius, (int)cs[index].Radius * 2, (int)cs[index].Radius * 2);
            Mat ImageROI = new Mat(img_mat, roi);
            ResultImg.Image = ImageROI.ToBitmap();
        }

        private void btn_backward_Click(object sender, EventArgs e)
        {
            index++ ;
            index = index > cs.Count() - 1  ? 0 : index;
            Rect roi = new Rect((int)cs[index].Center.X - (int)cs[index].Radius, (int)cs[index].Center.Y - (int)cs[index].Radius, (int)cs[index].Radius * 2, (int)cs[index].Radius * 2);
            Mat ImageROI = new Mat(img_mat, roi);
            ResultImg.Image = ImageROI.ToBitmap();
        }

        private void Mouse_down(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                Random rnd = new Random();
                int r = rnd.Next(0, 256);
                int g = rnd.Next(0, 256);
                int b = rnd.Next(0, 256);
                unchecked
                {
                    this.BackColor = Color.FromArgb(r, g, b);
                }
            }
        }

        private void Mouse_enter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
        }

        private void Mouse_leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            Button btn = (Button)sender;
            btn.BackColor = Color.Silver;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task t = new Task(() =>
            {
                while (true)
                {
                    try
                    {
                        this.Invoke((MethodInvoker)delegate  // 委派  這樣執行續才使用UI上的原件
                        {
                            lbl_time.Text = DateTime.Now.ToString();
                        });
                    
                    }
                    catch
                    {
                        break;
                    }
                    
                }
            });
            t.Start();
            
        }

        Camera cam = new Camera();
        Mat frame;

        private void stream()
        {
            {
                while (cam.running) 
                {
                    frame = cam.GetFrame();
                    try 
                    {
                        this.Invoke((MethodInvoker)delegate { video_process(); });
                        original_img.Image = frame.ToBitmap();
                    }
                    catch
                    {
                        cam.clsoe();
                    }
                }
            }
        }
    
        private void video_process()
        {
            try 
            { 
                switch(comboBox2.Text)
                {
                    case "otsu":
                        Cv2.CvtColor(frame, frame, ColorConversionCodes.BGR2GRAY);
                        Cv2.Threshold(frame, frame, 100, 255, ThresholdTypes.Otsu);
                        break;
                    case "negative":
                        Mat[] s = Cv2.Split(frame);
                        for(int i=0; i<s.Length;i++)
                        {
                            s[i] = 255 - s[i];
                        }
                        Cv2.Merge(s, frame);
                        break;
                }
                Thread.Sleep(100);
            }
            catch
            {
                cam.clsoe();
            }
           
        }

        private void btn_openvideo_Click(object sender, EventArgs e)
        {
            cam.open();
            Task t1 = new Task(() => stream());
            t1.Start();
        }

        private void btn_Stop_video_Click(object sender, EventArgs e)
        {
            cam.stop();
            cam.clsoe();
        }
        string filepath;
        private void openfolder_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description="請選擇資料夾";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                filepath = dialog.SelectedPath;
            }
        }

        private void Process_btn_Click(object sender, EventArgs e)
        {
            string Save_path = filepath + $"//{comboBox2.Text}//";
            if (! Directory.Exists(Save_path))
            {
                Directory.CreateDirectory(Save_path);
            }
            DirectoryInfo di = new DirectoryInfo(filepath);
            FileInfo[] files = di.GetFiles(".");
            int len = files.Length - 1;
            progressBar1.Maximum = len;
            progressBar1.Value = 0;
            int num = 0;
            foreach(FileInfo file in  files)  //輪尋所有資料
            {
                progressBar1.Value = num;
                Mat img_file = Cv2.ImRead(filepath + "//" + file.Name);
                Console.WriteLine(file.Name);
                switch(comboBox2.Text)
                {
                    case "otsu":
                        Cv2.CvtColor(img_file, img_file, ColorConversionCodes.BGR2GRAY);
                        Cv2.Threshold(img_file, img_file, 100, 255, ThresholdTypes.Otsu);
                        break;
                   
                    case "negative":
                        Mat[] s = Cv2.Split(img_file);
                        for (int i = 0; i < s.Length; i++)
                        {
                          s[i] = 255 - s[i];
                        }
                        Cv2.Merge(s, img_file);
                        break;

                    case "equalization":
                        Cv2.CvtColor(img_file, img_file, ColorConversionCodes.BGR2GRAY);
                        Cv2.EqualizeHist(img_file, img_file);

                        break;
                }

                Cv2.ImWrite(Save_path + file.Name, img_file);
                num++;
            
            }
        
        }

       



    }
}
