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
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerUI {
    public partial class ResetPasswordForm : Form {
        private readonly User user;
        public ResetPasswordForm(User model) {
            InitializeComponent();

            user = model;
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

            LogInForm logInForm = new LogInForm(user);
            logInForm.Show();
        }
    }
}
