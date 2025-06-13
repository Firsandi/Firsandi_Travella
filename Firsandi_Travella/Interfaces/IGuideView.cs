using Firsandi_Travella.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firsandi_Travella.Interfaces
{
    public interface IGuideView
    {
        void ShowGuides(List<GuideModels> guides);
        void ShowError(string message);
        void ShowSuccess(string message);
    }
}
