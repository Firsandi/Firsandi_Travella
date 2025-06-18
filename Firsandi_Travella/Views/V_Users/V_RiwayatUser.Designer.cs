namespace Firsandi_Travella.Views.V_Users
{
    partial class V_RiwayatUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RiwayatUser));
            pictureBox2 = new PictureBox();
            Beranda = new PictureBox();
            PaketTrip = new PictureBox();
            pictureBox1 = new PictureBox();
            btnRiwayatPemesanan = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaketTrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRiwayatPemesanan).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, -3);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1259, 97);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 70;
            pictureBox2.TabStop = false;
            // 
            // Beranda
            // 
            Beranda.Image = (Image)resources.GetObject("Beranda.Image");
            Beranda.Location = new Point(8, 101);
            Beranda.Name = "Beranda";
            Beranda.Size = new Size(211, 45);
            Beranda.SizeMode = PictureBoxSizeMode.Zoom;
            Beranda.TabIndex = 69;
            Beranda.TabStop = false;
            Beranda.Click += Beranda_Click;
            // 
            // PaketTrip
            // 
            PaketTrip.Image = (Image)resources.GetObject("PaketTrip.Image");
            PaketTrip.Location = new Point(8, 170);
            PaketTrip.Name = "PaketTrip";
            PaketTrip.Size = new Size(211, 45);
            PaketTrip.SizeMode = PictureBoxSizeMode.Zoom;
            PaketTrip.TabIndex = 66;
            PaketTrip.TabStop = false;
            PaketTrip.Click += PaketTrip_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-5, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 679);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // btnRiwayatPemesanan
            // 
            btnRiwayatPemesanan.Image = (Image)resources.GetObject("btnRiwayatPemesanan.Image");
            btnRiwayatPemesanan.Location = new Point(8, 240);
            btnRiwayatPemesanan.Margin = new Padding(3, 4, 3, 4);
            btnRiwayatPemesanan.Name = "btnRiwayatPemesanan";
            btnRiwayatPemesanan.Size = new Size(211, 45);
            btnRiwayatPemesanan.SizeMode = PictureBoxSizeMode.Zoom;
            btnRiwayatPemesanan.TabIndex = 71;
            btnRiwayatPemesanan.TabStop = false;
            btnRiwayatPemesanan.Click += btnRiwayatPemesanan_Click;
            // 
            // V_RiwayatUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnRiwayatPemesanan);
            Controls.Add(pictureBox2);
            Controls.Add(Beranda);
            Controls.Add(PaketTrip);
            Controls.Add(pictureBox1);
            Name = "V_RiwayatUser";
            Text = "V_RiwayatUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaketTrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRiwayatPemesanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox Beranda;
        private PictureBox PaketTrip;
        private PictureBox pictureBox1;
        private PictureBox btnRiwayatPemesanan;
    }
}