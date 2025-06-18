namespace Firsandi_Travella.Views.V_Users
{
    partial class V_PaketTripUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_PaketTripUser));
            PaketTrip = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox1 = new PictureBox();
            Beranda = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PaketTrip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // PaketTrip
            // 
            PaketTrip.Image = (Image)resources.GetObject("PaketTrip.Image");
            PaketTrip.Location = new Point(7, 129);
            PaketTrip.Margin = new Padding(3, 2, 3, 2);
            PaketTrip.Name = "PaketTrip";
            PaketTrip.Size = new Size(185, 34);
            PaketTrip.SizeMode = PictureBoxSizeMode.Zoom;
            PaketTrip.TabIndex = 45;
            PaketTrip.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(7, 181);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(185, 34);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 49;
            pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // Beranda
            // 
            Beranda.Image = (Image)resources.GetObject("Beranda.Image");
            Beranda.Location = new Point(7, 77);
            Beranda.Margin = new Padding(3, 2, 3, 2);
            Beranda.Name = "Beranda";
            Beranda.Size = new Size(185, 34);
            Beranda.SizeMode = PictureBoxSizeMode.Zoom;
            Beranda.TabIndex = 51;
            Beranda.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1102, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            // 
            // V_PaketTripUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1104, 505);
            Controls.Add(pictureBox2);
            Controls.Add(Beranda);
            Controls.Add(pictureBox7);
            Controls.Add(PaketTrip);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_PaketTripUser";
            Text = "V_PaketTripUser";
            ((System.ComponentModel.ISupportInitialize)PaketTrip).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Beranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox PaketTrip;
        private PictureBox pictureBox7;
        private PictureBox pictureBox1;
        private PictureBox Beranda;
        private PictureBox pictureBox2;
    }
}