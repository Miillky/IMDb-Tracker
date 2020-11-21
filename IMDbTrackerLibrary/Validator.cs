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

        private static bool ValidPassword(string passwordFieldValue, string error) {


            return true;
        }

        private static bool MatchingPassword(string passwordFieldValue, string repeatPasswordFieldValue, string error) {
            if(passwordFieldValue != repeatPasswordFieldValue) {
                throw new NotMatchingPasswordsException(error);
            }

            return true;
        }

        private static bool ValidEmail(string emailFieldValue, string error) {
            
            string validEmailRegexPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
            + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
            + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            Regex emailRegex = new Regex(validEmailRegexPattern, RegexOptions.IgnoreCase);

            if(!emailRegex.IsMatch(emailFieldValue)) {
                throw new InvalidEmailFormatException(error);
            }

            return true;
        }

        public static void ValidateUsernameTextBox(TextBox usernameField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(usernameField.Text, GetExceptionMessage("UsernameRequired"));
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return;
            }
        }

        public static void ValidateFirstNameTextBox(TextBox firstNameField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(firstNameField.Text, GetExceptionMessage("FirstNameRequired"));
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return;
            }
        }

        public static void ValidateLastNameTextBox(TextBox lastNameField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(lastNameField.Text, GetExceptionMessage("LastNameRequired"));
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return;
            }
        }

        public static void ValidateEmailTextBox(TextBox emailField, Label errorLabel) {
            try {
                errorLabel.Hide();

                Required(emailField.Text, GetExceptionMessage("EmailRequired"));
                ValidEmail(emailField.Text, GetExceptionMessage("EmailNotValid"));

            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return;
            } catch(InvalidEmailFormatException fex) {
                errorLabel.Show();
                errorLabel.Text = fex.Message;
                return;
            }
        }

        public static void ValidatePasswordTextBox(TextBox passwordField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(passwordField.Text, GetExceptionMessage("PasswordRequired"));
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return;
            }
        }

        public static void ValidateRepeatPasswordTextBox(TextBox passwordFeild, TextBox repeatPasswordField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(repeatPasswordField.Text, GetExceptionMessage("RepeatPasswordRequired"));
                MatchingPassword(passwordFeild.Text, repeatPasswordField.Text, GetExceptionMessage("NotMatchingPasswords"));
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return;
            } catch(NotMatchingPasswordsException nrpex) {
                errorLabel.Show();
                errorLabel.Text = nrpex.Message;
                return;
            }
        }

        public static void ValidateApiKeyTextBox(TextBox apiKeyField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Required(apiKeyField.Text, GetExceptionMessage("APIKeyRequired"));
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return;
            }
        }
    }
}
