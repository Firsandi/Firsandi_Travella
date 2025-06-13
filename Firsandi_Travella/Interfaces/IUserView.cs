using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Interfaces
{
    public interface IUserView
    {
        string Nama { get; }
        string Email { get; }
        string Nomor { get; }
        string Username { get; }
        string Password { get; }

        void ShowError(string message);
        void ShowSuccess(string message);

    }
}
