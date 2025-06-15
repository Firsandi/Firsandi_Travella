using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Models
{
    public class TransaksiModels
    {
        public int TransaksiId { get; set; }
        public int UserId { get; set; }
        public int PemesananId { get; set; }
        public int MetodeId { get; set; }
        public decimal Jumlah { get; set; }
        public string Status { get; set; } = "Berhasil";
        public DateTime TanggalPembayaran { get; set; }

        public string NamaUser { get; set; }
        public string NamaPaket { get; set; }
        public string Metode { get; set; }

    }
}
