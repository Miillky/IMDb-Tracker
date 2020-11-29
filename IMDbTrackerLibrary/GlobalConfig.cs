using System.Configuration;
using IMDbTrackerLibrary.DataAccess;

namespace IMDbTrackerLibrary {
    public static class GlobalConfig {

        public static int passwordLength = 9;
        public static int hashLength = 32;

        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(string db) {  
            switch(db) {
                case "MSSQL":
                    MSSQLConnector mssql = new MSSQLConnector();
                    Connection = mssql;
                    break;
                case "Entity":
                    EntityConnector entity = new EntityConnector();
                    Connection = entity;
                    break;
                default:
                    break;
            }
        }

        public static string ConnectionString() {
            return ConfigurationManager.ConnectionStrings[AppKeyLookup("activeConnection")].ConnectionString;
        }

        public static string AppKeyLookup(string key) {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
