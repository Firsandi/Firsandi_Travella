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
            ((System.ComponentModel.ISupportInitialize)Kembali).BeginInit();
            SuspendLayout();
            // 
            // Kembali
            // 
            Kembali.Image = (Image)resources.GetObject("Kembali.Image");
            Kembali.Location = new Point(1042, 602);
            Kembali.Margin = new Padding(3, 4, 3, 4);
            Kembali.Name = "Kembali";
            Kembali.Size = new Size(167, 46);
            Kembali.SizeMode = PictureBoxSizeMode.Zoom;
            Kembali.TabIndex = 65;
            Kembali.TabStop = false;
            // 
            // V_PemesananTrips
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(Kembali);
            Name = "V_PemesananTrips";
            Text = "V_PemesananTrips";
            ((System.ComponentModel.ISupportInitialize)Kembali).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Kembali;
    }
}