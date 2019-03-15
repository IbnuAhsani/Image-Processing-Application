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
            this.getCoordinatesRGBValueButton = new System.Windows.Forms.Button();
            this.rValueTextBox = new System.Windows.Forms.TextBox();
            this.gValueTextBox = new System.Windows.Forms.TextBox();
            this.bValueTextBox = new System.Windows.Forms.TextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.invertPictureByPointerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.pictureManipulationGroupBox.SuspendLayout();
            this.originalPictureGroupBox.SuspendLayout();
            this.resultPictureGroupBox.SuspendLayout();
            this.brightnessGroupBox.SuspendLayout();
            this.thresholdingGroupBox.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.mainPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseClick);
            // 
            // xCoordinateTextBox
            // 
            this.xCoordinateTextBox.Location = new System.Drawing.Point(13, 50);
            this.xCoordinateTextBox.Name = "xCoordinateTextBox";
            this.xCoordinateTextBox.Size = new System.Drawing.Size(42, 20);
            this.xCoordinateTextBox.TabIndex = 2;
            // 
            // yCoordinateTextBox
            // 
            this.yCoordinateTextBox.Location = new System.Drawing.Point(67, 50);
            this.yCoordinateTextBox.Name = "yCoordinateTextBox";
            this.yCoordinateTextBox.Size = new System.Drawing.Size(42, 20);
            this.yCoordinateTextBox.TabIndex = 3;
            // 
            // xCoordinateLabel
            // 
            this.xCoordinateLabel.AutoSize = true;
            this.xCoordinateLabel.Location = new System.Drawing.Point(28, 34);
            this.xCoordinateLabel.Name = "xCoordinateLabel";
            this.xCoordinateLabel.Size = new System.Drawing.Size(14, 13);
            this.xCoordinateLabel.TabIndex = 4;
            this.xCoordinateLabel.Text = "X";
            // 
            // yCoordinateLabel
            // 
            this.yCoordinateLabel.AutoSize = true;
            this.yCoordinateLabel.Location = new System.Drawing.Point(82, 34);
            this.yCoordinateLabel.Name = "yCoordinateLabel";
            this.yCoordinateLabel.Size = new System.Drawing.Size(14, 13);
            this.yCoordinateLabel.TabIndex = 5;
            this.yCoordinateLabel.Text = "Y";
            // 
            // getCoordinatesRGBValueButton
            // 
            this.getCoordinatesRGBValueButton.Location = new System.Drawing.Point(39, 130);
            this.getCoordinatesRGBValueButton.Name = "getCoordinatesRGBValueButton";
            this.getCoordinatesRGBValueButton.Size = new System.Drawing.Size(103, 45);
            this.getCoordinatesRGBValueButton.TabIndex = 7;
            this.getCoordinatesRGBValueButton.Text = "Get a pixel\'s (X, Y) and RGB Values";
            this.getCoordinatesRGBValueButton.UseVisualStyleBackColor = true;
            this.getCoordinatesRGBValueButton.Click += new System.EventHandler(this.getCoordinatesRGBValue_Click);
            // 
            // rValueTextBox
            // 
            this.rValueTextBox.Location = new System.Drawing.Point(13, 97);
            this.rValueTextBox.Name = "rValueTextBox";
            this.rValueTextBox.Size = new System.Drawing.Size(42, 20);
            this.rValueTextBox.TabIndex = 8;
            // 
            // gValueTextBox
            // 
            this.gValueTextBox.Location = new System.Drawing.Point(67, 97);
            this.gValueTextBox.Name = "gValueTextBox";
            this.gValueTextBox.Size = new System.Drawing.Size(42, 20);
            this.gValueTextBox.TabIndex = 9;
            // 
            // bValueTextBox
            // 
            this.bValueTextBox.Location = new System.Drawing.Point(121, 97);
            this.bValueTextBox.Name = "bValueTextBox";
            this.bValueTextBox.Size = new System.Drawing.Size(42, 20);
            this.bValueTextBox.TabIndex = 10;
            // 
            // rValueLabel
            // 
            this.rValueLabel.AutoSize = true;
            this.rValueLabel.Location = new System.Drawing.Point(28, 81);
            this.rValueLabel.Name = "rValueLabel";
            this.rValueLabel.Size = new System.Drawing.Size(15, 13);
            this.rValueLabel.TabIndex = 12;
            this.rValueLabel.Text = "R";
            // 
            // gValueLabel
            // 
            this.gValueLabel.AutoSize = true;
            this.gValueLabel.Location = new System.Drawing.Point(82, 81);
            this.gValueLabel.Name = "gValueLabel";
            this.gValueLabel.Size = new System.Drawing.Size(15, 13);
            this.gValueLabel.TabIndex = 13;
            this.gValueLabel.Text = "G";
            // 
            // bValueLabel
            // 
            this.bValueLabel.AutoSize = true;
            this.bValueLabel.Location = new System.Drawing.Point(136, 81);
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
            this.invertPictureButton.Location = new System.Drawing.Point(96, 23);
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
            this.thresholdPictureButton.Location = new System.Drawing.Point(93, 27);
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
            this.showPictureHistogramButton.Location = new System.Drawing.Point(96, 77);
            this.showPictureHistogramButton.Name = "showPictureHistogramButton";
            this.showPictureHistogramButton.Size = new System.Drawing.Size(76, 41);
            this.showPictureHistogramButton.TabIndex = 28;
            this.showPictureHistogramButton.Text = "View Histogram";
            this.showPictureHistogramButton.UseVisualStyleBackColor = true;
            this.showPictureHistogramButton.Click += new System.EventHandler(this.showPictureHistogramButton_Click);
            // 
            // pictureManipulationGroupBox
            // 
            this.pictureManipulationGroupBox.Controls.Add(this.greyscaleLumaButton);
            this.pictureManipulationGroupBox.Controls.Add(this.invertPictureButton);
            this.pictureManipulationGroupBox.Controls.Add(this.greyscaleAveragingButton);
            this.pictureManipulationGroupBox.Controls.Add(this.showPictureHistogramButton);
            this.pictureManipulationGroupBox.Location = new System.Drawing.Point(319, 247);
            this.pictureManipulationGroupBox.Name = "pictureManipulationGroupBox";
            this.pictureManipulationGroupBox.Size = new System.Drawing.Size(186, 194);
            this.pictureManipulationGroupBox.TabIndex = 29;
            this.pictureManipulationGroupBox.TabStop = false;
            this.pictureManipulationGroupBox.Text = "Picture Manipulation by Calculation";
            // 
            // greyscalePointerButton
            // 
            this.greyscalePointerButton.Location = new System.Drawing.Point(11, 23);
            this.greyscalePointerButton.Name = "greyscalePointerButton";
            this.greyscalePointerButton.Size = new System.Drawing.Size(76, 41);
            this.greyscalePointerButton.TabIndex = 34;
            this.greyscalePointerButton.Text = "BT.601 Greyscale";
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
            this.mainMenuStrip.Size = new System.Drawing.Size(1034, 24);
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
            this.changePictureToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.changePictureToolStripMenuItem.Text = "Change Picture";
            this.changePictureToolStripMenuItem.Click += new System.EventHandler(this.changePictureToolStripMenuItem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rValueTextBox);
            this.groupBox1.Controls.Add(this.gValueTextBox);
            this.groupBox1.Controls.Add(this.bValueTextBox);
            this.groupBox1.Controls.Add(this.rValueLabel);
            this.groupBox1.Controls.Add(this.gValueLabel);
            this.groupBox1.Controls.Add(this.bValueLabel);
            this.groupBox1.Controls.Add(this.xCoordinateTextBox);
            this.groupBox1.Controls.Add(this.xCoordinateLabel);
            this.groupBox1.Controls.Add(this.getCoordinatesRGBValueButton);
            this.groupBox1.Controls.Add(this.yCoordinateTextBox);
            this.groupBox1.Controls.Add(this.yCoordinateLabel);
            this.groupBox1.Location = new System.Drawing.Point(526, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 186);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinates";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.invertPictureByPointerButton);
            this.groupBox2.Controls.Add(this.greyscalePointerButton);
            this.groupBox2.Location = new System.Drawing.Point(526, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 194);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Picture Manipulation by Pointer";
            // 
            // invertPictureByPointerButton
            // 
            this.invertPictureByPointerButton.Location = new System.Drawing.Point(97, 23);
            this.invertPictureByPointerButton.Name = "invertPictureByPointerButton";
            this.invertPictureByPointerButton.Size = new System.Drawing.Size(76, 41);
            this.invertPictureByPointerButton.TabIndex = 29;
            this.invertPictureByPointerButton.Text = "Invert Color";
            this.invertPictureByPointerButton.UseVisualStyleBackColor = true;
            this.invertPictureByPointerButton.Click += new System.EventHandler(this.invertPictureByPointerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.thresholdingGroupBox);
            this.Controls.Add(this.brightnessGroupBox);
            this.Controls.Add(this.resultPictureGroupBox);
            this.Controls.Add(this.originalPictureGroupBox);
            this.Controls.Add(this.pictureManipulationGroupBox);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.TextBox xCoordinateTextBox;
        private System.Windows.Forms.TextBox yCoordinateTextBox;
        private System.Windows.Forms.Label xCoordinateLabel;
        private System.Windows.Forms.Label yCoordinateLabel;
        private System.Windows.Forms.Button getCoordinatesRGBValueButton;
        private System.Windows.Forms.TextBox rValueTextBox;
        private System.Windows.Forms.TextBox gValueTextBox;
        private System.Windows.Forms.TextBox bValueTextBox;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button invertPictureByPointerButton;
    }
}

