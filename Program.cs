using CourtManagement;
using CourtManagement.Login;
using System.Windows.Forms;
using System;

namespace CourtManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Uruchomienie formularza logowania
            FmLogin fmLogin = new FmLogin();
            if (fmLogin.ShowDialog() == DialogResult.OK)
            {
                // Jeśli wynik DialogResult to OK, uruchamiamy główny formularz
                Application.Run(new FmMain());
            }
            else
            {
                // Jeśli wynik DialogResult nie jest OK, zamykamy aplikację
                Application.Exit();
            }
        }
    }
}