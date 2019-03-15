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
            this.components = new System.ComponentModel.Container();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
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
            this.invertPictureButton = new System.Windows.Forms.Button();
            this.greyscaleAveragingButton = new System.Windows.Forms.Button();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.thresholdValueTextBox = new System.Windows.Forms.TextBox();
            this.thresholdPictureButton = new System.Windows.Forms.Button();
            this.greyscaleLumaButton = new System.Windows.Forms.Button();
            this.showPictureHistogramButton = new System.Windows.Forms.Button();
            this.pictureManipulationGroupBox = new System.Windows.Forms.GroupBox();
            this.greyscalePointerButton = new System.Windows.Forms.Button();
            this.originalPictureGroupBox = new System.Windows.Forms.GroupBox();
            this.resultPictureGroupBox = new System.Windows.Forms.GroupBox();
            this.brightnessGroupBox = new System.Windows.Forms.GroupBox();
            this.thresholdingGroupBox = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.pictureManipulationGroupBox.SuspendLayout();
            this.originalPictureGroupBox.SuspendLayout();
            this.resultPictureGroupBox.SuspendLayout();
            this.brightnessGroupBox.SuspendLayout();
            this.thresholdingGroupBox.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Location = new System.Drawing.Point(20, 19);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(224, 156);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseMove);
            // 
            // xCoordinateTextBox
            // 
            this.xCoordinateTextBox.Location = new System.Drawing.Point(627, 65);
            this.xCoordinateTextBox.Name = "xCoordinateTextBox";
            this.xCoordinateTextBox.Size = new System.Drawing.Size(42, 20);
            this.xCoordinateTextBox.TabIndex = 2;
            // 
            // yCoordinateTextBox
            // 
            this.yCoordinateTextBox.Location = new System.Drawing.Point(710, 65);
            this.yCoordinateTextBox.Name = "yCoordinateTextBox";
            this.yCoordinateTextBox.Size = new System.Drawing.Size(42, 20);
            this.yCoordinateTextBox.TabIndex = 3;
            // 
            // xCoordinateLabel
            // 
            this.xCoordinateLabel.AutoSize = true;
            this.xCoordinateLabel.Location = new System.Drawing.Point(640, 38);
            this.xCoordinateLabel.Name = "xCoordinateLabel";
            this.xCoordinateLabel.Size = new System.Drawing.Size(14, 13);
            this.xCoordinateLabel.TabIndex = 4;
            this.xCoordinateLabel.Text = "X";
            // 
            // yCoordinateLabel
            // 
            this.yCoordinateLabel.AutoSize = true;
            this.yCoordinateLabel.Location = new System.Drawing.Point(726, 38);
            this.yCoordinateLabel.Name = "yCoordinateLabel";
            this.yCoordinateLabel.Size = new System.Drawing.Size(14, 13);
            this.yCoordinateLabel.TabIndex = 5;
            this.yCoordinateLabel.Text = "Y";
            // 
            // coordinateLabel
            // 
            this.coordinateLabel.AutoSize = true;
            this.coordinateLabel.Location = new System.Drawing.Point(548, 65);
            this.coordinateLabel.Name = "coordinateLabel";
            this.coordinateLabel.Size = new System.Drawing.Size(52, 13);
            this.coordinateLabel.TabIndex = 6;
            this.coordinateLabel.Text = "Koordinat";
            // 
            // getCoordinatesRGBValueButton
            // 
            this.getCoordinatesRGBValueButton.Location = new System.Drawing.Point(650, 320);
            this.getCoordinatesRGBValueButton.Name = "getCoordinatesRGBValueButton";
            this.getCoordinatesRGBValueButton.Size = new System.Drawing.Size(103, 45);
            this.getCoordinatesRGBValueButton.TabIndex = 7;
            this.getCoordinatesRGBValueButton.Text = "Nilai RGB pada Koordinat";
            this.getCoordinatesRGBValueButton.UseVisualStyleBackColor = true;
            this.getCoordinatesRGBValueButton.Click += new System.EventHandler(this.getCoordinatesRGBValue_Click);
            // 
            // rValueTextBox
            // 
            this.rValueTextBox.Location = new System.Drawing.Point(588, 108);
            this.rValueTextBox.Name = "rValueTextBox";
            this.rValueTextBox.Size = new System.Drawing.Size(42, 20);
            this.rValueTextBox.TabIndex = 8;
            // 
            // gValueTextBox
            // 
            this.gValueTextBox.Location = new System.Drawing.Point(671, 108);
            this.gValueTextBox.Name = "gValueTextBox";
            this.gValueTextBox.Size = new System.Drawing.Size(42, 20);
            this.gValueTextBox.TabIndex = 9;
            // 
            // bValueTextBox
            // 
            this.bValueTextBox.Location = new System.Drawing.Point(755, 108);
            this.bValueTextBox.Name = "bValueTextBox";
            this.bValueTextBox.Size = new System.Drawing.Size(42, 20);
            this.bValueTextBox.TabIndex = 10;
            // 
            // intensityLabel
            // 
            this.intensityLabel.AutoSize = true;
            this.intensityLabel.Location = new System.Drawing.Point(509, 115);
            this.intensityLabel.Name = "intensityLabel";
            this.intensityLabel.Size = new System.Drawing.Size(52, 13);
            this.intensityLabel.TabIndex = 11;
            this.intensityLabel.Text = "Intensitas";
            // 
            // rValueLabel
            // 
            this.rValueLabel.AutoSize = true;
            this.rValueLabel.Location = new System.Drawing.Point(601, 82);
            this.rValueLabel.Name = "rValueLabel";
            this.rValueLabel.Size = new System.Drawing.Size(15, 13);
            this.rValueLabel.TabIndex = 12;
            this.rValueLabel.Text = "R";
            // 
            // gValueLabel
            // 
            this.gValueLabel.AutoSize = true;
            this.gValueLabel.Location = new System.Drawing.Point(687, 82);
            this.gValueLabel.Name = "gValueLabel";
            this.gValueLabel.Size = new System.Drawing.Size(15, 13);
            this.gValueLabel.TabIndex = 13;
            this.gValueLabel.Text = "G";
            // 
            // bValueLabel
            // 
            this.bValueLabel.AutoSize = true;
            this.bValueLabel.Location = new System.Drawing.Point(769, 82);
            this.bValueLabel.Name = "bValueLabel";
            this.bValueLabel.Size = new System.Drawing.Size(14, 13);
            this.bValueLabel.TabIndex = 14;
            this.bValueLabel.Text = "B";
            // 
            // brightnessTextBox
            // 
            this.brightnessTextBox.Location = new System.Drawing.Point(20, 50);
            this.brightnessTextBox.Name = "brightnessTextBox";
            this.brightnessTextBox.Size = new System.Drawing.Size(53, 20);
            this.brightnessTextBox.TabIndex = 15;
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(28, 26);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(34, 13);
            this.brightnessLabel.TabIndex = 16;
            this.brightnessLabel.Text = "Value";
            // 
            // changeBrightnessButton
            // 
            this.changeBrightnessButton.Location = new System.Drawing.Point(93, 31);
            this.changeBrightnessButton.Name = "changeBrightnessButton";
            this.changeBrightnessButton.Size = new System.Drawing.Size(79, 39);
            this.changeBrightnessButton.TabIndex = 17;
            this.changeBrightnessButton.Text = "Process";
            this.changeBrightnessButton.UseVisualStyleBackColor = true;
            this.changeBrightnessButton.Click += new System.EventHandler(this.changeBrightnessButton_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(20, 23);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(224, 156);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 18;
            this.resultPictureBox.TabStop = false;
            // 
            // invertPictureButton
            // 
            this.invertPictureButton.Location = new System.Drawing.Point(10, 134);
            this.invertPictureButton.Name = "invertPictureButton";
            this.invertPictureButton.Size = new System.Drawing.Size(76, 41);
            this.invertPictureButton.TabIndex = 21;
            this.invertPictureButton.Text = "Invert Color";
            this.invertPictureButton.UseVisualStyleBackColor = true;
            this.invertPictureButton.Click += new System.EventHandler(this.invertPictureButton_Click);
            // 
            // greyscaleAveragingButton
            // 
            this.greyscaleAveragingButton.Location = new System.Drawing.Point(10, 23);
            this.greyscaleAveragingButton.Name = "greyscaleAveragingButton";
            this.greyscaleAveragingButton.Size = new System.Drawing.Size(76, 41);
            this.greyscaleAveragingButton.TabIndex = 22;
            this.greyscaleAveragingButton.Text = "Averaging Greyscale";
            this.greyscaleAveragingButton.UseVisualStyleBackColor = true;
            this.greyscaleAveragingButton.Click += new System.EventHandler(this.greyscaleAveragingButton_Click);
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.AutoSize = true;
            this.thresholdLabel.Location = new System.Drawing.Point(28, 27);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(34, 13);
            this.thresholdLabel.TabIndex = 24;
            this.thresholdLabel.Text = "Value";
            // 
            // thresholdValueTextBox
            // 
            this.thresholdValueTextBox.Location = new System.Drawing.Point(22, 47);
            this.thresholdValueTextBox.Name = "thresholdValueTextBox";
            this.thresholdValueTextBox.Size = new System.Drawing.Size(53, 20);
            this.thresholdValueTextBox.TabIndex = 25;
            // 
            // thresholdPictureButton
            // 
            this.thresholdPictureButton.Location = new System.Drawing.Point(91, 27);
            this.thresholdPictureButton.Name = "thresholdPictureButton";
            this.thresholdPictureButton.Size = new System.Drawing.Size(79, 40);
            this.thresholdPictureButton.TabIndex = 26;
            this.thresholdPictureButton.Text = "Process";
            this.thresholdPictureButton.UseVisualStyleBackColor = true;
            this.thresholdPictureButton.Click += new System.EventHandler(this.thresholdPictureButton_Click);
            // 
            // greyscaleLumaButton
            // 
            this.greyscaleLumaButton.Location = new System.Drawing.Point(10, 77);
            this.greyscaleLumaButton.Name = "greyscaleLumaButton";
            this.greyscaleLumaButton.Size = new System.Drawing.Size(76, 41);
            this.greyscaleLumaButton.TabIndex = 27;
            this.greyscaleLumaButton.Text = "Luma Greyscale";
            this.greyscaleLumaButton.UseVisualStyleBackColor = true;
            this.greyscaleLumaButton.Click += new System.EventHandler(this.greyscaleLumaButton_Click);
            // 
            // showPictureHistogramButton
            // 
            this.showPictureHistogramButton.Location = new System.Drawing.Point(93, 77);
            this.showPictureHistogramButton.Name = "showPictureHistogramButton";
            this.showPictureHistogramButton.Size = new System.Drawing.Size(76, 41);
            this.showPictureHistogramButton.TabIndex = 28;
            this.showPictureHistogramButton.Text = "View Histogram";
            this.showPictureHistogramButton.UseVisualStyleBackColor = true;
            this.showPictureHistogramButton.Click += new System.EventHandler(this.showPictureHistogramButton_Click);
            // 
            // pictureManipulationGroupBox
            // 
            this.pictureManipulationGroupBox.Controls.Add(this.greyscalePointerButton);
            this.pictureManipulationGroupBox.Controls.Add(this.greyscaleLumaButton);
            this.pictureManipulationGroupBox.Controls.Add(this.invertPictureButton);
            this.pictureManipulationGroupBox.Controls.Add(this.greyscaleAveragingButton);
            this.pictureManipulationGroupBox.Controls.Add(this.showPictureHistogramButton);
            this.pictureManipulationGroupBox.Location = new System.Drawing.Point(319, 247);
            this.pictureManipulationGroupBox.Name = "pictureManipulationGroupBox";
            this.pictureManipulationGroupBox.Size = new System.Drawing.Size(186, 194);
            this.pictureManipulationGroupBox.TabIndex = 29;
            this.pictureManipulationGroupBox.TabStop = false;
            this.pictureManipulationGroupBox.Text = "Picture Manipulation";
            // 
            // greyscalePointerButton
            // 
            this.greyscalePointerButton.Location = new System.Drawing.Point(93, 23);
            this.greyscalePointerButton.Name = "greyscalePointerButton";
            this.greyscalePointerButton.Size = new System.Drawing.Size(76, 41);
            this.greyscalePointerButton.TabIndex = 34;
            this.greyscalePointerButton.Text = "Pointer Greyscale";
            this.greyscalePointerButton.UseVisualStyleBackColor = true;
            this.greyscalePointerButton.Click += new System.EventHandler(this.greyscalePointerButton_Click);
            // 
            // originalPictureGroupBox
            // 
            this.originalPictureGroupBox.Controls.Add(this.mainPictureBox);
            this.originalPictureGroupBox.Location = new System.Drawing.Point(33, 42);
            this.originalPictureGroupBox.Name = "originalPictureGroupBox";
            this.originalPictureGroupBox.Size = new System.Drawing.Size(262, 186);
            this.originalPictureGroupBox.TabIndex = 30;
            this.originalPictureGroupBox.TabStop = false;
            this.originalPictureGroupBox.Text = "Original Picture";
            // 
            // resultPictureGroupBox
            // 
            this.resultPictureGroupBox.Controls.Add(this.resultPictureBox);
            this.resultPictureGroupBox.Location = new System.Drawing.Point(33, 247);
            this.resultPictureGroupBox.Name = "resultPictureGroupBox";
            this.resultPictureGroupBox.Size = new System.Drawing.Size(262, 194);
            this.resultPictureGroupBox.TabIndex = 31;
            this.resultPictureGroupBox.TabStop = false;
            this.resultPictureGroupBox.Text = "Result Picture";
            // 
            // brightnessGroupBox
            // 
            this.brightnessGroupBox.Controls.Add(this.brightnessLabel);
            this.brightnessGroupBox.Controls.Add(this.brightnessTextBox);
            this.brightnessGroupBox.Controls.Add(this.changeBrightnessButton);
            this.brightnessGroupBox.Location = new System.Drawing.Point(319, 42);
            this.brightnessGroupBox.Name = "brightnessGroupBox";
            this.brightnessGroupBox.Size = new System.Drawing.Size(186, 86);
            this.brightnessGroupBox.TabIndex = 32;
            this.brightnessGroupBox.TabStop = false;
            this.brightnessGroupBox.Text = "Brightness";
            // 
            // thresholdingGroupBox
            // 
            this.thresholdingGroupBox.Controls.Add(this.thresholdLabel);
            this.thresholdingGroupBox.Controls.Add(this.thresholdValueTextBox);
            this.thresholdingGroupBox.Controls.Add(this.thresholdPictureButton);
            this.thresholdingGroupBox.Location = new System.Drawing.Point(319, 142);
            this.thresholdingGroupBox.Name = "thresholdingGroupBox";
            this.thresholdingGroupBox.Size = new System.Drawing.Size(186, 86);
            this.thresholdingGroupBox.TabIndex = 33;
            this.thresholdingGroupBox.TabStop = false;
            this.thresholdingGroupBox.Text = "Thresholding";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 36;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePictureToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changePictureToolStripMenuItem
            // 
            this.changePictureToolStripMenuItem.Name = "changePictureToolStripMenuItem";
            this.changePictureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changePictureToolStripMenuItem.Text = "Change Picture";
            this.changePictureToolStripMenuItem.Click += new System.EventHandler(this.changePictureToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.thresholdingGroupBox);
            this.Controls.Add(this.brightnessGroupBox);
            this.Controls.Add(this.resultPictureGroupBox);
            this.Controls.Add(this.originalPictureGroupBox);
            this.Controls.Add(this.pictureManipulationGroupBox);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.pictureManipulationGroupBox.ResumeLayout(false);
            this.originalPictureGroupBox.ResumeLayout(false);
            this.resultPictureGroupBox.ResumeLayout(false);
            this.brightnessGroupBox.ResumeLayout(false);
            this.brightnessGroupBox.PerformLayout();
            this.thresholdingGroupBox.ResumeLayout(false);
            this.thresholdingGroupBox.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
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
        private System.Windows.Forms.Button invertPictureButton;
        private System.Windows.Forms.Button greyscaleAveragingButton;
        private System.Windows.Forms.Label thresholdLabel;
        private System.Windows.Forms.TextBox thresholdValueTextBox;
        private System.Windows.Forms.Button thresholdPictureButton;
        private System.Windows.Forms.Button greyscaleLumaButton;
        private System.Windows.Forms.Button showPictureHistogramButton;
        private System.Windows.Forms.GroupBox pictureManipulationGroupBox;
        private System.Windows.Forms.GroupBox originalPictureGroupBox;
        private System.Windows.Forms.GroupBox resultPictureGroupBox;
        private System.Windows.Forms.GroupBox brightnessGroupBox;
        private System.Windows.Forms.GroupBox thresholdingGroupBox;
        private System.Windows.Forms.Button greyscalePointerButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePictureToolStripMenuItem;
    }
}

