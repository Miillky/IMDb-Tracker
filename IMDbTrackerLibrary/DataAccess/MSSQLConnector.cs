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

        public User FindUserByUsername(string username) {
            throw new NotImplementedException();
        }

        public User FindUserByEmail(string email) {
            throw new NotImplementedException();
        }

        public bool UsernameExists(string username) {
            throw new NotImplementedException();

        }

        public bool EmailExists(string email, int userId) {
            throw new NotImplementedException();
        }

        public bool APIKeyExists(string apiKey, int userId) {
            throw new NotImplementedException();
        }

        public void SetPasswordResetToken(User model, string passwordResetKey, DateTime passwordResetTokenValid) {
            throw new NotImplementedException();
        }

        public (string, DateTime?) GetPasswordResetToken(User model) {
            throw new NotImplementedException();
        }
    }
}
