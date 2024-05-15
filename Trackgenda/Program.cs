using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trackgenda
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var Language = ConfigurationManager.AppSettings["Language"];

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(Language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Language);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
