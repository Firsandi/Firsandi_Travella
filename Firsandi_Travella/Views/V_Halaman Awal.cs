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
    public partial class V_Halaman_Awal : Form
    {
        public V_Halaman_Awal()
        {
            InitializeComponent();
        }
        private void LoginAdmin_Click(object sender, EventArgs e)
        {
            V_LoginAdmin v_LoginAdmin = new V_LoginAdmin();
            v_LoginAdmin.Show();
            this.Hide();
        }

        private void LoginUser_Click(object sender, EventArgs e)
        {
            V_LoginUserForm v_LoginUser = new V_LoginUserForm();
            v_LoginUser.Show();
            this.Hide();
        }
    }
}
