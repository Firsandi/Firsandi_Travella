using Firsandi_Travella.Database;
using Firsandi_Travella.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Presenter
{
    public class RegisterPresenter
    {
        private readonly IUserView _view;
        private readonly UserRepository _repository;

        public RegisterPresenter(IUserView view)
        {
            _view = view;
            _repository = new UserRepository();
        }

        public void RegisterUser()
        {
            bool success = _repository.SimpanUser(_view.Nama, _view.Email, _view.Nomor, _view.Username, _view.Password);
            if (success)
                _view.ShowSuccess("Registrasi berhasil! Silakan login.");
            else
                _view.ShowError("Registrasi gagal! Silakan coba lagi.");
        }
    }

}
