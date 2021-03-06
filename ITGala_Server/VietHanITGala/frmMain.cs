using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Diagnostics;
using System.Media;

namespace VietHanITGaLa
{
    public partial class frmMain : Form
    {
        int thoigian = 120;
        string filename = "cauhoi//tangtoc1.txt";
        byte[] data = new byte[1024];
        private int Port = 8800;
        private TcpListener listener;
        private Thread listenerThread;
        public Hashtable clients = new Hashtable();
        private string PathSound = "";
        frmFinally frmfinally;
        frmVuotchuongngaivat frmvcnv;
        private Hashtable listKQ = new Hashtable();
        private frmTangtoc frmtangtoc;
        public bool Phanthitangtoc = false;
        public bool PhanthiVCNV = false;
        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Process.Start("SlideGioithieu\\gioithieutangtoc.pps");
            try
            {
                Config.ReadConfig();
                lblTendonvi.Text = Config.donvi;
                lblTenvongthi.Text = Config.vongthi;
                lblTenchude.Text = Config.chude;
                lblSlogan.Text = Config.slogan;
            }
            catch { }
            frmConfigServer frmconfig = new frmConfigServer();
            frmconfig.StartPosition = FormStartPosition.CenterParent;
            frmconfig.ShowDialog(this);
            try
            {
                Port = int.Parse(frmconfig.txtPort.Text);
                frmconfig.Dispose();
                listenerThread = new Thread(new ThreadStart(OnListen));
                listenerThread.Start();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Port không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
      
        }

        
        public void Broadcast(string strMessage)
        {
            UserConnection client;
            foreach (DictionaryEntry entry in clients)
            {
                client = (UserConnection)entry.Value;
                client.SendData(strMessage);
            }
        }
        public void SendtoClient(string strMessage,string name)
        {
            UserConnection client;
            foreach (DictionaryEntry entry in clients)
            {
                client = (UserConnection)entry.Value;
                if (client.Name == name.Trim())
                {
                    client.SendData(strMessage);
                }
            }
        }
        public void ReplyToSender(string strMessage, UserConnection sender)
        {
            sender.SendData(strMessage);
        }
        
        
        public void SendToClients(string strMessage, string name)
        {
            UserConnection client;
            // All entries in the clients Hashtable are UserConnection so it is possible
            // to assign it safely.
            foreach (DictionaryEntry entry in clients)
            {
                client = (UserConnection)entry.Value;
                if (client.Name != name)
                {
                    client.SendData(strMessage);
                }
            }
        }
        private void XulyTraloiTT(string msg, UserConnection sender)
        {
                frmtangtoc.UpdateListKQ(msg, sender);
        }
        private void XulyTraloiVCNV(string msg, UserConnection sender)
        {
              frmvcnv.UpdateListKQ(msg, sender);                   
        }
        
        public void OnDataReceived(UserConnection sender, string data)
        {
            string[] dataArray;
            dataArray = data.Split((char)124);
            switch (dataArray[0])
            {
                case "CONNECT":
                    ConnectUser(dataArray[1], sender);
                    break;
                case "BELLVD":
                    frmfinally.XulyChuong(sender);
                    break;
                case "BELLVCNV":
                    frmvcnv.XulyChuong(sender);
                    break;
                case "DISCONNECT":
                    DisconnectUser(sender);
                    break;
                case "RESULTTT":
                    XulyTraloiTT(dataArray[1],sender);
                    break;
                case "RESULTVCNV":
                    XulyTraloiVCNV(dataArray[1], sender);
                    break;
                default:
                    UpdateControl("Không hiểu yêu cầu:" + data);
                    break;
            }
        }
        public void OnListen()
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, Port);
                listener.Start();
                do
                {
                    UserConnection client = new UserConnection(listener.AcceptTcpClient());
                    // Create an event handler to allow the UserConnection to communicate
                    // with the window.

                    client.LineReceived += new LineReceive(OnDataReceived);

                    //AddHandler client.LineReceived, AddressOf OnLineReceived;
                    UpdateControl("new connection found: waiting for log-in");
                } while (true);
            }
            catch
            {
                MessageBox.Show("Server gặp sự cố. Đề nghị bạn kiểm tra và khởi động lại Server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
       
        public void UpdateControl(string msg)
        {
            //MessageBox.Show(msg);
        }
        
        private void SoundPlayer()
        {
            SoundPlayer sound = new SoundPlayer(PathSound);
            sound.Play();
        }
        
        public void ConnectUser(string userName, UserConnection sender)
        {
            if (clients.Contains(userName))
            {
                ReplyToSender("REFUSE", sender);
            }
            else
            {
                sender.Name = userName;
                UpdateControl(userName+" đã kết nối");
                clients.Add(userName, sender);
                ReplyToSender("JOIN", sender);
                
            }
        }
        private void DisconnectUser(UserConnection sender)
        {
            UpdateControl(sender.Name + " đã ngắt kết nối");
            clients.Remove(sender.Name);
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            listener.Stop();
        }

        private void kdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Broadcast("KHOIDONG|" +thoigian.ToString());
            frmKhoidong frmkd = new frmKhoidong(this, filename);
            frmkd.Show();
        }

        private void ttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Broadcast("TANGTOC| ");
            frmtangtoc = new frmTangtoc(this);
            frmtangtoc.Show();
        }

        private void vdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Broadcast("VEDICH" + "|ABC");
            frmfinally = new frmFinally(this);
            frmfinally.Show();
        }

        private void vcnvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanthiVCNV = true;
            Broadcast("VCNV" + "|ABC");
            frmvcnv = new frmVuotchuongngaivat(this);
            frmvcnv.Show();
            //PhanthiVCNV = false;
        }

        private void serverConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfigServer frmconfig = new frmConfigServer();
            frmconfig.ShowDialog();
        }

    }
}

