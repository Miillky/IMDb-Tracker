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
    
    public partial class MoviesForm : Form {
        private readonly User user;
        private readonly API api;
        private List<Movie> movies;

        public MoviesForm() {
            InitializeComponent();
        }

        private async void PopulateMovieTypeComboBox() {

            moviesTypeComboBox.DisplayMember = "description";
            moviesTypeComboBox.ValueMember = "endpoint";

            List<object> favorites = new List<object>() {
                new { description = "Favorites", endpoint = "favorites" },
                new { description = "Top rated", endpoint = "top-rated-movies" },
                new { description = "Most popular", endpoint = "most-popular-movies" }
            };

            favorites.ForEach(favorite => moviesTypeComboBox.Items.Add(favorite));

            moviesTypeComboBox.SelectedIndex = 0;

            var genres = await api.GetPopularGenres();
            genres.ToList().ForEach(genre => moviesTypeComboBox.Items.Add(genre));
        }

        private void MoviesForm_Load(object sender, EventArgs e) {

            PopulateMovieTypeComboBox();

        }

        private void FilterMoviesTextBox_TextChanged(object sender, EventArgs e) {
            string text = filterMoviesTextBox.Text;

            List<Movie> filteredMoviesList = movies.Where(movie => movie.Title.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            moviesListBox.Items.Clear();
            moviesListBox.Items.AddRange(filteredMoviesList.ToArray());
        }
    }
}
