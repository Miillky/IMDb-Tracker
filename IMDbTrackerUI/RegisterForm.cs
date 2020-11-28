using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMDbTrackerLibrary;

namespace IMDbTrackerUI {
    public partial class RegisterForm : Form {

        public RegisterForm() {
            InitializeComponent();
        }

        private void ValidateFields() {
            Validator.ValidateUsernameTextBox(userNameTextBox, usernameValidateErrorLabel);
            Validator.ValidateFirstNameTextBox(firstNameTextBox, firstNameValidateErrorLabel);
            Validator.ValidateLastNameTextBox(lastNameTextBox, lastNameValidateErrorLabel);
            Validator.ValidateEmailTextBox(emailTextBox, emailValidateErrorLabel);
            Validator.ValidatePasswordTextBox(passwordTextBox, passwordValidateErrorLabel);
            Validator.ValidateRepeatPasswordTextBox(passwordTextBox, repeatPasswordTextBox, repeatPasswordValidateErrorLabel);
            Validator.ValidateApiKeyTextBox(apiKeyTextBox, apiKeyValidateErrorLabel);
        }

        private void SignUpForm_Load(object sender, EventArgs e) {

        }
        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e) {
            passwordTextBox.UseSystemPasswordChar = !ShowPasswordCheckbox.Checked;
        }

        private void ShowRequiredPasswordCheckbox_CheckedChanged(object sender, EventArgs e) {
            repeatPasswordTextBox.UseSystemPasswordChar = !ShowRepeatPasswordCheckbox.Checked;
        }

        private void RegisterButton_Click(object sender, EventArgs e) {

            ValidateFields();

        }

    }
}
