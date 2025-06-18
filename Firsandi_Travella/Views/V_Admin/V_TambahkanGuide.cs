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
    public partial class V_TambahkanGuide : Form, IGuideView
    {
        private readonly GuidePresenter _presenter;
        public V_TambahkanGuide()
        {
            InitializeComponent();
            _presenter = new GuidePresenter(this);

        }

        private void TombolTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBNama.Text) || string.IsNullOrWhiteSpace(TBNomor.Text))
            {
                MessageBox.Show("Nama dan kontak harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GuideModels guide = new GuideModels
            {
                Nama = TBNama.Text,
                Kontak = TBNomor.Text
            };

            _presenter.TambahGuide(guide);
            MessageBox.Show("Guide berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            V_KelolaGuide v_KelolaGuide = new V_KelolaGuide();
            v_KelolaGuide.Show();
            this.Hide();

        }
        public void ShowGuides(List<GuideModels> guides)
        {

        }
        public void ShowError(string message)
        {

        }
        public void ShowSuccess(string message)
        {

        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            V_KelolaGuide v_KelolaGuide = new V_KelolaGuide();
            v_KelolaGuide.Show();
            this.Hide();
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
