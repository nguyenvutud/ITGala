using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace ITGala_CLient
{
    public partial class frmMain : Form
    {
        const int sizeBuffer = 1024;
        private int Port = 8800;
        private string Ipaddress = "192.168.1.100";
        private string Name="";
        private TcpClient client;
        private byte[] mangDulieu = new byte[sizeBuffer];
        private int thoigian = 60;
        private bool BellClicked = true;
        private bool StartedKD = false;
        private Thread thread;
        private string phanthi = "";
        private bool nhanchuongVCNV = false;
        public delegate void EnableControlCallBack(bool st);
        public delegate void UpdateThoigianCallBack(bool st, string t);
        public delegate void VisibleGroupBoxCallback(bool st);

        private void EnableControl(bool status)
        {
            if (InvokeRequired)
            {
                object[] o = { status };
                btnBell.BeginInvoke(new EnableControlCallBack(EnableButtonBell), status);

            }
            else
            {
                EnableButtonBell(status);
            }
        }
        private void EnableButtonBell(bool status)
        {
            //btnBell.Enabled = status;
            btnBell.Visible = status;
        }
        private void UpdateThoiGian(bool status, string tg)
        {
            if (InvokeRequired)
            {
                object[] o = { status, tg };
                lblDongho.BeginInvoke(new UpdateThoigianCallBack(UpdateLabelDongho), o);
            }
            else
            {
                UpdateLabelDongho(status, tg);
            }
        }
        private void UpdateLabelDongho(bool status, string tg)
        {
            lblDongho.Visible = status;
            lblDongho.Text = tg;
        }
        private void VisibleGroupBox(bool status)
        {
            if (InvokeRequired)
            {
                object[] o = { status };
                groupBoxResult.BeginInvoke(new VisibleGroupBoxCallback(VisibleResultGroupBox), o);
            }
            else
            {
                VisibleResultGroupBox(status);
            }
        }
        private void VisibleResultGroupBox(bool status)
        {
            groupBoxResult.Visible = status;
        }
        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void DangNhap()
        {
            frmPlayer frmplayer = new frmPlayer();
            frmplayer.StartPosition = FormStartPosition.CenterParent;
            frmplayer.ShowDialog(this);
            Ipaddress = frmplayer.txtIpaddress.Text;
            Port = int.Parse(frmplayer.txtPort.Text);
            Name = frmplayer.txtName.Text.ToUpper();
            frmplayer.Dispose();
            //Them vao EnableCallBack
            //btnBell.Visible = true;
        }
        #region formLoad
        private void frmMain_Load(object sender, EventArgs e)
        {
            DangNhap();

            try
            {
                client = new TcpClient(Ipaddress, Port);
                client.GetStream().BeginRead(mangDulieu, 0, 1024, new AsyncCallback(DoRead), null);
                this.Show();
                SendData("CONNECT|" + Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server không hoạt động. Đề nghị bạn kiểm tra lại thông tin của Server!",
                   this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Dispose();
            }

        }
        #endregion
        #region Onread
        private void DoRead(IAsyncResult ar)
        {
            int byteRead;
            string strMessage;
            try
            {
                byteRead = client.GetStream().EndRead(ar);
                if (byteRead < 1)
                {
                    XulyLoi();
                    return;
                }
                strMessage = Encoding.UTF8.GetString(mangDulieu, 0, byteRead - 2);
                XulyDulieu(strMessage);
                mangDulieu = new byte[1024];
                client.GetStream().BeginRead(mangDulieu, 0, mangDulieu.Length, new AsyncCallback(DoRead), null);
            }
            catch (Exception ex)
            {
                XulyLoi();
            }
        }
        #endregion
        #region Xử lý message nhận được từ client
        private void XulyDulieu(string strMessage)
        {
            try
            {
                string[] dataArray;
                dataArray = strMessage.Split((char)124);
                switch (dataArray[0])
                {
                    case "JOIN":
                        Connected();
                        break;
                    case "CHAT":
                        DisplayText(dataArray[1] + (char)13 + (char)10);
                        break;
                    case "REFUSE":
                        DangNhap();
                        break;
                    case "RESET":
                        Reset();
                        break;
                    case "BROAD":
                        DisplayText(dataArray[1]);
                        break;
                    case "KHOIDONG":
                        Phanthikhoidong(dataArray[1]);
                        break;
                    case "TANGTOC":
                        Phanthitangtoc();
                        break;
                    case "STARTKD":
                        StartKD(dataArray[1]);
                        break;
                    case "STARTTT":
                        StartTT(dataArray[1]);
                        break;
                    case "VEDICH":
                        Phanthivedich();
                        break;
                    case "STARTVD":
                        StartVD(dataArray[1]);
                        break;
                    case "VCNV":
                        PhanthiVCNV();
                        break;
                    case "STARTVCNV":
                        StartVCNV(dataArray[1]);
                        break;


                }
            }
            catch (Exception ex)
            {
                lbltoolStripStatus.Text = ex.ToString();
            }
        }
        #endregion
        #region Gửi dữ liệu tới Server
        private void SendData(string message)
        {
            try
            {
                StreamWriter streamwriter = new StreamWriter(client.GetStream());
                streamwriter.Write(message + (char)13);
                streamwriter.Flush();
            }
            catch
            {
                lbltoolStripStatus.Text = "Không gửi dữ liệu được";
            }
        }
        #endregion
        private void XulyLoi()
        {
            MessageBox.Show("Gặp sự cố khi nhận dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void Khoitao()
        {
            VisibleGroupBox(false);
            EnableControl(false);
            UpdateThoiGian(false, "");
            lblThongbao.Text = "";
        }
        #region Phần thi khởi động
        private void Phanthikhoidong(string tg)
        {
            phanthi = "KHOIDONG";
            thoigian = Convert.ToInt32(tg);
            lblPhanthi.Text = "PHẦN THI KHỞI ĐỘNG";
            StartedKD = false;
            Khoitao();
        }
        private void StartKD(string msg)
        {
            if (StartedKD == false)
            {
                StartedKD = true;
                thread = new Thread(new ThreadStart(ThoigianKD));
                thread.Start();
            }
            if (msg != "FINISH")
            {
                lblCauhoi.Text = msg;
            }
            else
            {
                lblCauhoi.Text = "ĐÃ HOÀN THÀNH PHẦN THI KHỞI ĐỘNG";
            }
        }
        #endregion
        private void ThoigianKD()
        {
            
            for (int i = thoigian; i >= 0; i--)
            {
                UpdateThoiGian(true,i.ToString());
                Thread.Sleep(1000);
                if (i < 1)
                {
                    lblThongbao.Text = "HẾT THỜI GIAN";
                    UpdateThoiGian(false, "Time");
                    btnSend.Enabled = false;
                    thread.Abort();
                }
                
            }
            
        }
        private void RunFormTime()
        {
            Application.Run(new frmThoigian());
        }
        #region Phần thi tăng tốc
        private void Phanthitangtoc()
        {
            try
            {
                lblPhanthi.Text = "PHẦN THI TĂNG TỐC";
                phanthi = "TANGTOC";
                lblCauhoi.Text = "Đang chờ nhận câu hỏi...";
                Khoitao();
            }
            catch (Exception ex)
            { 
                lbltoolStripStatus.Text = ex.ToString(); 
            }
        }
        
        private void StartTT(string msg)
        {
            lblCauhoi.Text = "";
            lblThongbao.Text = "";
            if (msg != " ")
            {
                if (msg != "FINISH")
                {
                    thoigian = 30;
                    thread = new Thread(new ThreadStart(ThoigianKD));
                    thread.Start();
                    VisibleGroupBox(true);
                    btnSend.Enabled = true;
                    lblCauhoi.Text = msg;
                }
                else
                {
                    lblCauhoi.Text = "ĐÃ HOÀN THÀNH PHẦN THI TĂNG TỐC";
                }
            }
            
            txtSend.Text = "";
            lbltoolStripStatus.Text = "Nhập nội dung đáp án và Click nút Send để trả lời!";

        }
        #endregion
        #region Phần thi về đích
        private void Phanthivedich()
        {
            try
            {
                phanthi = "VEDICH";
                lblPhanthi.Text = "PHẦN THI VỀ ĐÍCH";
                lblCauhoi.Text = "Đang chờ nhận câu hỏi...";
                Khoitao();
            }
            catch (Exception ex)
            {
                lbltoolStripStatus.Text = ex.ToString();
            }
        }
        private void StartVD(string msg)
        {
            if (msg != "FINISH")
            {
                //EnableControl(true); Chờ nhấn reset mới xuất hiện chuông
                lblCauhoi.Text = "";
                lblThongbao.Text = "";
                lblCauhoi.Text = msg;
                BellClicked = true;
                EnableControl(false);
                lbltoolStripStatus.Text = "Bạn Click vào Chuông để dành quyền trả lời";
            }
            else
            {
                lblCauhoi.Text = "ĐÃ HOÀN THÀNH CÁC CÂU HỎI PHẦN THI VỀ ĐÍCH";
            }
        }
        
        #endregion
        #region Phần thi vượt chướng ngại vật
        private void PhanthiVCNV()
        {
            try
            {
                phanthi = "VCNV";
                lblPhanthi.Text = "PHẦN THI VƯỢT CHƯỚNG NGẠI VẬT \n";
                lblCauhoi.Text = "Đang chờ nhận câu hỏi...";

                Khoitao();
            }
            catch (Exception ex)
            {
                lbltoolStripStatus.Text = ex.ToString();
            }
        }
        private void StartVCNV(string msg)
        {
            if (!nhanchuongVCNV)
            {
                EnableControl(true);
                VisibleGroupBox(true);
            }
            BellClicked = false;            
            lblCauhoi.Text = "";
            lblThongbao.Text = "";
            lblCauhoi.Text = msg;
            if (msg != " ")
            {
                thoigian = 30;
                thread = new Thread(new ThreadStart(ThoigianKD));
                thread.Start();
            }
            btnSend.Enabled = true;
            txtSend.Text = "";
            lbltoolStripStatus.Text = "Nhập nội dung đáp án và Click nút Send để trả lời!";
        }
        #endregion

        private void Connected()
        {
            lbltoolStripStatus.Text = "Bạn đã kết nối đến Server thành công!";
        }
        private void Reset()
        {
            BellClicked = false;
            EnableControl(true);
        }
        private void DisplayText(string text)
        {   
            lblCauhoi.Text = "";
            lblCauhoi.Visible = true;
            lblCauhoi.Text=text;
            btnBell.Enabled = true;
            btnBell.Refresh();
            lblCauhoi.Refresh();
        }
        private void btnBell_Click(object sender, EventArgs e)
        {
            
                if (phanthi == "VEDICH")
                {
                    if (!BellClicked)
                    {
                        SendData("BELLVD|" + "CHUONG");
                        lbltoolStripStatus.Text = "Thông báo: Bạn đã nhấn chuông trả lời!";
                        BellClicked = true;
                    }
                }
                else
                    if (phanthi == "VCNV")
                    {
                        nhanchuongVCNV = true;
                        groupBoxResult.Visible = false;
                        SendData("BELLVCNV|" + "CHUONG");
                        lbltoolStripStatus.Text = "Thông báo: Bạn đã nhấn chuông trả lời từ khóa, nếu trả lời sai bạn không được trả lời các câu tiếp theo trong phần thi này!";
                        lblDongho.Visible = false;
                        lblThongbao.Visible = false;
                    }
                
                //BellClicked = true;
                EnableControl(false);
            
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SendData("DISCONNECT");
            client.Close();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (phanthi == "TANGTOC")
            {
                SendData("RESULTTT|" + txtSend.Text);
                lbltoolStripStatus.Text = "Bạn đã gửi câu hỏi tới Server";
            }
            else
            if(phanthi=="VCNV")
            {
                if (!nhanchuongVCNV)
                {
                    SendData("RESULTVCNV|" + txtSend.Text);
                    lbltoolStripStatus.Text = "Bạn đã nhấn chuông để trả lời từ khóa";
                }
            }

            btnSend.Enabled = false;
        }

        private void txtSend_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                btnSend.PerformClick();
            }
        }

       
    }
}
