namespace ITGala_CLient
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDongho = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbltoolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPhanthi = new System.Windows.Forms.Label();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.lblCauhoi = new System.Windows.Forms.Label();
            this.btnBell = new System.Windows.Forms.Button();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1281, 91);
            this.label2.TabIndex = 6;
            this.label2.Text = "CHƯƠNG TRÌNH GALA IT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lblDongho
            // 
            this.lblDongho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDongho.BackColor = System.Drawing.Color.White;
            this.lblDongho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDongho.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongho.ForeColor = System.Drawing.Color.Blue;
            this.lblDongho.Location = new System.Drawing.Point(1107, 0);
            this.lblDongho.Name = "lblDongho";
            this.lblDongho.Size = new System.Drawing.Size(174, 100);
            this.lblDongho.TabIndex = 9;
            this.lblDongho.Text = "Time";
            this.lblDongho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDongho.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbltoolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 766);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1281, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbltoolStripStatus
            // 
            this.lbltoolStripStatus.Name = "lbltoolStripStatus";
            this.lbltoolStripStatus.Size = new System.Drawing.Size(39, 17);
            this.lbltoolStripStatus.Text = "Status";
            // 
            // lblPhanthi
            // 
            this.lblPhanthi.BackColor = System.Drawing.Color.Transparent;
            this.lblPhanthi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPhanthi.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanthi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPhanthi.Location = new System.Drawing.Point(0, 91);
            this.lblPhanthi.Name = "lblPhanthi";
            this.lblPhanthi.Size = new System.Drawing.Size(1281, 76);
            this.lblPhanthi.TabIndex = 13;
            this.lblPhanthi.Text = "TIÊU ĐỀ PHẦN THI";
            this.lblPhanthi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.BackColor = System.Drawing.Color.Blue;
            this.groupBoxResult.Controls.Add(this.btnSend);
            this.groupBoxResult.Controls.Add(this.txtSend);
            this.groupBoxResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResult.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBoxResult.Location = new System.Drawing.Point(0, 672);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(1281, 94);
            this.groupBoxResult.TabIndex = 18;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Nhập câu trả lời";
            this.groupBoxResult.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(1120, 27);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(148, 59);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.ForeColor = System.Drawing.Color.Navy;
            this.txtSend.Location = new System.Drawing.Point(15, 33);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(1082, 53);
            this.txtSend.TabIndex = 0;
            this.txtSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyUp);
            // 
            // lblCauhoi
            // 
            this.lblCauhoi.BackColor = System.Drawing.Color.Transparent;
            this.lblCauhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauhoi.ForeColor = System.Drawing.Color.Yellow;
            this.lblCauhoi.Location = new System.Drawing.Point(0, 219);
            this.lblCauhoi.Name = "lblCauhoi";
            this.lblCauhoi.Size = new System.Drawing.Size(1281, 370);
            this.lblCauhoi.TabIndex = 19;
            // 
            // btnBell
            // 
            this.btnBell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBell.BackColor = System.Drawing.Color.Transparent;
            this.btnBell.BackgroundImage = global::ITGala_CLient.Properties.Resources.chuong1;
            this.btnBell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBell.FlatAppearance.BorderSize = 0;
            this.btnBell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBell.Location = new System.Drawing.Point(567, 462);
            this.btnBell.Margin = new System.Windows.Forms.Padding(2);
            this.btnBell.Name = "btnBell";
            this.btnBell.Size = new System.Drawing.Size(146, 167);
            this.btnBell.TabIndex = 20;
            this.btnBell.UseVisualStyleBackColor = false;
            this.btnBell.Visible = false;
            this.btnBell.Click += new System.EventHandler(this.btnBell_Click);
            // 
            // lblThongbao
            // 
            this.lblThongbao.BackColor = System.Drawing.Color.Transparent;
            this.lblThongbao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblThongbao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongbao.ForeColor = System.Drawing.Color.Red;
            this.lblThongbao.Location = new System.Drawing.Point(0, 637);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(1281, 35);
            this.lblThongbao.TabIndex = 21;
            this.lblThongbao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1281, 52);
            this.label1.TabIndex = 22;
            this.label1.Text = "-----------------------------------------------------------";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ITGala_CLient.Properties.Resources.Cyclone_II_FPGA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 788);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.btnBell);
            this.Controls.Add(this.lblCauhoi);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.lblPhanthi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblDongho);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "ITGalaClient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDongho;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbltoolStripStatus;
        private System.Windows.Forms.Label lblPhanthi;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Label lblCauhoi;
        private System.Windows.Forms.Button btnBell;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.Label label1;

    }
}

