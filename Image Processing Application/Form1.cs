using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Bitmap variables for original and result pictures
        Bitmap bitMapOriginal, bitMapResult;

        /**
         * Function to change the brightness of the picture based on the brightness value input
         */
        private void changeBrightnessButton_Click(object sender, EventArgs e)
        {
            // Get the brightness value from brightness text box
            int brightnessValue = Convert.ToInt16(brightnessTextBox.Text);
            int redValue, greenValue, blueValue;

            // Get the original picture
            bitMapOriginal = (Bitmap)mainPictureBox.Image;

            // Get the width and height of the original picture
            int row = bitMapOriginal.Width;
            int column = bitMapOriginal.Height;

            // Create a new Bitmap with the size of the original picture
            bitMapResult = new Bitmap(row, column);

            // Display the loading animation for the cursor
            Cursor = Cursors.WaitCursor;

            // For how tall the original picture is
            for (int i = 0; i < row; i++)
            {
                // For how wide the original picture is
                for (int j = 0; j < column; j++)
                {
                    // Add the brightness value to the original RGB value 
                    redValue = bitMapOriginal.GetPixel(i, j).R + brightnessValue;
                    greenValue = bitMapOriginal.GetPixel(i, j).G + brightnessValue;
                    blueValue = bitMapOriginal.GetPixel(i, j).B + brightnessValue;

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

            // Display the resulting picture
            resultPictureBox.Image = bitMapResult;

            // Stop the cursor loading animation
            Cursor = Cursors.Default;
        }

        /**
         * Function to change the picture in the main picture box
         */
        private void changePictureButton_Click(object sender, EventArgs e)
        {
            // Open a Windows dialog
            OpenFileDialog open = new OpenFileDialog();

            // Fiter the format that can be displayed by the dialog
            open.Filter = "Image Files(*.jpg; *.bmp)|*.jpg; *.bmp";

            // Change the picture in the main picture box
            if (open.ShowDialog() == DialogResult.OK)
            {
                mainPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        /**
         * Function to get the RGB values based on the coordinates input
         */
        private void getCoordinatesRGBValue_Click(object sender, EventArgs e)
        {
            // Convert the string X and Y coordinates to Integers
            int xCoordinate = Convert.ToInt16(yCoordinateTextBox.Text);
            int yCoordinate = Convert.ToInt16(xCoordinateTextBox.Text);

            // Get the original picture
            bitMapOriginal = (Bitmap)mainPictureBox.Image;

            // Get the RGB value of the specific coordinate in the picture
            int redValue = bitMapOriginal.GetPixel(xCoordinate, yCoordinate).R;
            int greenValue = bitMapOriginal.GetPixel(xCoordinate, yCoordinate).G;
            int blueValue = bitMapOriginal.GetPixel(xCoordinate, yCoordinate).B;

            // Display the RGB value in the RGB text boxes
            rValueTextBox.Text = redValue.ToString();
            gValueTextBox.Text = greenValue.ToString();
            bValueTextBox.Text = blueValue.ToString();
        }

        /**
         * Function to greyscale a picture using averaging method
         */ 
        private void greyscaleAveragingButton_Click(object sender, EventArgs e)
        {
            // Greyscaled RGB values
            int redValue, greenValue, blueValue, greyscaledValue;

            // Get the original picture
            bitMapOriginal = (Bitmap)mainPictureBox.Image;

            // Get the width and height of the original picture
            int row = bitMapOriginal.Width;
            int column = bitMapOriginal.Height;

            // Create a new Bitmap with the size of the original picture
            bitMapResult = new Bitmap(row, column);

            // Display the loading animation for the cursor
            Cursor = Cursors.WaitCursor;

            // For how tall the original picture is
            for (int i = 0; i < row; i++)
            {
                // For how wide the original picture is
                for (int j = 0; j < column; j++)
                {
                    // Convert the original RGB to inverted value
                    redValue = bitMapOriginal.GetPixel(i, j).R;
                    greenValue = bitMapOriginal.GetPixel(i, j).G;
                    blueValue = bitMapOriginal.GetPixel(i, j).B;

                    greyscaledValue = (redValue + greenValue + blueValue) / 3;

                    // Set the pixel of Coordinate (i, j) of the resulting picture to the inverted RGB value 
                    bitMapResult.SetPixel(i, j, Color.FromArgb(greyscaledValue, greyscaledValue, greyscaledValue));
                }
            }

            // Display the resulting picture
            resultPictureBox.Image = bitMapResult;

            // Stop the cursor loading animation
            Cursor = Cursors.Default;
        }

        /**
         * Function to greyscale a picture using luma method
         */
        private void greyscaleLumaButton_Click(object sender, EventArgs e)
        {
            // Greyscaled RGB values
            int redValue, greenValue, blueValue, roundedGreyscaledValue;
            double greyscaledValue;

            // Get the original picture
            bitMapOriginal = (Bitmap)mainPictureBox.Image;

            // Get the width and height of the original picture
            int row = bitMapOriginal.Width;
            int column = bitMapOriginal.Height;

            // Create a new Bitmap with the size of the original picture
            bitMapResult = new Bitmap(row, column);

            // Display the loading animation for the cursor
            Cursor = Cursors.WaitCursor;

            // For how tall the original picture is
            for (int i = 0; i < row; i++)
            {
                // For how wide the original picture is
                for (int j = 0; j < column; j++)
                {
                    // Get the original RGB value
                    redValue = bitMapOriginal.GetPixel(i, j).R;
                    greenValue = bitMapOriginal.GetPixel(i, j).G;
                    blueValue = bitMapOriginal.GetPixel(i, j).B;

                    // Calculate greyscale value based on Luma method
                    greyscaledValue = 0.2126 * redValue + 0.7152 * greenValue + 0.0722 * blueValue;

                    // Convert the double value to integer value
                    roundedGreyscaledValue = Convert.ToInt16(greyscaledValue);

                    // Set the pixel of Coordinate (i, j) of the resulting picture to the inverted RGB value 
                    bitMapResult.SetPixel(i, j, Color.FromArgb(roundedGreyscaledValue, roundedGreyscaledValue, roundedGreyscaledValue));
                }
            }

            // Display the resulting picture
            resultPictureBox.Image = bitMapResult;

            // Stop the cursor loading animation
            Cursor = Cursors.Default;
        }

        /**
         * Function to invert the color of the picture
         */
        private void invertPictureButton_Click(object sender, EventArgs e)
        {
            // Inverted RGB values
            int invertRedValue, invertGreenValue, invertBlueValue;

            // Get the original picture
            bitMapOriginal = (Bitmap)mainPictureBox.Image;

            // Get the width and height of the original picture
            int row = bitMapOriginal.Width;
            int column = bitMapOriginal.Height;

            // Create a new Bitmap with the size of the original picture
            bitMapResult = new Bitmap(row, column);

            // Display the loading animation for the cursor
            Cursor = Cursors.WaitCursor;

            // For how tall the original picture is
            for (int i = 0; i < row; i++)
            {
                // For how wide the original picture is
                for (int j = 0; j < column; j++)
                {
                    // Convert the original RGB to inverted value
                    invertRedValue = 255 - bitMapOriginal.GetPixel(i, j).R;
                    invertGreenValue = 255 - bitMapOriginal.GetPixel(i, j).G;
                    invertBlueValue = 255 - bitMapOriginal.GetPixel(i, j).B;

                    // Set the pixel of Coordinate (i, j) of the resulting picture to the inverted RGB value 
                    bitMapResult.SetPixel(i, j, Color.FromArgb(invertRedValue, invertGreenValue, invertBlueValue));
                }
            }

            // Display the resulting picture
            resultPictureBox.Image = bitMapResult;

            // Stop the cursor loading animation
            Cursor = Cursors.Default;
        }

        /**
         * Returns 0 OR 255 based on the rgbValue and thresholdValue
         */ 
        private int getThresholdValue(int rgbValue, int thresholdValue)
        {
            if(rgbValue > thresholdValue)
            {
                return 255;
            }

            return 0;
        }

        /**
         * Function to greyscale an image based on a specific threshold
         */
        private void thresholdPictureButton_Click(object sender, EventArgs e)
        {
            // Get the threshold value from threshold text box
            int thresholdValue = Convert.ToInt16(thresholdValueTextBox.Text);

            // Variables for the RGB and thresholded RGB value
            int redValue, greenValue, blueValue;
            int thresholdedRedValue, thresholdedGreenValue, thresholdedBlueValue, thresholdedFinalValue;

            // Get the original picture
            bitMapOriginal = (Bitmap)mainPictureBox.Image;

            // Get the width and height of the original picture
            int row = bitMapOriginal.Width;
            int column = bitMapOriginal.Height;

            // Create a new Bitmap with the size of the original picture
            bitMapResult = new Bitmap(row, column);

            // Display the loading animation for the cursor
            Cursor = Cursors.WaitCursor;

            // For how tall the original picture is
            for (int i = 0; i < row; i++)
            {
                // For how wide the original picture is
                for (int j = 0; j < column; j++)
                {
                    // Get the original RGB value
                    redValue = bitMapOriginal.GetPixel(i, j).R;
                    greenValue = bitMapOriginal.GetPixel(i, j).G;
                    blueValue = bitMapOriginal.GetPixel(i, j).B;

                    // Get the thresholded RGB value
                    thresholdedRedValue = getThresholdValue(redValue, thresholdValue);
                    thresholdedGreenValue = getThresholdValue(greenValue, thresholdValue);
                    thresholdedBlueValue = getThresholdValue(blueValue, thresholdValue);

                    // Calculate for the final threshold value
                    if(thresholdedRedValue > thresholdValue && thresholdedGreenValue > thresholdValue && thresholdedBlueValue > thresholdValue)
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

            // Display the resulting picture
            resultPictureBox.Image = bitMapResult;

            // Stop the cursor loading animation
            Cursor = Cursors.Default;
        }
    }
}
