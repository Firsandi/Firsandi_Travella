using Firsandi_Travella.Helper;
using Firsandi_Travella.Views.V_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travella_TA.Views
{
    public partial class V_DashboardAdmin : Form
    {
        public V_DashboardAdmin()
        {
            InitializeComponent();
        }

        private void PaketTrip_Click_1(object sender, EventArgs e)
        {
            V_KelolaPaketTrip kelolaPaketTrip = new V_KelolaPaketTrip();
            kelolaPaketTrip.Show();
            this.Hide();
        }

        private void Transaksi_Click_1(object sender, EventArgs e)
        {
            V_KelolaPemesanan kelolaTransaksi = new V_KelolaPemesanan();
            kelolaTransaksi.Show();
            this.Hide();
        }

        private void Guide_Click(object sender, EventArgs e)
        {
            V_KelolaGuide kelolaGuide = new V_KelolaGuide();
            kelolaGuide.Show();
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
