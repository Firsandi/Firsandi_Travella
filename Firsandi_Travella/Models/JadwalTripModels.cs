using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Models
{
    public class JadwalTrip
    {
        public int JadwalId { get; set; }
        public int PaketId { get; set; }
        public TimeSpan JamBerangkat { get; set; }
        public TimeSpan JamPulang { get; set; }
    }
}
