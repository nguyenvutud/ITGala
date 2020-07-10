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
    public partial class frmVuotchuongngaivat : Form
    {
        public delegate void VisibleControlCallBack(bool status);
        public delegate void VisiblePanelResultCallBack(bool status);
        int thoigian = 30;
        public string Name = "";
        string filename = "cauhoi//Vuotchuongngaivat.txt";
        StreamReader streamreader;
        frmMain frmmain = new frmMain();
        private string Pathsound = "";
        private bool BellRang = false;
        private ArrayList ListCauhoi = new ArrayList();
        private int daudoc = -1;
        private ArrayList ListKQ = new ArrayList();
        private bool Hienthiketqua = false;
        static SoundPlayer playClock = new SoundPlayer(@"sound\clock.wav");
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
        private void VisiblePanelResult(bool status)
        {
            if (InvokeRequired)
            {
                object[] o = { status };
                panelResult.BeginInvoke(new VisiblePanelResultCallBack(VisiblePanel), o);
            }
            else
            {
                VisiblePanel(status);
            }
        }
        private void VisiblePanel(bool status)
        {
            panelResult.Visible = status;
        }
        public frmVuotchuongngaivat(frmMain fr)
        {
            frmmain = fr;
            InitializeComponent();
        }
        public void UpdateListKQ(string kq, UserConnection sender)
        {
            int n = (30 - thoigian);
            Doichoi dc = new Doichoi(sender.Name, kq, n);
            ListKQ.Add(dc);
        }
        private void KhoitaoKQ()
        {
            btnA.Text = "";
            lblGroup1.Text = "";
            lblThoigianDoi1.Text = "";
            btnB.Text = "";
            lblGroup2.Text = "";
            lblThoigianDoi2.Text = "";
            btnC.Text = "";
            lblGroup3.Text = "";
            lblThoigianDoi3.Text = "";
            btnD.Text = "";
            lblGroup4.Text = "";
            lblThoigianDoi4.Text = "";
        }
        private void HienthiKQ()
        {
            KhoitaoKQ();
            Doichoi dc;
            int dem = 0;
            if (dem < ListKQ.Count)
            {
                dc = (Doichoi)ListKQ[0];
                btnA.Text = dc.Dapan.ToUpper();
                lblGroup1.Text = dc.Name;
                //lblThoigianDoi1.Text = dc.Giay.ToString() + " giây";

                dem++;
            }

            if (dem < ListKQ.Count)
            {
                dc = (Doichoi)ListKQ[1];
                btnB.Text = dc.Dapan.ToUpper();
                lblGroup2.Text = dc.Name;
                //lblThoigianDoi2.Text = dc.Giay.ToString() + " giây";
                dem++;
            }


            if (dem < ListKQ.Count)
            {
                dc = (Doichoi)ListKQ[2];
                btnC.Text = dc.Dapan.ToUpper();
                lblGroup3.Text = dc.Name;
                //lblThoigianDoi3.Text = dc.Giay.ToString() + " giây";
                dem++;
            }

            if (dem < ListKQ.Count)
            {
                dc = (Doichoi)ListKQ[3];
                btnD.Text = dc.Dapan.ToUpper();
                lblGroup4.Text = dc.Name;
                //lblThoigianDoi4.Text = dc.Giay.ToString() + " giây";
                dem++;
            }
            //for(int i=0;i<ListKQ.Count;i++)
            //    ListKQ.RemoveAt(i);
            ListKQ.Clear();
            Hienthiketqua = true;
        }

        private Thread threadPlayclock = new Thread(new ThreadStart(PlayClock));
        private static void PlayClock()
        {
            try
            {

                playClock.PlayLooping();
            }catch
            {}
        }

        private void SoundPlayer()
        {
            SoundPlayer sound = new SoundPlayer(Pathsound);
            try
            {
                sound.Play();
            }
            catch { }
        }
        private void Choncauhoi()
        {
            if (daudoc < ListCauhoi.Count)
                {
                    ListKQ.Clear();
                panelResult.Visible = false;
                VisibleControl(false);
                lblNoidungcauhoi.Visible = true;
                lblNoidungcauhoi.Text = "";
                lblName.Text = "";
                BellRang = false;

                
                    thoigian = 30;
                    lblDongho.Visible = true;
                    timer1.Start();
                    try
                    {
                        playClock.PlayLooping();
                    }
                    catch { }

                    string cauhoi = ListCauhoi[daudoc].ToString();
                    lblNoidungcauhoi.Text = cauhoi;
                    string msg = cauhoi;
                    frmmain.Broadcast("STARTVCNV|" + msg);
                }
        }
        private void RightKeyPress(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 68) //tra loi dung. Phím d
            {
            }
            if (e.KeyValue == 83)//tra loi sai. Phím s
            {
                BellRang = false;
                lblName.Text = "";
                frmmain.SendToClients("RESET|", Name);

            }
            if (e.Control && (e.KeyValue == 13))
            {
                Pathsound = @"sound\true1.wav";
                Thread thread = new Thread(new ThreadStart(SoundPlayer));
                try
                {
                    thread.Start();
                }
                catch { }

                if (picBell.Visible)
                {
                    picBell.Visible = false;
                    lblName.Text = "";
                }
                panelResult.Visible = true;
                lblNoidungcauhoi.Visible = false;
                HienthiKQ();
            }
            switch (e.KeyValue)
            {
                case 48:
                    daudoc = 0;
                    Choncauhoi();
                    break;
                case 49://phim so 1
                    daudoc = 1;
                    Choncauhoi();
                    break;
                case 50://phim so 2
                    daudoc = 2;
                    Choncauhoi();
                    break;
                case 51://phim so 3
                    daudoc = 3;
                    Choncauhoi();
                    break;
                case 52://phim so 4
                    daudoc = 4;
                    Choncauhoi();
                    break;
                case 53://phim so 5
                    daudoc = 5;
                    Choncauhoi();
                    break;
                case 54://phim so 6
                    daudoc = 6;
                    Choncauhoi();
                    break;
                case 55://phim so 7
                    daudoc = 7;
                    Choncauhoi();
                    break;
                case 56://phim so 8
                    daudoc = 8;
                    Choncauhoi();
                    break;
                case 57://phim so 9
                    daudoc = 9;
                    Choncauhoi();
                    break;
            }
            if (e.KeyValue == 27)
            {
                lblDongho.Text = "";
                lblNoidungcauhoi.Text = "";
                playClock.Stop();
                timer1.Stop();
                panelResult.Visible = false;
            }
            if (e.KeyValue == 68) //tra loi dung. Phím d
            {
                Pathsound = @"sound\false1.wav";
                SoundPlayer();
            }
            if (e.KeyValue == 83)//tra loi sai. Phím s
            {
                Pathsound = @"sound\false1.wav";
                SoundPlayer();
            }

        }
        public void XulyChuong(UserConnection sender)
        {

            VisiblePanelResult(false);
            VisibleControl(true);
                //BellRang = true;
                lblName.Text = sender.Name;
                Name = sender.Name;
                Pathsound = @"sound\bellring.wav";
                try
                {
                    Thread threadsound = new Thread(new ThreadStart(SoundPlayer));
                    threadsound.Start();

                }catch{}
                this.Focus();
        }

        private void picBell_Click(object sender, EventArgs e)
        {

        }

        private void picStart_Click(object sender, EventArgs e)
        {
            picStart.Visible = false;
            //lblDongho.Visible = true;
            timer1.Start();
            try
            {
                streamreader = File.OpenText(filename);
            }
            catch {
                MessageBox.Show("Lỗi mở file!");
            }
            string s;
            do
            {
                string cauhoi = "";
                s = streamreader.ReadLine();
                while ((s != "*") && (s != null))
                {
                    cauhoi += s + "\n";
                    s = streamreader.ReadLine();
                }
                if (cauhoi != "")
                {
                    ListCauhoi.Add(cauhoi);
                }
            } while (s != null);
            streamreader.Close();
            daudoc = 0;
            Pathsound = @"sound\start1.wav";
            try
            {
                Thread thread = new Thread(new ThreadStart(SoundPlayer));
                thread.Start();
            }
            catch
            {
            }
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
                timer1.Stop();
                lblDongho.Text = "";
                try
                {
                    threadPlayclock.Abort();
                    playClock.Stop();
                }
                catch { }
                Pathsound = @"sound\hetgio.wav";
                Thread thread = new Thread(new ThreadStart(SoundPlayer));
                try
                {
                    thread.Start();
                }
                catch { }
            }
        }

        private void frmVuotchuongngaivat_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                threadPlayclock.Abort();
                playClock.Stop();
                
            }
            catch { }
        }

        private void frmVuotchuongngaivat_Load(object sender, EventArgs e)
        {
            try
            {
                Process.Start("SlideGioithieu\\vuotchuongngaivat.pps");
            }
            catch { }
        }

    }
}
