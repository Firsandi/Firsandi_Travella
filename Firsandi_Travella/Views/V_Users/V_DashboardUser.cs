using Firsandi_Travella.Views.V_Users;
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
    public partial class V_DashboardUser : Form
    {
        public V_DashboardUser()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void deskripsiTravella_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MulaiPerjalanan_Click(object sender, EventArgs e)
        {
            V_PaketTripUser v_PaketTripUser = new V_PaketTripUser();
            v_PaketTripUser.Show();
            this.Hide();
        }

        private void btnRiwayatPemesanan_Click(object sender, EventArgs e)
        {
            V_RiwayatUser v_RiwayatUser = new V_RiwayatUser();
            v_RiwayatUser.Show();
            this.Hide();
        }

        private void btnPaketTrip_Click(object sender, EventArgs e)
        {
            V_PaketTripUser v_PaketTripUser = new V_PaketTripUser();
            v_PaketTripUser.Show();
            this.Hide();
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            V_DashboardUser v_DashboardUser = new V_DashboardUser();
            v_DashboardUser.Show();
            this.Hide();
        }
    }
}
