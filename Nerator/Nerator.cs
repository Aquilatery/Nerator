using System;
using Nerator.UI;
using System.Windows.Forms;

namespace Nerator
{
    internal static class Nerator
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TEST());
        }
    }
}