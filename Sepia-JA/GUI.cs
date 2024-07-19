using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection.Emit;
using System.Windows.Media.Imaging;

namespace Sepia_JA
{
    public partial class SepiaForm : Form
    {
        private Stopwatch stopwatch;
        private Bitmap pictureOriginal;
        private Bitmap pictureSepia;
        private float[] pixels;
        public SepiaForm()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }

        public void openImage()
        {
            OpenFileDialog openDialog = new OpenFileDialog
            {
                Filter = "Plik graficzny (*.bmp)|*.BMP; *.bmp",
                FileName = "*.bmp"
            };
            openDialog.ShowDialog();

            if (openDialog.FileName != "*.bmp")
            {
                Image image = Image.FromFile(openDialog.FileName);
                openDialog.Dispose();
                pictureOriginal = (Bitmap)image;
            }
        }

        public bool thumbnailCallback()
        {
            return false;
        }

        private Bitmap scaleBitmap(Bitmap bmp, PictureBox picBox)
        {

            float ratio = 1.0f;
            int thumbHeight = 0;
            int thumbWidth = 0;

            if (bmp.Height > picBox.Height || bmp.Width > picBox.Width)
            {
                Image.GetThumbnailImageAbort myCallback =
                    new Image.GetThumbnailImageAbort(thumbnailCallback);

                if (bmp.Height >= bmp.Width)
                {
                    ratio = (((float)bmp.Width) / ((float)bmp.Height));
                    thumbHeight = picBox.Height;
                    thumbWidth = (int)((thumbHeight) * (ratio));
                }
                else
                {
                    ratio = (((float)bmp.Height) / ((float)bmp.Width));
                    thumbWidth = picBox.Width;
                    thumbHeight = (int)((thumbWidth) * (ratio));
                }

                Image myThumbnail = bmp.GetThumbnailImage(thumbWidth, thumbHeight, myCallback, IntPtr.Zero);
                return new Bitmap(myThumbnail);
            }
            return bmp;
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            openImage();
            if (pictureOriginal != null && pictureOriginal.Width>0 && pictureOriginal.Height>0)
            {
                pictureBefore.Image = scaleBitmap(pictureOriginal, pictureBefore);
            }
        }

        private void threads_Scroll(object sender, EventArgs e)
        {
            threads.Text = threadsNumber.Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if ((ASM.Checked || CS.Checked) && !pictureBefore.Image.Equals(null))
            {
                String sepiaMechanism = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
                BitmapSource bitmapsource = bitmap.bmpToBmpSource(pictureOriginal);
                pixels = bitmap.bmpToBGRArray(bitmapsource);
                double[] wyniki = new double[320];
                sepiaManager manager = null;
                if (ASM.Checked)
                {
                    manager = new sepiaManager(bitmapsource, enumTypes.Assembly, 20, threadsNumber.Value);
                }
                else if (CS.Checked)
                {
                    manager = new sepiaManager(bitmapsource, enumTypes.Cpp, 20, threadsNumber.Value);
                }
                
                TimeSpan timer;
                BitmapSource bitmapsourceafter = manager.executeEffect(out timer);
                pictureAfter.Image = scaleBitmap(bitmap.bmpFromSource(bitmapsourceafter), pictureAfter);
                pictureSepia = bitmap.bmpFromSource(bitmapsourceafter);
                time.Text = timer.TotalMilliseconds.ToString();
            }
            
        }

        private void CS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (pictureSepia != null)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = "save";
                saveDialog.Filter = "Plik graficzny (*.bmp)|*.bmp; *.BMP";
                saveDialog.ShowDialog();
                pictureSepia.Save(saveDialog.FileName);
                saveDialog.Dispose();
            }
        }
    }
 }