using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firsandi_Travella.Interfaces;
using Firsandi_Travella.Views;
using Firsandi_Travella.Presenter;

namespace Travella_TA.Views
{
    internal partial class V_LoginAdmin : Form, ILoginView
    {
        private AdminLoginPresenter _presenter;
        public V_LoginAdmin()
        {
            InitializeComponent();
            _presenter = new AdminLoginPresenter(this);
        }

        public string Username => TBUsername.Text;
        public string Password => TBPassword.Text;
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void OpenUserDashboard()
        {
        }
        public void OpenAdminDashboard()
        {
            MessageBox.Show("Login berhasil! Menuju Admin Dashboard...");
            V_DashboardAdmin dashboardAdmin = new V_DashboardAdmin();
            dashboardAdmin.Show();
            this.Hide();
        }

     

        

        private void Login_Click(object sender, EventArgs e)
        {
            _presenter.LoginAdmin();
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            V_Halaman_Awal awal = new V_Halaman_Awal();
            awal.Show();
            this.Hide();
        }
    }
}
