using System;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            Application.Run(new Dashboard());
        }
    }
}