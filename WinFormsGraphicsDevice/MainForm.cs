#region File Description
//-----------------------------------------------------------------------------
// MainForm.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System.Windows.Forms;
#endregion

namespace WinFormsGraphicsDevice
{
    using Microsoft.Xna.Framework.Graphics;
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Runtime.InteropServices;
    // System.Drawing and the XNA Framework both define Color types.
    // To avoid conflicts, we define shortcut names for them both.
    using GdiColor = System.Drawing.Color;
    using XnaColor = Microsoft.Xna.Framework.Color;


    /// <summary>
    /// Custom form provides the main user interface for the program.
    /// In this sample we used the designer to add a splitter pane to the form,
    /// which contains a SpriteFontControl and a SpinningTriangleControl.
    /// </summary>
    public partial class MainForm : Form
    {
  
        public MainForm()
        {
            InitializeComponent();
          //  this.mapEditControl2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.mapEditControl2_MouseClick);

        }
        const int WM_MOUSEWHEEL = 0x020A;
        static public int wheel_value = 0;
        static public bool isStopped = true;
        static public int lastMouseScroll = 0;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // This will completely ignore the mouse wheel, which will disable zooming as well
            wheel_value = 0;
            if (m.Msg == WM_MOUSEWHEEL)
            {
                if ((int)m.WParam >= 0)
                {
                    wheel_value = 1;
                    isStopped = false;
                    lastMouseScroll = 0;
                }
                else
                {
                    isStopped = false;
                    wheel_value = -1;
                    lastMouseScroll = 0;
                }
            }
            base.WndProc(ref m);
        }
        private void mapEditControl2_MouseClick(object sender, MouseEventArgs e)
        {
            MapEditControl.scale += (float)e.Delta / 400f;

            System.Diagnostics.Debug.WriteLine("blah:" + e.Delta);
        }

        public static byte[] ConvertFileToByteArray(string fileName)
        {

            byte[] returnValue = null;



            using (FileStream fr = new FileStream(fileName, FileMode.Open))
            {

                using (BinaryReader br = new BinaryReader(fr))
                {

                    returnValue = br.ReadBytes((int)fr.Length);

                }

            }



            return returnValue;



        }
        public static Bitmap byteArrayToImage(byte[] byteArrayIn)
        {
            ImageConverter ic = new ImageConverter();
            Image img = (Image)ic.ConvertFrom(byteArrayIn);
            return new Bitmap(img);
            /* if (byteArrayIn == null)
                 return null;
             using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn))
             {
                 System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
                 ms.Flush();
                 return returnImage;
             }

         */
        }
        
        private string SelectTextFile(string initialDirectory,string file_format)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =file_format+
               "  files (*." + file_format + ")|*." + file_format + "|All files (*.*)|*.*";
            dialog.InitialDirectory = initialDirectory;
            dialog.Title = "Select a text file";
            return (dialog.ShowDialog() == DialogResult.OK)
               ? dialog.FileName : null;
        }
        public byte[] CHR_BUFFER = null;
        private void cHRAsTileSetToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (imageList1.Images.Count > 0)
            {
                if (MessageBox.Show("Importing new tileset will erase all metatile groups.\n Do you really want to do this?", "Caution", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                { 
                        imageList1.Images.Clear();
                        listView1.Items.Clear();
                    filteredPictureBox1 .Image = null;
                        total_image_idx = 0; 
                }
                else return;
            }
            string file_path = SelectTextFile("\\","CHR");
            if (file_path != null)
            {
                CHR_BUFFER = ConvertFileToByteArray(file_path);
                this.chrViewControl1.bytetotex(CHR_BUFFER);


            }
        }

        private void spinningTriangleControl_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }
       
        int total_image_idx = 0;
        static Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.White);
            grPhoto.InterpolationMode =
                    InterpolationMode.NearestNeighbor;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }
        public Bitmap GrayScale(Bitmap Bmp)
        {
            int rgb;
            Color c;

            for (int y = 0; y < Bmp.Height; y++)
                for (int x = 0; x < Bmp.Width; x++)
                {
                    c = Bmp.GetPixel(x, y);
                    rgb = (int)((c.R + c.G + c.B) / 3);
                    Bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            return Bmp;
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            imageList1.Images.Add(FixedSize(filteredPictureBox1.Image, 32, 32));
            ListViewItem item = new ListViewItem();
            item.ImageIndex = total_image_idx;
            this.listView1.Items.Add(item);
            total_image_idx++;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                int idx = listView1.SelectedItems[0].ImageIndex;
                imageList1.Images.RemoveAt(idx);
                listView1.Items.RemoveAt(idx);
                for (int i = idx+1; i < listView1.Items.Count; i++)
                {
                    listView1.Items[i].ImageIndex--;
                }
                total_image_idx--;
            }
        }

        private void paletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string file_path = SelectTextFile("\\", "PAL");
            if (file_path != null)
            {
                byte[,] pal = new byte[4, 4];
                byte[] buf = ConvertFileToByteArray(file_path);
                for (int i = 0; i < 16; i++)
                {
                    pal[(int)i/4,i%4] = buf[i];
                }
                paletteControl1.bgPal = pal;


            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setMapSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapSize m = new MapSize();
            m.StartPosition = FormStartPosition.Manual;
            m.Location = new Point(this.Location.X + 10, this.Location.Y + 10);
            m.ShowDialog();
        }

        private void mapEditControl2_Click(object sender, EventArgs e)
        {

        }

        private void mapEditControl2_MouseDown(object sender, MouseEventArgs e)
        {
        
        }

        private void filteredPictureBox1_Click(object sender, EventArgs e)
        {

        }



    }
}
