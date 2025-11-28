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
            Application.Run(new ScanSpectre());
        }
    }
}
