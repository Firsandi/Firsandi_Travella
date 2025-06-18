namespace Firsandi_Travella.Views
{
    partial class V_HalamanAwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HalamanAwal));
            LoginAdmin = new PictureBox();
            LoginUser = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LoginAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LoginUser).BeginInit();
            SuspendLayout();
            // 
            // LoginAdmin
            // 
            LoginAdmin.BackColor = Color.Transparent;
            LoginAdmin.Image = (Image)resources.GetObject("LoginAdmin.Image");
            LoginAdmin.Location = new Point(89, 35);
            LoginAdmin.Margin = new Padding(3, 4, 3, 4);
            LoginAdmin.Name = "LoginAdmin";
            LoginAdmin.Size = new Size(247, 59);
            LoginAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            LoginAdmin.TabIndex = 3;
            LoginAdmin.TabStop = false;
            LoginAdmin.Click += LoginAdmin_Click;
            // 
            // LoginUser
            // 
            LoginUser.BackColor = Color.Transparent;
            LoginUser.Image = (Image)resources.GetObject("LoginUser.Image");
            LoginUser.Location = new Point(89, 500);
            LoginUser.Margin = new Padding(3, 4, 3, 4);
            LoginUser.Name = "LoginUser";
            LoginUser.Size = new Size(247, 59);
            LoginUser.SizeMode = PictureBoxSizeMode.Zoom;
            LoginUser.TabIndex = 4;
            LoginUser.TabStop = false;
            LoginUser.Click += LoginUser_Click;
            // 
            // V_HalamanAwal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1262, 673);
            Controls.Add(LoginUser);
            Controls.Add(LoginAdmin);
            DoubleBuffered = true;
            Name = "V_HalamanAwal";
            Text = "V_HalamanAwal";
            ((System.ComponentModel.ISupportInitialize)LoginAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)LoginUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox LoginAdmin;
        private PictureBox LoginUser;
    }
}