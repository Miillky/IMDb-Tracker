using System;
using System.Linq;
using System.Windows.Forms;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerUI {
    public partial class MainMenuForm : Form {

        private readonly User user;

        public MainMenuForm(User model) {
            InitializeComponent();

            user = model;
        }

        private void MoviesButton_Click(object sender, EventArgs e) {
            MoviesForm moviesForm = new MoviesForm(user);
            moviesForm.Show();
        }

        private void TvShowsButton_Click(object sender, EventArgs e) {
            ShowsForm showsForm = new ShowsForm(user);
            showsForm.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e) {
            ProfileForm profileForm = new ProfileForm(user);
            profileForm.Show();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e) {
            if(Application.OpenForms.OfType<WelcomeForm>().Count() == 1) {
                Application.OpenForms.OfType<WelcomeForm>().First().Dispose();
            }
        }
    }
}
