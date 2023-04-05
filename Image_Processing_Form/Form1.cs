using System.Text.RegularExpressions;

namespace Image_Processing_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        public Bitmap originalPic = null;
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK 
                && Regex.IsMatch(ofd.FileName, @"\.(jpg|jpeg|png|gif|bmp)$", RegexOptions.IgnoreCase)) // checks if the dialogresult is ok and the given file is picture and ignoring case
            {
                originalPic = new Bitmap(ofd.FileName);
                pb_original.Image = Resize(originalPic,pb_original.Width,pb_original.Height);//resizes the img to the pb_box size
            }
        }

        /// <summary>
        /// Resizes the Given Bitmap(picture) to the given size
        /// </summary>
        /// <param name="pic"></param>
        /// <param name="nwidth"></param>
        /// <param name="nheight"></param>
        /// <returns>with the resized picture</returns>
        private static Bitmap Resize(Bitmap pic, int nwidth, int nheight)
        {
            var bmap = new Bitmap(pic, nwidth, nheight);

            double nWidthFactor = (double)pic.Width / (double)nwidth;
            double nHeigthFactor = (double)pic.Height / (double)nheight;

            double fx, fy, nx, ny;
            int cx, cy, fr_x, fr_y;

            Color color1 = new Color();
            Color color2 = new Color();
            Color color3 = new Color();
            Color color4 = new Color();

            byte nRed, nBlue, nGreen;

            byte bp1, bp2;

            for (int x = 0; x < bmap.Width; ++x)
            {
                for (int y = 0; y < bmap.Height; ++y)
                {
                    fr_x = (int)Math.Floor(x * nWidthFactor);
                    fr_y = (int)Math.Floor(y * nHeigthFactor);

                    cx = fr_x + 1;
                    if (cx >= pic.Width) cx = fr_x;
                    cy = fr_y + 1;
                    if (cy >= pic.Height) cy = fr_y;
                    fx = x * nWidthFactor - fr_x;
                    fy = y * nHeigthFactor - fr_y;
                    nx = 1.0 - fx;
                    ny = 1.0 - fy;

                    color1 = pic.GetPixel(fr_x, fr_y);
                    color2 = pic.GetPixel(cx, fr_y);
                    color3 = pic.GetPixel(fr_x, cy);
                    color4 = pic.GetPixel(cx, cy);

                    // Blue
                    bp1 = (byte)(nx * color1.B + fx * color2.B);

                    bp2 = (byte)(nx * color3.B + fx * color4.B);

                    nBlue = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                    // Green
                    bp1 = (byte)(nx * color1.G + fx * color2.G);

                    bp2 = (byte)(nx * color3.G + fx * color4.G);

                    nGreen = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                    // Red
                    bp1 = (byte)(nx * color1.R + fx * color2.R);

                    bp2 = (byte)(nx * color3.R + fx * color4.R);

                    nRed = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                    bmap.SetPixel(x, y, System.Drawing.Color.FromArgb
                    (255, nRed, nGreen, nBlue));

                }
            }
            pic = (Bitmap)bmap.Clone();
            return pic;
        }

        private void btn_Gray_Click(object sender, EventArgs e)
        {
            if (originalPic != null)
            {
                var pic = Resize(originalPic, pb_processed.Width, pb_processed.Height);
                pic = SetGrayscale(pic);
                pb_processed.Image = pic;
            }
            else
            {
                MessageBox.Show("There is no image to generate the GrayScale of", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //FunnE messagebox rage could be made here
                //bool exit = true;
                //do
                //{
                //    int count = 0;
                //    switch (count)
                //    {
                //        case 0:
                //            MessageBox.Show("There is no image to generate the GrayScale of", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //            break;
                //        default:
                //            break;
                //    }
                //} while (!exit);
            }
        }
        /// <summary>
        /// Generates the given picture grayscale
        /// </summary>
        /// <param name="pic"></param>
        /// <returns>GrayScaled image</returns>
        public Bitmap SetGrayscale(Bitmap pic)
        {
            Bitmap bmap = (Bitmap)pic.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);

                    bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            return (Bitmap)bmap.Clone();
        }
    }
}