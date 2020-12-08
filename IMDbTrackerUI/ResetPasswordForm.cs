using System;
using System.Windows.Forms;
using IMDbTrackerLibrary;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerUI {
    public partial class ResetPasswordForm : Form {

        private readonly User user;
        private readonly bool updateProfile;

        public ResetPasswordForm(User model, bool updateProfile) {
            InitializeComponent();

            user = model;

            this.updateProfile = updateProfile;
        }

        private bool ValidatePasswordFields() {
            bool validPassword = Validator.ValidatePasswordTextBox(passwordTextBox, passwordValidateErrorLabel);
            bool validRepeatPassword = Validator.ValidateRepeatPasswordTextBox(passwordTextBox, repeatPasswordTextBox, repeatPasswordValidateErrorLabel);

            if(validPassword && validRepeatPassword) {
                return true;
            }

            return false;
        }

        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e) {
            passwordTextBox.UseSystemPasswordChar = !ShowPasswordCheckbox.Checked;
        }

        private void ShowRepeatPasswordCheckbox_CheckedChanged(object sender, EventArgs e) {
            repeatPasswordTextBox.UseSystemPasswordChar = !ShowRepeatPasswordCheckbox.Checked;
        }

        private void PasswordResetButton_Click(object sender, EventArgs e) {
            if(!ValidatePasswordFields()) {
                return;
            };

            if(user == null) {
                return;
            }

            user.Password = Helpers.HashPassword(passwordTextBox.Text);
            GlobalConfig.Connection.UpdateUser(user);

            Helpers.ShowMessageBox("PasswordReseted");

            this.Close();
            this.Dispose();

            if(updateProfile) {
                return;
            }

            LogInForm logInForm = new LogInForm(user);
            logInForm.Show();
        }
    }
}
