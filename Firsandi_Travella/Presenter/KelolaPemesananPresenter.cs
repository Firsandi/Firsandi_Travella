using Firsandi_Travella.Database;
using Firsandi_Travella.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Presenter
{
    //public class PemesananAdminPresenter
    //{
    //    private readonly IPemesananView _view;
    //    private readonly PemesananRepository _repository;

    //    public PemesananAdminPresenter(IPemesananView view)
    //    {
    //        _view = view;
    //        _repository = new PemesananRepository();
    //    }

    //    public void LoadData()
    //    {
    //        var daftar = _repository.GetPemesananPending();
    //        _view.TampilkanDaftar(daftar);
    //    }

    //    public void Konfirmasi(int id)
    //    {
    //        bool result = _repository.UpdateStatusPemesanan(id, "disetujui");
    //        if (result) _view.ShowSuccess("Pemesanan disetujui.");
    //        else _view.ShowError("Gagal menyetujui.");
    //        LoadData();
    //    }
    //}
}
