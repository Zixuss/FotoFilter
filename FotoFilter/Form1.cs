using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoFilter
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OpenIMG.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(OpenIMG.FileName);
                PicBox.Image = bitmap;
            }
        }
        private void RGGBBR()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color bitmapRGB = bitmap.GetPixel(x, y);

                    //ändra bild
                    Color modified = Color.FromArgb(bitmapRGB.G, bitmapRGB.B, bitmapRGB.R);


                    bitmap.SetPixel(x, y, modified);
                }

            }
            PicBox.Image = bitmap;
        }

        private void rGGBBRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RGGBBR();
        }

        private void Gray()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color bitmapRGB = bitmap.GetPixel(x, y);

                    //ändra bild
                    int z = (bitmapRGB.R + bitmapRGB.G + bitmapRGB.B) / 3;

                    Color modified = Color.FromArgb(z, z, z);
                    bitmap.SetPixel(x, y, modified);
                }

            }
            PicBox.Image = bitmap;
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gray();
        }

        private void Green()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color bitmapRGB = bitmap.GetPixel(x, y);

                    //ändra bild
                    int z = 0;

                    Color modified = Color.FromArgb(z, bitmapRGB.G, z);
                    bitmap.SetPixel(x, y, modified);
                }

            }
            PicBox.Image = bitmap;
        }

        private void Red()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color bitmapRGB = bitmap.GetPixel(x, y);

                    //ändra bild
                    int z = 0;

                    Color modified = Color.FromArgb(bitmapRGB.R, z, z);
                    bitmap.SetPixel(x, y, modified);
                }
        



            }
            PicBox.Image = bitmap;
        }
        
        private void Blue()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color bitmapRGB = bitmap.GetPixel(x, y);

                    //ändra bild
                    int z = 0;

                    Color modified = Color.FromArgb(z, z, bitmapRGB.B);
                    bitmap.SetPixel(x, y, modified);
                }

            }
            PicBox.Image = bitmap;
        }

        private void redToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Red();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Green();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blue();
        }

        private void Invert()
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color bitmapRGB = bitmap.GetPixel(x, y);

                    //ändra bild
                    int z = 255;

                    Color modified = Color.FromArgb(z - bitmapRGB.R, z - bitmapRGB.G, z - bitmapRGB.B);
                    bitmap.SetPixel(x, y, modified);
                }

            }
            PicBox.Image = bitmap;
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invert();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void öppnaBildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenIMG.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(OpenIMG.FileName);
                PicBox.Image = bitmap;
            }
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.png";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.PicBox.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.PicBox.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.PicBox.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
        }
        
        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UndoAll()
        {
            bitmap = new Bitmap(OpenIMG.FileName);
            PicBox.Image = bitmap;
        }

        private void undoAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoAll();
        }
    }
}

