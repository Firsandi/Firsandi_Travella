using Firsandi_Travella.Database;
using Firsandi_Travella.Interfaces;
using Firsandi_Travella.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Presenter
{
    public class PaketTripPresenter
    {
        private readonly IPaketTripView _view;
        private readonly PaketTripRepository _repository;
        private GuideRepository _guideRepository;
        public PaketTripPresenter(IPaketTripView view)
        {
            _view = view;
            _repository = new PaketTripRepository();
            _guideRepository = new GuideRepository();

        }

        public void LoadPaketTrips()
        {
            List<PaketTripModels> paketTrips = _repository.AmbilSemuaPaketTrip();
            _view.ShowPaketTrips(paketTrips);
        }

        public void TambahPaketTrip(PaketTripModels paket)
        {
            if (_repository.TambahPaketTrip(paket))
                _view.ShowSuccess("Paket Trip berhasil ditambahkan!");
            else
                _view.ShowError("Gagal menambahkan Paket Trip.");
        }

        public void HapusPaketTrip(int id)
        {
            if (_repository.HapusPaketTrip(id))
                _view.ShowSuccess("Paket Trip berhasil dihapus!");
            else
                _view.ShowError("Gagal menghapus Paket Trip.");
        }
      

        public List<GuideModels> GetGuides()
        {
            return _guideRepository.GetGuides();
        }
        public void UpdatePaketTrip(PaketTripModels trip)
        {
            _repository.UpdatePaketTrip(trip); // 🔥 Pastikan Presenter memanggil Repository
        }

        public void TampilkanDetailPaket(int id)
        {
            PaketTripModels detail = _repository.AmbilPaketTripById(id);

            if (detail != null && _view is IPaketTripUserView userView)
            {
                userView.ShowDetailPaket(detail);
            }
            else
            {
                _view.ShowError("Paket Trip tidak ditemukan.");
            }
        }
    }
}
   