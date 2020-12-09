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

            // Initialize the database connections
            GlobalConfig.InitializeConnections(GlobalConfig.AppKeyLookup("activeConnection"));

            Application.Run(new MoviesForm());
        }
    }
}
