using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace VietHanITGaLa
{
    public partial class frmConfigServer : Form
    {
        public frmConfigServer()
        {
            InitializeComponent();
        }
        private string GetIP()
        {
            string strHostName = Dns.GetHostName();
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
            return iphostentry.AddressList[0].ToString();;
        }
        private void frmConfigServer_Load(object sender, EventArgs e)
        {
            txtIpaddress.Text = GetIP();
        }
    }
}
