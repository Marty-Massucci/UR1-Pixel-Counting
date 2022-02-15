using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private Thread _captureThread;
        private int _threshold = 150;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            _capture = new VideoCapture(0);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();
            ThresholdTrackBar.Value = _threshold;
        }

        private void DisplayWebcam()
        {
            while (_capture.IsOpened)
            {
                Mat frame = _capture.QueryFrame();

                int newHeight = (frame.Size.Height * EmguPictureBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(EmguPictureBox.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);

                EmguPictureBox.Image = frame.Bitmap;

                Mat grayFrame = new Mat();
                Mat binaryFrame = new Mat();
                CvInvoke.CvtColor(frame, grayFrame, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                CvInvoke.Threshold(grayFrame, binaryFrame, _threshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

                BinaryPictureBox.Image = binaryFrame.Bitmap;
                int sliceWidth = frame.Width / 5; 

                /*
                Image<Gray, byte> img = frame.ToImage<Gray, byte>();
                img.ROI = new Rectangle(0, 0, frame.Width, frame.Height);
                int whitePixelsFirst = img.CountNonzero()[0];
                img.ROI = Rectangle.Empty;
                Invoke(new Action(() =>
                {
                    column1.Text = $"{whitePixelsFirst}";
                }));
                */


                //first fifth
                int whitePixelsfirst = 0;
                Image<Gray, byte> img2 = binaryFrame.ToImage<Gray, byte>();
                for (int x = 0; x < sliceWidth; x++)
                {
                    for (int y = 0; y < binaryFrame.Height; y++)
                    {
                        if (img2.Data[y, x, 0] == 255)
                        {
                            whitePixelsfirst++;
                        }
                    }
                }
                Invoke(new Action(() =>
                {
                    column1.Text = $"{whitePixelsfirst}";
                }));

                //second fifth
                int whitePixelssecond = 0;
                img2 = binaryFrame.ToImage<Gray, byte>();
                for (int x = sliceWidth; x < 2 * sliceWidth; x++)
                {
                    for (int y = 0; y < binaryFrame.Height; y++)
                    {
                        if (img2.Data[y, x, 0] == 255)
                        {
                            whitePixelssecond++;
                        }
                    }
                }
                Invoke(new Action(() =>
                {
                    column2.Text = $"{whitePixelssecond}";
                }));

                //third fifth
                int whitePixelsthird = 0;
                img2 = binaryFrame.ToImage<Gray, byte>();
                for (int x = 2 * sliceWidth; x < 3 * sliceWidth; x++)
                {
                    for (int y = 0; y < binaryFrame.Height; y++)
                    {
                        if (img2.Data[y, x, 0] == 255)
                        {
                            whitePixelsthird++;
                        }
                    }
                }
                Invoke(new Action(() =>
                {
                    column3.Text = $"{whitePixelsthird}";
                }));

                //fourth fifth
                int whitePixelsfourth = 0;
                img2 = binaryFrame.ToImage<Gray, byte>();
                for (int x = 3 * sliceWidth; x < 4 * sliceWidth; x++)
                {
                    for (int y = 0; y < binaryFrame.Height; y++)
                    {
                        if (img2.Data[y, x, 0] == 255)
                        {
                            whitePixelsfourth++;
                        }
                    }
                }
                Invoke(new Action(() =>
                {
                    column4.Text = $"{whitePixelsfourth}";
                }));

                //fifth fifth
                int whitePixelsfifth = 0;
                img2 = binaryFrame.ToImage<Gray, byte>();
                for (int x = 4 * sliceWidth; x < binaryFrame.Width; x++)
                {
                    for (int y = 0; y < binaryFrame.Height; y++)
                    {
                        if (img2.Data[y, x, 0] == 255)
                        {
                            whitePixelsfifth++;
                        }
                    }
                }
                Invoke(new Action(() =>
                {
                    column5.Text = $"{whitePixelsfifth}";
                }));


            }
        }

        


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }

        private void ThresholdTrackBar_Scroll(object sender, EventArgs e)
        {
            _threshold = ThresholdTrackBar.Value;
        }


    }
}
