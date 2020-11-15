using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess {
    public interface IDataConnection {

        void CreateUser(User model);
        void UpdateUser(User model);
        void GeneratePassword(string password);
    }
}
