using Simul.Config;
using Simul.Views;
using System;
using System.Windows.Forms;

namespace Simul
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = AutofacConfiguration.CreateContainer();

            using (var scope = container.BeginLifetimeScope())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                using (var frmPrincipal = new FrmPrincipal())
                {
                    Application.Run(frmPrincipal);
                }
            }
        }
    }
}
