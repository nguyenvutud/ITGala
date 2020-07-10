namespace VietHanITGaLa
{
    partial class frmConfigServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigServer));
            this.picBell = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIpaddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBell)).BeginInit();
            this.SuspendLayout();
            // 
            // picBell
            // 
            this.picBell.BackColor = System.Drawing.Color.Transparent;
            this.picBell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBell.Image = ((System.Drawing.Image)(resources.GetObject("picBell.Image")));
            this.picBell.Location = new System.Drawing.Point(-4, 28);
            this.picBell.Name = "picBell";
            this.picBell.Size = new System.Drawing.Size(232, 296);
            this.picBell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBell.TabIndex = 20;
            this.picBell.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Location = new System.Drawing.Point(401, 264);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 41);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(221, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port:";
            // 
            // txtIpaddress
            // 
            this.txtIpaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIpaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIpaddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtIpaddress.Location = new System.Drawing.Point(339, 159);
            this.txtIpaddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtIpaddress.Name = "txtIpaddress";
            this.txtIpaddress.Size = new System.Drawing.Size(174, 32);
            this.txtIpaddress.TabIndex = 10;
            this.txtIpaddress.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(221, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "IP Server:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeader.Location = new System.Drawing.Point(106, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(350, 39);
            this.lblHeader.TabIndex = 16;
            this.lblHeader.Text = "CẤU HÌNH SERVER";
            // 
            // txtPort
            // 
            this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPort.Location = new System.Drawing.Point(339, 202);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(174, 32);
            this.txtPort.TabIndex = 19;
            this.txtPort.Text = "8800";
            // 
            // frmConfigServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 317);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtIpaddress);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConfigServer";
            this.Text = "ServerManagerment";
            this.Load += new System.EventHandler(this.frmConfigServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBell;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtIpaddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.TextBox txtPort;
    }
}