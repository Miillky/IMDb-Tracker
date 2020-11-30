using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess {
    public interface IDataConnection {
        void CreateTables();
        void CreateUser(User model);
        void UpdateUser(User model);
        User findUserByUsername(string username);
        User findUserByEmail(string email);
    }
}
