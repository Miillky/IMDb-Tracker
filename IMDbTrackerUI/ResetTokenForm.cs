using IMDbTrackerLibrary;
using IMDbTrackerLibrary.Models;
using System;
using System.Windows.Forms;

namespace IMDbTrackerUI {
    public partial class ResetTokenForm : Form {
        private readonly User user;
        private bool updateProfile;

        public ResetTokenForm(User model) {
            InitializeComponent();

            user = model;

            this.AcceptButton = ChangePasswordButton;
        }

        public ResetTokenForm(User model, bool updateProfile) {
            InitializeComponent();

            user = model;

            this.updateProfile = updateProfile;

            this.AcceptButton = ChangePasswordButton;

        }

        private void PasswordResetButton_Click(object sender, EventArgs e) {
            var tokenTouple = GlobalConfig.Connection.GetPasswordResetToken(user);

            string token = tokenTouple.Item1;
            DateTime tokenExpiration = (DateTime)tokenTouple.Item2;

            bool validToken = Validator.ValidateToken(resetTokenTextBox, token, tokenExpiration, resetTokenValidateErrorLabel);

            if(validToken) {
                ResetPasswordForm resetPasswordForm = new ResetPasswordForm(user, updateProfile);
                resetPasswordForm.Show();

                this.Close();
                this.Dispose();
            }
        }
    }
}
