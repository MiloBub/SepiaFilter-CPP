using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sepia_JA
{
    static class sepiaFactory
    {
        public static sepiaInterface create(enumTypes mechanismType, float[] sepiaRates, int bytesPerPixel, int startIndex, int endIndex)
        {
            switch (mechanismType)
            {
                case enumTypes.Assembly:
                    return new asmSepia(sepiaRates, bytesPerPixel, startIndex, endIndex);
                case enumTypes.Cpp:
                    return new cppSepia(sepiaRates, bytesPerPixel, startIndex, endIndex);
                default:
                    return null;
            }
        }
    }
}