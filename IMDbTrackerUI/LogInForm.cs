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
    public partial class LogInForm : Form {
        public LogInForm() {
            InitializeComponent();
        }

        private void SingInForm_Load(object sender, EventArgs e) {

        }

        private void ValidateUsername(TextBox inputField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Validator.Required(inputField.Text, GlobalConfig.UsernameField);
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return;
            }
        }

        private void ValidatePassword(TextBox inputField, Label errorLabel) {
            try {
                errorLabel.Hide();
                Validator.Required(inputField.Text, GlobalConfig.PasswordField);
            } catch(ArgumentException aex) {
                errorLabel.Show();
                errorLabel.Text = aex.Message;
                return;
            }
        }

        private void logInButton_Click(object sender, EventArgs e) {
            ValidateUsername(userNameTextBox, usernameValidateErrorLabel);
            ValidatePassword(passwordTextBox, passwordValidateErrorLabel);
        }
    }
}
