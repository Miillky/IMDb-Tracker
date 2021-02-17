using System;
using System.Linq;
using System.Windows.Forms;
using IMDbTrackerLibrary;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerUI {
    public partial class LogInForm : Form {

        private User user;
        private bool validUser = false;

        public LogInForm() {
            InitializeComponent();

            this.AcceptButton = LogInButton;
        }

        public LogInForm(User user) {
            InitializeComponent();

            this.user = user;
            this.AcceptButton = LogInButton;

            usernameTextBox.Text = user.Username;
        }

        private async void ValidateLogInUser() {

            ForgotPasswordLabel.Enabled = false;
            ForgotPasswordLabel.Hide();

            bool validUsername = Validator.ValidateLogInUsername(usernameTextBox, usernameValidateErrorLabel);
            _ = Validator.ValidateUserPassword(passwordTextBox, "", passwordValidateErrorLabel);

            if(validUsername) {
                user = GlobalConfig.Connection.FindUserByUsername(usernameTextBox.Text);

                bool validPassword = Validator.ValidateUserPassword(passwordTextBox, user.Password, passwordValidateErrorLabel);

                if(!validPassword) {

                    if(passwordTextBox.Text.Length > 0) {
                        ForgotPasswordLabel.Enabled = true;
                        ForgotPasswordLabel.Show();
                    }

                    validUser = false;
                    return;
                }

                validUser = true;

                if(user.LastLogin != null) {
                    await Email.SendFavoritesToWatchEmail(user);
                }

                user.LastLogin = DateTime.UtcNow;
                GlobalConfig.Connection.UpdateUser(user);
            }
        }

        private void LogInButton_Click(object sender, EventArgs e) {

            ValidateLogInUser();

            if(!validUser) {
                return;
            }

            MainMenuForm mainMenuForm = new MainMenuForm(user);
            mainMenuForm.Show();

            if(Application.OpenForms.OfType<WelcomeForm>().Count() == 1) {
                Application.OpenForms.OfType<WelcomeForm>().First().Hide();
            }

            this.Close();
            this.Dispose();
        }

        private void ForgotPasswordLabel_Click(object sender, EventArgs e) {

            ResetTokenForm resetTokenForm = new ResetTokenForm(user);
            resetTokenForm.Show();

            Email.SendPasswordResetToken(user);

            this.Close();
            this.Dispose();
        }
    }
}
