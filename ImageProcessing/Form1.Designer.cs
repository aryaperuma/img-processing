namespace ImageProcessing
{
    partial class frmImageProcessing
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnDarken = new System.Windows.Forms.Button();
            this.btnLighten = new System.Windows.Forms.Button();
            this.btnSunset = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnPolarize = new System.Windows.Forms.Button();
            this.btnFlipHorizontal = new System.Windows.Forms.Button();
            this.btnFlipVertical = new System.Windows.Forms.Button();
            this.btnRotate180 = new System.Windows.Forms.Button();
            this.btnSwitchCorners = new System.Windows.Forms.Button();
            this.btnPixellate = new System.Windows.Forms.Button();
            this.btnTile = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnBlur = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.msFile = new System.Windows.Forms.MenuStrip();
            this.tsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGreenFilter = new System.Windows.Forms.Button();
            this.btnRedFilter = new System.Windows.Forms.Button();
            this.btnBlueFilter = new System.Windows.Forms.Button();
            this.gbDifficult = new System.Windows.Forms.GroupBox();
            this.gbEasy = new System.Windows.Forms.GroupBox();
            this.gbExtractChannel = new System.Windows.Forms.GroupBox();
            this.gbDarkenLighten = new System.Windows.Forms.GroupBox();
            this.gbFlip = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.msFile.SuspendLayout();
            this.gbDifficult.SuspendLayout();
            this.gbEasy.SuspendLayout();
            this.gbExtractChannel.SuspendLayout();
            this.gbDarkenLighten.SuspendLayout();
            this.gbFlip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(13, 360);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(13, 57);
            this.picImage.Margin = new System.Windows.Forms.Padding(4);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(427, 295);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // btnDarken
            // 
            this.btnDarken.Location = new System.Drawing.Point(18, 22);
            this.btnDarken.Margin = new System.Windows.Forms.Padding(4);
            this.btnDarken.Name = "btnDarken";
            this.btnDarken.Size = new System.Drawing.Size(100, 28);
            this.btnDarken.TabIndex = 0;
            this.btnDarken.Text = "Darken";
            this.btnDarken.UseVisualStyleBackColor = true;
            this.btnDarken.Click += new System.EventHandler(this.btnDarken_Click);
            // 
            // btnLighten
            // 
            this.btnLighten.Location = new System.Drawing.Point(18, 58);
            this.btnLighten.Margin = new System.Windows.Forms.Padding(4);
            this.btnLighten.Name = "btnLighten";
            this.btnLighten.Size = new System.Drawing.Size(100, 28);
            this.btnLighten.TabIndex = 1;
            this.btnLighten.Text = "Lighten";
            this.btnLighten.UseVisualStyleBackColor = true;
            this.btnLighten.Click += new System.EventHandler(this.btnLighten_Click);
            // 
            // btnSunset
            // 
            this.btnSunset.Location = new System.Drawing.Point(208, 43);
            this.btnSunset.Margin = new System.Windows.Forms.Padding(4);
            this.btnSunset.Name = "btnSunset";
            this.btnSunset.Size = new System.Drawing.Size(100, 28);
            this.btnSunset.TabIndex = 1;
            this.btnSunset.Text = "Sunset Effect";
            this.btnSunset.UseVisualStyleBackColor = true;
            this.btnSunset.Click += new System.EventHandler(this.btnSunset_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(209, 79);
            this.btnGrayscale.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(100, 56);
            this.btnGrayscale.TabIndex = 2;
            this.btnGrayscale.Text = "Convert to Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnPolarize
            // 
            this.btnPolarize.Location = new System.Drawing.Point(209, 143);
            this.btnPolarize.Margin = new System.Windows.Forms.Padding(4);
            this.btnPolarize.Name = "btnPolarize";
            this.btnPolarize.Size = new System.Drawing.Size(100, 28);
            this.btnPolarize.TabIndex = 3;
            this.btnPolarize.Text = "Polarize";
            this.btnPolarize.UseVisualStyleBackColor = true;
            this.btnPolarize.Click += new System.EventHandler(this.btnPolarize_Click);
            // 
            // btnFlipHorizontal
            // 
            this.btnFlipHorizontal.Location = new System.Drawing.Point(18, 22);
            this.btnFlipHorizontal.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlipHorizontal.Name = "btnFlipHorizontal";
            this.btnFlipHorizontal.Size = new System.Drawing.Size(100, 28);
            this.btnFlipHorizontal.TabIndex = 0;
            this.btnFlipHorizontal.Text = "Horizontally";
            this.btnFlipHorizontal.UseVisualStyleBackColor = true;
            this.btnFlipHorizontal.Click += new System.EventHandler(this.btnFlipHorizontal_Click);
            // 
            // btnFlipVertical
            // 
            this.btnFlipVertical.Location = new System.Drawing.Point(18, 58);
            this.btnFlipVertical.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlipVertical.Name = "btnFlipVertical";
            this.btnFlipVertical.Size = new System.Drawing.Size(100, 28);
            this.btnFlipVertical.TabIndex = 1;
            this.btnFlipVertical.Text = "Vertically";
            this.btnFlipVertical.UseVisualStyleBackColor = true;
            this.btnFlipVertical.Click += new System.EventHandler(this.btnFlipVertical_Click);
            // 
            // btnRotate180
            // 
            this.btnRotate180.Location = new System.Drawing.Point(208, 286);
            this.btnRotate180.Margin = new System.Windows.Forms.Padding(4);
            this.btnRotate180.Name = "btnRotate180";
            this.btnRotate180.Size = new System.Drawing.Size(100, 28);
            this.btnRotate180.TabIndex = 4;
            this.btnRotate180.Text = "Rotate 180";
            this.btnRotate180.UseVisualStyleBackColor = true;
            this.btnRotate180.Click += new System.EventHandler(this.btnRotate180_Click);
            // 
            // btnSwitchCorners
            // 
            this.btnSwitchCorners.Location = new System.Drawing.Point(358, 43);
            this.btnSwitchCorners.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwitchCorners.Name = "btnSwitchCorners";
            this.btnSwitchCorners.Size = new System.Drawing.Size(100, 43);
            this.btnSwitchCorners.TabIndex = 5;
            this.btnSwitchCorners.Text = "Switch Corners";
            this.btnSwitchCorners.UseVisualStyleBackColor = true;
            this.btnSwitchCorners.Click += new System.EventHandler(this.btnSwitchCorners_Click);
            // 
            // btnPixellate
            // 
            this.btnPixellate.Location = new System.Drawing.Point(358, 107);
            this.btnPixellate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPixellate.Name = "btnPixellate";
            this.btnPixellate.Size = new System.Drawing.Size(100, 28);
            this.btnPixellate.TabIndex = 6;
            this.btnPixellate.Text = "Pixellate";
            this.btnPixellate.UseVisualStyleBackColor = true;
            this.btnPixellate.Click += new System.EventHandler(this.btnPixellate_Click);
            // 
            // btnTile
            // 
            this.btnTile.Location = new System.Drawing.Point(358, 161);
            this.btnTile.Margin = new System.Windows.Forms.Padding(4);
            this.btnTile.Name = "btnTile";
            this.btnTile.Size = new System.Drawing.Size(100, 28);
            this.btnTile.TabIndex = 7;
            this.btnTile.Text = "Tile";
            this.btnTile.UseVisualStyleBackColor = true;
            this.btnTile.Click += new System.EventHandler(this.btnTile_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Location = new System.Drawing.Point(24, 173);
            this.btnNegative.Margin = new System.Windows.Forms.Padding(4);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(100, 28);
            this.btnNegative.TabIndex = 0;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnBlur
            // 
            this.btnBlur.Location = new System.Drawing.Point(17, 55);
            this.btnBlur.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(100, 28);
            this.btnBlur.TabIndex = 1;
            this.btnBlur.Text = "Blur";
            this.btnBlur.UseVisualStyleBackColor = true;
            this.btnBlur.Click += new System.EventHandler(this.btnBlur_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(17, 124);
            this.btnSort.Margin = new System.Windows.Forms.Padding(4);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(100, 28);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(17, 198);
            this.btnZoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(100, 28);
            this.btnZoom.TabIndex = 3;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // msFile
            // 
            this.msFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile});
            this.msFile.Location = new System.Drawing.Point(0, 0);
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(1112, 28);
            this.msFile.TabIndex = 26;
            this.msFile.Text = "File";
            // 
            // tsFile
            // 
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSaveImage});
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(46, 24);
            this.tsFile.Text = "File";
            // 
            // tsSaveImage
            // 
            this.tsSaveImage.Name = "tsSaveImage";
            this.tsSaveImage.Size = new System.Drawing.Size(224, 26);
            this.tsSaveImage.Text = "Save Image";
            this.tsSaveImage.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // btnGreenFilter
            // 
            this.btnGreenFilter.Location = new System.Drawing.Point(18, 58);
            this.btnGreenFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnGreenFilter.Name = "btnGreenFilter";
            this.btnGreenFilter.Size = new System.Drawing.Size(100, 28);
            this.btnGreenFilter.TabIndex = 1;
            this.btnGreenFilter.Text = "Green";
            this.btnGreenFilter.UseVisualStyleBackColor = true;
            this.btnGreenFilter.Click += new System.EventHandler(this.btnGreenFilter_Click);
            // 
            // btnRedFilter
            // 
            this.btnRedFilter.Location = new System.Drawing.Point(18, 22);
            this.btnRedFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnRedFilter.Name = "btnRedFilter";
            this.btnRedFilter.Size = new System.Drawing.Size(100, 28);
            this.btnRedFilter.TabIndex = 0;
            this.btnRedFilter.Text = "Red";
            this.btnRedFilter.UseVisualStyleBackColor = true;
            this.btnRedFilter.Click += new System.EventHandler(this.btnRedFilter_Click);
            // 
            // btnBlueFilter
            // 
            this.btnBlueFilter.Location = new System.Drawing.Point(18, 94);
            this.btnBlueFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnBlueFilter.Name = "btnBlueFilter";
            this.btnBlueFilter.Size = new System.Drawing.Size(100, 28);
            this.btnBlueFilter.TabIndex = 2;
            this.btnBlueFilter.Text = "Blue";
            this.btnBlueFilter.UseVisualStyleBackColor = true;
            this.btnBlueFilter.Click += new System.EventHandler(this.btnBlueFilter_Click);
            // 
            // gbDifficult
            // 
            this.gbDifficult.Controls.Add(this.btnZoom);
            this.gbDifficult.Controls.Add(this.btnSort);
            this.gbDifficult.Controls.Add(this.btnBlur);
            this.gbDifficult.Location = new System.Drawing.Point(950, 57);
            this.gbDifficult.Name = "gbDifficult";
            this.gbDifficult.Size = new System.Drawing.Size(146, 276);
            this.gbDifficult.TabIndex = 25;
            this.gbDifficult.TabStop = false;
            this.gbDifficult.Text = "Difficult Filters";
            // 
            // gbEasy
            // 
            this.gbEasy.Controls.Add(this.gbExtractChannel);
            this.gbEasy.Controls.Add(this.btnNegative);
            this.gbEasy.Controls.Add(this.gbDarkenLighten);
            this.gbEasy.Controls.Add(this.btnTile);
            this.gbEasy.Controls.Add(this.btnSunset);
            this.gbEasy.Controls.Add(this.btnPixellate);
            this.gbEasy.Controls.Add(this.btnGrayscale);
            this.gbEasy.Controls.Add(this.btnSwitchCorners);
            this.gbEasy.Controls.Add(this.btnPolarize);
            this.gbEasy.Controls.Add(this.btnRotate180);
            this.gbEasy.Controls.Add(this.gbFlip);
            this.gbEasy.Location = new System.Drawing.Point(447, 54);
            this.gbEasy.Name = "gbEasy";
            this.gbEasy.Size = new System.Drawing.Size(485, 345);
            this.gbEasy.TabIndex = 20;
            this.gbEasy.TabStop = false;
            this.gbEasy.Text = "Easy Filters";
            // 
            // gbExtractChannel
            // 
            this.gbExtractChannel.Controls.Add(this.btnBlueFilter);
            this.gbExtractChannel.Controls.Add(this.btnRedFilter);
            this.gbExtractChannel.Controls.Add(this.btnGreenFilter);
            this.gbExtractChannel.Location = new System.Drawing.Point(6, 21);
            this.gbExtractChannel.Name = "gbExtractChannel";
            this.gbExtractChannel.Size = new System.Drawing.Size(138, 134);
            this.gbExtractChannel.TabIndex = 9;
            this.gbExtractChannel.TabStop = false;
            this.gbExtractChannel.Text = "Extract Channel";
            // 
            // gbDarkenLighten
            // 
            this.gbDarkenLighten.Controls.Add(this.btnDarken);
            this.gbDarkenLighten.Controls.Add(this.btnLighten);
            this.gbDarkenLighten.Location = new System.Drawing.Point(6, 220);
            this.gbDarkenLighten.Name = "gbDarkenLighten";
            this.gbDarkenLighten.Size = new System.Drawing.Size(138, 94);
            this.gbDarkenLighten.TabIndex = 12;
            this.gbDarkenLighten.TabStop = false;
            this.gbDarkenLighten.Text = "Darken/Lighten";
            // 
            // gbFlip
            // 
            this.gbFlip.Controls.Add(this.btnFlipHorizontal);
            this.gbFlip.Controls.Add(this.btnFlipVertical);
            this.gbFlip.Location = new System.Drawing.Point(188, 179);
            this.gbFlip.Name = "gbFlip";
            this.gbFlip.Size = new System.Drawing.Size(138, 100);
            this.gbFlip.TabIndex = 4;
            this.gbFlip.TabStop = false;
            this.gbFlip.Text = "Flip";
            // 
            // frmImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 418);
            this.Controls.Add(this.gbDifficult);
            this.Controls.Add(this.gbEasy);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.msFile);
            this.MainMenuStrip = this.msFile;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmImageProcessing";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.msFile.ResumeLayout(false);
            this.msFile.PerformLayout();
            this.gbDifficult.ResumeLayout(false);
            this.gbEasy.ResumeLayout(false);
            this.gbExtractChannel.ResumeLayout(false);
            this.gbDarkenLighten.ResumeLayout(false);
            this.gbFlip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnDarken;
        private System.Windows.Forms.Button btnLighten;
        private System.Windows.Forms.Button btnSunset;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btnPolarize;
        private System.Windows.Forms.Button btnFlipHorizontal;
        private System.Windows.Forms.Button btnFlipVertical;
        private System.Windows.Forms.Button btnRotate180;
        private System.Windows.Forms.Button btnSwitchCorners;
        private System.Windows.Forms.Button btnPixellate;
        private System.Windows.Forms.Button btnTile;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnBlur;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.MenuStrip msFile;
        private System.Windows.Forms.ToolStripMenuItem tsFile;
        private System.Windows.Forms.ToolStripMenuItem tsSaveImage;
        private System.Windows.Forms.Button btnGreenFilter;
        private System.Windows.Forms.Button btnRedFilter;
        private System.Windows.Forms.Button btnBlueFilter;
        private System.Windows.Forms.GroupBox gbDifficult;
        private System.Windows.Forms.GroupBox gbEasy;
        private System.Windows.Forms.GroupBox gbExtractChannel;
        private System.Windows.Forms.GroupBox gbDarkenLighten;
        private System.Windows.Forms.GroupBox gbFlip;
    }
}

