using Firsandi_Travella.Database.Firsandi_Travella.Database;
using Firsandi_Travella.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Presenter
{
    internal class AdminLoginPresenter
    {
        private readonly ILoginView _view;
        private readonly AdminRepository _repository;

        public AdminLoginPresenter(ILoginView view)
        {
            _view = view;
            _repository = new AdminRepository();
        }

        public void LoginAdmin()
        {
            bool isValid = _repository.ValidasiAdmin(_view.Username, _view.Password);
            if (isValid)
                _view.OpenAdminDashboard();
            else
                _view.ShowError("Login gagal! Periksa kembali username dan password Anda.");
        }

    }
}
