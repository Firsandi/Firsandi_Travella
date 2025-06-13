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
using Travella_TA.Views.V_Admin;

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
            V_Kelola_Transaksi kelolaTransaksi = new V_Kelola_Transaksi();
            kelolaTransaksi.Show();
            this.Hide();
        }
    }
}
