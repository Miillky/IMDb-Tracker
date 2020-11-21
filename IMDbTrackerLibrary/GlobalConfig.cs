using System.Configuration;
using IMDbTrackerLibrary.DataAccess;

namespace IMDbTrackerLibrary {
    public static class GlobalConfig {

        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(string db) {  
            switch(db) {
                case "MSSQL":
                    MSSQLConnector mssql = new MSSQLConnector();
                    Connection = mssql;
                    break;
                default:
                    break;
            }
        }

        public static string ConnectionString() {
            return ConfigurationManager.ConnectionStrings[AppKeyLookup("activeDatabase")].ConnectionString;
        }

        public static string AppKeyLookup(string key) {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
