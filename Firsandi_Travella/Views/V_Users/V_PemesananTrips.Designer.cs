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
            Kembali = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Kembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Kembali
            // 
            Kembali.Image = (Image)resources.GetObject("Kembali.Image");
            Kembali.Location = new Point(912, 452);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(146, 34);
            Kembali.SizeMode = PictureBoxSizeMode.Zoom;
            Kembali.TabIndex = 65;
            Kembali.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-24, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1225, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // V_PemesananTrips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1104, 505);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Kembali);
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_PemesananTrips";
            Text = "V_PemesananTrips";
            ((System.ComponentModel.ISupportInitialize)Kembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Kembali;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}