using Firsandi_Travella.Database;
using Firsandi_Travella.Interfaces;
using Firsandi_Travella.Models;

namespace Firsandi_Travella.Presenter
{
    public class TransaksiPresenter
    {
        private readonly ITransaksiView _view;
        private readonly TransaksiRepository _repo;

        public TransaksiPresenter(ITransaksiView view)
        {
            _view = view;
            _repo = new TransaksiRepository();
        }
        public void KonfirmasiTransaksi(int transaksiId)
        {
            bool sukses = _repo.UpdateStatusPembayaran(transaksiId, "Berhasil");
            if (sukses)
            {
                _view.ShowSuccess("Transaksi berhasil dikonfirmasi.");
                TampilkanSemuaTransaksiAdmin(); // Refresh data
            }
            else
                _view.ShowError("Gagal mengkonfirmasi transaksi.");
        }

        public void BatalkanPemesanan(int pemesananId)
        {
            bool sukses = _repo.HapusPemesanan(pemesananId);
            if (sukses)
                _view.ShowSuccess("Pemesanan berhasil dibatalkan.");
            else
                _view.ShowError("Gagal membatalkan pemesanan.");
        }

        public void SubmitTransaksi(TransaksiModels transaksi)
        {
            bool sukses = _repo.SimpanTransaksi(transaksi);
            if (sukses)
                _view.ShowSuccess("Pembayaran berhasil dicatat.");
            else
                _view.ShowError("Gagal mencatat transaksi.");
        }

        public void TampilkanRiwayatUser(int userId)
        {
            var data = _repo.GetRiwayatUser(userId);
            _view.TampilkanRiwayatTransaksi(data);
        }

        public void TampilkanSemuaTransaksiAdmin()
        {
            var data = _repo.GetSemuaTransaksi();
            _view.TampilkanTransaksiAdmin(data);
        }
    }
}
