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
