using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace CProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void openImage()
        {

            OpenFileDialog o = new OpenFileDialog();
            
            if (o.ShowDialog() == DialogResult.OK)
                file = Image.FromFile(o.FileName);
            pictureBox1.Image = file;
            opened = true;

            
        }
        

        

        Image file;
        Boolean opened = false;
        





        private void reload()
        {

            
            if (!opened)
            {
                
            }
            else
            {

                if (opened)
            {

                    pictureBox1.Image = file;
                    opened =true;
                
                }
        }
    }


        void hue()
        {
            float changered = barRed.Value * 0.1f;
            float changegreen = barGreen.Value * 0.1f;
            float changeblue = barBlue.Value * 0.1f;
            

            barRed.Text = changered.ToString();
            barGreen.Text = changegreen.ToString();
            barBlue.Text = changeblue.ToString();
           

            reload();
            if (!opened)
            {
            }
            else
            {



                Image img = pictureBox1.Image;                             
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   

                ImageAttributes ia = new ImageAttributes();                
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{1+changered, 0, 0, 0, 0},
            new float[]{0, 1+changegreen, 0, 0, 0},
            new float[]{0, 0, 1+changeblue, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);          
                Graphics g = Graphics.FromImage(bmpInverted);  

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


               


                g.Dispose();                           
                pictureBox1.Image = bmpInverted;


            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openImage();
        }


        private void saveImage()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image.Save(sfd.FileName);
            else
            {
                
            }


            
            
           

        }


        void grayscale()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes"); 
            }
            else
            {
                Image img = pictureBox1.Image;                             
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   

                ImageAttributes ia = new ImageAttributes();                
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                ia.SetColorMatrix(cmPicture);           
                Graphics g = Graphics.FromImage(bmpInverted);   

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


               


                g.Dispose();                           
                pictureBox1.Image = bmpInverted;
            }
        }

        void flash()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {




                Image img = pictureBox1.Image;                             
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   

                ImageAttributes ia = new ImageAttributes();                
                ColorMatrix cmPicture = new ColorMatrix(new float[][]      
                {
                    new float[]{1+0.9f, 0, 0, 0, 0},
            new float[]{0, 1+1.5f, 0, 0, 0},
            new float[]{0, 0, 1+1.3f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);          
                Graphics g = Graphics.FromImage(bmpInverted);   

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


               


                g.Dispose();                           
                pictureBox1.Image = bmpInverted;

            }

        }

        void Frozen()
        {

            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {


                Image img = pictureBox1.Image;                            
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   



                ImageAttributes ia = new ImageAttributes();                 
                ColorMatrix cmPicture = new ColorMatrix(new float[][]      
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
            new float[]{0, 1+0f, 0, 0, 0},
            new float[]{0, 0, 1+5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);          
                Graphics g = Graphics.FromImage(bmpInverted);   

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                


                g.Dispose();                           
                pictureBox1.Image = bmpInverted;

            }

        }

        void fog()
        {

            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {


                Image img = pictureBox1.Image;                            
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   

                ImageAttributes ia = new ImageAttributes();                 
                ColorMatrix cmPicture = new ColorMatrix(new float[][]      
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
            new float[]{0, 1+0.7f, 0, 0, 0},
            new float[]{0, 0, 1+1.3f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);          
                Graphics g = Graphics.FromImage(bmpInverted);   

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


               


                g.Dispose();                            
                pictureBox1.Image = bmpInverted;



            }
        }

        void redscale()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox1.Image;                            
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   


                ImageAttributes ia = new ImageAttributes();                 
                ColorMatrix cmPicture = new ColorMatrix(new float[][]      
                {
                    new float[]{.393f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);          
                Graphics g = Graphics.FromImage(bmpInverted);   

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


               


                g.Dispose();                            
                pictureBox1.Image = bmpInverted;

            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void btnDramatic_Click(object sender, EventArgs e)
        {
            reload();
            fog();
        }

        private void btnSepa_Click(object sender, EventArgs e)
        {
            reload();
            Frozen();
        }

        private void btnArtistic_Click(object sender, EventArgs e)
        {
            reload();
            redscale();
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            reload();
            grayscale();
        }

     

       


        private void barBlue_Scroll(object sender, EventArgs e)
        {
            hue();
        }

        private void barGreen_Scroll(object sender, EventArgs e)
        {
            hue();
        }


        private void barRed_Scroll(object sender, EventArgs e)
        {
            hue();
        }
    }
}
