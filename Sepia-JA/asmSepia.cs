using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sepia_JA
{
    internal class asmSepia : sepiaInterface
    {
        public asmSepia(float[] sepiaRates, int bytesPerPixel,
            int startIndex, int endIndex)
            : base(sepiaRates, bytesPerPixel, startIndex, endIndex)
        { }

        [DllImport(@"..\..\..\x64\Debug\SepiaASM.dll")]
        private static extern void sepia(
            float[] pixels, float[] sepiaRates,
            float[] rgbRates, float[] array255, int startIndex, int endIndex);

        public override void executeEffect(float[] allPixels)
        {
            float[] array255 = { 255.0f, 255.0f, 255.0f, 255.0f };
            sepia(allPixels, _sepiaRates,
                _rgbRates, array255, _startIndex, _endIndex);
        }
    }
}