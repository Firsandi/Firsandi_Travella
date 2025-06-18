namespace Firsandi_Travella.Views.V_Admin
{
    partial class V_KelolaPaketTrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_KelolaPaketTrip));
            pictureBox10 = new PictureBox();
            TambahPaket = new PictureBox();
            pictureBox2 = new PictureBox();
            Transaksi = new PictureBox();
            Guide = new PictureBox();
            PaketTrip = new PictureBox();
            Beranda = new PictureBox();
            Logout = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TambahPaket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Transaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaketTrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(280, 125);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(309, 61);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 25;
            pictureBox10.TabStop = false;
            // 
            // TambahPaket
            // 
            TambahPaket.Image = (Image)resources.GetObject("TambahPaket.Image");
            TambahPaket.Location = new Point(1115, 125);
            TambahPaket.Name = "TambahPaket";
            TambahPaket.Size = new Size(135, 61);
            TambahPaket.SizeMode = PictureBoxSizeMode.Zoom;
            TambahPaket.TabIndex = 41;
            TambahPaket.TabStop = false;
            TambahPaket.Click += TambahPaket_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 1);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1259, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // Transaksi
            // 
            Transaksi.Image = (Image)resources.GetObject("Transaksi.Image");
            Transaksi.Location = new Point(18, 309);
            Transaksi.Name = "Transaksi";
            Transaksi.Size = new Size(211, 45);
            Transaksi.SizeMode = PictureBoxSizeMode.Zoom;
            Transaksi.TabIndex = 91;
            Transaksi.TabStop = false;
            Transaksi.Click += Transaksi_Click;
            // 
            // Guide
            // 
            Guide.Image = (Image)resources.GetObject("Guide.Image");
            Guide.Location = new Point(18, 245);
            Guide.Name = "Guide";
            Guide.Size = new Size(211, 45);
            Guide.SizeMode = PictureBoxSizeMode.Zoom;
            Guide.TabIndex = 90;
            Guide.TabStop = false;
            Guide.Click += Guide_Click;
            // 
            // PaketTrip
            // 
            PaketTrip.Image = (Image)resources.GetObject("PaketTrip.Image");
            PaketTrip.Location = new Point(18, 180);
            PaketTrip.Name = "PaketTrip";
            PaketTrip.Size = new Size(211, 45);
            PaketTrip.SizeMode = PictureBoxSizeMode.Zoom;
            PaketTrip.TabIndex = 89;
            PaketTrip.TabStop = false;
            PaketTrip.Click += PaketTrip_Click;
            // 
            // Beranda
            // 
            Beranda.Image = (Image)resources.GetObject("Beranda.Image");
            Beranda.Location = new Point(18, 115);
            Beranda.Name = "Beranda";
            Beranda.Size = new Size(211, 45);
            Beranda.SizeMode = PictureBoxSizeMode.Zoom;
            Beranda.TabIndex = 88;
            Beranda.TabStop = false;
            Beranda.Click += Beranda_Click_1;
            // 
            // Logout
            // 
            Logout.Image = (Image)resources.GetObject("Logout.Image");
            Logout.Location = new Point(12, 607);
            Logout.Name = "Logout";
            Logout.Size = new Size(211, 45);
            Logout.SizeMode = PictureBoxSizeMode.Zoom;
            Logout.TabIndex = 86;
            Logout.TabStop = false;
            Logout.Click += Logout_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-2, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(248, 679);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 87;
            pictureBox3.TabStop = false;
            // 
            // V_KelolaPaketTrip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1262, 673);
            Controls.Add(Transaksi);
            Controls.Add(Guide);
            Controls.Add(PaketTrip);
            Controls.Add(Beranda);
            Controls.Add(Logout);
            Controls.Add(pictureBox2);
            Controls.Add(TambahPaket);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox3);
            Name = "V_KelolaPaketTrip";
            Text = "V_KelolaPaketTrip";
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)TambahPaket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Transaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guide).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaketTrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox10;
        private PictureBox TambahPaket;
        private PictureBox pictureBox2;
        private PictureBox Transaksi;
        private PictureBox Guide;
        private PictureBox PaketTrip;
        private PictureBox Beranda;
        private PictureBox Logout;
        private PictureBox pictureBox3;
    }
}