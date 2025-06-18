using Firsandi_Travella.Database;
using Firsandi_Travella.Helper;
using Firsandi_Travella.Interfaces;
using Firsandi_Travella.Models;
using Firsandi_Travella.Presenter;
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
    public partial class V_PemesananTrips : Form, IPemesananView
    {
        private readonly PemesananPresenter _presenter;
        private readonly PaketTripModels _paket;
        private readonly int _userId;

        private ComboBox CBJadwal, CBMetode;
        private DateTimePicker DTP;

        public V_PemesananTrips(int userId, PaketTripModels paket)
        {
            InitializeComponent();
            this.Size = new Size(1280, 720);
            if (!SessionManager.IsLoggedIn)
            {
                MessageBox.Show("Sesi pengguna tidak valid. Silakan login ulang.");
                this.Close();
                return;
            }

            _userId = SessionManager.UserId;
            _paket = paket;
            _presenter = new PemesananPresenter(this);

            this.Text = $"🗓 Pemesanan: {_paket.Nama}";
            this.Size = new Size(850, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                Padding = new Padding(20)
            };
            Controls.Add(panel);

            PictureBox pb = new PictureBox
            {
                Size = new Size(300, 200),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            string imgPath = Path.Combine(Application.StartupPath, "Images", _paket.GambarPath);
            if (File.Exists(imgPath)) pb.Image = Image.FromFile(imgPath);

            DTP = new DateTimePicker
            {
                MinDate = DateTime.Today,
                Format = DateTimePickerFormat.Short
            };

            CBJadwal = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
            CBJadwal.Items.AddRange(new string[] { "Siang", "Malam" });

            CBMetode = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
            CBMetode.Items.AddRange(new string[] { "Bank Transfer", "QRIS" });

            Button btnPesan = new Button
            {
                Text = "Konfirmasi Pemesanan",
                AutoSize = true,
                BackColor = Color.ForestGreen,
                ForeColor = Color.White
            };
            btnPesan.Click += BtnPesan_Click;

            panel.Controls.AddRange(new Control[]
            {
                new Label { Text = $"🌍 {_paket.Nama}", Font = new Font("Segoe UI", 16, FontStyle.Bold), AutoSize = true },
                pb,
                new Label { Text = "📅 Tanggal Keberangkatan:", AutoSize = true },
                DTP,
                new Label { Text = "⏰ Jadwal Keberangkatan:", AutoSize = true },
                CBJadwal,
                new Label { Text = "💳 Metode Pembayaran:", AutoSize = true },
                CBMetode,
                btnPesan
            });
        }

        private void BtnPesan_Click(object sender, EventArgs e)
        {
            if (CBJadwal.SelectedIndex == -1 || CBMetode.SelectedIndex == -1)
            {
                TampilkanPesan("Harap pilih jadwal dan metode pembayaran!");
                return;
            }

            PemesananModels model = new PemesananModels
            {
                UserId = _userId,
                PaketId = _paket.Id,
                GuideId = _paket.GuideId,
                TanggalKeberangkatan = DTP.Value,
                JadwalKeberangkatan = CBJadwal.SelectedItem.ToString(),
                MetodePembayaran = CBMetode.SelectedItem.ToString()
            };

            _presenter.SimpanPemesanan(model);
            if (model.MetodePembayaran == "Bank Transfer")
            {
                V_TFBANK tfBank = new V_TFBANK(_paket.Harga);
                tfBank.ShowDialog();
            }
            else if (model.MetodePembayaran == "QRIS")
            {
                V_QRIS qris = new V_QRIS(_paket.Harga);
                qris.ShowDialog();
            }
        }

        public void TampilkanPesan(string pesan)
        {
            MessageBox.Show(pesan, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void TutupForm()
        {
            this.Close();
        }
        public void PerbaruiRiwayat(List<PemesananModels> pemesanans)
        {
            // Untuk saat ini bisa kosong, atau tampilkan di konsol/log
            Console.WriteLine($"📦 Total data pemesanan: {pemesanans.Count}");
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            V_DetailPaketTrips detailForm = new V_DetailPaketTrips(_userId, _paket);
            detailForm.Show();
            this.Hide();
        }
    }
}
