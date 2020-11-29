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
    public partial class WelcomeForm : Form {

        private LogInForm logInForm = null;
        private RegisterForm registerForm = null;
           
        public WelcomeForm() {
            InitializeComponent();

        }

        private void LogInButton_Click(object sender, EventArgs e) {

            logInForm = logInForm == null ? new LogInForm(this) : logInForm;
            registerForm = registerForm == null ? new RegisterForm() : registerForm;

            logInForm.Show();
            registerForm.Hide();

        }

        private void RegisterButton_Click(object sender, EventArgs e) {

            logInForm = logInForm == null ? new LogInForm(this) : logInForm;
            registerForm = registerForm == null ? new RegisterForm() : registerForm;

            logInForm.Hide();
            registerForm.Show();

        }
    }
}
