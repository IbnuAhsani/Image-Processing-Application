using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_Processing_Application
{
    internal class PointerButtonFunctions
    { 
        /**
         * Unlock and lock the addresses of each pixels in order to be used for manipulation
         */
        internal Bitmap manipulatePicture(Bitmap bitMap, Action<BitmapData> calculationFunction)
        {
            BitmapData bitMapData = bitMap.LockBits(new Rectangle(0, 0, bitMap.Width, bitMap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                calculationFunction(bitMapData);
            }

            bitMap.UnlockBits(bitMapData);

            return bitMap;
        }

        /**
         * Calculations to invert picture's color by pointer
         */
        internal unsafe void invertColor(BitmapData bitMapData)
        {
            byte* p = (byte*)(void*)bitMapData.Scan0.ToPointer();
            int stopAddress = (int)p + bitMapData.Stride * bitMapData.Height;
            while ((int)p != stopAddress)
            {
                p[0] = (byte)(255 - p[0]);
                p[1] = (byte)(255 - p[1]);
                p[2] = (byte)(255 - p[2]);
                p += 3;
            }
        }
    }
}