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
    public partial class V_TambahTrip : Form, IPaketTripView
    {
        private PaketTripPresenter _presenter;
        //private string GambarPath;
        public V_TambahTrip()
        {
            InitializeComponent();
            _presenter = new PaketTripPresenter(this);
            LoadGuides();
        }

        private void LoadGuides()
        {
            List<GuideModels> guides = _presenter.GetGuides();
            if (guides.Count == 0)
            {
                MessageBox.Show("Tidak ada guide yang tersedia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CBGuide.DataSource = guides;
            CBGuide.DisplayMember = "Nama";
            CBGuide.ValueMember = "Id";
        }
        public string NamaPaket => TBNama.Text;
        public decimal Harga => decimal.TryParse(TBHarga.Text, out decimal h) ? h : 0;
        public int GuideId => (int)CBGuide.SelectedValue;
        public string Deskripsi => TBDeskripsi.Text;
        public string GambarPath { get; private set; }

        public void ShowPaketTrips(List<PaketTripModels> paketTrips)
        {

        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            PaketTripModels paket = new PaketTripModels
            {
                Nama = NamaPaket,
                Harga = Harga,
                GuideId = GuideId,
                Deskripsi = Deskripsi,
                GambarPath = GambarPath
            };
            _presenter.TambahPaketTrip(paket);
        }

        private void MasukkanGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png;*.jpeg"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        MasukkanGambar.Image = Image.FromStream(fs);
                    }

                    GambarPath = Path.GetFileName(openFileDialog.FileName);

                    string imageFolder = Path.Combine(Application.StartupPath, "Images");
                    if (!Directory.Exists(imageFolder))
                    {
                        Directory.CreateDirectory(imageFolder); // 🔥 Buat folder jika belum ada
                    }

                    File.Copy(openFileDialog.FileName, Path.Combine(imageFolder, GambarPath), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memuat gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TBHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void Beranda_Click(object sender, EventArgs e)
        {
            V_DashboardAdmin v_DashboardAdmin = new V_DashboardAdmin();
            v_DashboardAdmin.Show();
            this.Hide();
        }

        private void Booking_Click(object sender, EventArgs e)
        {

        }

        private void Guide_Click(object sender, EventArgs e)
        {

        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            V_KelolaPaketTrip kelolaPaketTrip = new V_KelolaPaketTrip();
            kelolaPaketTrip.Show();
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

        private void Guide_Click_1(object sender, EventArgs e)
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
