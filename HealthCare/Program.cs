using System;
using System.Windows.Forms;

namespace HealthCare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new View.LoginForm());
            Application.Run(new View.NurseDashboard(new View.LoginForm()));

        }
    }
}
