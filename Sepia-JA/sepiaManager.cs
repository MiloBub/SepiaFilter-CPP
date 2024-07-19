using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Sepia_JA
{
    class sepiaManager
    {
        private BitmapSource _oldBitmap;
        private List<sepiaInterface> _sepiaInterfaces = new List<sepiaInterface>();
        private List<Task> _tasks = new List<Task>();
        private int _numberOfThreads;
        private float[] _allPixels;

        const int _bitsInByte = 8;

        private sepiaManager() { }

        public sepiaManager(BitmapSource bitmapImage,
            enumTypes mechanismType,
            float sepiaRate, int numberOfThreads)
        {
            _oldBitmap = bitmapImage;
            _allPixels = retrievePixels(bitmapImage);
            _numberOfThreads = numberOfThreads;
            int pieceLenght = adjustPieceLenght();
            float[] sepiaRates = { 0, sepiaRate, 2 * sepiaRate, 0 };
            for (int partNumber = 0; partNumber < _numberOfThreads; partNumber++)   
            {
                int tempPartNumber = partNumber;
                int pieceEnd;
                if (partNumber + 1 == _numberOfThreads)
                    pieceEnd = _allPixels.Length;
                else
                    pieceEnd = pieceLenght * (tempPartNumber + 1) - 1;
                _sepiaInterfaces.Add(sepiaFactory.create(
                        mechanismType, sepiaRates,
                        bitmapImage.Format.BitsPerPixel / _bitsInByte,
                        pieceLenght * tempPartNumber,
                        pieceEnd));
                _tasks.Add(new Task(() =>
                    _sepiaInterfaces[tempPartNumber].executeEffect(_allPixels)));
            }
        }

        private int adjustPieceLenght()
        {
            int pieceLenght = _allPixels.Length / _numberOfThreads;
            while (pieceLenght % (_oldBitmap.Format.BitsPerPixel / _bitsInByte) != 0)
                pieceLenght++;
            return pieceLenght;
        }

        private float[] retrievePixels(BitmapSource bitmapImage)
        {
            return bitmapImage.bmpToBGRArray();
        }

        public BitmapSource executeEffect(out System.TimeSpan elapsedTime)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Parallel.ForEach(_tasks, (task) => task.Start());
            Task.WaitAll(_tasks.ToArray());

            stopwatch.Stop();
            elapsedTime = stopwatch.Elapsed;

            return _allPixels.bmpBGRArrayToImage(_oldBitmap.PixelWidth,
                _oldBitmap.PixelHeight, _oldBitmap.Format);
        }
    }
}