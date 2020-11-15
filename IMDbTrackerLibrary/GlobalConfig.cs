using System.Configuration;
using IMDbTrackerLibrary.DataAccess;

namespace IMDbTrackerLibrary {
    public static class GlobalConfig {
        public enum DatabaseType {
            SQL
        }
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db) {

            switch(db) {
                case DatabaseType.SQL:
                    SQLConnector sql = new SQLConnector();
                    Connection = sql;
                    break;
                default:
                    break;
            }
        }

        public static string ConnectionString() {
            return ConfigurationManager.ConnectionStrings[AppKeyLookup("activeDatabaseConnectionString")].ConnectionString;
        }

        public static string AppKeyLookup(string key) {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
