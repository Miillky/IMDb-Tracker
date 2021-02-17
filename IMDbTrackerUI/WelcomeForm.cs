using System;
using System.Windows.Forms;

namespace IMDbTrackerUI {
    public partial class WelcomeForm : Form {

        private LogInForm logInForm;
        private RegisterForm registerForm;
           
        public WelcomeForm() {
            InitializeComponent();

        }

        private void LogInButton_Click(object sender, EventArgs e) {

            logInForm = new LogInForm();
            logInForm.Show();

            if(registerForm != null) {
                registerForm.Close();
                registerForm.Dispose();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e) {

            registerForm = new RegisterForm();
            registerForm.Show();

            if(logInForm != null) {
                logInForm.Close();
                logInForm.Dispose();
            }
        }
    }
}
