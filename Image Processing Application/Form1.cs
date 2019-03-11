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
        
        // Variable to count the number of mouse clicks
        int mouseClickCount = 0;

        // Variables for the points coordinates
        int x1, y1, x2, y2;
        
        /**
         * Function to change the picture in the main picture box
         */
        private void changePictureButton_Click(object sender, EventArgs e)
        {
            // Open a Windows dialog
            OpenFileDialog open = new OpenFileDialog
            {
                // Fiter the format that can be displayed by the dialog
                Filter = "Image Files(*.jpg; *.bmp)|*.jpg; *.bmp"
            };

            // Change the picture in the main picture box
            if (open.ShowDialog() == DialogResult.OK)
            {
                mainPictureBox.Image = new Bitmap(open.FileName);
            }
        }

        /**
         * Function to calculate chessboard, manhattan, and euclidean distance
         * based on the two points where we clicked in the picture box
         */ 
        private void euclideanDistanceButton_Click(object sender, EventArgs e)
        {
            bool pointOneCoordinateNullOrEmpty = pointOneXCoordinateTextBox.Text == "" ||
                    pointOneYCoordinateTextBox.Text == "";

            bool pointTwoCoordinateNullOrEmpty = pointTwoXCoordinateTextBox.Text == "" ||
                    pointTwoYCoordinateTextBox.Text == "";
            
            if (!(pointOneCoordinateNullOrEmpty && pointTwoCoordinateNullOrEmpty))
            {
                double chessboardDistance = Math.Max(Math.Abs(x1 - x2), Math.Abs(y1 - y2));
                double manhattanDistance = Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
                double euclideanDistance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

                double roundedChessboardDistance = Math.Round(chessboardDistance, 3);
                double roundedManhattanDistance = Math.Round(manhattanDistance, 3);
                double roundedEuclideanDistance = Math.Round(euclideanDistance, 3);

                chessboardDistanceValueTextBox.Text = roundedChessboardDistance.ToString();
                manhattanDistanceValueTextBox.Text = roundedManhattanDistance.ToString();
                euclideanDistanceValueTextBox.Text = roundedEuclideanDistance.ToString();
            } else
            {
                var errorMessage = new Form
                {
                    ShowInTaskbar = false,
                    TopMost = true,
                    Size = new Size(300, 300),
                    Location = new Point(300, 200),
                    StartPosition = FormStartPosition.Manual,
                    Text = "Salah satu koordinat belum dipilih",
                };

                // Display the form
                errorMessage.Show();
            }

        }

        /**
         * Function that saves and displays the values of the points
         * where the user clicked in the picture box
         */ 
        private void mainPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (mainPictureBox.Image != null)
            {
                if (mouseClickCount == 0)
                {
                    pointOneXCoordinateTextBox.Text = e.X.ToString();
                    pointOneYCoordinateTextBox.Text = e.Y.ToString();

                    x1 = e.X;
                    y1 = e.Y;

                    mouseClickCount++;
                }
                else
                {
                    pointTwoXCoordinateTextBox.Text = e.X.ToString();
                    pointTwoYCoordinateTextBox.Text = e.Y.ToString();

                    x2 = e.X;
                    y2 = e.Y;

                    mouseClickCount = 0;
                }
            }
        }
    }
}
