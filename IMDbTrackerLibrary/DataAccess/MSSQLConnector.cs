using System;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess {
    class MSSQLConnector : IDataConnection {

        private string db = GlobalConfig.ConnectionString();

        public void CreateUser(User model) {
            throw new NotImplementedException();
        }

        public void UpdateUser(User model) {
            throw new NotImplementedException();
        }

        public void GeneratePassword(string password) {
            throw new NotImplementedException();
        }
    }
}
