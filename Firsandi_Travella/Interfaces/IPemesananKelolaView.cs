using Firsandi_Travella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Interfaces
{
    public interface IPemesananKelolaView
    {
        void ShowPemesanan(List<PemesananModels> data);
        void ShowMessage(string message);
    }
}
