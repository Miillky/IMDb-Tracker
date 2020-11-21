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

namespace IMDbTrackerUI {
    public partial class LogInForm : Form {

        public LogInForm() {
            InitializeComponent();
            
        }

        private void ValidateFields() {
            Validator.ValidateUsernameTextBox(userNameTextBox, usernameValidateErrorLabel);
            Validator.ValidatePasswordTextBox(passwordTextBox, passwordValidateErrorLabel);
        }

        private void logInButton_Click(object sender, EventArgs e) {

            ValidateFields();

        }
    }
}
