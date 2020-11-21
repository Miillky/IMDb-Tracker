using System;
using System.Windows.Forms;
using IMDbTrackerLibrary;

namespace IMDbTrackerUI {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize database connection
            GlobalConfig.InitializeConnections(GlobalConfig.AppKeyLookup("activeDatabase"));

            Application.Run(new RegisterForm());
        }
    }
}
