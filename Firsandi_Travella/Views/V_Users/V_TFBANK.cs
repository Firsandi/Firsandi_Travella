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
    public partial class V_TFBANK : Form
    {
        private decimal _nominal;
        public V_TFBANK(decimal nominal)
        {
            InitializeComponent();
            _nominal = nominal;
            Harga.Text = $"Rp {_nominal:N0}";

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
