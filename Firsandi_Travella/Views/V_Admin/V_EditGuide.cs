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

namespace Firsandi_Travella.Views.V_Admin
{
    public partial class V_EditGuide : Form, IGuideView
    {
        private readonly GuidePresenter _presenter;
        private GuideModels _guide;
        public V_EditGuide(GuideModels guide)
        {
            InitializeComponent();
            _presenter = new GuidePresenter(this);
            _guide = guide;

            // 🔥 Tampilkan data lama di input
            TBNama.Text = _guide.Nama;
            TBNomor.Text = _guide.Kontak;
        }

        private void Ubah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBNama.Text) || string.IsNullOrWhiteSpace(TBNomor.Text))
            {
                MessageBox.Show("Nama dan nomor telepon harus diisi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _guide.Nama = TBNama.Text;
            _guide.Kontak = TBNomor.Text;

            bool success = _presenter.UbahGuide(_guide);

            if (success)
            {
                MessageBox.Show("Guide berhasil diubah!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // 🔥 Pastikan hasil edit dikembalikan
                this.Close();
            }
            else
            {
                MessageBox.Show("Terjadi kesalahan saat mengubah guide.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
