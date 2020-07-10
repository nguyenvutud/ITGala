using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VietHanITGaLa
{
    public partial class frmGoicauhoiKD : Form
    {
        public frmGoicauhoiKD()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbDoichoi.SelectedItem.ToString() == "")
                cmbDoichoi.SelectedIndex = 1;
            if (cmbGoicauhoi.SelectedItem.ToString() == "")
                cmbGoicauhoi.SelectedIndex = 1;
        }

       
    }
}