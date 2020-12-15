using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using IMDbTrackerLibrary.Exceptions;
using IMDbTrackerLibrary;

namespace IMDbTrackerLibrary {
    public static class Validator {

        private static bool Required(string fieldValue, string error) {
            if(string.IsNullOrWhiteSpace(fieldValue)) {
                throw new ArgumentException(error);
            }
            return true;
        }

        private static bool UniqueUsername(string usernameFieldValue) {
            if(GlobalConfig.Connection.UsernameExists(usernameFieldValue)) {
                throw new UserNameExistsException(GlobalConfig.GetExceptionMessage("UniqueUsername"));
            }
            return true;
        }

        private static bool IsUserRegistered(string usernameFieldValue) {
            if(!GlobalConfig.Connection.UsernameExists(usernameFieldValue)) {
                throw new UserNameExistsException(GlobalConfig.GetExceptionMessage("NoRegisteredUser"));
            }
            return true;
        }

        private static bool UniqueEmail(string emailFieldValue, int userId) {
            if(GlobalConfig.Connection.EmailExists(emailFieldValue, userId)) {
                throw new EmailExistsException(GlobalConfig.GetExceptionMessage("UniqueEmail"));
            }
            return true;
        }
        private static bool UniqueAPIKey(string apiFieldValue, int userId) {
            if(GlobalConfig.Connection.APIKeyExists(apiFieldValue, userId)) {
                throw new APIKeyExistsException(GlobalConfig.GetExceptionMessage("UniqueApiKey"));
            }
            return true;
        }

        private static bool PasswordStrength(string passwordFieldValue) {

            // Ensure string has two uppercase letters.
            Regex passwordUppercaseRegex = new Regex("(?=.*[A-Z].*[A-Z])");
            if(!passwordUppercaseRegex.IsMatch(passwordFieldValue)){
                throw new PasswordUppercaseException(GlobalConfig.GetExceptionMessage("PasswordUppercase"));
            }

            // Ensure string has one special case letter.
            Regex passwordSpecialCharacterRegex = new Regex("(?=.*[!@#$&*])");
            if(!passwordSpecialCharacterRegex.IsMatch(passwordFieldValue)) {
                throw new PasswordSpecialCharException(GlobalConfig.GetExceptionMessage("PasswordSpecialCharacter"));
            }

            // Ensure string has two digits.
            Regex passwordDigitsRegex = new Regex("(?=.*[0-9].*[0-9])");
            if(!passwordDigitsRegex.IsMatch(passwordFieldValue)) {
                throw new PasswordDigitsException(GlobalConfig.GetExceptionMessage("PasswordDigits"));
            }

            // Ensure string has three digits.
            Regex passwordLowercaseRegex = new Regex("(?=.*[a-z].*[a-z].*[a-z])");
            if(!passwordLowercaseRegex.IsMatch(passwordFieldValue)) {
                throw new PasswordLowercaseException(GlobalConfig.GetExceptionMessage("PasswordLowercase"));
            }

            // Ensure minimum password length
            int minPasswordLength = GlobalConfig.ValidatorMinPasswordLength;
            if(passwordFieldValue.Length < minPasswordLength) {
                throw new PasswordLengthException($"{GlobalConfig.GetExceptionMessage("PasswordLength")} ({minPasswordLength}).");
            }

            return true;
        }

        private static bool MatchingPassword(string passwordFieldValue, string repeatPasswordFieldValue) {
            if(passwordFieldValue != repeatPasswordFieldValue) {
                throw new NotMatchingPasswordsException(GlobalConfig.GetExceptionMessage("NotMatchingPasswords"));
            }

            return true;
        }

        private static bool ValidPassword(string hash, string passwordFieldValue) {
            if(!Helpers.CheckPassword(hash, passwordFieldValue)) {
                throw new NotMatchingPasswordsException(GlobalConfig.GetExceptionMessage("InvalidPassword"));
            }
            return true;
        }

        private static bool ValidEmail(string emailFieldValue) {
            
            string validEmailRegexPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            Regex emailRegex = new Regex(validEmailRegexPattern, RegexOptions.IgnoreCase);

            if(!emailRegex.IsMatch(emailFieldValue)) {
                throw new InvalidEmailFormatException(GlobalConfig.GetExceptionMessage("EmailNotValid"));
            }

            return true;
        }

        private static bool ValidToken(string token, string tokenFieldValue) {
            if(token != tokenFieldValue) {
                throw new InvalidTokenException(GlobalConfig.GetExceptionMessage("InvalidToken"));
            }
            return true;
        }

        private static bool TokenNotExpired(DateTime tokenExpiration) {
            if(DateTime.UtcNow >= tokenExpiration) {
                throw new TokenExpiredException(GlobalConfig.GetExceptionMessage("TokenExpired"));
            }
            return true;
        }

        public static bool ValidateUsernameTextBox(TextBox usernameField, Label errorLabel) {
            try {

                errorLabel.Hide();
                Required(usernameField.Text, GlobalConfig.GetExceptionMessage("UsernameRequired"));
                UniqueUsername(usernameField.Text);

            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            } catch(UserNameExistsException uex) {
                errorLabel.Show();
                errorLabel.Text = uex.Message;
                return false;
            }

            return true;
        }

