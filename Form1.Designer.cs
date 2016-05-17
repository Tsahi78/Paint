namespace Paint
{
    partial class frmPaint
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pctBackColor = new System.Windows.Forms.PictureBox();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.pctPenColor = new System.Windows.Forms.PictureBox();
            this.btnRotate = new System.Windows.Forms.Button();
            this.lblSizeMode = new System.Windows.Forms.Label();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.cmbSizeMode = new System.Windows.Forms.ComboBox();
            this.lblWidthPen = new System.Windows.Forms.Label();
            this.lblColorPen = new System.Windows.Forms.Label();
            this.cmbWidthPen = new System.Windows.Forms.ComboBox();
            this.lblShapes = new System.Windows.Forms.Label();
            this.cmbShapes = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.pnlRotate = new System.Windows.Forms.Panel();
            this.btnFlipY = new System.Windows.Forms.Button();
            this.btnFlipX = new System.Windows.Forms.Button();
            this.btn270degree = new System.Windows.Forms.Button();
            this.btn180degree = new System.Windows.Forms.Button();
            this.btn90degree = new System.Windows.Forms.Button();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPenColor)).BeginInit();
            this.pnlRotate.SuspendLayout();
            this.pnlImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pctImage
            // 
            this.pctImage.BackColor = System.Drawing.Color.White;
            this.pctImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctImage.Location = new System.Drawing.Point(12, 6);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(1109, 500);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctImage.TabIndex = 1;
            this.pctImage.TabStop = false;
            this.pctImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pctImage_MouseClick);
            this.pctImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctImage_MouseDown);
            this.pctImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctImage_MouseMove);
            this.pctImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctImage_MouseUp);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pctBackColor);
            this.pnlMenu.Controls.Add(this.lblBackColor);
            this.pnlMenu.Controls.Add(this.pctPenColor);
            this.pnlMenu.Controls.Add(this.btnRotate);
            this.pnlMenu.Controls.Add(this.lblSizeMode);
            this.pnlMenu.Controls.Add(this.btnZoomOut);
            this.pnlMenu.Controls.Add(this.btnZoomIn);
            this.pnlMenu.Controls.Add(this.cmbSizeMode);
            this.pnlMenu.Controls.Add(this.lblWidthPen);
            this.pnlMenu.Controls.Add(this.lblColorPen);
            this.pnlMenu.Controls.Add(this.cmbWidthPen);
            this.pnlMenu.Controls.Add(this.lblShapes);
            this.pnlMenu.Controls.Add(this.cmbShapes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 24);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1133, 67);
            this.pnlMenu.TabIndex = 2;
            // 
            // pctBackColor
            // 
            this.pctBackColor.BackColor = System.Drawing.Color.White;
            this.pctBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBackColor.Location = new System.Drawing.Point(408, 33);
            this.pctBackColor.Name = "pctBackColor";
            this.pctBackColor.Size = new System.Drawing.Size(96, 21);
            this.pctBackColor.TabIndex = 15;
            this.pctBackColor.TabStop = false;
            this.pctBackColor.Click += new System.EventHandler(this.pctBackColor_Click);
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(433, 15);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(60, 13);
            this.lblBackColor.TabIndex = 14;
            this.lblBackColor.Text = "צבע מילוי";
            // 
            // pctPenColor
            // 
            this.pctPenColor.BackColor = System.Drawing.Color.Black;
            this.pctPenColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctPenColor.Location = new System.Drawing.Point(160, 33);
            this.pctPenColor.Name = "pctPenColor";
            this.pctPenColor.Size = new System.Drawing.Size(86, 21);
            this.pctPenColor.TabIndex = 13;
            this.pctPenColor.TabStop = false;
            this.pctPenColor.Click += new System.EventHandler(this.pctPenColor_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(812, 33);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 23);
            this.btnRotate.TabIndex = 12;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // lblSizeMode
            // 
            this.lblSizeMode.AutoSize = true;
            this.lblSizeMode.Location = new System.Drawing.Point(548, 15);
            this.lblSizeMode.Name = "lblSizeMode";
            this.lblSizeMode.Size = new System.Drawing.Size(73, 13);
            this.lblSizeMode.TabIndex = 11;
            this.lblSizeMode.Text = "תצוגת תמונה";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(730, 33);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 10;
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(648, 33);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 23);
            this.btnZoomIn.TabIndex = 9;
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // cmbSizeMode
            // 
            this.cmbSizeMode.FormattingEnabled = true;
            this.cmbSizeMode.Items.AddRange(new object[] {
            "Zoom",
            "Stretch",
            "Normal"});
            this.cmbSizeMode.Location = new System.Drawing.Point(520, 33);
            this.cmbSizeMode.Name = "cmbSizeMode";
            this.cmbSizeMode.Size = new System.Drawing.Size(121, 21);
            this.cmbSizeMode.TabIndex = 8;
            this.cmbSizeMode.TextChanged += new System.EventHandler(this.cmbSizeMode_TextChanged);
            // 
            // lblWidthPen
            // 
            this.lblWidthPen.AutoSize = true;
            this.lblWidthPen.Location = new System.Drawing.Point(300, 15);
            this.lblWidthPen.Name = "lblWidthPen";
            this.lblWidthPen.Size = new System.Drawing.Size(64, 13);
            this.lblWidthPen.TabIndex = 5;
            this.lblWidthPen.Text = "עובי עפרון";
            // 
            // lblColorPen
            // 
            this.lblColorPen.AutoSize = true;
            this.lblColorPen.Location = new System.Drawing.Point(171, 15);
            this.lblColorPen.Name = "lblColorPen";
            this.lblColorPen.Size = new System.Drawing.Size(61, 13);
            this.lblColorPen.TabIndex = 4;
            this.lblColorPen.Text = "צבע עפרון";
            // 
            // cmbWidthPen
            // 
            this.cmbWidthPen.FormattingEnabled = true;
            this.cmbWidthPen.Location = new System.Drawing.Point(264, 33);
            this.cmbWidthPen.Name = "cmbWidthPen";
            this.cmbWidthPen.Size = new System.Drawing.Size(121, 21);
            this.cmbWidthPen.TabIndex = 3;
            this.cmbWidthPen.TextChanged += new System.EventHandler(this.cmbWidthPen_TextChanged);
            // 
            // lblShapes
            // 
            this.lblShapes.AutoSize = true;
            this.lblShapes.Location = new System.Drawing.Point(43, 15);
            this.lblShapes.Name = "lblShapes";
            this.lblShapes.Size = new System.Drawing.Size(58, 13);
            this.lblShapes.TabIndex = 1;
            this.lblShapes.Text = "צורת ציור";
            // 
            // cmbShapes
            // 
            this.cmbShapes.FormattingEnabled = true;
            this.cmbShapes.Items.AddRange(new object[] {
            "חופשי",
            "קו",
            "אליפסה"});
            this.cmbShapes.Location = new System.Drawing.Point(12, 33);
            this.cmbShapes.Name = "cmbShapes";
            this.cmbShapes.Size = new System.Drawing.Size(121, 21);
            this.cmbShapes.TabIndex = 0;
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // pnlRotate
            // 
            this.pnlRotate.Controls.Add(this.btnFlipY);
            this.pnlRotate.Controls.Add(this.btnFlipX);
            this.pnlRotate.Controls.Add(this.btn270degree);
            this.pnlRotate.Controls.Add(this.btn180degree);
            this.pnlRotate.Controls.Add(this.btn90degree);
            this.pnlRotate.Location = new System.Drawing.Point(803, 6);
            this.pnlRotate.Name = "pnlRotate";
            this.pnlRotate.Size = new System.Drawing.Size(93, 152);
            this.pnlRotate.TabIndex = 3;
            this.pnlRotate.Visible = false;
            // 
            // btnFlipY
            // 
            this.btnFlipY.Location = new System.Drawing.Point(7, 121);
            this.btnFlipY.Name = "btnFlipY";
            this.btnFlipY.Size = new System.Drawing.Size(75, 23);
            this.btnFlipY.TabIndex = 4;
            this.btnFlipY.Text = "Flip Y";
            this.btnFlipY.UseVisualStyleBackColor = true;
            this.btnFlipY.Click += new System.EventHandler(this.btnFlipY_Click);
            // 
            // btnFlipX
            // 
            this.btnFlipX.Location = new System.Drawing.Point(8, 91);
            this.btnFlipX.Name = "btnFlipX";
            this.btnFlipX.Size = new System.Drawing.Size(75, 23);
            this.btnFlipX.TabIndex = 3;
            this.btnFlipX.Text = "Flip X";
            this.btnFlipX.UseVisualStyleBackColor = true;
            this.btnFlipX.Click += new System.EventHandler(this.btnFlipX_Click);
            // 
            // btn270degree
            // 
            this.btn270degree.Location = new System.Drawing.Point(8, 61);
            this.btn270degree.Name = "btn270degree";
            this.btn270degree.Size = new System.Drawing.Size(75, 23);
            this.btn270degree.TabIndex = 2;
            this.btn270degree.Text = "270";
            this.btn270degree.UseVisualStyleBackColor = true;
            this.btn270degree.Click += new System.EventHandler(this.btn270degree_Click);
            // 
            // btn180degree
            // 
            this.btn180degree.Location = new System.Drawing.Point(8, 32);
            this.btn180degree.Name = "btn180degree";
            this.btn180degree.Size = new System.Drawing.Size(75, 23);
            this.btn180degree.TabIndex = 1;
            this.btn180degree.Text = "180";
            this.btn180degree.UseVisualStyleBackColor = true;
            this.btn180degree.Click += new System.EventHandler(this.btn180degree_Click);
            // 
            // btn90degree
            // 
            this.btn90degree.Location = new System.Drawing.Point(8, 3);
            this.btn90degree.Name = "btn90degree";
            this.btn90degree.Size = new System.Drawing.Size(75, 23);
            this.btn90degree.TabIndex = 0;
            this.btn90degree.Text = "90";
            this.btn90degree.UseVisualStyleBackColor = true;
            this.btn90degree.Click += new System.EventHandler(this.btn90degree_Click);
            // 
            // pnlImage
            // 
            this.pnlImage.AutoScroll = true;
            this.pnlImage.Controls.Add(this.pnlRotate);
            this.pnlImage.Controls.Add(this.pctImage);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImage.Location = new System.Drawing.Point(0, 91);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(1133, 518);
            this.pnlImage.TabIndex = 6;
            // 
            // frmPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 609);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmPaint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.frmPaint_Load);
            this.Resize += new System.EventHandler(this.frmPaint_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPenColor)).EndInit();
            this.pnlRotate.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblWidthPen;
        private System.Windows.Forms.Label lblColorPen;
        private System.Windows.Forms.ComboBox cmbWidthPen;
        private System.Windows.Forms.Label lblShapes;
        private System.Windows.Forms.ComboBox cmbShapes;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ComboBox cmbSizeMode;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Label lblSizeMode;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Panel pnlRotate;
        private System.Windows.Forms.Button btn270degree;
        private System.Windows.Forms.Button btn180degree;
        private System.Windows.Forms.Button btn90degree;
        private System.Windows.Forms.Button btnFlipY;
        private System.Windows.Forms.Button btnFlipX;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pctPenColor;
        private System.Windows.Forms.PictureBox pctBackColor;
        private System.Windows.Forms.Label lblBackColor;
    }
}

