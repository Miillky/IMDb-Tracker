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
    public partial class MainMenuForm : Form {

        private readonly User user;

        public MainMenuForm(User model) {
            InitializeComponent();

            user = model;
        }

        private void MoviesButton_Click(object sender, EventArgs e) {

        }

        private void TvShowsButton_Click(object sender, EventArgs e) {

        }

        private void ProfileButton_Click(object sender, EventArgs e) {

        }
    }
}
