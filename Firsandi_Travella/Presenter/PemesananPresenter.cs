using Firsandi_Travella.Database;
using Firsandi_Travella.Interfaces;
using Firsandi_Travella.Models;

namespace Firsandi_Travella.Presenter
{
    public class PemesananPresenter
    {
        private readonly IPemesananView _view;
        private readonly PemesananRepository _repo;

        public PemesananPresenter(IPemesananView view)
        {
            _view = view;
            _repo = new PemesananRepository();
        }

        public void LoadMetodePembayaran()
        {
            var metodeList = _repo.GetMetode();
            _view.TampilkanMetode(metodeList);
        }

        public void SubmitPemesanan(PemesananModels model)
        {
            bool sukses = _repo.SimpanPemesananLangsung(model);

            if (sukses)
                _view.ShowSuccess("Pemesanan berhasil dan otomatis dikonfirmasi.");
            else
                _view.ShowError("Gagal menyimpan pemesanan.");
        }

        public void AmbilDaftarBank(int metodeId)
        {
            var daftar = _repo.GetBankByMetode(metodeId);
            _view.TampilkanDaftarBank(daftar);
        }

    }
}
