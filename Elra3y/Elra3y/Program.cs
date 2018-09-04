using System;
using System.Windows.Forms;
using Elra3y.PL.Forms;

namespace Elra3y
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmIndex());
        }
    }
}