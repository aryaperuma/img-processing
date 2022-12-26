using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ImageProcessing
{
    public partial class frmImageProcessing : Form
    {
        public frmImageProcessing()
        {
            InitializeComponent();
        }

        // setting up variable for bitmap image
        Bitmap bitmapImage;

        Color[,] ImageArray = new Color[320, 240];

        // code for browse btn
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //   openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Image Browser";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    Image newImage = Image.FromStream(myStream);
                    bitmapImage = new Bitmap(newImage, 320, 240);
                    picImage.Image = bitmapImage;
                    myStream.Close();
                }
            }

            SetArrayFromBitmap();

        }

        private void SetBitmapFromArray()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    bitmapImage.SetPixel(row, col, ImageArray[row, col]);
                }
        }

        private void SetArrayFromBitmap()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    ImageArray[row, col] = bitmapImage.GetPixel(row, col);
                }
        }
        // code for green extract channel
        private void btnGreenFilter_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            // Processing array data
            int Green;

            int iWidth = 320;
            int iHeight = 240;

            // The sample code extracts the green channel of a pixel and assign the color only to green channel
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    //Gets the green element of the color
                    Green = col.G;

                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // code for red extract channel
        private void btnRedFilter_Click(object sender, EventArgs e)
        {
            //check that image exists
            if (bitmapImage == null)

                //exit
                return;

            // initialized variable for red value
            int Red;

            //initialized and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            // loop through all pixel colors 
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    // gets red element of pixel
                    Red = col.R;

                    // created new filtered colour (red)
                    Color newColor = Color.FromArgb(255, Red, 0, 0);
                    ImageArray[i, j] = newColor;
                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // code for blue extract channel
        private void btnBlueFilter_Click(object sender, EventArgs e)
        {
            //check that image exists
            if (bitmapImage == null)

                //exit
                return;

            // initialized variable for blue value
            int Blue;

            //initialized and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            // loop through all pixel colors 
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    // gets blue element of pixel
                    Blue = col.B;

                    // created new filtered colour (blue)
                    Color newColor = Color.FromArgb(255, 0, 0, Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // gives negative of current image
        private void btnNegative_Click(object sender, EventArgs e)
        {
            // check that image exists
            if (bitmapImage == null)
            {

                // exit
                return;
            }

            // initialized variables for color values  
            int Red, Green, Blue;

            //initialize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            // loop through all color pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    // get pixel
                    Color col = ImageArray[i, j];

                    // set RGB values of pixel
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    // creates new negative image color
                    Color newColor = Color.FromArgb(255, (255 - Red), (255 - Green), (255 - Blue));
                    ImageArray[i, j] = newColor;
                }
            }
            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // darkens image
        private void btnDarken_Click(object sender, EventArgs e)
        {
            // check that image exists
            if (bitmapImage == null)
            {
                // exit
                return;
            }

            // initialize variables for colour values
            int Red, Green, Blue;

            // initalize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            // loop through all pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    // get color pixel
                    Color col = ImageArray[i, j];

                    // subtracting 20 from RGB values each time btn is clicked
                    Red = col.R - 20;

                    Green = col.G - 20;

                    Blue = col.B - 20;

                    // checking if red is invalid (less than 0) and setting it to min value
                    if (Red < 0)
                    {
                        Red = 0;
                    }
                    // checking if green is invalid (less than 0) and setting it to min value
                    if (Green < 0)
                    {
                        Green = 0;
                    }
                    // checking if blue is invalid (less than 0) and setting it to min value
                    if (Blue < 0)
                    {
                        Blue = 0;
                    }

                    // create new darkened color
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            // create new image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;

        }

        private void btnLighten_Click(object sender, EventArgs e)
        {
            // check that image exists
            if (bitmapImage == null)
            {
                // exists
                return;
            }

            // initialize variables for color values
            int Red, Green, Blue;

            // initialize and set image size variables 
            int iWidth = 320;
            int iHeight = 240;

            // loop through all pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    // get color pixel
                    Color col = ImageArray[i, j];

                    // increment RGB values by 20 each time btn is clicked
                    Red = col.R + 20;

                    Green = col.G + 20;

                    Blue = col.B + 20;

                    // checking if red value is invalid (more than 255) and setting it to max value
                    if (Red > 255)
                    {
                        Red = 255;
                    }
                    // checking if green value is invalid (more than 255) and setting it to max value
                    if (Green > 255)
                    {
                        Green = 255;
                    }
                    // checking if blue value is invalid (more than 255) and setting it to max value
                    if (Blue > 255)
                    {
                        Blue = 255;
                    }

                    // create new lightened color
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            // create new image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // creates sunset effect on image
        private void btnSunset_Click(object sender, EventArgs e)
        {
            // check if image exists
            if (bitmapImage == null)
            {
                // exit
                return;
            }

            // initialize variables for color values
            int Red, Green, Blue;

            // initialize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            // loop through all pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {

                    // get color pixel
                    Color col = ImageArray[i, j];

                    // increment red value by 20
                    Red = col.R + 20;

                    // keep green value constant
                    Green = col.G;

                    // decrement blue value by 20
                    Blue = col.B - 20;

                    // check if red value is invalid (more than 255) and set it to max value
                    if (Red > 255)
                    {
                        Red = 255;
                    }
                    // check if blue value is invalid (more than 255) and set it to max value
                    if (Blue < 0)
                    {
                        Blue = 0;
                    }

                    // create new sunset color
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            // create new image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            // check that image exists
            if (bitmapImage == null)
            {
                // exit
                return;
            }

            // initialize variables for colour values
            int Red, Green, Blue, Average;

            // initialize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            // loop through all pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    // get pixel
                    Color pixel = ImageArray[i, j];

                    // set colour values of pixel
                    Red = pixel.R;
                    Green = pixel.G;
                    Blue = pixel.B;

                    // get average of RGB values and store it in variable
                    Average = Convert.ToInt32((Red + Green + Blue) / 3);

                    // create new grayscale color
                    Color newPixel = Color.FromArgb(255, Average, Average, Average);
                    ImageArray[i, j] = newPixel;
                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // puts polarize effect on image
        private void btnPolarize_Click(object sender, EventArgs e)
        {
            // check that image exists
            if (bitmapImage == null)
            {
                return;
            }

            //initialize variables for colour values
            int Red, Green, Blue;
            int redAvg, greenAvg, blueAvg;

            redAvg = 0;
            greenAvg = 0;
            blueAvg = 0;

            //initialize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            //loop through all pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    Red = pixel.R;

                    Green = pixel.G;

                    Blue = pixel.B;

                    // set averages for each RGB value
                    redAvg = Convert.ToInt32(Red) + redAvg;
                    greenAvg = Convert.ToInt32(Green) + greenAvg;
                    blueAvg = Convert.ToInt32(Blue) + blueAvg;

                }
            }

            // divide averages by total pixel area
            redAvg = redAvg / 76800;
            greenAvg = greenAvg / 76800;
            blueAvg = blueAvg / 76800;

            //loop through all pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color pixel = ImageArray[i, j];

                    // set pixel values for RGB
                    Red = pixel.R;

                    Green = pixel.G;

                    Blue = pixel.B;

                    // checking if red value is greater than average 
                    if (Red >= redAvg)
                    {
                        Red = 255;
                    }
                    else
                    {
                        Red = 0;
                    }

                    // checking if green value is greater than average
                    if (Green >= greenAvg)
                    {
                        Green = 255;
                    }
                    else
                    {
                        Green = 0;
                    }

                    // checking if blue value is greater than average 
                    if (Blue >= blueAvg)
                    {
                        Blue = 255;
                    }
                    else
                    {
                        Blue = 0;
                    }

                    // create new polarized color
                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;

        }

        // flip image horizontally
        private void btnFlipHorizontal_Click(object sender, EventArgs e)
        {
            //check that image exists
            if (bitmapImage == null)
            {
                //exit
                return;
            }

            // initialize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            //loop through half of all pixels
            for (int i = 0; i < iWidth / 2; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    // creating temp variable
                    Color temp = ImageArray[i, j];

                    // flip image horizontally with temp variable
                    ImageArray[i, j] = ImageArray[319 - i, j];
                    ImageArray[319 - i, j] = temp;

                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipVertical_Click(object sender, EventArgs e)
        {
            //check that image exists
            if (bitmapImage == null)
            {
                //exit
                return;
            }
            // initialize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            //loop through half of all pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight / 2; j++)
                {
                    // creating temp variable
                    Color temp = ImageArray[i, j];

                    // flip image vertically with temp variable
                    ImageArray[i, j] = ImageArray[i, 239 - j];
                    ImageArray[i, 239 - j] = temp;

                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        private void btnRotate180_Click(object sender, EventArgs e)
        {
            //check that image exists
            if (bitmapImage == null)
            {
                //exit
                return;
            }

            //initialize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            //loop through half of all pixels
            for (int i = 0; i < iWidth / 2; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color temp = ImageArray[i, j];

                    //get values of pixels
                    ImageArray[i, j] = ImageArray[319 - i, j];
                    ImageArray[319 - i, j] = temp;

                }
            }


            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight / 2; j++)
                {
                    // create temp variable
                    Color temp = ImageArray[i, j];

                    // get values of pixels to rotate
                    ImageArray[i, j] = ImageArray[i, 239 - j];
                    ImageArray[i, 239 - j] = temp;

                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // switches corners of image
        private void btnSwitchCorners_Click(object sender, EventArgs e)
        {
            //check that image exists
            if (bitmapImage == null)
            {
                // exit
                return;
            }

            //initialize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            // loop through all pixels
            for (int i = 0; i < iWidth / 2; i++)
            {
                for (int j = 0; j < iHeight / 2; j++)
                {
                    // create temp array
                    Color temp = ImageArray[i, j];

                    // 2D arrays to switch corners
                    ImageArray[i, j] = ImageArray[i + (iWidth - (iWidth / 2)), j + (iHeight - (iHeight / 2))];

                    ImageArray[i + (iWidth - (iWidth / 2)), j + (iHeight - (iHeight / 2))] = temp;
                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // pixelates image
        private void btnPixellate_Click(object sender, EventArgs e)
        {
            //check that image exists
            if (bitmapImage == null)
            {
                //exit
                return;
            }

            //initialize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            // loop through all pixels
            for (int i = 0; i < iWidth; i = i + 8)
            {
                for (int j = 0; j < iHeight; j = j + 8)
                {
                    // store pixel in array
                    Color pixel = ImageArray[i, j];

                    // looping through pixels in increments of 8
                    for (int k = i; k < i + 8; k++)
                    {
                        for (int l = j; l < j + 8; l++)
                        {
                            ImageArray[k, l] = pixel;
                        }
                    }
                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // tiles image
        private void btnTile_Click(object sender, EventArgs e)
        {
            // check that image exists
            if (bitmapImage == null)
            {
                // exit
                return;
            }

            // initialize and set image size variables
            int iWidth, iHeight;
            iWidth = 320;
            iHeight = 240;

            // loop through all pixels
            for (int i = 0; i < iWidth; i = i + 2)
            {
                for (int j = 0; j < iHeight; j = j + 2)
                {
                    // store pixels in array
                    Color pixel = ImageArray[i, j];

                    // divide increments by 2
                    ImageArray[i / 2, j / 2] = ImageArray[i, j];
                    ImageArray[i / 2, j / 2] = pixel;
                }
            }

            for (int i = 0; i < 160; i++)
            {
                for (int j = 0; j < 120; j++)
                {

                    // horizontal pixel values
                    Color pixelH = ImageArray[i, j];

                    ImageArray[319 - i, j] = pixelH;
                    ImageArray[319 - i, j] = ImageArray[i, j];

                    // vertical pixel values
                    Color pixelV = ImageArray[i, j];

                    ImageArray[i, 239 - j] = pixelV;
                    ImageArray[i, 239 - j] = ImageArray[i, j];

                    // rotate pixel values
                    Color pixelRotate = ImageArray[i, j];

                    ImageArray[319 - i, 239 - j] = pixelRotate;
                    ImageArray[i, 239 - j] = ImageArray[i, j];

                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // scrolls through image
        private void btnScrollDown_Click(object sender, EventArgs e)
        {
            // check that image exists
            if (bitmapImage == null)
            {
                // exit
                return;
            }

            // initialize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            // create temp array
            Color[,] TempArray = new Color[320, 240];

            // loop through pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    TempArray[i, j] = ImageArray[i, j];
                }
            }

            // loop through pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    if (j + 30 <= 239)
                    {
                        ImageArray[i, j] = TempArray[i, j + 20];
                    }
                    else
                    {
                        ImageArray[i, j] = TempArray[i, j - 210];
                    }
                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // save image as with file dialog
        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save As New Image";
            saveFileDialog.FileName = "Untitled";
            saveFileDialog.Filter = "PNG|*.png|JPEG Image|*.jpg|GIF Image|*.gif|Bitmap Image|*.bmp|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                int width = Convert.ToInt32(picImage.Width);
                int height = Convert.ToInt32(picImage.Height);
                Bitmap bmp = new Bitmap(width, height);
                picImage.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(saveFileDialog.FileName);

                MessageBox.Show("Image successfully saved to " + "'" + saveFileDialog.FileName + "'.");
            }
            else
            {
                return;
            }
        }

        // blurs image
        private void btnBlur_Click(object sender, EventArgs e)
        {
            // check if image exists
            if (bitmapImage == null)
            {
                // exit
                return;
            }

            // create 2D temp array
            Color[,] TempArray = new Color[320, 240];

            // initalize variables for RGB values
            int Red, Green, Blue, iCounter;

            // initialize variables for RGB sums
            int RedSum, GreenSum, BlueSum;

            // initialize RGB sums to 0
            RedSum = 0;
            GreenSum = 0;
            BlueSum = 0;

            // initialize and set image size variables
            int iWidth, iHeight;
            iWidth = 320;
            iHeight = 240;
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    TempArray[i, j] = ImageArray[i, j];
                }
            }
            // loop through pixels
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {

                    iCounter = 0;


                    for (int m = -1; m <= 1; m++)
                    {
                        for (int n = -1; n <= 1; n++)
                        {
                            if ((i + m) >= 0 && (i + m) < iWidth && (j + n) >= 0 && (j + n) < iHeight && !(m == 0 && n == 0))
                            {
                                // create temp array
                                Color tempPixel = TempArray[(i + m), (j + n)];

                                // increment RGB sum my temp pixel value
                                RedSum += tempPixel.R;
                                GreenSum += tempPixel.G;
                                BlueSum += tempPixel.B;

                                // increment counter
                                iCounter++;
                            }
                        }
                    }


                    Color pixel = ImageArray[i, j];

                    // divide RGB sums by counter value
                    Red = Convert.ToInt32(RedSum / iCounter);
                    Green = Convert.ToInt32(GreenSum / iCounter);
                    Blue = Convert.ToInt32(BlueSum / iCounter);


                    RedSum = 0;
                    GreenSum = 0;
                    BlueSum = 0;


                    Color newPixel = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newPixel;
                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // sorts colors of image (in greyscale)
        private void btnSort_Click(object sender, EventArgs e)
        {
            // check if image exists
            if (bitmapImage == null)
            {
                // exit
                return;
            }

            // initializing variables for RGB and average
            int Red, Green, Blue, Average;

            // initalize and set image size variables
            int iWidth, iHeight;
            iWidth = 320;
            iHeight = 240;

            // create array for averages
            int[] Averages = new int[iWidth];

            // loop through pixels 
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    //get pixel
                    Color pixel = ImageArray[i, j];

                    //set colour values of pixel
                    Red = pixel.R;
                    Green = pixel.G;
                    Blue = pixel.B;

                    //get average
                    Average = Convert.ToInt32((Red + Green + Blue) / 3);

                    //add average to array
                    Averages[j] = Average;
                }

                //sort each line
                for (int j = 1; j < iHeight; j++)
                {
                    // copy element to be inserted
                    int iValue = Averages[j];
                    int k = j - 1;

                    //inner loop moving checking if elements must be moved
                    while (k >= 0)
                    {
                        if (iValue < Averages[k])
                        {
                            //move one space to the right
                            Averages[k + 1] = Averages[k];
                        }
                        else
                        {
                            break;
                        }

                        //move one space to the right
                        k--;
                    }

                    //insert value in correct location
                    Averages[k + 1] = iValue;
                }

                //set sorted array to values of image
                for (int j = 0; j < iHeight; j++)
                {
                    //create new sorted colour
                    Color newPixel = Color.FromArgb(255, Averages[j], Averages[j], Averages[j]);
                    ImageArray[i, j] = newPixel;
                }
            }

            //create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }

        // zoom in on image
        private void btnZoom_Click(object sender, EventArgs e)
        {
            // check if image exists
            if (bitmapImage == null)
            {
                // exit
                return;
            }

            // initialize and set image size variables
            int iWidth = 320;
            int iHeight = 240;

            // create temp array
            Color[,] TempArray = new Color[320, 240];

            // loop through pixels 
            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    TempArray[i, j] = ImageArray[i, j];
                }
            }

            // zooms on centre point of image
            for (int i = 0; i < iWidth; i = i + 2)
            {
                for (int j = 0; j < iHeight; j = j + 2)
                {
                    // create new zoomed area
                    ImageArray[i, j] = TempArray[i / 2 + 79, j / 2 + 59];
                    ImageArray[i + 1, j] = TempArray[i / 2 + 79, j / 2 + 59];
                    ImageArray[i, j + 1] = TempArray[i / 2 + 79, j / 2 + 59];
                    ImageArray[i + 1, j + 1] = TempArray[i / 2 + 79, j / 2 + 59];
                }
            }

            // create image and output
            SetBitmapFromArray();
            picImage.Image = bitmapImage;
        }
    }
}

