using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firsandi_Travella.Models;
using System.Drawing;
using System.IO;

//namespace Firsandi_Travella.Views.V_Users
//{
//    public partial class V_DetailTrips : Form
//    {

//        private readonly PaketTripModels _trip;
//        public V_DetailTrips(PaketTripModels trip)
//        {
//            InitializeComponent();
//            _trip = trip;
//            SetupForm();
//        }
//        public void SetupForm()
//        {

//        }
//    }
//}

namespace Firsandi_Travella.Views.V_Users
{
    public partial class V_DetailTrips : Form
    {
        private PaketTripModels _paket;

        public V_DetailTrips(PaketTripModels paket)
        {
            InitializeComponent();
            _paket = paket;

            this.Text = "Detail Paket Trip";

            Label lblNama = new Label
            {
                Text = "📦 " + paket.Nama,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(20, 20),
                AutoSize = true
            };

            Label lblHarga = new Label
            {
                Text = $"💰 Rp. {paket.Harga:N0}",
                Font = new Font("Segoe UI", 12),
                Location = new Point(20, 60),
                AutoSize = true
            };

            Label lblDeskripsi = new Label
            {
                Text = "📝 Deskripsi:\n" + paket.Deskripsi,
                Font = new Font("Segoe UI", 11),
                Location = new Point(20, 100),
                Size = new Size(350, 150)
            };

            PictureBox pb = new PictureBox
            {
                Size = new Size(200, 200),
                Location = new Point(400, 20),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            string imagePath = Path.Combine(Application.StartupPath, "Images", paket.GambarPath);
            if (File.Exists(imagePath))
                pb.Image = Image.FromFile(imagePath);

            Button btnPesan = new Button
            {
                Text = "Pesan Sekarang",
                Location = new Point(20, 270),
                Size = new Size(150, 35),
                BackColor = Color.Green,
                ForeColor = Color.White
            };
            btnPesan.Click += BtnPesan_Click;

            Button btnKembali = new Button
            {
                Text = "Kembali",
                Location = new Point(180, 270),
                Size = new Size(100, 35)
            };
            btnKembali.Click += (sender, e) => this.Close();

            this.Controls.Add(lblNama);
            this.Controls.Add(lblHarga);
            this.Controls.Add(lblDeskripsi);
            this.Controls.Add(pb);
            this.Controls.Add(btnPesan);
            this.Controls.Add(btnKembali);

            this.Size = new Size(650, 370);
        }

        private void BtnPesan_Click(object sender, EventArgs e)
        {
            V_Pemesanan pesanForm = new V_Pemesanan(_paket);
            pesanForm.ShowDialog();
        }
    }
}

