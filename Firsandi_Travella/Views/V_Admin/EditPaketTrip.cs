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

namespace Firsandi_Travella.Views.V_Admin
{
    public partial class EditPaketTrip : Form
    {
        private PaketTripPresenter _presenter;
        private PaketTripModels _trip;
        private string GambarPath;

        public EditPaketTrip(PaketTripModels trip, PaketTripPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
            _trip = trip;
            LoadGuides();
            LoadTripData();
        }
        private void LoadGuides()
        {
            List<GuideModels> guides = _presenter.GetGuides();
            Console.WriteLine($"Jumlah guide yang ditemukan: {guides.Count}"); // 🔥 Debugging

            if (guides.Count == 0)
            {
                MessageBox.Show("Error: Tidak ada guide yang tersedia! Tambahkan guide terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CBGuide.DataSource = guides;
            CBGuide.DisplayMember = "Nama";
            CBGuide.ValueMember = "Id";
        }

        private void LoadTripData()
        {
            TBNama.Text = _trip.Nama;
            TBHarga.Text = _trip.Harga.ToString();
            TBDeskripsi.Text = _trip.Deskripsi;
            CBGuide.SelectedValue = _trip.GuideId;
            GambarPath = _trip.GambarPath;

            string imagePath = Path.Combine(Application.StartupPath, "Images", _trip.GambarPath);
            if (File.Exists(imagePath))
                MasukkanGambar.Image = Image.FromFile(imagePath);
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
                        Directory.CreateDirectory(imageFolder);
                    }

                    File.Copy(openFileDialog.FileName, Path.Combine(imageFolder, GambarPath), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal memuat gambar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Ubah_Click(object sender, EventArgs e)
        {
            try
            {
                _trip.Nama = TBNama.Text;
                _trip.Harga = decimal.TryParse(TBHarga.Text, out decimal h) ? h : 0;
                _trip.GuideId = (int)CBGuide.SelectedValue;
                _trip.Deskripsi = TBDeskripsi.Text;
                _trip.GambarPath = GambarPath;

                _presenter.UpdatePaketTrip(_trip);
                MessageBox.Show("Paket trip berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
