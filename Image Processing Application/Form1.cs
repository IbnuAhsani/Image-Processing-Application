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

        Bitmap bitMap;

        private void getCoordinatesRGBValue_Click(object sender, EventArgs e)
        {

            int xCoordinate = Convert.ToInt16(yCoordinateTextBox.Text);
            int yCoordinate = Convert.ToInt16(xCoordinateTextBox.Text);

            bitMap = (Bitmap)mainPictureBox.Image;

            int r = bitMap.GetPixel(xCoordinate, yCoordinate).R;
            int g = bitMap.GetPixel(xCoordinate, yCoordinate).G;
            int b = bitMap.GetPixel(xCoordinate, yCoordinate).B;

            rValueTextBox.Text = r.ToString();
            gValueTextBox.Text = g.ToString();
            bValueTextBox.Text = b.ToString();
        }
    }
}
