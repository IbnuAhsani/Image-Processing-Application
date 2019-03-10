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
            this.xCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.yCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.xCoordinateLabel = new System.Windows.Forms.Label();
            this.yCoordinateLabel = new System.Windows.Forms.Label();
            this.coordinateLabel = new System.Windows.Forms.Label();
            this.getCoordinatesRGBValueButton = new System.Windows.Forms.Button();
            this.rValueTextBox = new System.Windows.Forms.TextBox();
            this.gValueTextBox = new System.Windows.Forms.TextBox();
            this.bValueTextBox = new System.Windows.Forms.TextBox();
            this.intensityLabel = new System.Windows.Forms.Label();
            this.rValueLabel = new System.Windows.Forms.Label();
            this.gValueLabel = new System.Windows.Forms.Label();
            this.bValueLabel = new System.Windows.Forms.Label();
            this.brightnessTextBox = new System.Windows.Forms.TextBox();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.changeBrightnessButton = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.originalPictureLabel = new System.Windows.Forms.Label();
            this.resultPictureLabel = new System.Windows.Forms.Label();
            this.invertPictureButton = new System.Windows.Forms.Button();
            this.greyscaleAveragingButton = new System.Windows.Forms.Button();
            this.processLabel = new System.Windows.Forms.Label();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.thresholdValueTextBox = new System.Windows.Forms.TextBox();
            this.thresholdPictureButton = new System.Windows.Forms.Button();
            this.greyscaleLumaButton = new System.Windows.Forms.Button();
            this.showPictureHistogramButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(33, 34);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(224, 156);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // changePictureButton
            // 
            this.changePictureButton.Location = new System.Drawing.Point(157, 393);
            this.changePictureButton.Name = "changePictureButton";
            this.changePictureButton.Size = new System.Drawing.Size(100, 45);
            this.changePictureButton.TabIndex = 1;
            this.changePictureButton.Text = "Ganti Gambar";
            this.changePictureButton.UseVisualStyleBackColor = true;
            this.changePictureButton.Click += new System.EventHandler(this.changePictureButton_Click);
            // 
            // xCoordinateTextBox
            // 
            this.xCoordinateTextBox.Location = new System.Drawing.Point(544, 190);
            this.xCoordinateTextBox.Name = "xCoordinateTextBox";
            this.xCoordinateTextBox.Size = new System.Drawing.Size(42, 20);
            this.xCoordinateTextBox.TabIndex = 2;
            // 
            // yCoordinateTextBox
            // 
            this.yCoordinateTextBox.Location = new System.Drawing.Point(627, 190);
            this.yCoordinateTextBox.Name = "yCoordinateTextBox";
            this.yCoordinateTextBox.Size = new System.Drawing.Size(42, 20);
            this.yCoordinateTextBox.TabIndex = 3;
            // 
            // xCoordinateLabel
            // 
            this.xCoordinateLabel.AutoSize = true;
            this.xCoordinateLabel.Location = new System.Drawing.Point(557, 163);
            this.xCoordinateLabel.Name = "xCoordinateLabel";
            this.xCoordinateLabel.Size = new System.Drawing.Size(14, 13);
            this.xCoordinateLabel.TabIndex = 4;
            this.xCoordinateLabel.Text = "X";
            // 
            // yCoordinateLabel
            // 
            this.yCoordinateLabel.AutoSize = true;
            this.yCoordinateLabel.Location = new System.Drawing.Point(643, 163);
            this.yCoordinateLabel.Name = "yCoordinateLabel";
            this.yCoordinateLabel.Size = new System.Drawing.Size(14, 13);
            this.yCoordinateLabel.TabIndex = 5;
            this.yCoordinateLabel.Text = "Y";
            // 
            // coordinateLabel
            // 
            this.coordinateLabel.AutoSize = true;
            this.coordinateLabel.Location = new System.Drawing.Point(465, 190);
            this.coordinateLabel.Name = "coordinateLabel";
            this.coordinateLabel.Size = new System.Drawing.Size(52, 13);
            this.coordinateLabel.TabIndex = 6;
            this.coordinateLabel.Text = "Koordinat";
            // 
            // getCoordinatesRGBValueButton
            // 
            this.getCoordinatesRGBValueButton.Location = new System.Drawing.Point(650, 300);
            this.getCoordinatesRGBValueButton.Name = "getCoordinatesRGBValueButton";
            this.getCoordinatesRGBValueButton.Size = new System.Drawing.Size(103, 45);
            this.getCoordinatesRGBValueButton.TabIndex = 7;
            this.getCoordinatesRGBValueButton.Text = "Nilai RGB pada Koordinat";
            this.getCoordinatesRGBValueButton.UseVisualStyleBackColor = true;
            this.getCoordinatesRGBValueButton.Click += new System.EventHandler(this.getCoordinatesRGBValue_Click);
            // 
            // rValueTextBox
            // 
            this.rValueTextBox.Location = new System.Drawing.Point(544, 253);
            this.rValueTextBox.Name = "rValueTextBox";
            this.rValueTextBox.Size = new System.Drawing.Size(42, 20);
            this.rValueTextBox.TabIndex = 8;
            // 
            // gValueTextBox
            // 
            this.gValueTextBox.Location = new System.Drawing.Point(627, 253);
            this.gValueTextBox.Name = "gValueTextBox";
            this.gValueTextBox.Size = new System.Drawing.Size(42, 20);
            this.gValueTextBox.TabIndex = 9;
            // 
            // bValueTextBox
            // 
            this.bValueTextBox.Location = new System.Drawing.Point(711, 253);
            this.bValueTextBox.Name = "bValueTextBox";
            this.bValueTextBox.Size = new System.Drawing.Size(42, 20);
            this.bValueTextBox.TabIndex = 10;
            // 
            // intensityLabel
            // 
            this.intensityLabel.AutoSize = true;
            this.intensityLabel.Location = new System.Drawing.Point(465, 260);
            this.intensityLabel.Name = "intensityLabel";
            this.intensityLabel.Size = new System.Drawing.Size(52, 13);
            this.intensityLabel.TabIndex = 11;
            this.intensityLabel.Text = "Intensitas";
            // 
            // rValueLabel
            // 
            this.rValueLabel.AutoSize = true;
            this.rValueLabel.Location = new System.Drawing.Point(557, 227);
            this.rValueLabel.Name = "rValueLabel";
            this.rValueLabel.Size = new System.Drawing.Size(15, 13);
            this.rValueLabel.TabIndex = 12;
            this.rValueLabel.Text = "R";
            // 
            // gValueLabel
            // 
            this.gValueLabel.AutoSize = true;
            this.gValueLabel.Location = new System.Drawing.Point(643, 227);
            this.gValueLabel.Name = "gValueLabel";
            this.gValueLabel.Size = new System.Drawing.Size(15, 13);
            this.gValueLabel.TabIndex = 13;
            this.gValueLabel.Text = "G";
            // 
            // bValueLabel
            // 
            this.bValueLabel.AutoSize = true;
            this.bValueLabel.Location = new System.Drawing.Point(725, 227);
            this.bValueLabel.Name = "bValueLabel";
            this.bValueLabel.Size = new System.Drawing.Size(14, 13);
            this.bValueLabel.TabIndex = 14;
            this.bValueLabel.Text = "B";
            // 
            // brightnessTextBox
            // 
            this.brightnessTextBox.Location = new System.Drawing.Point(544, 47);
            this.brightnessTextBox.Name = "brightnessTextBox";
            this.brightnessTextBox.Size = new System.Drawing.Size(79, 20);
            this.brightnessTextBox.TabIndex = 15;
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(465, 54);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(59, 13);
            this.brightnessLabel.TabIndex = 16;
            this.brightnessLabel.Text = "Kecerahan";
            // 
            // changeBrightnessButton
            // 
            this.changeBrightnessButton.Location = new System.Drawing.Point(650, 34);
            this.changeBrightnessButton.Name = "changeBrightnessButton";
            this.changeBrightnessButton.Size = new System.Drawing.Size(103, 45);
            this.changeBrightnessButton.TabIndex = 17;
            this.changeBrightnessButton.Text = "Ubah Kecerahan Gambar";
            this.changeBrightnessButton.UseVisualStyleBackColor = true;
            this.changeBrightnessButton.Click += new System.EventHandler(this.changeBrightnessButton_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(33, 221);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(224, 156);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 18;
            this.resultPictureBox.TabStop = false;
            // 
            // originalPictureLabel
            // 
            this.originalPictureLabel.AutoSize = true;
            this.originalPictureLabel.Location = new System.Drawing.Point(115, 18);
            this.originalPictureLabel.Name = "originalPictureLabel";
            this.originalPictureLabel.Size = new System.Drawing.Size(63, 13);
            this.originalPictureLabel.TabIndex = 19;
            this.originalPictureLabel.Text = "Gambar Asli";
            // 
            // resultPictureLabel
            // 
            this.resultPictureLabel.AutoSize = true;
            this.resultPictureLabel.Location = new System.Drawing.Point(115, 205);
            this.resultPictureLabel.Name = "resultPictureLabel";
            this.resultPictureLabel.Size = new System.Drawing.Size(70, 13);
            this.resultPictureLabel.TabIndex = 20;
            this.resultPictureLabel.Text = "Gambar Hasil";
            // 
            // invertPictureButton
            // 
            this.invertPictureButton.Location = new System.Drawing.Point(317, 189);
            this.invertPictureButton.Name = "invertPictureButton";
            this.invertPictureButton.Size = new System.Drawing.Size(100, 45);
            this.invertPictureButton.TabIndex = 21;
            this.invertPictureButton.Text = "Invert Gambar";
            this.invertPictureButton.UseVisualStyleBackColor = true;
            this.invertPictureButton.Click += new System.EventHandler(this.invertPictureButton_Click);
            // 
            // greyscaleAveragingButton
            // 
            this.greyscaleAveragingButton.Location = new System.Drawing.Point(317, 57);
            this.greyscaleAveragingButton.Name = "greyscaleAveragingButton";
            this.greyscaleAveragingButton.Size = new System.Drawing.Size(100, 45);
            this.greyscaleAveragingButton.TabIndex = 22;
            this.greyscaleAveragingButton.Text = "Greyscale dengan Perataan";
            this.greyscaleAveragingButton.UseVisualStyleBackColor = true;
            this.greyscaleAveragingButton.Click += new System.EventHandler(this.greyscaleAveragingButton_Click);
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(341, 18);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(53, 13);
            this.processLabel.TabIndex = 23;
            this.processLabel.Text = "Olah Citra";
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(465, 111);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(68, 13);
            this.thresholdLabel.TabIndex = 24;
            this.thresholdLabel.Text = "Thresholding";
            // 
            // thresholdValueTextBox
            // 
            this.thresholdValueTextBox.Location = new System.Drawing.Point(544, 108);
            this.thresholdValueTextBox.Name = "thresholdValueTextBox";
            this.thresholdValueTextBox.Size = new System.Drawing.Size(79, 20);
            this.thresholdValueTextBox.TabIndex = 25;
            // 
            // thresholdPictureButton
            // 
            this.thresholdPictureButton.Location = new System.Drawing.Point(650, 95);
            this.thresholdPictureButton.Name = "thresholdPictureButton";
            this.thresholdPictureButton.Size = new System.Drawing.Size(103, 45);
            this.thresholdPictureButton.TabIndex = 26;
            this.thresholdPictureButton.Text = "Threshold Gambar";
            this.thresholdPictureButton.UseVisualStyleBackColor = true;
            this.thresholdPictureButton.Click += new System.EventHandler(this.thresholdPictureButton_Click);
            // 
            // greyscaleLumaButton
            // 
            this.greyscaleLumaButton.Location = new System.Drawing.Point(317, 121);
            this.greyscaleLumaButton.Name = "greyscaleLumaButton";
            this.greyscaleLumaButton.Size = new System.Drawing.Size(100, 45);
            this.greyscaleLumaButton.TabIndex = 27;
            this.greyscaleLumaButton.Text = "Greyscale dengan Luma";
            this.greyscaleLumaButton.UseVisualStyleBackColor = true;
            this.greyscaleLumaButton.Click += new System.EventHandler(this.greyscaleLumaButton_Click);
            // 
            // showPictureHistogramButton
            // 
            this.showPictureHistogramButton.Location = new System.Drawing.Point(33, 393);
            this.showPictureHistogramButton.Name = "showPictureHistogramButton";
            this.showPictureHistogramButton.Size = new System.Drawing.Size(100, 45);
            this.showPictureHistogramButton.TabIndex = 28;
            this.showPictureHistogramButton.Text = "Liat Histogram";
            this.showPictureHistogramButton.UseVisualStyleBackColor = true;
            this.showPictureHistogramButton.Click += new System.EventHandler(this.showPictureHistogramButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showPictureHistogramButton);
            this.Controls.Add(this.greyscaleLumaButton);
            this.Controls.Add(this.thresholdPictureButton);
            this.Controls.Add(this.thresholdValueTextBox);
            this.Controls.Add(this.thresholdLabel);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.greyscaleAveragingButton);
            this.Controls.Add(this.invertPictureButton);
            this.Controls.Add(this.resultPictureLabel);
            this.Controls.Add(this.originalPictureLabel);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.changeBrightnessButton);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.brightnessTextBox);
            this.Controls.Add(this.bValueLabel);
            this.Controls.Add(this.gValueLabel);
            this.Controls.Add(this.rValueLabel);
            this.Controls.Add(this.intensityLabel);
            this.Controls.Add(this.bValueTextBox);
            this.Controls.Add(this.gValueTextBox);
            this.Controls.Add(this.rValueTextBox);
            this.Controls.Add(this.getCoordinatesRGBValueButton);
            this.Controls.Add(this.coordinateLabel);
            this.Controls.Add(this.yCoordinateLabel);
            this.Controls.Add(this.xCoordinateLabel);
            this.Controls.Add(this.yCoordinateTextBox);
            this.Controls.Add(this.xCoordinateTextBox);
            this.Controls.Add(this.changePictureButton);
            this.Controls.Add(this.mainPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Button changePictureButton;
        private System.Windows.Forms.TextBox xCoordinateTextBox;
        private System.Windows.Forms.TextBox yCoordinateTextBox;
        private System.Windows.Forms.Label xCoordinateLabel;
        private System.Windows.Forms.Label yCoordinateLabel;
        private System.Windows.Forms.Label coordinateLabel;
        private System.Windows.Forms.Button getCoordinatesRGBValueButton;
        private System.Windows.Forms.TextBox rValueTextBox;
        private System.Windows.Forms.TextBox gValueTextBox;
        private System.Windows.Forms.TextBox bValueTextBox;
        private System.Windows.Forms.Label intensityLabel;
        private System.Windows.Forms.Label rValueLabel;
        private System.Windows.Forms.Label gValueLabel;
        private System.Windows.Forms.Label bValueLabel;
        private System.Windows.Forms.TextBox brightnessTextBox;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Button changeBrightnessButton;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.Label originalPictureLabel;
        private System.Windows.Forms.Label resultPictureLabel;
        private System.Windows.Forms.Button invertPictureButton;
        private System.Windows.Forms.Button greyscaleAveragingButton;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.TextBox thresholdValueTextBox;
        private System.Windows.Forms.Button thresholdPictureButton;
        private System.Windows.Forms.Button greyscaleLumaButton;
        private System.Windows.Forms.Button showPictureHistogramButton;
    }
}

