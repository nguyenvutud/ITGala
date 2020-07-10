using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VietHanITGaLa
{
    public partial class frmHetgio : Form
    {
        public frmHetgio()
        {
            InitializeComponent();
        }

        private void frmHetgio_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void frmHetgio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                timer1.Stop();
                Close();
                Dispose();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
                this.BackColor = Color.IndianRed;
            else
                this.BackColor = Color.Red;
        }
    }
}
