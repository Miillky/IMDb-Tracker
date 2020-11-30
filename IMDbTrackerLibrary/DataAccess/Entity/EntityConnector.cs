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

        User IDataConnection.findUserByUsername(string username) {
            return context.Users.Where(u => u.UserName == username).FirstOrDefault();
        }

        User IDataConnection.findUserByEmail(string email) {
            return context.Users.Where(u => u.Email == email).FirstOrDefault();
        }
    }
}