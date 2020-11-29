using System;
using System.Windows.Forms;
using System.Resources;
using System.Text.RegularExpressions;
using IMDbTrackerLibrary.Properties;
using IMDbTrackerLibrary.Exceptions;

namespace IMDbTrackerLibrary {
    public static class Validator {

        private static readonly ResourceManager rm = new ResourceManager(typeof(ExceptionMessages));

        private static string GetExceptionMessage(string messageName) {
            return rm.GetString(messageName);
        }

        private static bool Required(string fieldValue, string error) {
            if(string.IsNullOrWhiteSpace(fieldValue)) {
                throw new ArgumentException(error);
            }
            return true;
        }

        private static bool PasswordStrength(string passwordFieldValue) {

            // Ensure string has two uppercase letters.
            Regex passwordUppercaseRegex = new Regex("(?=.*[A-Z].*[A-Z])");
            if(!passwordUppercaseRegex.IsMatch(passwordFieldValue)){
                throw new PasswordUppercaseException(GetExceptionMessage("PasswordUppercase"));
            }

            // Ensure string has one special case letter.
            Regex passwordSpecialCharacterRegex = new Regex("(?=.*[!@#$&*])");
            if(!passwordSpecialCharacterRegex.IsMatch(passwordFieldValue)) {
                throw new PasswordSpecialCharException(GetExceptionMessage("PasswordSpecialCharacter"));
            }

            // Ensure string has two digits.
            Regex passwordDigitsRegex = new Regex("(?=.*[0-9].*[0-9])");
            if(!passwordDigitsRegex.IsMatch(passwordFieldValue)) {
                throw new PasswordDigitsException(GetExceptionMessage("PasswordDigits"));
            }

            // Ensure string has three digits.
            Regex passwordLowercaseRegex = new Regex("(?=.*[a-z].*[a-z].*[a-z])");
            if(!passwordLowercaseRegex.IsMatch(passwordFieldValue)) {
                throw new PasswordLowercaseException(GetExceptionMessage("PasswordLowercase"));
            }

            // Ensure minimum password length
            int passwordLength = GlobalConfig.passwordLength;
            if(passwordFieldValue.Length < passwordLength) {
                throw new PasswordLengthException($"{GetExceptionMessage("PasswordLength")} ({passwordLength}).");
            }

            return true;
        }

        private static bool MatchingPassword(string passwordFieldValue, string repeatPasswordFieldValue, string error) {
            if(passwordFieldValue != repeatPasswordFieldValue) {
                throw new NotMatchingPasswordsException(error);
            }

            return true;
        }

        private static bool ValidEmail(string emailFieldValue) {
            
            string validEmailRegexPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            Regex emailRegex = new Regex(validEmailRegexPattern, RegexOptions.IgnoreCase);

            if(!emailRegex.IsMatch(emailFieldValue)) {
                throw new InvalidEmailFormatException(GetExceptionMessage("EmailNotValid"));
            }

            return true;
        }

        public static bool ValidateUsernameTextBox(TextBox usernameField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(usernameField.Text, GetExceptionMessage("UsernameRequired"));
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            }

            return true;
        }

        public static bool ValidateFirstNameTextBox(TextBox firstNameField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(firstNameField.Text, GetExceptionMessage("FirstNameRequired"));
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
                Required(lastNameField.Text, GetExceptionMessage("LastNameRequired"));
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            }

            return true;
        }

        public static bool ValidateEmailTextBox(TextBox emailField, Label errorLabel) {
            try {
                errorLabel.Hide();

                Required(emailField.Text, GetExceptionMessage("EmailRequired"));
                ValidEmail(emailField.Text);

            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            } catch(InvalidEmailFormatException fex) {
                errorLabel.Show();
                errorLabel.Text = fex.Message;
                return false;
            }

            return true;
        }

        public static bool ValidatePasswordTextBox(TextBox passwordField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(passwordField.Text, GetExceptionMessage("PasswordRequired"));
                PasswordStrength(passwordField.Text);
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

        public static bool ValidateRepeatPasswordTextBox(TextBox passwordFeild, TextBox repeatPasswordField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(repeatPasswordField.Text, GetExceptionMessage("RepeatPasswordRequired"));
                MatchingPassword(passwordFeild.Text, repeatPasswordField.Text, GetExceptionMessage("NotMatchingPasswords"));
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

        public static bool ValidateApiKeyTextBox(TextBox apiKeyField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(apiKeyField.Text, GetExceptionMessage("APIKeyRequired"));
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return false;
            }

            return true;
        }
    }
}
