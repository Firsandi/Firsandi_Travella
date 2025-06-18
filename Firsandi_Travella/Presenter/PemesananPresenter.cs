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

        public void SimpanPemesanan(PemesananModels pemesanan)
        {
            int pemesananId = _repo.SimpanPemesanan(pemesanan);
            if (pemesananId > 0)
                _view.TampilkanPesan($"✅ Pemesanan Berhasil! ID: {pemesananId}");
            else
                _view.TampilkanPesan("❌ Pemesanan Gagal!");
        }


        public List<PemesananModels> GetRiwayatPemesananUser(int userId)
        {
            return _repo.GetPemesananByUser(userId); // method ini akan kita buat juga kalau belum
        }



    }
}
