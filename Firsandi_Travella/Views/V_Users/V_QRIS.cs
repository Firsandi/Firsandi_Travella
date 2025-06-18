using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firsandi_Travella.Views.V_Users
{
    public partial class V_QRIS : Form
    {
        private decimal _nominal;
        public V_QRIS(decimal nominal)
        {
            InitializeComponent();
            _nominal = nominal;
            Harga.Text = $"Rp {_nominal:N0}";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Harga_Click(object sender, EventArgs e)
        {
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            V_RiwayatUser v_RiwayatUser = new V_RiwayatUser();
            v_RiwayatUser.Show();
            this.Hide();
        }
    }
}
