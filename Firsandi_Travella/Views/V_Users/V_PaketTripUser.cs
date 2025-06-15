
using Firsandi_Travella.Interfaces;
using Firsandi_Travella.Models;
using Firsandi_Travella.Presenter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Firsandi_Travella.Views.V_Users
{
    public partial class V_PaketTripUser : Form, IPaketTripUserView
    {
        private PaketTripPresenter _presenter;
        private FlowLayoutPanel flowLayoutPanelTrips;
        public V_PaketTripUser()
        {
            InitializeComponent();
            Label lblJudul = new Label
            {
                Text = "Daftar Paket Trip",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 30, 30),
                AutoSize = true,
                Location = new Point(250, 90) // Disesuaikan dengan layout kamu
            };

            flowLayoutPanelTrips = new FlowLayoutPanel
            {
                Dock = DockStyle.None,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                Size = new Size(800, 500),
                Location = new Point(350, 180)
            };

            this.Controls.Add(lblJudul);
            this.Controls.Add(flowLayoutPanelTrips);

            _presenter = new PaketTripPresenter(this);
            _presenter.LoadPaketTrips();
        }
        
        public void ShowPaketTrips(List<PaketTripModels> paketTrips)
        {
            flowLayoutPanelTrips.Controls.Clear();
            Console.WriteLine($"Total paket trip: {paketTrips.Count}");

            foreach (var trip in paketTrips)
            {
                Panel card = new Panel
                {

                    Size = new Size(700, 100),
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

                Button btnLihatDetail = new Button
                {
                    Text = "Lihat Detail",
                    Location = new Point(580, 35),
                    Size = new Size(100, 30),
                    Tag = trip
                };
                btnLihatDetail.Click += (sender, e) => _presenter.TampilkanDetailPaket(trip.Id);

                card.Controls.Add(pb);
                card.Controls.Add(lblNama);
                card.Controls.Add(lblHarga);
                card.Controls.Add(btnLihatDetail);

                flowLayoutPanelTrips.Controls.Add(card);
            }

        }

        public void ShowDetailPaket(PaketTripModels paket)
        {
            V_DetailTrips detailForm = new V_DetailTrips(paket);
            detailForm.ShowDialog();
        }

        //private void LihatDetailTrip(PaketTripModels paket)
        //{
        //    V_DetailTrips detailForm = new V_DetailTrips(paket);
        //    detailForm.ShowDialog();
        //}

        private void PesanTrip(PaketTripModels paket)
        {
            V_Pemesanan pemesananForm = new V_Pemesanan(paket);
            pemesananForm.ShowDialog();
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}

