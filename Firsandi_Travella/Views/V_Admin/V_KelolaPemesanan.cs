using Firsandi_Travella.Helper;
using Firsandi_Travella.Interfaces;
using Firsandi_Travella.Models;
using Firsandi_Travella.Presenter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Travella_TA.Views;

namespace Firsandi_Travella.Views.V_Admin
{
    public partial class V_KelolaPemesanan : Form, IPemesananKelolaView
    {
        private readonly KelolaPemesananPresenter _presenter;
        private FlowLayoutPanel flowPanel;

        public V_KelolaPemesanan()
        {
            InitializeComponent();
            this.Text = "Kelola Pemesanan";
            this.Size = new Size(1280, 720);

            this.flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.None,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Size = new Size(800, 500),
                Location = new Point(400, 180)
            };
            Controls.Add(this.flowPanel);

            _presenter = new KelolaPemesananPresenter(this);
            _presenter.LoadPemesanan();
        }

        public void ShowPemesanan(List<PemesananModels> list)
        {
            flowPanel.Controls.Clear();

            foreach (var item in list)
            {
                Panel card = new Panel
                {
                    Size = new Size(700, 100),
                    BackColor = Color.FromArgb(173, 205, 255),
                    Padding = new Padding(10),
                    Margin = new Padding(15),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblInfo = new Label
                {
                    Text = $"👤 {item.Username} | 📦 {item.Nama} | 🗓 {item.TanggalKeberangkatan:dd MMM yyyy}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label lblStatus = new Label
                {
                    Text = $"Status: {item.StatusPembayaran}",
                    ForeColor = item.StatusPembayaran == "Selesai" ? Color.Green : Color.DarkOrange,
                    Location = new Point(10, 40),
                    AutoSize = true
                };

                card.Controls.Add(lblInfo);
                card.Controls.Add(lblStatus);

                if (item.StatusPembayaran != "Selesai")
                {
                    Button btnKonfirmasi = new Button
                    {
                        Text = "✔ Konfirmasi",
                        Location = new Point(450, 20),
                        AutoSize = true,
                        Tag = item.PemesananId
                    };
                    btnKonfirmasi.Click += (s, e) =>
                    {
                        _presenter.Konfirmasi(item.PemesananId);
                    };

                    Button btnHapus = new Button
                    {
                        Text = "🗑 Hapus",
                        Location = new Point(570, 20),
                        AutoSize = true,
                        Tag = item.PemesananId
                    };
                    btnHapus.Click += (s, e) =>
                    {
                        if (MessageBox.Show("Yakin hapus pemesanan ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            _presenter.Hapus(item.PemesananId);
                        }
                    };

                    card.Controls.Add(btnKonfirmasi);
                    card.Controls.Add(btnHapus);
                }

                flowPanel.Controls.Add(card);
            }
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin v_DashboardAdmin = new V_DashboardAdmin();
            v_DashboardAdmin.Show();
            this.Hide();
        }

        private void PaketTrip_Click(object sender, EventArgs e)
        {
            V_KelolaPaketTrip kelolaPaketTrip = new V_KelolaPaketTrip();
            kelolaPaketTrip.Show();
            this.Hide();
        }

        private void Guide_Click(object sender, EventArgs e)
        {
            V_KelolaGuide v_KelolaGuide = new V_KelolaGuide();
            v_KelolaGuide.Show();
            this.Hide();
        }

        private void Transaksi_Click(object sender, EventArgs e)
        {
            V_KelolaPemesanan v_KelolaPemesanan = new V_KelolaPemesanan();
            v_KelolaPemesanan.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Yakin ingin logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                SessionManager.ClearSession();

                // Kembali ke halaman login
                new V_LoginAdmin().Show();
                this.Close(); // atau this.Hide();
            }
        }
    }
}
