using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Media;
using System.Threading;
using System.Collections;

namespace VietHanITGaLa
{
    public partial class frmFinally : Form
    {
        public delegate void VisibleControlCallBack(bool status);
        int thoigian = 60;
        //public string Name = "";
        string filename = "cauhoi//Vedich.txt";
        StreamReader streamreader;
        frmMain frmmain = new frmMain();
        private string Pathsound = "";
        private bool BellRang=false;
        private ArrayList ListCauhoi = new ArrayList();
        private int daudoc = -1;
        private void VisibleControl(bool status)
        {
            if (InvokeRequired)
            {
                object[] o = { status };
                picBell.BeginInvoke(new VisibleControlCallBack(VisiblePicBell), o);
            }
            else
            {
                VisiblePicBell(status);
            }
        }
        private void VisiblePicBell(bool status)
        {
            picBell.Visible = status;
        }
        public frmFinally(frmMain fr)
        {
            frmmain = fr;
            InitializeComponent();
        }
       
        private void SoundPlayer()
        {
            SoundPlayer sound = new SoundPlayer(Pathsound);
            sound.Play();
        }

        private void RightKeyPress(object sender, KeyEventArgs e)
        {
            
                if (e.KeyValue == 39)
                {
                    //VisibleControl(false);
                    picBell.Visible = false;
                    lblNoidungcauhoi.Text = "";
                    lblName.Text = "";
                    Name = "";
                    labelR.Text = e.KeyValue.ToString();
                    BellRang = false;
                    if (daudoc < ListCauhoi.Count)
                    {
                        string cauhoi = ListCauhoi[daudoc].ToString();
                        lblNoidungcauhoi.Text=cauhoi;
                        string msg = cauhoi;
                        frmmain.Broadcast("STARTVD|" + msg);
                        daudoc++;
                    }
                    else
                    {
                        lblNoidungcauhoi.Text = "";
                        frmmain.Broadcast("STARTVD|FINISH");
                    }

                }
                if (e.KeyValue == 37)
                {
                    //VisibleControl(false);
                    picBell.Visible = false;
                    lblNoidungcauhoi.Text = "";
                    Name = "";
                    if (daudoc >0)
                    {
                        lblName.Text = "";
                        BellRang = false;
                        daudoc--;
                        string cauhoi = ListCauhoi[daudoc].ToString();
                        lblNoidungcauhoi.Text = cauhoi;
                        string msg = cauhoi;
                        frmmain.Broadcast("STARTVD|" + msg);

                    }
                    else
                    {
                        lblNoidungcauhoi.Text = "";
                        frmmain.Broadcast("STARTVD|FINISH");
                    }

                }
                
                if (e.KeyValue == 82) //reset: phím r
                {
                    labelR.Text = e.KeyValue.ToString();
                    BellRang = false;
                    lblName.Text = "";
                    picBell.Visible = false;
                    frmmain.SendToClients("RESET|", Name);
                }
                if (e.KeyValue == 68) //tra loi dung. Phím d
                {
                    labelR.Text = e.KeyValue.ToString();
                    Pathsound = @"sound\WinFirst.wav";
                    Thread threadsound = new Thread(new ThreadStart(SoundPlayer));
                    threadsound.Start();
                }
                if (e.KeyValue == 83)//tra loi sai. Phím s
                {
                    labelR.Text = e.KeyValue.ToString();
                    Pathsound = @"sound\false1.wav";
                    Thread threadsound = new Thread(new ThreadStart(SoundPlayer));
                    threadsound.Start();
                    
                }
        }
        public void XulyChuong(UserConnection sender)
        {

            if (!BellRang)
            {
                VisibleControl(true);
                //picBell.BackgroundImage = Image.FromFile("chuong1.png");
                BellRang = true;
                lblName.Text = sender.Name;
                Name = sender.Name;
                Pathsound = @"sound\bellring.wav";
                Thread threadsound = new Thread(new ThreadStart(SoundPlayer));
                threadsound.Start();

            }
        }

        private void picBell_Click(object sender, EventArgs e)
        {

        }

        private void picStart_Click(object sender, EventArgs e)
        {
            picStart.Visible = false;
            //lblDongho.Visible = true;
            timer1.Start();
            //frmmain.Broadcast("STARTVD|");
            streamreader = File.OpenText(filename);
            string s;
            do
            {
                string cauhoi = "";
                s = streamreader.ReadLine();
                while ((s != "*") && (s !=null))
                {
                    cauhoi += s + "\n";
                    s = streamreader.ReadLine();
                }
                if (cauhoi != "")
                {
                    ListCauhoi.Add(cauhoi);
                }
            }while(s !=null);
            streamreader.Close();
            daudoc = 0;
            Pathsound = @"sound\start1.wav";
            Thread thread = new Thread(new ThreadStart(SoundPlayer));
            thread.Start();
        }

        private void frmFinally_Load(object sender, EventArgs e)
        {
            try
            {
                Process.Start("SlideGioithieu\\vedich.pps");
            }
            catch { }
        }
            
    }
}