        public static bool ValidateFirstNameTextBox(TextBox firstNameField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(firstNameField.Text, GlobalConfig.GetExceptionMessage("FirstNameRequired"));
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            }

            return true;
        }

        public static bool ValidateLastNameTextBox(TextBox lastNameField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(lastNameField.Text, GlobalConfig.GetExceptionMessage("LastNameRequired"));
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            }

            return true;
        }

        public static bool ValidateEmailTextBox(TextBox emailField, Label errorLabel, int userId) {
            try {

                errorLabel.Hide();
                Required(emailField.Text, GlobalConfig.GetExceptionMessage("EmailRequired"));
                ValidEmail(emailField.Text);
                UniqueEmail(emailField.Text, userId);

            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            } catch(InvalidEmailFormatException fex) {
                errorLabel.Show();
                errorLabel.Text = fex.Message;
                return false;
            } catch(EmailExistsException eex) {
                errorLabel.Show();
                errorLabel.Text = eex.Message;
                return false;
            }

            return true;
        }

        public static bool ValidatePasswordTextBox(TextBox passwordField, Label errorLabel, bool isUserProfile) {
            try {

                errorLabel.Hide();

                if(!isUserProfile) {
                    Required(passwordField.Text, GlobalConfig.GetExceptionMessage("PasswordRequired"));
                }
                
                if(isUserProfile && passwordField.Text.Length > 0) {
                    PasswordStrength(passwordField.Text);
                }

            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            } catch(PasswordUppercaseException puex) {
                errorLabel.Show();
                errorLabel.Text = puex.Message;
                return false;
            } catch(PasswordSpecialCharException pscex) {
                errorLabel.Show();
                errorLabel.Text = pscex.Message;
                return false;
            } catch(PasswordDigitsException pdex) {
                errorLabel.Show();
                errorLabel.Text = pdex.Message;
                return false;
            } catch(PasswordLowercaseException plex) {
                errorLabel.Show();
                errorLabel.Text = plex.Message;
                return false;
            } catch(PasswordLengthException plex) {
                errorLabel.Show();
                errorLabel.Text = plex.Message;
                return false;
            }

            return true;
        }

        public static bool ValidateRepeatPasswordTextBox(TextBox passwordFeild, TextBox repeatPasswordField, Label errorLabel, bool updateProfile) {
            try {

                errorLabel.Hide();
                if(!updateProfile || passwordFeild.Text.Length > 0) {
                    Required(repeatPasswordField.Text, GlobalConfig.GetExceptionMessage("RepeatPasswordRequired"));
                    MatchingPassword(passwordFeild.Text, repeatPasswordField.Text);
                }

            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            } catch(NotMatchingPasswordsException nmpex) {
                errorLabel.Show();
                errorLabel.Text = nmpex.Message;
                return false;
            }

            return true;
        }

        public static bool ValidateApiKeyTextBox(TextBox apiKeyField, Label errorLabel, int userId) {
            try {
                errorLabel.Hide();
                Required(apiKeyField.Text, GlobalConfig.GetExceptionMessage("APIKeyRequired"));
                UniqueAPIKey(apiKeyField.Text, userId);
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            } catch(APIKeyExistsException uapik){
                errorLabel.Show();
                errorLabel.Text = uapik.Message;
                return false;
            }

            return true;
        }

        public static bool ValidateLogInUsername(TextBox usernameField, Label errorLabel) {
            try {

                errorLabel.Hide();
                Required(usernameField.Text, GlobalConfig.GetExceptionMessage("LogInUsername"));
                IsUserRegistered(usernameField.Text);

            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            } catch(UserNameExistsException uex) {
                errorLabel.Show();
                errorLabel.Text = uex.Message;
                return false;
            }

            return true;
        }

        public static bool ValidateUserPassword(TextBox passwordField, string paswordHash, Label errorLabel) {
            try {

                errorLabel.Hide();
                Required(passwordField.Text, GlobalConfig.GetExceptionMessage("PasswordRequired"));
                if(paswordHash.Length > 0) {
                    ValidPassword(paswordHash, passwordField.Text);
                }

            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            } catch(NotMatchingPasswordsException nmpex) {
                errorLabel.Show();
                errorLabel.Text = nmpex.Message;
                return false;
            }

            return true;
        }

        public static bool ValidateToken(TextBox tokenField, string token, DateTime tokenExpiration, Label errorLabel) {
            try {

                errorLabel.Hide();
                Required(tokenField.Text, GlobalConfig.GetExceptionMessage("TokenRequired"));
                ValidToken(tokenField.Text, token);
                TokenNotExpired(tokenExpiration);

            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            } catch(InvalidTokenException itex) {
                errorLabel.Show();
                errorLabel.Text = itex.Message;
                return false;
            } catch(TokenExpiredException teex) {
                errorLabel.Show();
                errorLabel.Text = teex.Message;
                return false;
            }

            return true;
        }
    }
}
