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
using Travella_TA.Views;

namespace Firsandi_Travella.Views
{
    public partial class V_HalamanAwal : Form
    {
        public V_HalamanAwal()
        {
            InitializeComponent();
        }

        private void LoginUser_Click(object sender, EventArgs e)
        {
            V_LoginUserForm v_LoginUserForm = new V_LoginUserForm();
            v_LoginUserForm.Show();
            this.Hide();
        }

        private void LoginAdmin_Click(object sender, EventArgs e)
        {
            V_LoginAdmin v_LoginAdmin = new V_LoginAdmin();
            v_LoginAdmin.Show();
            this.Hide();
        }
    }
}
