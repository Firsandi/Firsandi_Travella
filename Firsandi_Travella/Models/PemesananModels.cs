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
        public int PaketId { get; set; }
        public int GuideId { get; set; }
        public int MetodeId { get; set; }
        public DateTime TanggalKeberangkatan { get; set; }
        public DateTime TanggalPemesanan { get; set; }
        public string StatusPemesanan { get; set; } = "Berhasil";
    }
}

