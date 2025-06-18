namespace Firsandi_Travella.Views.V_Users
{
    partial class V_PemesananTrips
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_PemesananTrips));
            pictureBox1 = new PictureBox();
            Kembali = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Kembali).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-27, -5);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1400, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // Kembali
            // 
            Kembali.BackgroundImage = (Image)resources.GetObject("Kembali.BackgroundImage");
            Kembali.Image = (Image)resources.GetObject("Kembali.Image");
            Kembali.Location = new Point(14, 16);
            Kembali.Margin = new Padding(3, 4, 3, 4);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(167, 45);
            Kembali.SizeMode = PictureBoxSizeMode.Zoom;
            Kembali.TabIndex = 67;
            Kembali.TabStop = false;
            Kembali.Click += Kembali_Click;
            // 
            // V_PemesananTrips
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1262, 673);
            Controls.Add(Kembali);
            Controls.Add(pictureBox1);
            Name = "V_PemesananTrips";
            Text = "V_PemesananTrips";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Kembali).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox Kembali;
    }
}