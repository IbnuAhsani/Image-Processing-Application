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

        /// <summary>
        /// Button Functions
        /// </summary>

        int mouseClickCount = 0;

        // Variables for the Bitmap's row and column
        int row, column;

        // Bitmap variables for original and result pictures
        Bitmap bitMapOriginal, bitMapResult;


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


        private void euclideanDistanceButton_Click(object sender, EventArgs e)
        {

        }


        private void mainPictureBox_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
