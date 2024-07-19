using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace Sepia_JA
{
    public static class pixelsArray
    {
        public static BitmapSource bmpBGRArrayToImage(
                this float[] pixels, int width, int height, PixelFormat pixelFormat)
        {
            byte[] byteArray = pixels.toByteArray();
            return byteArray.bmpBGRArrayToImage(width, height, pixelFormat);
        }

        public static byte[] toByteArray(this float[] floatArray)
        {
            var newByteArray = new byte[floatArray.Length];
            for (int i = 0; i < newByteArray.Length; i++)
            {
                newByteArray[i] = (byte)floatArray[i];
            }
            return newByteArray;
        }
    }
}