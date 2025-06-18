namespace Travella_TA.Views
{
    partial class V_DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DashboardAdmin));
            pictureBox8 = new PictureBox();
            Guide = new PictureBox();
            PaketTrip = new PictureBox();
            Transaksi = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Logout = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaketTrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Transaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logout).BeginInit();
            SuspendLayout();
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(247, 105);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(773, 64);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            // 
            // Guide
            // 
            Guide.Image = (Image)resources.GetObject("Guide.Image");
            Guide.Location = new Point(777, 229);
            Guide.Name = "Guide";
            Guide.Size = new Size(242, 177);
            Guide.SizeMode = PictureBoxSizeMode.Zoom;
            Guide.TabIndex = 15;
            Guide.TabStop = false;
            Guide.Click += Guide_Click;
            // 
            // PaketTrip
            // 
            PaketTrip.Image = (Image)resources.GetObject("PaketTrip.Image");
            PaketTrip.Location = new Point(517, 443);
            PaketTrip.Name = "PaketTrip";
            PaketTrip.Size = new Size(242, 177);
            PaketTrip.SizeMode = PictureBoxSizeMode.Zoom;
            PaketTrip.TabIndex = 14;
            PaketTrip.TabStop = false;
            PaketTrip.Click += PaketTrip_Click_1;
            // 
            // Transaksi
            // 
            Transaksi.Image = (Image)resources.GetObject("Transaksi.Image");
            Transaksi.Location = new Point(331, 220);
            Transaksi.Name = "Transaksi";
            Transaksi.Size = new Size(183, 187);
            Transaksi.SizeMode = PictureBoxSizeMode.Zoom;
            Transaksi.TabIndex = 11;
            Transaksi.TabStop = false;
            Transaksi.Click += Transaksi_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-11, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1270, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(550, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Logout
            // 
            Logout.BackColor = Color.Transparent;
            Logout.BackgroundImage = (Image)resources.GetObject("Logout.BackgroundImage");
            Logout.BackgroundImageLayout = ImageLayout.Stretch;
            Logout.Image = (Image)resources.GetObject("Logout.Image");
            Logout.Location = new Point(36, 29);
            Logout.Name = "Logout";
            Logout.Size = new Size(211, 45);
            Logout.SizeMode = PictureBoxSizeMode.Zoom;
            Logout.TabIndex = 70;
            Logout.TabStop = false;
            Logout.Click += Logout_Click;
            // 
            // V_DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1262, 701);
            Controls.Add(Logout);
            Controls.Add(pictureBox8);
            Controls.Add(Guide);
            Controls.Add(PaketTrip);
            Controls.Add(Transaksi);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_DashboardAdmin";
            Text = "V_DashboardAdmin";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guide).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaketTrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)Transaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logout).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox8;
        private PictureBox Guide;
        private PictureBox PaketTrip;
        private PictureBox Transaksi;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox Logout;
    }
}