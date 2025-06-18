using Firsandi_Travella.Database;
using Firsandi_Travella.Helper;
using Firsandi_Travella.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firsandi_Travella.Views.V_Users
{
    public partial class V_DetailPaketTrips : Form
    {
        private PaketTripModels _paket;
        private FlowLayoutPanel flowPanel;
        private int _userId;


        public V_DetailPaketTrips(int userId,PaketTripModels paket)
        {
            InitializeComponent();
            this.Size = new Size(1280, 720);

            if (!SessionManager.IsLoggedIn)
            {
                MessageBox.Show("Sesi pengguna tidak valid. Harap login ulang.");
                this.Close();
                return;
            }

            _userId = SessionManager.UserId;
            _paket = paket;
            this.Text = "📜 Detail Paket Trip";
            this.Size = new Size(950, 580);
            this.StartPosition = FormStartPosition.CenterScreen;

            flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(10)
            };

            this.Controls.Add(flowPanel);
            TampilkanDetailPaket();
        }

        private void TampilkanDetailPaket()
        {
            flowPanel.Controls.Clear();

            Panel card = new Panel
            {
                Size = new Size(860, 1000),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                Padding = new Padding(10)
            };

            PictureBox pbGambar = new PictureBox
            {
                Size = new Size(300, 200),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            string imagePath = Path.Combine(Application.StartupPath, "Images", _paket.GambarPath);
            if (File.Exists(imagePath))
                pbGambar.Image = Image.FromFile(imagePath);

          

            Label lblNama = new Label
            {
                Text = $"🌍 {_paket.Nama}",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(320, 10),
                AutoSize = true
            };

            Label lblHarga = new Label
            {
                Text = $"💰 Harga: Rp {_paket.Harga:N0}",
                Font = new Font("Segoe UI", 14),
                Location = new Point(320, 50),
                AutoSize = true
            };

            TextBox txtDeskripsi = new TextBox
            {
                Text = _paket.Deskripsi,
                Multiline = true,
                ReadOnly = true,
                Width = 500,
                Height = 200,
                Location = new Point(320, 100)
            };

            Button btnPesanSekarang = new Button
            {
                Text = "📅 Pesan Sekarang",
                Location = new Point(320, 320),
                Size = new Size(150, 40),
                BackColor = Color.ForestGreen,
                ForeColor = Color.White
            };
            btnPesanSekarang.Click += (sender, e) => BukaFormPemesanan();

            card.Controls.Add(pbGambar);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblHarga);
            card.Controls.Add(txtDeskripsi);
            card.Controls.Add(btnPesanSekarang);

            flowPanel.Controls.Add(card);
        }

        private void BukaFormPemesanan()
        {
            if (_userId <= 0)
            {
                MessageBox.Show("User tidak dikenali. Harap login ulang.");
                return;
            }

            var pemesananForm = new V_PemesananTrips(_userId, _paket);
            pemesananForm.ShowDialog();
            this.Hide();
        }

    }
}
