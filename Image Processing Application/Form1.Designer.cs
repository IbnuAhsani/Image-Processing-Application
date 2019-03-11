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
            this.pointOneXCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.pointOneYCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.pointTwoXCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.pointTwoYCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.euclideanDistanceButton = new System.Windows.Forms.Button();
            this.euclideanDistanceValueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.manhattanDistanceValueTextBox = new System.Windows.Forms.TextBox();
            this.chessboardDistanceValueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(24, 21);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(442, 310);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseClick);
            // 
            // changePictureButton
            // 
            this.changePictureButton.Location = new System.Drawing.Point(551, 352);
            this.changePictureButton.Name = "changePictureButton";
            this.changePictureButton.Size = new System.Drawing.Size(111, 49);
            this.changePictureButton.TabIndex = 1;
            this.changePictureButton.Text = "Change Picture";
            this.changePictureButton.UseVisualStyleBackColor = true;
            this.changePictureButton.Click += new System.EventHandler(this.changePictureButton_Click);
            // 
            // pointOneXCoordinateTextBox
            // 
            this.pointOneXCoordinateTextBox.Location = new System.Drawing.Point(38, 34);
            this.pointOneXCoordinateTextBox.Name = "pointOneXCoordinateTextBox";
            this.pointOneXCoordinateTextBox.Size = new System.Drawing.Size(46, 20);
            this.pointOneXCoordinateTextBox.TabIndex = 20;
            // 
            // pointOneYCoordinateTextBox
            // 
            this.pointOneYCoordinateTextBox.Location = new System.Drawing.Point(38, 65);
            this.pointOneYCoordinateTextBox.Name = "pointOneYCoordinateTextBox";
            this.pointOneYCoordinateTextBox.Size = new System.Drawing.Size(46, 20);
            this.pointOneYCoordinateTextBox.TabIndex = 22;
            // 
            // pointTwoXCoordinateTextBox
            // 
            this.pointTwoXCoordinateTextBox.Location = new System.Drawing.Point(38, 34);
            this.pointTwoXCoordinateTextBox.Name = "pointTwoXCoordinateTextBox";
            this.pointTwoXCoordinateTextBox.Size = new System.Drawing.Size(46, 20);
            this.pointTwoXCoordinateTextBox.TabIndex = 23;
            // 
            // pointTwoYCoordinateTextBox
            // 
            this.pointTwoYCoordinateTextBox.Location = new System.Drawing.Point(38, 65);
            this.pointTwoYCoordinateTextBox.Name = "pointTwoYCoordinateTextBox";
            this.pointTwoYCoordinateTextBox.Size = new System.Drawing.Size(46, 20);
            this.pointTwoYCoordinateTextBox.TabIndex = 24;
            // 
            // euclideanDistanceButton
            // 
            this.euclideanDistanceButton.Location = new System.Drawing.Point(668, 352);
            this.euclideanDistanceButton.Name = "euclideanDistanceButton";
            this.euclideanDistanceButton.Size = new System.Drawing.Size(102, 49);
            this.euclideanDistanceButton.TabIndex = 26;
            this.euclideanDistanceButton.Text = "Calculate Distance";
            this.euclideanDistanceButton.UseVisualStyleBackColor = true;
            this.euclideanDistanceButton.Click += new System.EventHandler(this.euclideanDistanceButton_Click);
            // 
            // euclideanDistanceValueTextBox
            // 
            this.euclideanDistanceValueTextBox.Location = new System.Drawing.Point(103, 106);
            this.euclideanDistanceValueTextBox.Name = "euclideanDistanceValueTextBox";
            this.euclideanDistanceValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.euclideanDistanceValueTextBox.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pointOneYCoordinateTextBox);
            this.groupBox1.Controls.Add(this.pointOneXCoordinateTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(549, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Point One";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mainPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(31, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 349);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Y";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.pointTwoXCoordinateTextBox);
            this.groupBox3.Controls.Add(this.pointTwoYCoordinateTextBox);
            this.groupBox3.Location = new System.Drawing.Point(668, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(102, 100);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Point Two";
            // 
            // manhattanDistanceValueTextBox
            // 
            this.manhattanDistanceValueTextBox.Location = new System.Drawing.Point(103, 73);
            this.manhattanDistanceValueTextBox.Name = "manhattanDistanceValueTextBox";
            this.manhattanDistanceValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.manhattanDistanceValueTextBox.TabIndex = 35;
            // 
            // chessboardDistanceValueTextBox
            // 
            this.chessboardDistanceValueTextBox.Location = new System.Drawing.Point(103, 38);
            this.chessboardDistanceValueTextBox.Name = "chessboardDistanceValueTextBox";
            this.chessboardDistanceValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.chessboardDistanceValueTextBox.TabIndex = 36;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.euclideanDistanceValueTextBox);
            this.groupBox4.Controls.Add(this.chessboardDistanceValueTextBox);
            this.groupBox4.Controls.Add(this.manhattanDistanceValueTextBox);
            this.groupBox4.Location = new System.Drawing.Point(549, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 158);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Distance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Euclidean";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Chessboard";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Manhattan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.euclideanDistanceButton);
            this.Controls.Add(this.changePictureButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Button changePictureButton;
        private System.Windows.Forms.TextBox pointOneXCoordinateTextBox;
        private System.Windows.Forms.TextBox pointOneYCoordinateTextBox;
        private System.Windows.Forms.TextBox pointTwoXCoordinateTextBox;
        private System.Windows.Forms.TextBox pointTwoYCoordinateTextBox;
        private System.Windows.Forms.Button euclideanDistanceButton;
        private System.Windows.Forms.TextBox euclideanDistanceValueTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox manhattanDistanceValueTextBox;
        private System.Windows.Forms.TextBox chessboardDistanceValueTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

