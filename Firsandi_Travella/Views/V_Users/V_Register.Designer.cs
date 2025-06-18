namespace Travella_TA.Views
{
    partial class V_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Register));
            Kembali = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            TBNama = new TextBox();
            TBEmail = new TextBox();
            TBNomor = new TextBox();
            TBUsername = new TextBox();
            TBPassword = new TextBox();
            Daftar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Kembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Daftar).BeginInit();
            SuspendLayout();
            // 
            // Kembali
            // 
            Kembali.Image = (Image)resources.GetObject("Kembali.Image");
            Kembali.Location = new Point(10, 11);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(146, 34);
            Kembali.SizeMode = PictureBoxSizeMode.Zoom;
            Kembali.TabIndex = 3;
            Kembali.TabStop = false;
            Kembali.Click += Kembali_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(75, 113);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(345, 394);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(550, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(556, 638);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(550, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(556, 544);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // TBNama
            // 
            TBNama.BorderStyle = BorderStyle.None;
            TBNama.Location = new Point(684, 151);
            TBNama.Multiline = true;
            TBNama.Name = "TBNama";
            TBNama.Size = new Size(330, 50);
            TBNama.TabIndex = 17;
            TBNama.TextChanged += Nama_TextChanged;
            // 
            // TBEmail
            // 
            TBEmail.BorderStyle = BorderStyle.None;
            TBEmail.Location = new Point(684, 241);
            TBEmail.Multiline = true;
            TBEmail.Name = "TBEmail";
            TBEmail.Size = new Size(330, 50);
            TBEmail.TabIndex = 18;
            // 
            // TBNomor
            // 
            TBNomor.BorderStyle = BorderStyle.None;
            TBNomor.Location = new Point(684, 338);
            TBNomor.Multiline = true;
            TBNomor.Name = "TBNomor";
            TBNomor.Size = new Size(330, 50);
            TBNomor.TabIndex = 19;
            // 
            // TBUsername
            // 
            TBUsername.BorderStyle = BorderStyle.None;
            TBUsername.Location = new Point(684, 428);
            TBUsername.Multiline = true;
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(330, 50);
            TBUsername.TabIndex = 20;
            // 
            // TBPassword
            // 
            TBPassword.BorderStyle = BorderStyle.None;
            TBPassword.Location = new Point(684, 520);
            TBPassword.Multiline = true;
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(330, 50);
            TBPassword.TabIndex = 21;
            // 
            // Daftar
            // 
            Daftar.Image = (Image)resources.GetObject("Daftar.Image");
            Daftar.Location = new Point(129, 544);
            Daftar.Name = "Daftar";
            Daftar.Size = new Size(231, 76);
            Daftar.SizeMode = PictureBoxSizeMode.Zoom;
            Daftar.TabIndex = 22;
            Daftar.TabStop = false;
            Daftar.Click += Daftar_Click;
            // 
            // V_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1104, 526);
            Controls.Add(Daftar);
            Controls.Add(TBPassword);
            Controls.Add(TBUsername);
            Controls.Add(TBNomor);
            Controls.Add(TBEmail);
            Controls.Add(TBNama);
            Controls.Add(Kembali);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "V_Register";
            Text = "V_Register";
            ((System.ComponentModel.ISupportInitialize)Kembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Daftar).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Kembali;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TBNama;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBNomor;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.PictureBox Daftar;
    }
}