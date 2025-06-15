using Firsandi_Travella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Interfaces
{
    public interface IPaketTripView
    {
        void ShowPaketTrips(List<PaketTripModels> paketTrips);
        void ShowError(string message);
        void ShowSuccess(string message);
        //void ShowDetailPaket(PaketTripModels paket);
    }
    //public interface IPaketTripUserView : IPaketTripView
    //{
    //    void ShowDetailPaket(PaketTripModels paket);
    //}
    //public interface IPaketTripAdminView : IPaketTripView
    //{
    //    void TambahPaket_Click(object sender, EventArgs e);
    //    void HapusPaket_Click(object sender, EventArgs e);
    //    void UpdatePaket_Click(object sender, EventArgs e);
    //    //void TampilkanDetailPaket(int id);
    //}
}
