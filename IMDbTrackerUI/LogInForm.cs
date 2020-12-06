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

        private readonly WelcomeForm activeWelcomeForm = null;
        private User user = null;

        public LogInForm() {
            InitializeComponent();

            this.AcceptButton = LogInButton;
        }

        public LogInForm(WelcomeForm welcomeForm) {
            InitializeComponent();

            this.AcceptButton = LogInButton;

            activeWelcomeForm = welcomeForm;
        }

        private void ValidateLogInUser() {

            bool validUsername = Validator.ValidateLogInUsername(usernameTextBox, usernameValidateErrorLabel);
            _ = Validator.ValidateLogInPassword(passwordTextBox, "", passwordValidateErrorLabel);

            if(validUsername) {
                user = GlobalConfig.Connection.FindUserByUsername(usernameTextBox.Text);

                bool validPassword = Validator.ValidateLogInPassword(passwordTextBox, user.Password, passwordValidateErrorLabel);

                if(!validPassword) {
                    user = null;
                    return;
                }

                user.LastLogin = DateTime.UtcNow;
                GlobalConfig.Connection.UpdateUser(user);
            }
        }

        private void LogInButton_Click(object sender, EventArgs e) {

            ValidateLogInUser();

            if(user == null) {
                return;
            }

            activeWelcomeForm.Hide();

            MainMenuForm mainMenuForm = new MainMenuForm(user);
            mainMenuForm.Show();
            this.Close();
        }
    }
}
