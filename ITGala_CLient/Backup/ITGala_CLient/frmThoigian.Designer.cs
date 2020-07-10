namespace ITGala_CLient
{
    partial class frmThoigian
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
            this.lblDongho = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDongho
            // 
            this.lblDongho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDongho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDongho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDongho.Font = new System.Drawing.Font("Times New Roman", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongho.ForeColor = System.Drawing.Color.Maroon;
            this.lblDongho.Location = new System.Drawing.Point(0, 0);
            this.lblDongho.Name = "lblDongho";
            this.lblDongho.Size = new System.Drawing.Size(484, 167);
            this.lblDongho.TabIndex = 10;
            this.lblDongho.Text = "HẾT THỜI GIAN";
            this.lblDongho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmThoigian
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 167);
            this.Controls.Add(this.lblDongho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "frmThoigian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thông báo";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmThoigian_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDongho;
        private System.Windows.Forms.Timer timer1;
    }
}