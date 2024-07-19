using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;

namespace Sepia_JA
{
    public static class bytesArray
    {
        public static BitmapSource bmpBGRArrayToImage(
           this byte[] pixels, int width, int height, PixelFormat pixelFormat)
        {
            const int bitsInByte = 8;
            const int dpi = 96;
            WriteableBitmap bitmap = new WriteableBitmap(width, height, dpi, dpi, pixelFormat, null);

            bitmap.WritePixels(new Int32Rect(0, 0, width, height), pixels, width * (bitmap.Format.BitsPerPixel / bitsInByte), 0);

            return bitmap;
        }

        public static float[] toFloatArray(this byte[] byteArray)
        {
            var newFloatArray = new float[byteArray.Length];
            for (int i = 0; i < newFloatArray.Length; i++)
            {
                newFloatArray[i] = (float)byteArray[i];
            }
            return newFloatArray;
        }
    }
}