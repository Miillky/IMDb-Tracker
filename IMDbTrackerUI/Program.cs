using System;
using System.Windows.Forms;
using IMDbTrackerLibrary;
using System.Data.Entity;
using IMDbTrackerLibrary.DataAccess;

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
            string activeDatabase = GlobalConfig.AppKeyLookup("activeConnection");
            if(activeDatabase != "ENTITY") {
                GlobalConfig.InitializeConnections(activeDatabase);
            }

            Application.Run(new WelcomeForm());
        }
    }
}
