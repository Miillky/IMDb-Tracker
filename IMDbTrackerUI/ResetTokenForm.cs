using IMDbTrackerLibrary;
using IMDbTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDbTrackerUI {
    public partial class ResetTokenForm : Form {
        private readonly User user;
        public ResetTokenForm(User model) {
            InitializeComponent();

            user = model;
        }

        private void PasswordResetButton_Click(object sender, EventArgs e) {
            var tokenTouple = GlobalConfig.Connection.GetPasswordResetToken(user);

            string token = tokenTouple.Item1;
            DateTime tokenExpiration = (DateTime)tokenTouple.Item2;

            bool validToken = Validator.ValidateToken(resetTokenTextBox, token, tokenExpiration, resetTokenValidateErrorLabel);

            if(validToken) {
                ResetPasswordForm resetPasswordForm = new ResetPasswordForm(user);
                resetPasswordForm.Show();

                this.Close();
                this.Dispose();
            }
        }
    }
}
