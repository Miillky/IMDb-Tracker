using System;
using System.Linq;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess.Entity {
    class EntityConnector : IDataConnection {

        private readonly IMDbTrackerContext context = new IMDbTrackerContext();

        public void CreateTables() {
        }

        public void CreateUser(User model) {
            context.Users.Add(model);
            context.SaveChangesAsync();
        }

        public void UpdateUser(User model) {
            User user = context.Users.SingleOrDefault(u => u.Id == model.Id);
            if(user != null) {
                context.Entry(user).CurrentValues.SetValues(model);
                context.SaveChangesAsync();
            }
        }

        public User FindUserByUsername(string username) {
            return context.Users.Where(u => u.Username == username).SingleOrDefault();
        }

        public User FindUserByEmail(string email) {
            return context.Users.Where(u => u.Email == email).SingleOrDefault();
        }

        public bool UsernameExists(string username) {
            if(context.Users.Where(u => u.Username == username).SingleOrDefault() != null) {
                return true;
            }
            return false;
        }

        public bool EmailExists(string email, int userId) {
            if(userId > 0) {
                if(context.Users.Where(u => u.Email == email && u.Id == userId).SingleOrDefault() != null) {
                    return false;
                }
            }

            if(context.Users.Where(u => u.Email == email).SingleOrDefault() != null) {
                return true;
            }

            return false;
        }

        public bool APIKeyExists(string apiKey, int userId) {
            if(userId > 0) {
                if(context.Users.Where(u => u.APIKey == apiKey && u.Id == userId).SingleOrDefault() != null) {
                    return false;
                }
            }

            if(context.Users.Where(u => u.APIKey == apiKey).SingleOrDefault() != null) {
                return true;
            }
            return false;
        }

        public void SetPasswordResetToken(User model, string passwordResetToken, DateTime passwordResetTokenValid) {
            User user = context.Users.SingleOrDefault(u => u.Id == model.Id);
            if(user != null) {
                model.PasswordResetToken = passwordResetToken;
                model.PasswordResetTokenValid = passwordResetTokenValid;
                context.Entry(user).CurrentValues.SetValues(model);
                context.SaveChangesAsync();
            }
        }

        public (string, DateTime?) GetPasswordResetToken(User model) {
            User user = context.Users.Where(u => u.Id == model.Id).SingleOrDefault();
            return (user.PasswordResetToken, user.PasswordResetTokenValid);
        }
    }
}