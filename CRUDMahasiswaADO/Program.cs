using System;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Baris ini yang menentukan form mana yang pertama kali dijalankan
            Application.Run(new Dashboard());
        }
    }
}