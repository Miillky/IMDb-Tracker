using System;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess {
    class MSSQLConnector : IDataConnection {

        private string db = GlobalConfig.ConnectionString();
        public void CreateTables() {
            throw new NotImplementedException();
        }
        public void CreateUser(User model) {
            throw new NotImplementedException();
        }

        public void UpdateUser(User model) {
            throw new NotImplementedException();
        }

        public void CreateUsersTable() {
            throw new NotImplementedException();
        }

        public User findUserByUsername(string username) {
            throw new NotImplementedException();
        }
    }
}
