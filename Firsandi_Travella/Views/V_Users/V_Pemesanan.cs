using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firsandi_Travella.Models;

namespace Firsandi_Travella.Views.V_Users
{
    public partial class V_Pemesanan : Form
    {
        private readonly PaketTripModels _trip;
        public V_Pemesanan(PaketTripModels trip)
        {
            InitializeComponent();
            _trip = trip;
            SetupForm();
            _trip = trip;
        }
        public void SetupForm()
        {
          
        }
    }
}
