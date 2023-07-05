using System.Diagnostics;
using System.Text.RegularExpressions;
using static Image_Processing_Form.Error_Window;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Image_Processing_Form
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();


        }
        public Bitmap originalPic = null;
        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK
                && Ispicture(ofd.FileName)) // checks if the dialogresult is ok and the given file is picture and ignoring case
            {
                originalPic = new Bitmap(ofd.FileName);
                pb_original.Image = Resize(originalPic, pb_original.Width, pb_original.Height);//resizes the img to the pb_box size
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

        private void btn_ScanFolder_Click(object sender, EventArgs e)
        {
            try
            {
                using (var folder = new FolderBrowserDialog())
                {
                    //checks if selected folder dialog result is okay and the path is not null or whitespace
                    if (DialogResult.OK == folder.ShowDialog() && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                    {
                        string[] pirturefiles = Directory.GetFiles(folder.SelectedPath, "*.*", SearchOption.TopDirectoryOnly).Where(file => Ispicture(file)).ToArray();

                        foreach (string pictureFile in pirturefiles)
                        {
                            // Perform the desired operations with the picture file
                            // For example, you can copy or move the file to another location
                            // or store the file path in a data structure for further processing.
                        }
                        ShowCustomDialog("Scanning was succesfull.", MessageType.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                ShowCustomDialog($"There was an error:{ex.Message}", MessageType.Error);
            }


        }

        //checks if the given file is picture or not.
        private bool Ispicture(string file)
        {
            string extension = Path.GetExtension(file).ToLower();
            string[] supportedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" }; // Add more supported extensions if needed

            return supportedExtensions.Contains(extension);
        }
        private void ShowCustomDialog(string message, MessageType type)
        {
            using (var customDialog = new Error_Window())
            {
                customDialog.message = message;
                customDialog.DialogMessageType = type;
                DialogResult result = customDialog.ShowDialog();

                // Handle the dialog result
                if (result == DialogResult.OK)
                {
                    customDialog.Close();
                }
            }
        }
        //resize warning form/warning for resizes thing
        private void btn_resize_Click(object sender, EventArgs e)
        {
            if (originalPic != null)
            {
                string selected = ShowResizeDialog();
                if (selected != null)
                {
                    int width = int.Parse(selected.Substring(0, 4).Trim());
                    int height = int.Parse(selected.Substring(6).Trim());

                    var pic = Resize(originalPic, width, height);
                    pb_processed.Image = pic;
                }
            }
        }
        private string ShowResizeDialog()
        {
            Form prompt = new Form() //creates a new form window to select te new size of the picture.
            {
                Width = 250,
                Height = 150,
                FormBorderStyle = FormBorderStyle.SizableToolWindow,
                Text = "Resize Picture",
                StartPosition = FormStartPosition.CenterScreen,
                MinimumSize = new Size(250, 150),
                MaximumSize = new Size(250, 150)
            };

            //creates a label and a dropdown menu on the from.
            Label lblWidth = new Label() { Left = 15, Top = 20, Text = "Width:" };
            ComboBox comboBox = new ComboBox() { Left = 80, Top = 20, Width = 120 };

            //selectable sizes
            string[] t = { "320 x 240", "640 x 480", "800 x 600", "1024 x 768", "1280 x 720", "1366 x 768", "1600 x 900", "1920 x 1080", "2560 x 1440", "3840 x 2160" };

            //fils the dropdown menu
            foreach (string item in t)
            {
                comboBox.Items.Add(item);
            }

            //creates 2 button on the form
            Button btnOK = new Button() { Text = "OK", Left = 20, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            Button btnCancel = new Button() { Text = "Cancel", Left = 130, Width = 100, Top = 80, DialogResult = DialogResult.Cancel };

            //set the OK button click event to close the form
            btnOK.Click += (sender, e) => { prompt.Close(); };
            

            //puts everything on the form
            prompt.Controls.Add(lblWidth);
            prompt.Controls.Add(comboBox);
            prompt.Controls.Add(btnOK);
            prompt.Controls.Add(btnCancel);

            //the combobox was coverd by the label so this way will not be covered.
            prompt.Controls.SetChildIndex(comboBox, 0);
            prompt.Controls.SetChildIndex(lblWidth, 1);

            DialogResult dialogResult = prompt.ShowDialog();

            //if the form was closed with okbutton then calls the resize method.
            if (dialogResult == DialogResult.OK && comboBox.SelectedItem!= null)
                return comboBox.SelectedItem.ToString();
            else
                return null;
        }
    }
}