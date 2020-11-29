using System;
using IMDbTrackerLibrary.Models;
using IMDbTrackerLibrary.EntityContexts;
using System.Collections.Generic;
using System.Linq;

namespace IMDbTrackerLibrary.DataAccess {
    class EntityConnector : IDataConnection {
        void IDataConnection.CreateUser(User model) {
            UserContext context = new UserContext();
            context.Users.Add(model);
            context.SaveChanges();
        }

        User IDataConnection.findUserByUsername(string username) {
            UserContext context = new UserContext();
            User user = context.Users.Where(u => u.UserName == username).FirstOrDefault();
            return user; 
        }

        void IDataConnection.CreateTables() {
        }

        void IDataConnection.UpdateUser(User model) {
            throw new NotImplementedException();
        }
        
    }
}
