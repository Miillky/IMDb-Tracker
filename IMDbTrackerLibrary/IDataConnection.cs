using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess {
    public interface IDataConnection {
        void CreateTables();
        void CreateUser(User model);
        void UpdateUser(User model);
        User FindUserByUsername(string username);
        User FindUserByEmail(string email);
        bool UsernameExists(string username);
        bool EmailExists(string email);
        bool APIKeyExists(string apiKey);
        void SetPasswordResetToken(User model, string passwordResetKey, System.DateTime passwordResetTokenValid);
        (string, System.DateTime?) GetPasswordResetToken(User model);
    }
}
