using System.Linq;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess.Entity {
    class EntityConnector : IDataConnection {

        private readonly IMDbTrackerContext context = new IMDbTrackerContext();

        void IDataConnection.CreateTables() {
        }
        void IDataConnection.CreateUser(User model) {
            context.Users.Add(model);
            context.SaveChanges();
        }

        void IDataConnection.UpdateUser(User model) {
            User user = context.Users.SingleOrDefault(u => u.Id == model.Id);
            if(user != null) {

            }
        }

        User IDataConnection.FindUserByUsername(string username) {
            return context.Users.Where(u => u.Username == username).FirstOrDefault();
        }

        User IDataConnection.FindUserByEmail(string email) {
            return context.Users.Where(u => u.Email == email).FirstOrDefault();
        }

        bool IDataConnection.UsernameExists(string username) {
            if(context.Users.Where(u => u.Username == username).FirstOrDefault() != null) {
                return true;
            }
            return false;
        }

        bool IDataConnection.EmailExists(string email) {
            if(context.Users.Where(u => u.Email == email).FirstOrDefault() != null) {
                return true;
            }
            return false;
        }

        bool IDataConnection.APIKeyExists(string apiKey) {
            if(context.Users.Where(u => u.APIKey == apiKey).FirstOrDefault() != null) {
                return true;
            }
            return false;
        }
    }
}