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
        internal Bitmap manipulatePicture(Bitmap bitMapSource, Action<BitmapData> calculationFunction)
        {
            BitmapData bitMapData = bitMapSource.LockBits(new Rectangle(0, 0, bitMapSource.Width, bitMapSource.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                calculationFunction(bitMapData);
            }

            bitMapSource.UnlockBits(bitMapData);

            return bitMapSource;
        }

        /**
         * Calculations to invert picture's color by pointer
         */
        internal unsafe void invertColor(BitmapData bitMapSourceData)
        {
            byte* p = (byte*)(void*)bitMapSourceData.Scan0.ToPointer();
            int stopAddress = (int)p + bitMapSourceData.Stride * bitMapSourceData.Height;
            while ((int)p != stopAddress)
            {
                p[0] = (byte)(255 - p[0]);
                p[1] = (byte)(255 - p[1]);
                p[2] = (byte)(255 - p[2]);
                p += 3;
            }
        }

        /**
         * Calculations to convert picture to greyscale using BT.601 method by pointer
         */
        internal unsafe void convertBt601Greyscale(BitmapData bitMapSourceData)
        {
            byte* p = (byte*)(void*)bitMapSourceData.Scan0.ToPointer();
            int stopAddress = (int)p + bitMapSourceData.Stride * bitMapSourceData.Height;
            while ((int)p != stopAddress)
            {
                p[0] = (byte)(.299 * p[2] + .587 * p[1] + .114 * p[0]);
                p[1] = p[0];
                p[2] = p[0];
                p += 3;
            }
        }

        /**
         * Unlock and lock the addresses of each pixels in order to be used for manipulation with an extra param for text box variable and with a helper function that has 1 param
         */
        internal unsafe Bitmap manipulatePictureWithOneParam(int textBoxValue, Bitmap bitMapSource, Action<int, BitmapData> calculationFunction)
        {
            BitmapData bitMapData = bitMapSource.LockBits(new Rectangle(0, 0, bitMapSource.Width, bitMapSource.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                calculationFunction(textBoxValue, bitMapData);
            }

            bitMapSource.UnlockBits(bitMapData);

            return bitMapSource;
        }

        /**
         * Calculations to threshold the picture based on the input threshold value
         */
        internal unsafe void threshold(int thresholdValue, BitmapData bitMapSourceData)
        {
            int finalThresholdValue;
            byte* p = (byte*)(void*)bitMapSourceData.Scan0.ToPointer();
            int stopAddress = (int)p + bitMapSourceData.Stride * bitMapSourceData.Height;
            while ((int)p != stopAddress)
            {
                if (p[0] < thresholdValue && p[1] < thresholdValue && p[2] < thresholdValue)
                {
                    finalThresholdValue = 0;
                }
                else
                {
                    finalThresholdValue = 255;
                }
                p[0] = (byte)finalThresholdValue;
                p[1] = (byte)finalThresholdValue;
                p[2] = (byte)finalThresholdValue;
                p += 3;
            }
        }

        /**
         * Unlock and lock the addresses of each pixels in order to be used for manipulation with an extra param for text box variable and with a helper function that has 3 params
         */
        internal Bitmap manipulatePictureWithThreeParams(int textBoxValue, Bitmap bitMapSource, Action<int, int, int, BitmapData> calculationFunction)
        {
            BitmapData bitMapData = bitMapSource.LockBits(new Rectangle(0, 0, bitMapSource.Width, bitMapSource.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int numOffset = bitMapData.Stride - bitMapData.Width * 3;
            int numWidth = bitMapData.Width * 3;

            unsafe
            {
                calculationFunction(numWidth, numOffset, textBoxValue, bitMapData);
            }

            bitMapSource.UnlockBits(bitMapData);
            Bitmap bitMapCopy = (Bitmap)bitMapSource.Clone();

            return bitMapCopy;
        }

        /**
         * Calculations to brighten the pixel of the image
         */
        internal unsafe void changeBrightness(int numWidth, int numOffset, int brightnessValue, BitmapData bitMapSourceData)
        {
            int x;
            byte* p = (byte*)(void*)bitMapSourceData.Scan0.ToPointer();
            for (int i = 0; i < bitMapSourceData.Height; i++)
            {
                for (int j = 0; j < numWidth; j++)
                {
                    x = (int)(p[0] + brightnessValue);
                    if (x < 0) x = 0;
                    if (x > 255) x = 255;

                    p[0] = (byte)x;
                    ++p;
                }
                p += numOffset;
            }
        }
    }
}