using Firsandi_Travella.Interfaces;
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

namespace Firsandi_Travella.Views.V_Users
{
    public partial class V_LoginUserForm : Form, ILoginView
    {
        private readonly UserLoginPresenter _presenter;

        public V_LoginUserForm()
        {
            InitializeComponent();
            _presenter = new UserLoginPresenter(this);

        }
        public string Username => TBUsername.Text;
        public string Password => TBPassword.Text;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void OpenUserDashboard()
        {
            MessageBox.Show("Login berhasil! Menuju User Dashboard...");
            V_DashboardUser dashboardUser = new V_DashboardUser();
            dashboardUser.Show();
            this.Hide();
        }
        public void OpenAdminDashboard()
        {

        }

        private void LoginUser_Click(object sender, EventArgs e)
        {
            _presenter.LoginUser();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void balik_Click(object sender, EventArgs e)
        {
            V_Halaman_Awal awal = new V_Halaman_Awal();
            awal.Show();
            this.Hide();
        }

        private void TidakPunyaakun_Click(object sender, EventArgs e)
        {
            V_Register v_Register = new V_Register();
            v_Register.Show();
            this.Hide();
        }

        private void Tidakpunyakun_Click(object sender, EventArgs e)
        {
            V_Register v_Register = new V_Register();
            v_Register.Show();
            this.Hide();
        }
    }
}
