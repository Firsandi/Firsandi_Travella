using Firsandi_Travella.Views;
using Firsandi_Travella.Views.V_Admin;
using Firsandi_Travella.Views.V_Users;


namespace Firsandi_Travella
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new V_PaketTripUser());
            //Application.Run(new V_Halaman_Awal());
            //Application.Run(new V_PaketTripUser());
            Application.Run(new V_HalamanAwal());
            //Application.Run(new V_PaketTripUser());
        }
    }
}