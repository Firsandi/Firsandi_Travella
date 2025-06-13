using Firsandi_Travella.Database;
using Firsandi_Travella.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Presenter
{
    internal class UserLoginPresenter
    {
        private readonly ILoginView _view;
        private readonly UserRepository _repository;

        public UserLoginPresenter(ILoginView view)
        {
            _view = view;
            _repository = new UserRepository();
        }

        public void LoginUser()
        {
            bool isValid = _repository.ValidasiUser(_view.Username, _view.Password);
            if (isValid)
                _view.OpenUserDashboard();
            else
                _view.ShowError("Login gagal! Periksa kembali username dan password Anda.");
        }
    }

}
