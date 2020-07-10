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
    public partial class frmPlayer : Form
    {
        public bool OK = false;
        public frmPlayer()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            OK = true;
        }

       
    }
}
