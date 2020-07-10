using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITGala_CLient
{
    public partial class frmThoigian : Form
    {
        private int thoigian = 60;
        public frmThoigian()
        {
            InitializeComponent();
        }

        private void frmThoigian_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
                lblDongho.Text = "Hết giờ";
                timer1.Stop();
                this.Dispose();
            }
            
        }
    }
}
