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
    public partial class frmTangtoc : Form
    {
        public delegate void VisibleControlCallBack(bool status);
        int thoigian = 30;
        
        //public string Name = "";
        string filename = "cauhoi//tangtoc.txt";
        StreamReader streamreader;
        private int goicauhoi = 0;
        frmMain frmmain = new frmMain();
        private string Pathsound = "";
        private bool BellRang = false;
        private ArrayList ListKQ = new ArrayList();
        private bool Hienthiketqua = false;

        static SoundPlayer playClock = new SoundPlayer(@"sound\clock.wav");
        public frmTangtoc(frmMain fr)
        {
            frmmain = fr;
            InitializeComponent();
        }
        private void UpdateControls()
        {
            Pathsound = @"sound\ReadyGo.wav";
            try
            {
                Thread thread = new Thread(new ThreadStart(SoundPlayer));
                thread.Start();
                Thread.Sleep(5000);
            }
            catch { }
            
        }

        public void UpdateListKQ(string kq, UserConnection sender)
        {
            int n = (30 - thoigian);
            Doichoi dc = new Doichoi(sender.Name, kq,n);
            ListKQ.Add(dc);
        }
        private void SoundPlayer()
        {
            try
            {
                SoundPlayer sound = new SoundPlayer(Pathsound);
                sound.Play();
            }
            catch { }
            
        }
        private Thread threadPlayclock = new Thread(new ThreadStart(PlayClock));
        private static void PlayClock()
        {
            try
            {
                playClock.PlayLooping();
            }
            catch { }
        }
        private void RightKeyPress(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 39)
            {
                if (!Hienthiketqua)
                {
                    Hienthiketqua = true;
                    HienthiKQ();
                }
                else
                {
                    
                    lblNoidungcauhoi.Visible = true;
                    panelResult.Visible = false;
                    Hienthiketqua = false;
                    lblNoidungcauhoi.Text = "";
                    lblName.Text = "";
                    string cauhoi = streamreader.ReadLine();
                    string dapan = streamreader.ReadLine();
                    //string da1 = streamreader.ReadLine();
                    //string da2 = streamreader.ReadLine();
                    //string da3 = streamreader.ReadLine();
                    if (cauhoi != null)
                    {
                        lblDongho.Visible = true;
                        thoigian = 30;
                        timer1.Start();
                        try
                        {
                            playClock.PlayLooping();
                        }
                        catch { }
                        lblNoidungcauhoi.Text += cauhoi + "\n";
                        lblDapan.Text = dapan;
                        string msg = lblNoidungcauhoi.Text;
                        frmmain.Broadcast("STARTTT|" + msg);
                    }
                    else
                    {
                        lblNoidungcauhoi.Text = "";
                        frmmain.Broadcast("STARTTT|" + "FINISH");
                        lblDongho.Visible = false;
                        try
                        {
                            streamreader.Close();
                        }catch{}
                        
                        
                    }

                }
            }
            if (e.Control && (e.KeyValue == 13))
            {
                Pathsound = @"sound\true1.wav";
                try
                {
                    Thread thread = new Thread(new ThreadStart(SoundPlayer));
                    thread.Start();
                }catch{}

                lblDongho.Visible = false;
                panelResult.Visible = true;
                lblNoidungcauhoi.Visible = false;
                HienthiKQ();
            }
            //if()
            //{

            //}
        }
        
        private void picStart_Click(object sender, EventArgs e)
        {
            filename = @"cauhoi\tangtoc.txt";
            //try
            //{
            //    streamreader = File.OpenText(filename);
            //}catch{
            //    MessageBox.Show("Lỗi đọc file");
            //}
            Hienthiketqua = false;
            //lblNoidungcauhoi.Visible = true;
            picStart.Visible = false;
            //lblDongho.Visible = true;
            //timer1.Start();
            this.Focus();
            frmmain.Broadcast("STARTTT| ");
            try
            {
                streamreader = File.OpenText(filename);
            }
            catch (IOException io)
            {
                MessageBox.Show("Loi moi file:" + io.ToString());
            }
            Pathsound = @"sound\start1.wav";
            try
            {
                Thread thread = new Thread(new ThreadStart(SoundPlayer));
                thread.Start();
            }
            catch { }
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
            if (dem<ListKQ.Count)
            {
                dc= (Doichoi) ListKQ[0];
                btnA.Text = dc.Dapan.ToUpper();
                lblGroup1.Text = dc.Name;
                lblThoigianDoi1.Text = dc.Giay.ToString() + " giây";
                
                dem++;
            }
            
            if (dem<ListKQ.Count)
            {
                dc = (Doichoi)ListKQ[1];
                btnB.Text = dc.Dapan.ToUpper();
                lblGroup2.Text = dc.Name;
                lblThoigianDoi2.Text = dc.Giay.ToString() + " giây";
                dem++;
            }
            

            if (dem<ListKQ.Count)
            {
                dc = (Doichoi)ListKQ[2];
                btnC.Text = dc.Dapan.ToUpper();
                lblGroup3.Text = dc.Name;
                lblThoigianDoi3.Text = dc.Giay.ToString() + " giây";
                dem++;
            }
            
            if (dem<ListKQ.Count)
            {
                dc = (Doichoi)ListKQ[3];
                btnD.Text = dc.Dapan.ToUpper();
                lblGroup4.Text = dc.Name;
                lblThoigianDoi4.Text = dc.Giay.ToString() + " giây";
                dem++;
            }
            //for(int i=0;i<ListKQ.Count;i++)
            //    ListKQ.RemoveAt(i);
            ListKQ.Clear();
            Hienthiketqua = true;
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
                try
                {
                    threadPlayclock.Abort();
                    Pathsound = @"sound\hetgio.wav";
                    Thread thread = new Thread(new ThreadStart(SoundPlayer));
                    thread.Start();
                }
                catch { }
            }
           
        }

        private void frmTangtoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            try{
                threadPlayclock.Abort();
                playClock.Stop();
            }
            catch{}
        }

        private void frmTangtoc_Load(object sender, EventArgs e)
        {
            try
            {
                Process.Start("SlideGioithieu\\tangtoc.pps");
            }
            catch { }
        }

        private void lblTenphanthi_Click(object sender, EventArgs e)
        {

        }

    }
}
