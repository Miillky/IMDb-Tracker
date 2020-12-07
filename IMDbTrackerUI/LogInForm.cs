using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
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

        private void ValidateLogInUser() {

            forgotPasswordLabel.Enabled = false;
            forgotPasswordLabel.Hide();

            bool validUsername = Validator.ValidateLogInUsername(usernameTextBox, usernameValidateErrorLabel);
            _ = Validator.ValidateLogInPassword(passwordTextBox, "", passwordValidateErrorLabel);

            if(validUsername) {
                user = GlobalConfig.Connection.FindUserByUsername(usernameTextBox.Text);

                bool validPassword = Validator.ValidateLogInPassword(passwordTextBox, user.Password, passwordValidateErrorLabel);

                if(!validPassword) {

                    if(passwordTextBox.Text.Length > 0) {
                        forgotPasswordLabel.Enabled = true;
                        forgotPasswordLabel.Show();
                    }

                    validUser = false;
                    return;
                }

                validUser = true;

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

        private void forgotPasswordLabel_Click(object sender, EventArgs e) {

            ResetTokenForm resetTokenForm = new ResetTokenForm(user);
            resetTokenForm.Show();

            string passwordResetToken = Helpers.GeneratePasswordResetToken();
            DateTime passwordResetTokenValid = DateTime.UtcNow.AddMinutes(5);

            GlobalConfig.Connection.SetPasswordResetToken(user, passwordResetToken, passwordResetTokenValid);

            Email.SendResetToken(user.Email, passwordResetToken, passwordResetTokenValid, null);
            Helpers.ShowMessageBox("PasswordResetTokenSend");

            this.Close();
            this.Dispose();
        }
    }
}
