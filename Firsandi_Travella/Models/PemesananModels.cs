using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Models
{
    public class PemesananModels
    {
        public int PemesananId { get; set; }
        public int UserId { get; set; }
        public int? GuideId { get; set; } // ✅ Bisa `NULL`
        public int PaketId { get; set; }
        public DateTime TanggalPemesanan { get; set; } = DateTime.Now;
        public DateTime TanggalKeberangkatan { get; set; }
        public string JadwalKeberangkatan { get; set; } // ✅ "Siang" atau "Malam"
        public string MetodePembayaran { get; set; } // ✅ "Bank Transfer" atau "QRIS"
        public string StatusPembayaran { get; set; } = "Menunggu Pembayaran"; // ✅ Status awal
        public decimal NominalPembayaran { get; set; } // ✅ Simpan nominal pembayaran jika diperlukan
        public string Nama { get; set; } // ✅ Nama paket untuk tampilan
        public string Username { get; set; } // ✅ Nama user untuk tampilan
    }
}

