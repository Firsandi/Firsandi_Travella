using Firsandi_Travella.Interfaces;
using Firsandi_Travella.Presenter;
using Firsandi_Travella.Views;
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
    public partial class V_Register : Form, IUserView

    {
        private RegisterPresenter _presenter;
        public V_Register()
        {
            InitializeComponent();
            _presenter = new RegisterPresenter(this);
        }

        public string Nama => TBNama.Text;
        public string Email => TBEmail.Text;
        public string Nomor => TBNomor.Text;
        public string Username => TBUsername.Text;
        public string Password => TBPassword.Text;

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void HasilRegister(bool success)
        {
            if (success)
            {
                MessageBox.Show("Registrasi Berhasil");
                V_LoginUserForm loginuser = new V_LoginUserForm();
                loginuser.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Registrasi Gagal, Silakan Coba Lagi");
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            V_LoginUserForm loginuser = new V_LoginUserForm();
            loginuser.Show();
            this.Hide();
        }

        private void Nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void Daftar_Click(object sender, EventArgs e)
        {
            _presenter.RegisterUser();
        }
    }
}
