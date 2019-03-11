namespace Image_Processing_Application
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.changePictureButton = new System.Windows.Forms.Button();
            this.originalPictureLabel = new System.Windows.Forms.Label();
            this.pointOneXCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.pointOneLabel = new System.Windows.Forms.Label();
            this.pointOneYCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.pointTwoXCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.pointTwoYCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.pointTwoLabel = new System.Windows.Forms.Label();
            this.euclideanDistanceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(33, 34);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(526, 344);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseClick);
            // 
            // changePictureButton
            // 
            this.changePictureButton.Location = new System.Drawing.Point(247, 389);
            this.changePictureButton.Name = "changePictureButton";
            this.changePictureButton.Size = new System.Drawing.Size(100, 45);
            this.changePictureButton.TabIndex = 1;
            this.changePictureButton.Text = "Change Picture";
            this.changePictureButton.UseVisualStyleBackColor = true;
            this.changePictureButton.Click += new System.EventHandler(this.changePictureButton_Click);
            // 
            // originalPictureLabel
            // 
            this.originalPictureLabel.AutoSize = true;
            this.originalPictureLabel.Location = new System.Drawing.Point(255, 9);
            this.originalPictureLabel.Name = "originalPictureLabel";
            this.originalPictureLabel.Size = new System.Drawing.Size(78, 13);
            this.originalPictureLabel.TabIndex = 19;
            this.originalPictureLabel.Text = "Original Picture";
            // 
            // pointOneXCoordinateTextBox
            // 
            this.pointOneXCoordinateTextBox.Location = new System.Drawing.Point(661, 83);
            this.pointOneXCoordinateTextBox.Name = "pointOneXCoordinateTextBox";
            this.pointOneXCoordinateTextBox.Size = new System.Drawing.Size(46, 20);
            this.pointOneXCoordinateTextBox.TabIndex = 20;
            // 
            // pointOneLabel
            // 
            this.pointOneLabel.AutoSize = true;
            this.pointOneLabel.Location = new System.Drawing.Point(658, 36);
            this.pointOneLabel.Name = "pointOneLabel";
            this.pointOneLabel.Size = new System.Drawing.Size(54, 13);
            this.pointOneLabel.TabIndex = 21;
            this.pointOneLabel.Text = "Point One";
            // 
            // pointOneYCoordinateTextBox
            // 
            this.pointOneYCoordinateTextBox.Location = new System.Drawing.Point(661, 139);
            this.pointOneYCoordinateTextBox.Name = "pointOneYCoordinateTextBox";
            this.pointOneYCoordinateTextBox.Size = new System.Drawing.Size(46, 20);
            this.pointOneYCoordinateTextBox.TabIndex = 22;
            // 
            // pointTwoXCoordinateTextBox
            // 
            this.pointTwoXCoordinateTextBox.Location = new System.Drawing.Point(661, 250);
            this.pointTwoXCoordinateTextBox.Name = "pointTwoXCoordinateTextBox";
            this.pointTwoXCoordinateTextBox.Size = new System.Drawing.Size(46, 20);
            this.pointTwoXCoordinateTextBox.TabIndex = 23;
            // 
            // pointTwoYCoordinateTextBox
            // 
            this.pointTwoYCoordinateTextBox.Location = new System.Drawing.Point(661, 300);
            this.pointTwoYCoordinateTextBox.Name = "pointTwoYCoordinateTextBox";
            this.pointTwoYCoordinateTextBox.Size = new System.Drawing.Size(46, 20);
            this.pointTwoYCoordinateTextBox.TabIndex = 24;
            // 
            // pointTwoLabel
            // 
            this.pointTwoLabel.AutoSize = true;
            this.pointTwoLabel.Location = new System.Drawing.Point(658, 203);
            this.pointTwoLabel.Name = "pointTwoLabel";
            this.pointTwoLabel.Size = new System.Drawing.Size(55, 13);
            this.pointTwoLabel.TabIndex = 25;
            this.pointTwoLabel.Text = "Point Two";
            // 
            // euclideanDistanceButton
            // 
            this.euclideanDistanceButton.Location = new System.Drawing.Point(607, 389);
            this.euclideanDistanceButton.Name = "euclideanDistanceButton";
            this.euclideanDistanceButton.Size = new System.Drawing.Size(122, 49);
            this.euclideanDistanceButton.TabIndex = 26;
            this.euclideanDistanceButton.Text = "Calculate Euclidean Distance";
            this.euclideanDistanceButton.UseVisualStyleBackColor = true;
            this.euclideanDistanceButton.Click += new System.EventHandler(this.euclideanDistanceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.euclideanDistanceButton);
            this.Controls.Add(this.pointTwoLabel);
            this.Controls.Add(this.pointTwoYCoordinateTextBox);
            this.Controls.Add(this.pointTwoXCoordinateTextBox);
            this.Controls.Add(this.pointOneYCoordinateTextBox);
            this.Controls.Add(this.pointOneLabel);
            this.Controls.Add(this.pointOneXCoordinateTextBox);
            this.Controls.Add(this.originalPictureLabel);
            this.Controls.Add(this.changePictureButton);
            this.Controls.Add(this.mainPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Button changePictureButton;
        private System.Windows.Forms.Label originalPictureLabel;
        private System.Windows.Forms.TextBox pointOneXCoordinateTextBox;
        private System.Windows.Forms.Label pointOneLabel;
        private System.Windows.Forms.TextBox pointOneYCoordinateTextBox;
        private System.Windows.Forms.TextBox pointTwoXCoordinateTextBox;
        private System.Windows.Forms.TextBox pointTwoYCoordinateTextBox;
        private System.Windows.Forms.Label pointTwoLabel;
        private System.Windows.Forms.Button euclideanDistanceButton;
    }
}

