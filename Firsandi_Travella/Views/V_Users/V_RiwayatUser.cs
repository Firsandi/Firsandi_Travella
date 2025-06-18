using Firsandi_Travella.Helper;
using Firsandi_Travella.Models;
using Firsandi_Travella.Presenter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Travella_TA.Views;

namespace Firsandi_Travella.Views.V_Users
{
    public partial class V_RiwayatUser : Form
    {
        private readonly PemesananPresenter _presenter;
        private FlowLayoutPanel flowRiwayat;

        public V_RiwayatUser()
        {
            InitializeComponent();

            this.Text = "📋 Riwayat Pemesanan";
            this.Size = new Size(1280, 720);

            flowRiwayat = new FlowLayoutPanel
            {
                Dock = DockStyle.None,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Size = new Size(900, 520),
                Location = new Point(350, 160),
                Padding = new Padding(10)
            };

            this.Controls.Add(flowRiwayat);

            _presenter = new PemesananPresenter(null);
            LoadRiwayatUser();
        }

        private void LoadRiwayatUser()
        {
            flowRiwayat.Controls.Clear();
            int userId = SessionManager.UserId;

            var riwayat = _presenter.GetRiwayatPemesananUser(userId);

            foreach (var item in riwayat)
            {
                Panel card = new Panel
                {
                    Size = new Size(800, 100),
                    BackColor = Color.FromArgb(210, 230, 255),
                    Margin = new Padding(15),
                    Padding = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblNama = new Label
                {
                    Text = $"📦 {item.Nama}",
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label lblJadwal = new Label
                {
                    Text = $"🗓 {item.TanggalKeberangkatan:dd MMM yyyy} - {item.JadwalKeberangkatan}",
                    Location = new Point(10, 40),
                    AutoSize = true
                };

                Label lblMetode = new Label
                {
                    Text = $"💳 Metode: {item.MetodePembayaran}",
                    Location = new Point(10, 60),
                    AutoSize = true
                };

                Label lblStatus = new Label
                {
                    Text = $"📌 Status: {item.StatusPembayaran}",
                    ForeColor = item.StatusPembayaran == "Selesai" ? Color.Green : Color.OrangeRed,
                    Location = new Point(10, 80),
                    AutoSize = true
                };

                // ✅ Tambahkan tombol "Detail" hanya jika BELUM selesai
                if (item.StatusPembayaran != "Selesai")
                {
                    Button btnDetail = new Button
                    {
                        Text = "Detail",
                        Size = new Size(70, 30),
                        Location = new Point(700, 30),
                        Tag = item
                    };
                    btnDetail.Click += BtnDetail_Click;

                    card.Controls.Add(btnDetail); // ✅ hanya ditambahkan jika belum selesai
                }


                card.Controls.Add(lblNama);
                card.Controls.Add(lblJadwal);
                card.Controls.Add(lblMetode);
                card.Controls.Add(lblStatus);
                flowRiwayat.Controls.Add(card);
            }
        }

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var data = (PemesananModels)btn.Tag;

            if (data.MetodePembayaran == "Bank Transfer")
            {
                new V_TFBANK(data.NominalPembayaran).ShowDialog();
            }
            else if (data.MetodePembayaran == "QRIS")
            {
                new V_QRIS(data.NominalPembayaran).ShowDialog();
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRiwayatPemesanan_Click(object sender, EventArgs e)
        {
            V_RiwayatUser v_RiwayatUser = new V_RiwayatUser();
            v_RiwayatUser.Show();
            this.Hide();
        }

        private void PaketTrip_Click(object sender, EventArgs e)
        {
            V_PaketTripUser v_PaketTripUser = new V_PaketTripUser();
            v_PaketTripUser.Show();
            this.Hide();
        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            V_DashboardUser _DashboardUser = new V_DashboardUser();
            _DashboardUser.Show();
            this.Hide();
        }
    }
}
