using Firsandi_Travella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Interfaces
{
    public interface ITransaksiView
    {
        void ShowSuccess(string message);
        void ShowError(string message);
        void TampilkanRiwayatTransaksi(List<TransaksiModels> data);
        void TampilkanTransaksiAdmin(List<TransaksiModels> data);
    }
}
