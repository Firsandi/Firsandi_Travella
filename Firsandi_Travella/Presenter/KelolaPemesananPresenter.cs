using Firsandi_Travella.Database;
using Firsandi_Travella.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Presenter
{
    public class KelolaPemesananPresenter
    {
        private readonly IPemesananKelolaView _view;
        private readonly PemesananRepository _repo;

        public KelolaPemesananPresenter(IPemesananKelolaView view)
        {
            _view = view;
            _repo = new PemesananRepository();
        }

        public void LoadPemesanan()
        {
            var data = _repo.GetSemuaPemesanan();
            _view.ShowPemesanan(data);
        }

        public void Konfirmasi(int id)
        {
            _repo.UpdateStatusPembayaran(id, "Selesai");
            _view.ShowMessage("✔ Dikonfirmasi.");
            LoadPemesanan();
        }

        public void Hapus(int id)
        {
            _repo.HapusPemesanan(id);
            _view.ShowMessage("🗑 Dihapus.");
            LoadPemesanan();
        }
    }

}
