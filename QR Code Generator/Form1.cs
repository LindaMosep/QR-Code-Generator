using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace QR_Code_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            encoder.QRCodeScale = 20;
            var bm = encoder.Encode(textBox1.Text);
            pictureBox1.Image = bm;
            QRCodeDecoder decoder = new QRCodeDecoder();
   

            if(textBox2.Text.Length > 0)
            {
               
                if(!File.Exists(@"C:\Users\username\Desktop\QRCODES\" + textBox2.Text + ".png"))
                {
                    bm.Save(@"C:\Users\username\Desktop\QRCODES\" + textBox2.Text + ".png");
                }
                else
                {
                         int i = 0;
                        while (File.Exists(@"C:\Users\username\Desktop\QRCODES\" + textBox2.Text + "(" + i.ToString()+ ")" + ".png"))
                        {
                            i++;
                        }

                    bm.Save(@"C:\Users\username\Desktop\QRCODES\" + textBox2.Text + "(" + i.ToString()+ ")" + ".png");
                }
              
            }
           


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
