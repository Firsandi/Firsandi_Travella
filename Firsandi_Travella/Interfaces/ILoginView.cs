using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Interfaces
{
    internal interface ILoginView
    {
        string Username { get; }
        string Password { get; }
        void ShowError(string message);
        void OpenAdminDashboard();
        void OpenUserDashboard();
    }
}
