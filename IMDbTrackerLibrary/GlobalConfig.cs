using System.Resources;
using System.Configuration;
using IMDbTrackerLibrary.Properties;
using IMDbTrackerLibrary.DataAccess;
using IMDbTrackerLibrary.DataAccess.Entity;
using static System.Net.Mime.MediaTypeNames;

namespace IMDbTrackerLibrary {
    public static class GlobalConfig {

        public const int ValidatorMinPasswordLength = 9;
        public const int PasswordHashIterations = 10000;
        public const int PasswordHashSaltSize = 16; // 128 bit 
        public const int PasswordHashKeySize = 32; // 256 bit
        public const int PasswordResetTokenLength = 32;

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

        public static string GetExceptionMessage(string messageName) {
            ResourceManager exceptionMessages = new ResourceManager(typeof(ExceptionMessages));
            return exceptionMessages.GetString(messageName);
        }

        public static string GetMessageBoxMessages(string messageName) {
            ResourceManager exceptionMessages = new ResourceManager(typeof(MessageBoxMessages));
            return exceptionMessages.GetString(messageName);
        }

        public static string GetEmailResourceString(string stringName) {
            ResourceManager emailResources = new ResourceManager(typeof(EmailResources));
            return emailResources.GetString(stringName);
        }

        public static object GetEmailResourceImage(string imageName) {
            ResourceManager emailResources = new ResourceManager(typeof(EmailResources));
            return emailResources.GetObject(imageName);
        }
    }
}
