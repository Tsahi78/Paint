/*
 *  Maslikov Igor 327125217
 *  Shrago Evgeny 317846897
 *  Simon Ziv 301354676 
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace Paint
{
    public partial class frmPaint : Form
    {
        private Bitmap img;
        private Graphics g;
        Image imageFromFile;

        private int startX;
        private int startY;
        private int endX;
        private int endY;

        private Pen currentPen;
        private bool startFlag;
        private bool visible = false;

        Point lastPoint = Point.Empty;//Point.Empty represents null for a Point object

        bool isMouseDown = new Boolean();//this is used to evaluate whether our mousebutton

        public frmPaint()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Open file dialog and choose image file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgOpen.FileName = string.Empty;
            dlgOpen.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imageFromFile = Image.FromFile(dlgOpen.FileName);
                img = (Bitmap)imageFromFile;
                g = Graphics.FromImage(img);
                pctImage.Image = img;
            }
        }

        /// <summary>
        /// exit from application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// clear picture box
        /// </summary>
        private void clearImageBox()
        {
            img = new Bitmap(pctImage.Width, pctImage.Height);
            g = Graphics.FromImage(img);
            //g.Clear(Color.White);
            g.Clear(pctBackColor.BackColor);
            pctImage.Image = img;
        }

        /// <summary>
        /// new clear image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearImageBox();
        }

        /// <summary>
        /// load form of application
        /// initialize pen, combobox of sizeMode, combobox of kind shapes,
        /// combobox of width pen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPaint_Load(object sender, EventArgs e)
        {
            
            clearImageBox();
            currentPen = new Pen(pctPenColor.BackColor, getWidth(cmbWidthPen));
            cmbSizeMode.Text = cmbSizeMode.Items[0].ToString();
            cmbShapes.Text = cmbShapes.Items[0].ToString();

            for (int i = 2; i < 30; i+=2 )
            {
                cmbWidthPen.Items.Add(i);
            }
            cmbWidthPen.Text = cmbWidthPen.Items[0].ToString();
        }

        /// <summary>
        /// if mouse down, memory point where mouse down
        /// start of drawing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (cmbShapes.Text == "חופשי")
            {
               // lastPoint = e.Location;//we assign the lastPoint to the current mouse position: e.Location ('e' is from the MouseEventArgs passed into the MouseDown event)
                lastPoint = point_projection(img, e.X, e.Y);
                isMouseDown = true;//we set to true because our mouse button is down (clicked)
            }
        }

        /// <summary>
        /// draw line by move mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)//check to see if the mouse button is down
            {

                if (lastPoint != null)//if our last point is not null, which in this case we have assigned above
                {
                    g.DrawLine(currentPen, lastPoint, point_projection(img, e.X, e.Y));
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    //this is to give the drawing a more smoother, less sharper look

                    pctImage.Invalidate();//refreshes the picturebox

                    lastPoint = point_projection(img, e.X, e.Y); ;//keep assigning the lastPoint to the current mouse position

                }

            }
        }

        /// <summary>
        /// end of drawing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (cmbShapes.Text == "חופשי")
            {
                isMouseDown = false;

                lastPoint = Point.Empty;
            }

        }

        /// <summary>
        /// draw line and elipse by clicked on 2 points
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctImage_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = point_projection(img, e.X, e.Y);
            if (startFlag == false)
            {
                startX = point.X;
                startY = point.Y;
                startFlag = true;
            }
            else
            {
                endX = point.X;
                endY = point.Y;
                switch (cmbShapes.Text)
                {
                    case "קו":
                        g.DrawLine(currentPen, startX, startY, endX, endY);
                        break;
                    case "אליפסה":
                        g.DrawEllipse(currentPen, startX, startY, endX - startX, endY - startY);
                        break;
                }

                pctImage.Refresh();
                startFlag = false;

            }


        }

        /// <summary>
        /// change size mode of image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSizeMode_TextChanged(object sender, EventArgs e)
        {
            
            switch (cmbSizeMode.Text)
            {
                case "Zoom":
                    pctImage.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "Stretch":
                    pctImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Normal":
                    pctImage.SizeMode = PictureBoxSizeMode.Normal;
                    break;
            }
            pctImage.Refresh();
        }

        /// <summary>
        /// save image in startup folder,the file name of image is 1.jpg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            pctImage.Image.Save(Application.StartupPath + "\\1.jpg", ImageFormat.Jpeg);
        }

        /// <summary>
        /// save as image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgSave.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            ImageFormat format = ImageFormat.Png;
            if(dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (dlgSave.FilterIndex)
                {
                    case 1:
                        format = ImageFormat.Jpeg;
                        break;

                    case 2:
                        format = ImageFormat.Bmp;
                        break;

                    case 3:
                        format = ImageFormat.Gif;
                        break;
                }
                pctImage.Image.Save(dlgSave.FileName, format);
            }
        }

        /// <summary>
        /// zoomIn image, pictureBox size +50
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            
            pctImage.Height += 50;
            pctImage.Width += 50;
        }

        /// <summary>
        /// zoomOut image, pictureBox size -50
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            pctImage.Height -= 50;
            pctImage.Width -= 50;
        }

        /// <summary>
        /// change width of pen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbWidthPen_TextChanged(object sender, EventArgs e)
        {
            currentPen.Width = getWidth(cmbWidthPen);
        }

        /// <summary>
        /// convert string of combobox to float
        /// </summary>
        /// <param name="cmbWidthPen"></param>
        /// <returns></returns>
        private float getWidth(ComboBox cmbWidthPen)
        {
            float result;
            try
            {
                
                float.TryParse(cmbWidthPen.Text.ToString(), out result);
            }
            catch (Exception)
            {
                result=2;
                cmbWidthPen.Text = cmbWidthPen.Items[0].ToString();
            }
            return result;
        }

        /// <summary>
        /// visible and unvisible panel of rotates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRotate_Click(object sender, EventArgs e)
        {
            if(!visible)
            {
                visible = true;
            }
            else
            {
                visible = false;
                
            }
            pnlRotate.Visible = visible;
        }

        /// <summary>
        /// rotate 90 degree image clockwise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn90degree_Click(object sender, EventArgs e)
        {
            rotateImage("90");

        }

        /// <summary>
        /// rotate 180 degree image clockwise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn180degree_Click(object sender, EventArgs e)
        {
            rotateImage("180");
        }

        /// <summary>
        /// rotate 270 degree image clockwise
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn270degree_Click(object sender, EventArgs e)
        {
            rotateImage("270");
        }

        /// <summary>
        /// flip image by X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFlipX_Click(object sender, EventArgs e)
        {
            rotateImage("FlipX");
        }

        /// <summary>
        /// flip image by Y
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFlipY_Click(object sender, EventArgs e)
        {
            rotateImage("FlipY");
        }

        /// <summary>
        /// function for rotate image
        /// </summary>
        /// <param name="degree"> parameter for rotate</param>
        void rotateImage(string degree)
        {

            switch (degree)
            {
                case "90":
                    pctImage.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case "180":
                    pctImage.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case "270":
                    pctImage.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case "FlipX":
                    pctImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                case "FlipY":
                    pctImage.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;
            }

            img = new Bitmap(pctImage.Image);
            g = Graphics.FromImage(img);
            pctImage.Image = img;           
        
            pctImage.Refresh();
            visible = false;
            pnlRotate.Visible = visible;
            
        }

        /// <summary>
        /// return actual point of bitmap image,by size mode
        /// </summary>
        /// <param name="myBitmap">bitmap of image</param>
        /// <param name="x">X from point on pictureBox</param>
        /// <param name="y">Y from point on pictureBox</param>
        /// <returns>Point</returns>
        private Point point_projection(Bitmap myBitmap, int x, int y)
        {
            int heightB = myBitmap.Height;
            int heightP = pctImage.Height;
            int widthB = myBitmap.Width;
            int widthP = pctImage.Width;
            double xRatio = (double)widthB / (double)widthP;
            double yRatio = (double)heightB / (double)heightP;
            Point point = new Point();

            if (pctImage.SizeMode == PictureBoxSizeMode.StretchImage)
            {
                point.X = (int)(x * xRatio);
                point.Y = (int)(y * yRatio);
            }
            else if (pctImage.SizeMode == PictureBoxSizeMode.Zoom)
            {
                double ratio = xRatio;
                bool x_filled = true;

                if (ratio < yRatio)
                {
                    ratio = yRatio;
                    x_filled = false;
                }

                if (x_filled)
                {
                    heightB = (int)(heightB / ratio);
                    int borderHeight = (heightP - heightB) / 2;
                    point.X = (int)(x * ratio);
                    point.Y = (int)((y - borderHeight) * ratio);
                }
                else
                {
                    widthB = (int)(widthB / ratio);
                    int borderWidth = (widthP - widthB) / 2;
                    point.X = (int)((x - borderWidth) * ratio);
                    point.Y = (int)(y * ratio);
                }
            }
            else
            {
                point.X = x;
                point.Y = y;
            }
            return point;
        }

        /// <summary>
        /// open color dialog,choose color and change pen color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctPenColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pctPenColor.BackColor = colorDialog.Color;
                currentPen.Color = colorDialog.Color;
            }
        }

        /// <summary>
        /// open color dialog,choose color and change backcolor of image(clear image in color chosen)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pctBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pctBackColor.BackColor = colorDialog.Color;
                g.Clear(colorDialog.Color);
                pctImage.Refresh();
            }
        }

        /// <summary>
        /// resize picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPaint_Resize(object sender, EventArgs e)
        {
            pctImage.Width = pnlImage.Width - 2 * pctImage.Left;
            pctImage.Height = pnlImage.Height - 2*pctImage.Top;
            pctImage.Refresh();
        }

   }
}
