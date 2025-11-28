using System;
using System.Windows.Forms;

namespace ScanSpectre
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var splash = new SplashScreen())
                splash.ShowDialog();

            Application.Run(new ScanSpectre());
        }
    }
}
