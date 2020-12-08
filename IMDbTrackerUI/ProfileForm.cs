using System;
using System.Windows.Forms;
using IMDbTrackerLibrary;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerUI {
    public partial class ProfileForm : Form {

        private User user;

        public ProfileForm(User model) {
            InitializeComponent();

            this.user = model;

            FillUpProfileFields();

            this.Text = $"{this.Text} - {user.FirstName} {user.LastName}";
            this.AcceptButton = UpdateProfileButton;
        }

        private bool ValidateFields() {

            ForgotPasswordLabel.Enabled = false;
            ForgotPasswordLabel.Hide();

            bool validFirstName = Validator.ValidateFirstNameTextBox(firstNameTextBox, firstNameValidateErrorLabel);
            bool validLastName = Validator.ValidateLastNameTextBox(lastNameTextBox, lastNameValidateErrorLabel);
            bool validEmail = Validator.ValidateEmailTextBox(emailTextBox, emailValidateErrorLabel, user.Id);
            bool validCurrentPassword = Validator.ValidateUserPassword(currentPasswordTextBox, user.Password, currentPasswordValidateErrorLabel);

            if(!validCurrentPassword) {

                if(currentPasswordTextBox.Text.Length > 0) {
                    ForgotPasswordLabel.Enabled = true;
                    ForgotPasswordLabel.Show();
                }
            }

            bool validNewPassword = Validator.ValidatePasswordTextBox(newPasswordTextBox, newPasswordValidateErrorLabel);
            bool validRepeatNewPassword = Validator.ValidateRepeatPasswordTextBox(newPasswordTextBox, repeatNewPasswordTextBox, repeatNewPasswordValidateErrorLabel);
            bool validApiKey = Validator.ValidateApiKeyTextBox(apiKeyTextBox, apiKeyValidateErrorLabel, user.Id);

            if(validFirstName && validLastName && validEmail && validCurrentPassword && validNewPassword && validRepeatNewPassword && validApiKey)
                return true;

            return false;
        }

        private void FillUpProfileFields() {
            firstNameTextBox.Text = user.FirstName;
            lastNameTextBox.Text = user.LastName;
            emailTextBox.Text = user.Email;
            apiKeyTextBox.Text = user.APIKey;
        }

        private void UpdateUser() {
            user.FirstName = firstNameTextBox.Text;
            user.LastName = lastNameTextBox.Text;
            user.Email = emailTextBox.Text;
            user.Password = Helpers.HashPassword(newPasswordTextBox.Text);
            user.APIKey = apiKeyTextBox.Text;

            GlobalConfig.Connection.UpdateUser(user);
        }

        private void ForgotPasswordLabel_Click(object sender, EventArgs e) {
            ResetTokenForm resetTokenForm = new ResetTokenForm(user, true);
            resetTokenForm.Show();

            Email.SendPasswordResetToken(user);
        }

        private void ShowNewPasswordCheckbox_CheckedChanged(object sender, EventArgs e) {
            newPasswordTextBox.UseSystemPasswordChar = !ShowNewPasswordCheckbox.Checked;
        }

        private void ShowNewRepeatPasswordCheckbox_CheckedChanged(object sender, EventArgs e) {
           repeatNewPasswordTextBox.UseSystemPasswordChar = !ShowRepeatNewPasswordCheckbox.Checked;
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            if(!ValidateFields()) {
                return;
            };

            UpdateUser();

            if(user == null) {
                return;
            }

            Email.SendUpdateProfileMail(user.Email, user, newPasswordTextBox.Text, null);
            Helpers.ShowMessageBox("UserUpdated");

            this.Close();
            this.Dispose();
        }
    }
}
