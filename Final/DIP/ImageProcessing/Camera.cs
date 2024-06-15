using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ImageProcessing
{
    class Camera
    {
        private VideoCapture video;
        public bool connect;
        public bool running;

        public Camera() // 建構 初始化時會直接質性
        {
            video = new VideoCapture(0); //@"路徑"
            if(! video.IsOpened())
            {
                Console.WriteLine("Open fail");
                connect = false;
                running = false;
                return;
            }
            connect = true;
            running = true;
        }

        public Mat GetFrame() 
        {
            Mat Camera = new Mat();
            if (connect && running)
                video.Read(Camera);
            return Camera;
        }

        public void open()
        {
            if (connect)
                running = true;
        }

        public void stop()
        {
            if (connect)
                running = false;
        }
        
        public void clsoe()
        {
            if (connect)
                running = false;
        }

    }
}
