namespace Travella_TA.Views
{
    partial class V_Halaman_Awal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Halaman_Awal));
            this.LoginUser = new System.Windows.Forms.PictureBox();
            this.LoginAdmin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginUser
            // 
            this.LoginUser.Image = ((System.Drawing.Image)(resources.GetObject("LoginUser.Image")));
            this.LoginUser.Location = new System.Drawing.Point(109, 516);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Size = new System.Drawing.Size(312, 58);
            this.LoginUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginUser.TabIndex = 1;
            this.LoginUser.TabStop = false;
            this.LoginUser.Click += new System.EventHandler(this.LoginUser_Click);
            // 
            // LoginAdmin
            // 
            this.LoginAdmin.Image = ((System.Drawing.Image)(resources.GetObject("LoginAdmin.Image")));
            this.LoginAdmin.Location = new System.Drawing.Point(54, 3);
            this.LoginAdmin.Name = "LoginAdmin";
            this.LoginAdmin.Size = new System.Drawing.Size(247, 66);
            this.LoginAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginAdmin.TabIndex = 2;
            this.LoginAdmin.TabStop = false;
            this.LoginAdmin.Click += new System.EventHandler(this.LoginAdmin_Click);
            // 
            // V_Halaman_Awal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.LoginAdmin);
            this.Controls.Add(this.LoginUser);
            this.DoubleBuffered = true;
            this.Name = "V_Halaman_Awal";
            this.Text = "V_Halaman_Awal";
            ((System.ComponentModel.ISupportInitialize)(this.LoginUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox LoginUser;
        private System.Windows.Forms.PictureBox LoginAdmin;
    }
}