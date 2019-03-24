using System;
using System.Drawing;

namespace Image_Processing_Application
{
    internal class CalculatedButtonFunctions
    {
        /// <summary>
        /// Button Functions by Calculation
        /// </summary>

        internal Bitmap changeBrightness(int row, int column, int brightnessValue, Bitmap bitMapSource)
        {
            // RGB values for the calculated pixel value
            int redValue, greenValue, blueValue;

            // Create a new empty bitmap with the same dimensions as the source bitmap
            Bitmap bitMapResult = new Bitmap(bitMapSource.Width, bitMapSource.Height);

            // For how tall the original picture is
            for (int i = 0; i < row; i++)
            {
                // For how wide the original picture is
                for (int j = 0; j < column; j++)
                {
                    Color coordinatePixelValue = bitMapSource.GetPixel(i, j);

                    // Add the brightness value to the original RGB value 
                    redValue = coordinatePixelValue.R + brightnessValue;
                    greenValue = coordinatePixelValue.G + brightnessValue;
                    blueValue = coordinatePixelValue.B + brightnessValue;

                    // If the resulting RGB value exceeds maximum brightness value
                    if (redValue > 255) redValue = 255;
                    if (greenValue > 255) greenValue = 255;
                    if (blueValue > 255) blueValue = 255;

                    // If the resulting RGB value exceeds minimum brightness value
                    if (redValue < 0) redValue = 0;
                    if (greenValue < 0) greenValue = 0;
                    if (blueValue < 0) blueValue = 0;

                    // Set the pixel of Coordinate (i, j) of the resulting picture to the resulting RGB value 
                    bitMapResult.SetPixel(i, j, Color.FromArgb(redValue, greenValue, blueValue));
                }
            }

            // Returns the resulting bitmap
            return bitMapResult;
        }

        /**
         * Function that returns the greyscale value based on averaging method
         */
        internal int getGreyscaleAverageValue(int row, int column, Bitmap bitMapSource)
        {
            Color pixel = bitMapSource.GetPixel(row, column);
            int redValue = pixel.R;
            int greenValue = pixel.G;
            int blueValue = pixel.B;

            return (redValue + greenValue + blueValue) / 3;
        }

        internal Bitmap greyscaleAveraging(int row, int column, Bitmap bitMapSource)
        {
            // Greyscaled RGB values
            int greyscaledValue;

            // Create a new empty bitmap with the same dimensions as the source bitmap
            Bitmap bitMapResult = new Bitmap(bitMapSource.Width, bitMapSource.Height);

            // For how tall the original picture is
            for (int i = 0; i < row; i++)
            {
                // For how wide the original picture is
                for (int j = 0; j < column; j++)
                {
                    // Convert the original RGB to inverted value
                    greyscaledValue = getGreyscaleAverageValue(i, j, bitMapSource);

                    // Set the pixel of Coordinate (i, j) of the resulting picture to the inverted RGB value 
                    bitMapResult.SetPixel(i, j, Color.FromArgb(greyscaledValue, greyscaledValue, greyscaledValue));
                }
            }
           
            return bitMapResult;
        }

        internal Bitmap greyscaleLuma(int row, int column, Bitmap bitMapSource)
        {
            // Greyscaled RGB values
            int redValue, greenValue, blueValue, roundedGreyscaledValue;
            double greyscaledValue;

            // Create a new empty bitmap with the same dimensions as the source bitmap
            Bitmap bitMapResult = new Bitmap(bitMapSource.Width, bitMapSource.Height);

            // For how tall the original picture is
            for (int i = 0; i < row; i++)
            {
                // For how wide the original picture is
                for (int j = 0; j < column; j++)
                {
                    Color coordinatePixelValue = bitMapSource.GetPixel(i, j);

                    // Get the original RGB value
                    redValue = coordinatePixelValue.R;
                    greenValue = coordinatePixelValue.G;
                    blueValue = coordinatePixelValue.B;

                    // Calculate greyscale value based on Luma method
                    greyscaledValue = 0.2126 * redValue + 0.7152 * greenValue + 0.0722 * blueValue;

                    // Convert the double value to integer value
                    roundedGreyscaledValue = Convert.ToInt16(greyscaledValue);

                    // Set the pixel of Coordinate (i, j) of the resulting picture to the inverted RGB value 
                    bitMapResult.SetPixel(i, j, Color.FromArgb(roundedGreyscaledValue, roundedGreyscaledValue, roundedGreyscaledValue));
                }
            }

            return bitMapResult;
        }

        internal Bitmap invertPicture(int row, int column, Bitmap bitMapSource)
        {
            // Inverted RGB values
            int invertRedValue, invertGreenValue, invertBlueValue;

            // Create a new empty bitmap with the same dimensions as the source bitmap
            Bitmap bitMapResult = new Bitmap(bitMapSource.Width, bitMapSource.Height);

            // For how tall the original picture is
            for (int i = 0; i < row; i++)
            {
                // For how wide the original picture is
                for (int j = 0; j < column; j++)
                {
                    Color coordinatePixelValue = bitMapSource.GetPixel(i, j);

                    // Convert the original RGB to inverted value
                    invertRedValue = 255 - coordinatePixelValue.R;
                    invertGreenValue = 255 - coordinatePixelValue.G;
                    invertBlueValue = 255 - coordinatePixelValue.B;

                    // Set the pixel of Coordinate (i, j) of the resulting picture to the inverted RGB value 
                    bitMapResult.SetPixel(i, j, Color.FromArgb(invertRedValue, invertGreenValue, invertBlueValue));
                }
            }

            return bitMapResult;
        }

        /**
         * Returns 0 OR 255 based on the rgbValue and thresholdValue
         */
        private int getThresholdValue(int rgbValue, int thresholdValue)
        {
            if (rgbValue > thresholdValue)
            {
                return 255;
            }

            return 0;
        }

        internal Bitmap thresholdPicture(int row, int column, int thresholdValue, Bitmap bitMapSource)
        {
            // Variables for the RGB and thresholded RGB value
            int redValue, greenValue, blueValue;
            int thresholdedRedValue, thresholdedGreenValue, thresholdedBlueValue, thresholdedFinalValue;

            // Create a new empty bitmap with the same dimensions as the source bitmap
            Bitmap bitMapResult = new Bitmap(bitMapSource.Width, bitMapSource.Height);

            // For how tall the original picture is
            for (int i = 0; i < row; i++)
            {
                // For how wide the original picture is
                for (int j = 0; j < column; j++)
                {
                    Color coordinatePixelValue = bitMapSource.GetPixel(i, j);

                    // Get the original RGB value
                    redValue = coordinatePixelValue.R;
                    greenValue = coordinatePixelValue.G;
                    blueValue = coordinatePixelValue.B;

                    // Get the thresholded RGB value
                    thresholdedRedValue = getThresholdValue(redValue, thresholdValue);
                    thresholdedGreenValue = getThresholdValue(greenValue, thresholdValue);
                    thresholdedBlueValue = getThresholdValue(blueValue, thresholdValue);

                    // Calculate for the final threshold value
                    if (thresholdedRedValue > thresholdValue && thresholdedGreenValue > thresholdValue && thresholdedBlueValue > thresholdValue)
                    {
                        thresholdedFinalValue = 255;
                    }
                    else
                    {
                        thresholdedFinalValue = 0;
                    }

                    // Set the pixel of Coordinate (i, j) of the resulting picture to the resulting RGB value 
                    bitMapResult.SetPixel(i, j, Color.FromArgb(thresholdedFinalValue, thresholdedFinalValue, thresholdedFinalValue));
                }
            }

            return bitMapResult;
        }
    }
}