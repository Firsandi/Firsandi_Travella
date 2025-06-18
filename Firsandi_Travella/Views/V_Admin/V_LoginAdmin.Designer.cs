namespace Travella_TA.Views
{
    partial class V_LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_LoginAdmin));
            Kembali = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Login = new PictureBox();
            TBUsername = new TextBox();
            TBPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Kembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Login).BeginInit();
            SuspendLayout();
            // 
            // Kembali
            // 
            Kembali.Image = (Image)resources.GetObject("Kembali.Image");
            Kembali.Location = new Point(4, 8);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(146, 34);
            Kembali.SizeMode = PictureBoxSizeMode.Zoom;
            Kembali.TabIndex = 12;
            Kembali.TabStop = false;
            Kembali.Click += Kembali_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(69, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(345, 394);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(544, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(556, 314);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(544, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(556, 638);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            Login.BackgroundImage = (Image)resources.GetObject("Login.BackgroundImage");
            Login.Image = (Image)resources.GetObject("Login.Image");
            Login.Location = new Point(700, 447);
            Login.Name = "Login";
            Login.Size = new Size(241, 106);
            Login.SizeMode = PictureBoxSizeMode.Zoom;
            Login.TabIndex = 14;
            Login.TabStop = false;
            Login.Click += Login_Click;
            // 
            // TBUsername
            // 
            TBUsername.BorderStyle = BorderStyle.None;
            TBUsername.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBUsername.Location = new Point(677, 244);
            TBUsername.Name = "TBUsername";
            TBUsername.Size = new Size(330, 25);
            TBUsername.TabIndex = 15;
            // 
            // TBPassword
            // 
            TBPassword.BorderStyle = BorderStyle.None;
            TBPassword.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBPassword.Location = new Point(677, 342);
            TBPassword.Name = "TBPassword";
            TBPassword.Size = new Size(330, 25);
            TBPassword.TabIndex = 16;
            // 
            // V_LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1104, 526);
            Controls.Add(TBPassword);
            Controls.Add(TBUsername);
            Controls.Add(Login);
            Controls.Add(Kembali);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "V_LoginAdmin";
            Text = "V_LoginAdmin";
            ((System.ComponentModel.ISupportInitialize)Kembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Login).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Kembali;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Login;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.TextBox TBPassword;
    }
}