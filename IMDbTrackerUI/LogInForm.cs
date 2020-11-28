﻿using System;
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

        private readonly WelcomeForm activeWelcomeForm = null;

        public LogInForm(WelcomeForm welcomeForm) {
            InitializeComponent();

            activeWelcomeForm = welcomeForm;
        }

        private bool ValidateFields() {

            bool validUsername = Validator.ValidateUsernameTextBox(userNameTextBox, usernameValidateErrorLabel);
            bool validPassword = Validator.ValidatePasswordTextBox(passwordTextBox, passwordValidateErrorLabel);

            if(validUsername || validPassword) {
                return true;
            }

            return false;
        }

        private void LogInButton_Click(object sender, EventArgs e) {

            if(ValidateFields() == false) {
                return;
            }

            activeWelcomeForm.Hide();

            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }
    }
}
