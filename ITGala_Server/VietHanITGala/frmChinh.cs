using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VietHanITGaLa
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tangtocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain frmtangtoc = new frmMain();
            frmtangtoc.Show();
        }

        private void khoidongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kethucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
