using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Collections;
using System.Media;
using System.Threading;

namespace VietHanITGaLa
{
    public partial class frmKhoidong : Form
    {
        int thoigian = 120;
        //public string Name="";
        string filename = "";
        StreamReader streamreader;
        frmMain frmmain=new frmMain();
        
        static SoundPlayer playClock = new SoundPlayer(@"sound\clock.wav");
        public frmKhoidong(frmMain fr,string fn)
        {
            InitializeComponent();
            frmmain=fr;
            filename = fn;
        }
        private string Pathsound = "";
        private void SoundPlayer()
        {
            SoundPlayer sound = new SoundPlayer(Pathsound);
            sound.Play();
        }
        
        private void picStart_Click(object sender, EventArgs e)
        {
            try
            {
                Pathsound = @"sound\start1.wav";
                Thread thread = new Thread(new ThreadStart(SoundPlayer));
                thread.Start();
            }
            catch { }

            thoigian = 120;
            picStart.Visible = false;
            lblDongho.Visible = true;
            timer1.Start();
            frmmain.SendtoClient("STARTKD| ",Name);
            try
            {
                streamreader = File.OpenText(filename);
            }
            catch { }

            try
            {
                playClock.PlayLooping();
            }
            catch { }

        }
        private  Thread threadPlayclock = new Thread(new ThreadStart(PlayClock));
        private static void PlayClock()
        {

            playClock.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (thoigian > 0)
            {
                thoigian = thoigian - 1;
                lblDongho.Text = thoigian.ToString();
            }
            else
            {
                lblDongho.Visible = false;
                lblNoidungcauhoi.Visible = false;
                lblDapan.Visible = false;
                frmHetgio frmhetgio = new frmHetgio();
                frmhetgio.Show();
                timer1.Stop();
                try
                {

                    playClock.Stop();
                }
                catch { }
                Pathsound = @"sound\hetgio.wav";
                SoundPlayer();
            }

        }

        private void frmKhoidong_Load(object sender, EventArgs e)
        {
            try
            {
                Process.Start("SlideGioithieu\\khoidong.pps");
            }
            catch { }
        }
        private void Chondoithi()
        {
            thoigian = 120;
            frmmain.Broadcast("KHOIDONG|" + thoigian.ToString());
            frmGoicauhoiKD frmgoicauhoi = new frmGoicauhoiKD();
            UserConnection client;

            foreach (DictionaryEntry entry in frmmain.clients)
            {
                client = (UserConnection)entry.Value;
                string dc=client.Name;
                frmgoicauhoi.cmbDoichoi.Items.Add(dc);

                frmgoicauhoi.cmbGoicauhoi.Items.Add("Đội: " + dc);
            }
            frmgoicauhoi.ShowDialog();
            try
            {
                Name = frmgoicauhoi.cmbDoichoi.SelectedItem.ToString();
                lblDoithi.Text = "ĐỘI: " + Name;
            
            switch (frmgoicauhoi.cmbGoicauhoi.SelectedIndex.ToString())
            {
                case "0":
                    filename = "cauhoi//khoidong1.txt";
                    break;
                case "1":
                    filename = "cauhoi//khoidong2.txt";
                    break;
                case "2":
                    filename = "cauhoi//khoidong3.txt";
                    break;
                case "3":
                    filename = "cauhoi//khoidong4.txt";
                    break;
                }
            }
            catch { }
            frmgoicauhoi.Dispose();
        }

        private void RightKeyPress(object sender, KeyEventArgs e)
        {
            
            if (thoigian > 0)
            {
                if (streamreader != null)
                {
                    if (e.KeyValue == 39)
                    {
                        lblNoidungcauhoi.Visible = true;
                        playClock.Stop();
                        playClock.PlayLooping();
                        lblNoidungcauhoi.Text = "";
                        string cauhoi = streamreader.ReadLine();
                        lblDapan.Text = streamreader.ReadLine();
                        lblDapan.Visible = false;
                        if (cauhoi != null)
                        {
                            lblNoidungcauhoi.Text = cauhoi + "\n";
                            string msg = cauhoi;
                            frmmain.SendtoClient("STARTKD|" + msg, Name);
                        }
                        else
                        {
                            lblNoidungcauhoi.Text = "";
                            frmmain.SendtoClient("STARTKD|FINISH", Name);
                        }
                    }
                }
                
            }
            else
            {
                streamreader.Close();
            }
            if (e.KeyValue == 68) //tra loi dung. Phím d
                {
                    Pathsound = @"sound\WinFirst.wav";
                    SoundPlayer();
                    lblDapan.Visible = true;
                }
            if (e.KeyValue == 83)//tra loi sai. Phím s
            {
                Pathsound = @"sound\false1.wav";
                SoundPlayer();
                lblDapan.Visible = true;
            }
            
            if (e.Control && (e.KeyValue == 49))
            {
                //lblDapan.Visible = true;
                Chondoithi();
                picStart.Visible = true;
            }
            //Dung trong t/h dung dong ho lai
            if (e.KeyValue == 27)
            {
                timer1.Stop();
                lblNoidungcauhoi.Text = "";
                lblDapan.Text = "";
                lblDapan.Visible = false;
                lblDongho.Text = "";
                playClock.Stop();
            }

        }

        private void frmKhoidong_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                playClock.Stop();
            }
            catch
            {
            }
            
        }
        
    }
}
