namespace Firsandi_Travella.Views.V_Users
{
    partial class V_TFBANK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_TFBANK));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            Harga = new Label();
            Kembali = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Kembali).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1259, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 101);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1268, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 189);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1268, 388);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 67;
            pictureBox3.TabStop = false;
            // 
            // Harga
            // 
            Harga.AutoSize = true;
            Harga.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Harga.Location = new Point(597, 601);
            Harga.Name = "Harga";
            Harga.Size = new Size(60, 27);
            Harga.TabIndex = 68;
            Harga.Text = "label1";
            Harga.Click += Harga_Click;
            // 
            // Kembali
            // 
            Kembali.Image = (Image)resources.GetObject("Kembali.Image");
            Kembali.Location = new Point(25, 27);
            Kembali.Margin = new Padding(3, 4, 3, 4);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(167, 45);
            Kembali.SizeMode = PictureBoxSizeMode.Zoom;
            Kembali.TabIndex = 69;
            Kembali.TabStop = false;
            Kembali.Click += Kembali_Click;
            // 
            // V_TFBANK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(Kembali);
            Controls.Add(Harga);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "V_TFBANK";
            Text = "V_TFBANK";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Kembali).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label Harga;
        private PictureBox Kembali;
    }
}