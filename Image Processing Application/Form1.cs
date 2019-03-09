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

        private void changePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.bmp)|*.jpg; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                mainPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        Bitmap bitMapOriginal, bitMapResult;

        private void getCoordinatesRGBValue_Click(object sender, EventArgs e)
        {

            int xCoordinate = Convert.ToInt16(yCoordinateTextBox.Text);
            int yCoordinate = Convert.ToInt16(xCoordinateTextBox.Text);

            bitMapOriginal = (Bitmap)mainPictureBox.Image;

            int redValue = bitMapOriginal.GetPixel(xCoordinate, yCoordinate).R;
            int greenValue = bitMapOriginal.GetPixel(xCoordinate, yCoordinate).G;
            int blueValue = bitMapOriginal.GetPixel(xCoordinate, yCoordinate).B;

            rValueTextBox.Text = redValue.ToString();
            gValueTextBox.Text = greenValue.ToString();
            bValueTextBox.Text = blueValue.ToString();
        }

        private void changeBrightnessButton_Click(object sender, EventArgs e)
        {
            int brightnessValue = Convert.ToInt16(brightnessTextBox.Text);
            int redValue, greenValue, blueValue;

            bitMapOriginal = (Bitmap)mainPictureBox.Image;

            int row = bitMapOriginal.Width;
            int column = bitMapOriginal.Height;

            bitMapResult = new Bitmap(row, column);

            Cursor = Cursors.WaitCursor;

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    redValue = bitMapOriginal.GetPixel(i, j).R + brightnessValue;
                    greenValue = bitMapOriginal.GetPixel(i, j).G + brightnessValue;
                    blueValue = bitMapOriginal.GetPixel(i, j).B + brightnessValue;

                    if (redValue > 255) redValue = 255;
                    if (greenValue > 255) greenValue = 255;
                    if (blueValue > 255) blueValue = 255;

                    if (redValue < 0) redValue = 0;
                    if (greenValue < 0) greenValue = 0;
                    if (blueValue < 0) blueValue = 0;

                    bitMapResult.SetPixel(i, j, Color.FromArgb(redValue, greenValue, blueValue));
                }
            }

            resultPictureBox.Image = bitMapResult;
            Cursor = Cursors.Default;
        }
    }
}
