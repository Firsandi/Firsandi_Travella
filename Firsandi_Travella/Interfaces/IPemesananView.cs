using System;
using Firsandi_Travella.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firsandi_Travella.Models;

namespace Firsandi_Travella.Interfaces
{
    public interface IPemesananView
    {
        void TampilkanPesan(string pesan); // ✅ Menampilkan pesan ke user
        void PerbaruiRiwayat(List<PemesananModels> pemesanans); // ✅ Menampilkan daftar pemesanan
    }
    //public interface IPemesananView
    //{

    //    //void TampilkanMetode(List<MetodePembayaranModels> metodeList);
    //    //void TampilkanDaftarBank(List<BankTransferModels> bankList);
    //    //void ShowSuccess(string message);
    //    //void ShowError(string message);
    //    //void CloseForm();
    //}
}
