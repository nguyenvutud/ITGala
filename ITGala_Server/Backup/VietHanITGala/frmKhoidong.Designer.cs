namespace VietHanITGaLa
{
    partial class frmKhoidong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhoidong));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTenvongthi = new System.Windows.Forms.Label();
            this.lblTenphanthi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDoithi = new System.Windows.Forms.Label();
            this.lblNoidungcauhoi = new System.Windows.Forms.Label();
            this.lblDapan = new System.Windows.Forms.Label();
            this.picStart = new System.Windows.Forms.PictureBox();
            this.lblDongho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTenvongthi
            // 
            this.lblTenvongthi.BackColor = System.Drawing.Color.Transparent;
            this.lblTenvongthi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenvongthi.Font = new System.Drawing.Font("Times New Roman", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenvongthi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTenvongthi.Location = new System.Drawing.Point(0, 0);
            this.lblTenvongthi.Name = "lblTenvongthi";
            this.lblTenvongthi.Size = new System.Drawing.Size(922, 76);
            this.lblTenvongthi.TabIndex = 0;
            this.lblTenvongthi.Text = "VÒNG CHUNG KẾT GALA IT NĂM 2012";
            this.lblTenvongthi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenphanthi
            // 
            this.lblTenphanthi.BackColor = System.Drawing.Color.Transparent;
            this.lblTenphanthi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenphanthi.Font = new System.Drawing.Font("Times New Roman", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenphanthi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTenphanthi.Location = new System.Drawing.Point(0, 76);
            this.lblTenphanthi.Name = "lblTenphanthi";
            this.lblTenphanthi.Size = new System.Drawing.Size(922, 76);
            this.lblTenphanthi.TabIndex = 5;
            this.lblTenphanthi.Text = "PHẦN THI KHỞI ĐỘNG";
            this.lblTenphanthi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "-------------------------------------------------------";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDoithi
            // 
            this.lblDoithi.BackColor = System.Drawing.Color.Transparent;
            this.lblDoithi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDoithi.Font = new System.Drawing.Font("Times New Roman", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblDoithi.ForeColor = System.Drawing.Color.Yellow;
            this.lblDoithi.Location = new System.Drawing.Point(0, 193);
            this.lblDoithi.Name = "lblDoithi";
            this.lblDoithi.Size = new System.Drawing.Size(922, 113);
            this.lblDoithi.TabIndex = 21;
            this.lblDoithi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoidungcauhoi
            // 
            this.lblNoidungcauhoi.BackColor = System.Drawing.Color.Transparent;
            this.lblNoidungcauhoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNoidungcauhoi.Font = new System.Drawing.Font("Times New Roman", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoidungcauhoi.ForeColor = System.Drawing.Color.Gold;
            this.lblNoidungcauhoi.Location = new System.Drawing.Point(0, 306);
            this.lblNoidungcauhoi.Name = "lblNoidungcauhoi";
            this.lblNoidungcauhoi.Size = new System.Drawing.Size(922, 268);
            this.lblNoidungcauhoi.TabIndex = 22;
            this.lblNoidungcauhoi.Text = "Câu hỏi";
            this.lblNoidungcauhoi.Visible = false;
            // 
            // lblDapan
            // 
            this.lblDapan.BackColor = System.Drawing.Color.Transparent;
            this.lblDapan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDapan.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapan.ForeColor = System.Drawing.Color.White;
            this.lblDapan.Location = new System.Drawing.Point(0, 574);
            this.lblDapan.Name = "lblDapan";
            this.lblDapan.Size = new System.Drawing.Size(922, 164);
            this.lblDapan.TabIndex = 23;
            this.lblDapan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picStart
            // 
            this.picStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picStart.BackColor = System.Drawing.Color.Transparent;
            this.picStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picStart.Image = ((System.Drawing.Image)(resources.GetObject("picStart.Image")));
            this.picStart.Location = new System.Drawing.Point(376, 343);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(171, 171);
            this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStart.TabIndex = 24;
            this.picStart.TabStop = false;
            this.picStart.Visible = false;
            this.picStart.Click += new System.EventHandler(this.picStart_Click);
            // 
            // lblDongho
            // 
            this.lblDongho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDongho.BackColor = System.Drawing.Color.Transparent;
            this.lblDongho.Font = new System.Drawing.Font("Tahoma", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongho.ForeColor = System.Drawing.Color.Snow;
            this.lblDongho.Location = new System.Drawing.Point(692, 566);
            this.lblDongho.Name = "lblDongho";
            this.lblDongho.Size = new System.Drawing.Size(230, 124);
            this.lblDongho.TabIndex = 25;
            this.lblDongho.Text = "120";
            this.lblDongho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDongho.Visible = false;
            // 
            // frmKhoidong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 687);
            this.Controls.Add(this.lblDongho);
            this.Controls.Add(this.picStart);
            this.Controls.Add(this.lblDapan);
            this.Controls.Add(this.lblNoidungcauhoi);
            this.Controls.Add(this.lblDoithi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenphanthi);
            this.Controls.Add(this.lblTenvongthi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhoidong";
            this.Text = "frmKhoidong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKhoidong_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKhoidong_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RightKeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTenvongthi;
        private System.Windows.Forms.Label lblTenphanthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDoithi;
        private System.Windows.Forms.Label lblNoidungcauhoi;
        private System.Windows.Forms.Label lblDapan;
        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.Label lblDongho;
    }
}