using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stegonograpy.Classes;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Stegonograpy
{
    public partial class Form1 : Form
    {
        Image image;
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "BMP Files (*.bmp)|*.bmp";
        }
        #region Top Panel Draging
        private Point startPoint = new Point(0, 0);
        private bool draging = false;
        

        

        private void B_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void B_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            draging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            draging = false;
        }

        private void Top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (draging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        #endregion
        private void B_OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                image = new Bitmap(openFileDialog1.FileName);
                uint msgSize = BitmapEncoder.calculateLargestMessageSize(image);

                LabelMaxSize.Text = "Largest message size: " + msgSize.ToString() + " B";
                RichTextBox.Text = "";
                StatusLabel.Text = "File opened " + openFileDialog1.FileName;

                B_decode.Enabled = true;
                B_Encode.Enabled = true;
                B_Save.Enabled = true;
            }          
        }



        private void B_Encode_Click(object sender, EventArgs e)
        {
            if (BitmapEncoder.isMessageToLarge(image, RichTextBox.Text)) {
                StatusLabel.Text = "Message is too large!";
                return;
            }
            else
            {
                BitmapEncoder.encodeMessage(ref image, RichTextBox.Text);
                StatusLabel.Text = "Message encoded successfully!";              
            }                
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(saveFileDialog1.FileName))
                {
                    string saveTo = saveFileDialog1.FileName;
                    saveTo = saveTo.Remove(saveTo.Length - 4);
                    saveTo += "_copy.bmp";
                    image.Save(saveTo);
                }
                else
                {
                    image.Save(saveFileDialog1.FileName);
                }
                StatusLabel.Text = "File saved as "+saveFileDialog1.FileName;
            }
        }

        private void B_decode_Click(object sender, EventArgs e)
        {
            try
            {

                string msg = BitmapDecoder.decodeMessage(image);
                uint msglenght = BitmapDecoder.decodeMessageLenght(image);
                RichTextBox.Text = msg;
                LabelSize.Text = "Current size: " + msglenght.ToString() + " B";
            }
            catch
            {
                StatusLabel.Text = "No message is encoded!";
            }
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            LabelSize.Text = "Current size: " + RichTextBox.Text.Length.ToString() +" B";
        }

    }
}

