﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Processing_Application
{
    public partial class Form1 : Form
    {
        CalculatedButtonFunctions calculatedButtonFunctions;
        PointerButtonFunctions pointerButtonFunctions;

        public Form1()
        {
            InitializeComponent();
            calculatedButtonFunctions = new CalculatedButtonFunctions();
            pointerButtonFunctions = new PointerButtonFunctions();
        }

        /// <summary>
        /// Mouse Functions
        /// </summary>

        private bool isGetXYRGBValuesActivated = false;

        private void mainPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (isGetXYRGBValuesActivated)
            {
                // Checks if the main picture box is empty or not
                bool isMainPictureBoxNullOrEmpty = mainPictureBox == null || mainPictureBox.Image == null;
                if (!isMainPictureBoxNullOrEmpty)
                {
                    // Variables for the x, y coordinates, the bitmap for the main picture box, color value of the coordinate
                    int xCoordinate = e.X, yCoordinate = e.Y;
                    Color coordinatePixelValue = this.bitMapOriginal.GetPixel(xCoordinate, yCoordinate);

                    // Set the x, y coordinate textbox to where the mouse is hovering
                    xCoordinateTextBox.Text = xCoordinate.ToString();
                    yCoordinateTextBox.Text = yCoordinate.ToString();

                    // Set the RGB value textbox to where the mouse is hovering
                    rValueTextBox.Text = coordinatePixelValue.R.ToString();
                    gValueTextBox.Text = coordinatePixelValue.G.ToString();
                    bValueTextBox.Text = coordinatePixelValue.B.ToString();

                    isGetXYRGBValuesActivated = false;
                }

            }
        }

        /// <summary>
        /// Button Functions by Calculation
        /// </summary>

        // Variables for the Bitmap's row and column
        int row, column;

        // Bitmap variables for original and result pictures
        Bitmap bitMapOriginal, bitMapResult;

        /**
         * Function to save the picture uploaded from the file explorer to the global original bit map variable
         */
        private void saveBitMapOriginal(Bitmap bitMapResult)
        {
            this.bitMapOriginal = bitMapResult;
        }

        /**
         * Function to save the bitmap of resulting calculation to the global bit map result variable
         */
        private void saveAndDisplayBitMapResult(Bitmap bitMapOriginal)
        {
            this.bitMapResult = bitMapOriginal;
            resultPictureBox.Image = this.bitMapResult;
        }

        /**
         * Function to setup the original and result Bitmap
         */
        private void bitMapSetup()
        {
            // Get the width and height of the original picture
            this.row = this.bitMapOriginal.Width;
            this.column = this.bitMapOriginal.Height;

            // Create a new Bitmap with the size of the original picture
            this.bitMapResult = new Bitmap(row, column);
        }

        /**
         * Function to change the brightness of the picture based on the brightness value input
         */
        private void changeBrightnessButton_Click(object sender, EventArgs e)
        {
            // Get the brightness value from brightness text box
            int brightnessValue = Convert.ToInt16(brightnessTextBox.Text);

            // Setup the original and result Bitmap
            bitMapSetup();

            // Display the loading animation for the cursor
            Cursor = Cursors.WaitCursor;

            // Change the brightness of the picture
            this.bitMapResult = calculatedButtonFunctions.changeBrightness(row, column, brightnessValue, this.bitMapOriginal);

            // Display the resulting 
            resultPictureBox.Image = this.bitMapResult;

            // Stop the cursor loading animation
            Cursor = Cursors.Default;
        }

        private void changePictureToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Open a Windows dialog
            OpenFileDialog open = new OpenFileDialog();

            // Fiter the format that can be displayed by the dialog
            open.Filter = "Image Files(*.jpg; *.bmp)|*.jpg; *.bmp";

            // Change the picture in the main picture box
            if (open.ShowDialog() == DialogResult.OK)
            {
                saveBitMapOriginal(new Bitmap(open.FileName));
                mainPictureBox.Image = this.bitMapOriginal;
            }
        }

        /**
         * Function to get the RGB values based on the coordinates input
         */
        private void getCoordinatesRGBValue_Click(object sender, EventArgs e)
        {
            isGetXYRGBValuesActivated = true;
        }

        /**
         * Function to greyscale a picture using averaging method
         */ 
        private void greyscaleAveragingButton_Click(object sender, EventArgs e)
        {

            // Setup the original and result Bitmap
            bitMapSetup();

            // Display the loading animation for the cursor
            Cursor = Cursors.WaitCursor;

            // Calculate for the greyscaled picture by averging
            this.bitMapResult = calculatedButtonFunctions.greyscaleAveraging(row, column, this.bitMapOriginal);

            // Display the resulting 
            resultPictureBox.Image = this.bitMapResult;

            // Stop the cursor loading animation
            Cursor = Cursors.Default;
        }

        /**
         * Function to greyscale a picture using luma method
         */
        private void greyscaleLumaButton_Click(object sender, EventArgs e)
        {

            // Setup the original and result Bitmap
            bitMapSetup();

            // Display the loading animation for the cursor
            Cursor = Cursors.WaitCursor;

            // Calculate for the greyscaled picture by Luma equation
            this.bitMapResult = calculatedButtonFunctions.greyscaleLuma(row, column, bitMapOriginal);

            // Display the resulting 
            resultPictureBox.Image = this.bitMapResult;

            // Stop the cursor loading animation
            Cursor = Cursors.Default;
        }

        /**
         * Function to invert the color of the picture by calculation
         */
        private void invertPictureButton_Click(object sender, EventArgs e)
        {

            // Setup the original and result Bitmap
            bitMapSetup();

            // Display the loading animation for the cursor
            Cursor = Cursors.WaitCursor;

            // Calculate for the inverted version of the picture
            this.bitMapResult = calculatedButtonFunctions.invertPicture(row, column, bitMapOriginal);

            // Display the resulting 
            resultPictureBox.Image = this.bitMapResult;

            // Stop the cursor loading animation
            Cursor = Cursors.Default;
        }

        /**
         * Function to greyscale an image based on a specific threshold
         */
        private void thresholdPictureButton_Click(object sender, EventArgs e)
        {
            // Get the threshold value from threshold text box
            int thresholdValue = Convert.ToInt16(thresholdValueTextBox.Text);

            // Setup the original and result Bitmap
            bitMapSetup();

            // Display the loading animation for the cursor
            Cursor = Cursors.WaitCursor;

            // Calculate for the thresholded picture
            this.bitMapResult = calculatedButtonFunctions.thresholdPicture(row, column, thresholdValue, bitMapOriginal);

            // Display the resulting 
            resultPictureBox.Image = this.bitMapResult;

            // Stop the cursor loading animation
            Cursor = Cursors.Default;
        }

        /**
         * Function to show picture histogram
         */ 
        private void showPictureHistogramButton_Click(object sender, EventArgs e)
        {
            // Array to hold the greyscale values and their amount
            int[] histogramValue = new int[256];
            int max = 0, histogramValueMaxIndex = 0;

            // Setup the original and result Bitmap
            bitMapSetup();

            // Display the loading animation for the cursor
            Cursor = Cursors.WaitCursor;

            // Variable for the greyscale value
            int greyscaleValue;
            
            // For how tall the original picture is
            for (int i = 0; i < row; i++)
            {
                // For how wide the original picture is
                for (int j = 0; j < column; j++)
                {
                    // Convert the original RGB to inverted value
                    greyscaleValue = calculatedButtonFunctions.getGreyscaleAverageValue(i, j, bitMapOriginal);

                    // Set the pixel of Coordinate (i, j) of the resulting picture to the inverted RGB value 
                    this.bitMapResult.SetPixel(i, j, Color.FromArgb(greyscaleValue, greyscaleValue, greyscaleValue));

                    // Increment the amount of that specific greyscaleValue in the array
                    histogramValue[greyscaleValue]++;

                    // Change the max value
                    if (max < histogramValue[greyscaleValue])
                    {
                        max = histogramValue[greyscaleValue];
                        histogramValueMaxIndex = greyscaleValue;
                    }
                }
            }

            // Display the resulting 
            resultPictureBox.Image = this.bitMapResult;

            // Stop the cursor loading animation
            Cursor = Cursors.Default;

            // Variables regarding histogram
            int histogramHeight = 236;
            float histogramValuePercentage;
            Bitmap histogramData = new Bitmap(256, histogramHeight + 10);

            // Draw the histogram
            using (Graphics g = Graphics.FromImage(histogramData))
            {
                for (int v = 0; v < 256; v++)
                {
                    histogramValuePercentage = (histogramValue[v] * histogramHeight) / max;   // What percentage of the max is this value
                    g.DrawLine(
                        Pens.Black,
                        new Point(v, histogramHeight),
                        new Point(v, histogramHeight - (int)Math.Round(histogramValuePercentage))  // Use that percentage of the height
                    );
                }
            }

            // Variable to display the histogram in a form
            var histogramForm = new Form
            {
                ShowInTaskbar = false,
                TopMost = true,
                Size = histogramData.Size,
                Location = new Point(0, 0),
                StartPosition = FormStartPosition.Manual,
                BackgroundImage = histogramData
            };

            // Display the form
            histogramForm.Show();
        }

        /// <summary>
        /// Button Functions by Pointer
        /// </summary>

        /**
         * Function to invert the color of the picture by pointer
         */
        private void invertPictureByPointerButton_Click(object sender, EventArgs e)
        {
            Bitmap bitMapOriginalCopy = new Bitmap(this.bitMapOriginal);
            Bitmap invertedBitMap = pointerButtonFunctions.manipulatePicture(bitMapOriginalCopy, pointerButtonFunctions.invertColor);

            // Save the resulting bit map to the global bit map result variable
            saveAndDisplayBitMapResult(invertedBitMap);
        }

        /**
         * Function to greyscale an image using BT.601 method by pointer
         */
        private void greyscalePointerButton_Click(object sender, EventArgs e)
        {
            Bitmap bitMapOriginalCopy = new Bitmap(this.bitMapOriginal);
            Bitmap greyscaledBitMap = pointerButtonFunctions.manipulatePicture(bitMapOriginalCopy, pointerButtonFunctions.convertBt601Greyscale);

            // Save the resulting bit map to the global bit map result variable
            saveAndDisplayBitMapResult(greyscaledBitMap);
        }

        /**
         * Function to threshold the picture
         */
        private void thresholdingPictureByPointerButton_Click(object sender, EventArgs e)
        {
            // Get the brightness value from brightness text box
            int thresholdValue = Convert.ToInt16(thresholdValueByPointerTextBox.Text);

            if (thresholdValue < 0) thresholdValue = 0;
            if (thresholdValue > 255) thresholdValue = 255;

            Bitmap bitMapOriginalCopy = new Bitmap(this.bitMapOriginal);
            Bitmap bitMapResult = pointerButtonFunctions.manipulatePictureWithOneParam(thresholdValue, bitMapOriginalCopy, pointerButtonFunctions.threshold);

            // Save the resulting bit map to the global bit map result variable
            saveAndDisplayBitMapResult(bitMapResult);
        }
        
        /**
         * Function to brighten the color of the picture by pointer
         */
        private void changeBrightnessByPointerButton_Click(object sender, EventArgs e)
        {
            // Get the brightness value from brightness text box
            int brightnessValue = Convert.ToInt16(brightnessByPointerTextBox.Text);

            if (brightnessValue < 0) brightnessValue = 0;
            if (brightnessValue > 255) brightnessValue = 255;

            Bitmap bitMapOriginalCopy = new Bitmap(this.bitMapOriginal);
            Bitmap bitMapResult = pointerButtonFunctions.manipulatePictureWithThreeParams(brightnessValue, bitMapOriginalCopy, pointerButtonFunctions.changeBrightness);

            // Save the resulting bit map to the global bit map result variable
            saveAndDisplayBitMapResult(bitMapResult);
        }
    }
}
