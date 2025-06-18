using Firsandi_Travella.Database;
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
    public partial class V_PemesananTrips : Form
    {
        private PaketTripModels _paket;
        private DateTimePicker DTPKeberangkatan;
        private ComboBox CBJadwal, CBMetodePembayaran;
        private Button BtnPesan;

        public V_PemesananTrips(int paketId)
        {
            InitializeComponent();

            // 🔥 Ambil data paket berdasarkan ID dari repository
            PaketTripRepository repo = new PaketTripRepository();
            _paket = repo.AmbilPaketTripById(paketId);

            if (_paket == null)
            {
                MessageBox.Show("Paket tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            this.Text = "🛫 Pemesanan Trip";
            this.Size = new Size(950, 580);
            this.StartPosition = FormStartPosition.CenterScreen;

            FlowLayoutPanel flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Padding = new Padding(10)
            };
            this.Controls.Add(flowPanel);

            Panel card = new Panel
            {
                Size = new Size(860, 400),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                Padding = new Padding(10)
            };

            PictureBox pbGambar = new PictureBox
            {
                Size = new Size(300, 200),
                Location = new Point(10, 50),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            string imagePath = Path.Combine(Application.StartupPath, "Images", _paket.GambarPath);
            if (File.Exists(imagePath))
                pbGambar.Image = Image.FromFile(imagePath);

            Label lblJudul = new Label
            {
                Text = $"🌍 {_paket.Nama}",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblHarga = new Label
            {
                Text = $"💰 Harga: Rp {_paket.Harga:N0}",
                Font = new Font("Segoe UI", 14),
                Location = new Point(320, 50),
                AutoSize = true
            };

            Label lblTanggal = new Label
            {
                Text = "📅 Pilih Tanggal Keberangkatan:",
                Location = new Point(320, 100),
                AutoSize = true
            };

            DTPKeberangkatan = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                MinDate = DateTime.Today,
                Location = new Point(545, 95)
            };

            Label lblJadwal = new Label
            {
                Text = "⏰ Pilih Jadwal Keberangkatan:",
                Location = new Point(320, 150),
                AutoSize = true
            };

            CBJadwal = new ComboBox
            {
                Location = new Point(535, 145),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            CBJadwal.Items.AddRange(new string[] { "Siang", "Malam" });

            Label lblMetode = new Label
            {
                Text = "💳 Pilih Metode Pembayaran:",
                Location = new Point(320, 200),
                AutoSize = true
            };

            CBMetodePembayaran = new ComboBox
            {
                Location = new Point(527, 195),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            CBMetodePembayaran.Items.AddRange(new string[] { "Transfer Bank", "QRIS" });

            BtnPesan = new Button
            {
                Text = "✅ Konfirmasi Pemesanan",
                Location = new Point(320, 300),
                Size = new Size(200, 40),
                BackColor = Color.ForestGreen,
                ForeColor = Color.White
            };

            BtnPesan.Click += (sender, e) =>
            {
                if (CBJadwal.SelectedIndex == -1 || CBMetodePembayaran.SelectedIndex == -1)
                {
                    MessageBox.Show("Harap pilih jadwal keberangkatan dan metode pembayaran!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime tanggalBooking = DTPKeberangkatan.Value;
                string jadwalKeberangkatan = CBJadwal.SelectedItem.ToString();
                string metodePembayaran = CBMetodePembayaran.SelectedItem.ToString();

                MessageBox.Show($"✅ Pemesanan Berhasil!\nTanggal: {tanggalBooking.ToShortDateString()}\nJadwal: {jadwalKeberangkatan}\nMetode: {metodePembayaran}",
                                "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            };

            card.Controls.Add(pbGambar);
            card.Controls.Add(lblJudul);
            card.Controls.Add(lblHarga);
            card.Controls.Add(lblTanggal);
            card.Controls.Add(DTPKeberangkatan);
            card.Controls.Add(lblJadwal);
            card.Controls.Add(CBJadwal);
            card.Controls.Add(lblMetode);
            card.Controls.Add(CBMetodePembayaran);
            card.Controls.Add(BtnPesan);

            flowPanel.Controls.Add(card);
        }
    }
}
