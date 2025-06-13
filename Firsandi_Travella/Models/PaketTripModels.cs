using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Models
{
    public class PaketTripModels
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public decimal Harga { get; set; }
        public string Deskripsi { get; set; }
        public int GuideId { get; set; } 
        public string GambarPath { get; set; }
    }
}
