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
using Travella_TA.Views;

namespace Firsandi_Travella.Views.V_Admin
{
    public partial class V_KelolaPaketTrip : Form, IPaketTripView
    {
        private readonly PaketTripPresenter _presenter;
        private FlowLayoutPanel flowLayoutPanelTrips;

        public V_KelolaPaketTrip()
        {
            InitializeComponent();

            flowLayoutPanelTrips = new FlowLayoutPanel
            {
                Dock = DockStyle.None,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Size = new Size(800, 500),
                Location = new Point(400, 180)
            };

            this.Controls.Add(flowLayoutPanelTrips);

            _presenter = new PaketTripPresenter(this);
            _presenter.LoadPaketTrips();
        }

        public void TambahPaket_Click(object sender, EventArgs e)
        {
            V_TambahTrip tambahTrip = new V_TambahTrip();
            if (tambahTrip.ShowDialog() == DialogResult.OK)
            {
                _presenter.LoadPaketTrips();
            }
        }

        public void ShowPaketTrips(List<PaketTripModels> paketTrips)
        {
            flowLayoutPanelTrips.Controls.Clear();

            Console.WriteLine($"Total paket trip: {paketTrips.Count}");

            foreach (var trip in paketTrips)
            {
                Panel card = new Panel
                {
                    Size = new Size(600, 100),
                    BackColor = Color.FromArgb(173, 205, 255),
                    Padding = new Padding(10),
                    Margin = new Padding(15),
                    BorderStyle = BorderStyle.FixedSingle,

                };

                PictureBox pb = new PictureBox
                {
                    Width = 100,
                    Height = 100,
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                string imagePath = Path.Combine(Application.StartupPath, "Images", trip.GambarPath);
                if (File.Exists(imagePath))
                    pb.Image = Image.FromFile(imagePath);

                Label lblNama = new Label
                {
                    Text = trip.Nama,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(110, 10)
                };

                Label lblHarga = new Label
                {
                    Text = $"Rp. {trip.Harga:N0}",
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true,
                    Location = new Point(110, 40)
                };

                Button btnEdit = new Button
                {
                    Text = "Edit",
                    Location = new Point(450, 20),
                    AutoSize = true,
                    Tag = trip

                };
                btnEdit.Click += BtnEdit_Click;

                Button btnDelete = new Button
                {
                    Text = "🗑",
                    Location = new Point(520, 20),
                    AutoSize = true,
                    Tag = trip
                };
                btnDelete.Click += BtnDelete_Click;

                card.Controls.Add(pb);
                card.Controls.Add(lblNama);
                card.Controls.Add(lblHarga);
                card.Controls.Add(btnEdit);
                card.Controls.Add(btnDelete);


                flowLayoutPanelTrips.Controls.Add(card);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var trip = (PaketTripModels)((Button)sender).Tag;
            EditPaketTrip editTrip = new EditPaketTrip(trip, _presenter);

            if (editTrip.ShowDialog() == DialogResult.OK)
            {
                _presenter.LoadPaketTrips();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var trip = (PaketTripModels)((Button)sender).Tag;
            var confirm = MessageBox.Show($"Yakin hapus trip {trip.Nama}?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _presenter.HapusPaketTrip(trip.Id);
                _presenter.LoadPaketTrips();
            }
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TambahPaket_Click_1(object sender, EventArgs e)
        {
            V_TambahTrip v_TambahTrip = new V_TambahTrip();
            v_TambahTrip.Show();
            this.Hide();
        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin v_DashboardAdmin = new V_DashboardAdmin();
            v_DashboardAdmin.Show();
            this.Hide();
        }



        private void Kembali_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin v_DashboardAdmin = new V_DashboardAdmin();
            v_DashboardAdmin.Show();
            this.Hide();
        }

        private void Beranda_Click_1(object sender, EventArgs e)
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
