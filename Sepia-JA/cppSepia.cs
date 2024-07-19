using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sepia_JA
{
    internal class cppSepia : sepiaInterface
    {
        public cppSepia(float[] sepiaRates, int bytesPerPixel,
            int startIndex, int endIndex)
            : base(sepiaRates, bytesPerPixel, startIndex, endIndex)
        { }

        [DllImport(@"..\..\..\x64\Debug\SepiaCPP.dll", EntryPoint = "sepiaCpp")]
        private static extern void sepiaCppAlgorithm(
            float[] pixels, int size,
            float[] sepiaRate, float[] rgbRates,
            int bytesPerPixel, int startIndex, int endIndex);

        public override void executeEffect(float[] allPixels)
        {
            sepiaCppAlgorithm(allPixels, allPixels.Length,
                _sepiaRates, _rgbRates,
                _bytesPerPixel, _startIndex, _endIndex);
        }
    }
}