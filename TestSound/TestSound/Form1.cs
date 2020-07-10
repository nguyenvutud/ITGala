using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace TestSound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"D:\Viet Han\IT GaLA\ChuongTrinh\ITGala_Server\VietHanITGala\bin\Debug\sound\clock.wav");
            sound.PlayLooping();
            string s = "Nguyen Van A";
            string s1 = "Nguyen Van A";
            object st=s.Clone();
            int a=s.CompareTo(s1);
           
            MessageBox.Show(a.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"c:\ChuongRung.swf";
            axShockwaveFlash1.LoadMovie(0, path);
            label1.Text = this.Width.ToString() + "  " + this.Height.ToString();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //label1.Text = e.X.ToString() + ";" + e.Y.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyValue.ToString() + ";" + e.KeyValue.ToString();
        }
    }
}
