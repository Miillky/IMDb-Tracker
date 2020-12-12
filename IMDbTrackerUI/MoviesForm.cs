using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IMDbTrackerLibrary;
using IMDbTrackerLibrary.Models;
using IMDbTrackerLibrary.Models.API;

namespace IMDbTrackerUI {

    public partial class MoviesForm : Form {
        private readonly User user;
        private readonly API api;
        private readonly List<MovieType> movieTypes;
        private Movie selectedMovie;
        private List<Movie> movies;

        public MoviesForm() {
            InitializeComponent();

            movieTypes = new List<MovieType>() {
                new MovieType{ Description = "Favorites", Endpoint = "favorites" },
                new MovieType{ Description = "Top rated", Endpoint = "top-rated-movies" },
                new MovieType{ Description = "Most popular", Endpoint = "most-popular-movies" }
            };
            
            api = new API(user);
        }

        private void MoviesForm_Load(object sender, EventArgs e) {

            PopulateMovieTypeComboBox();

            moviesTypeComboBox.SelectedIndex = 0;
        }

        private void FilterMoviesTextBox_TextChanged(object sender, EventArgs e) {
            string text = filterMoviesTextBox.Text;

            List<Movie> filteredMoviesList = movies.Where(movie => movie.Title.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            moviesListBox.Items.Clear();
            moviesListBox.Items.AddRange(filteredMoviesList.ToArray());
        }

        private void MoviesTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            MovieType selectedMovieType = (MovieType)moviesTypeComboBox.SelectedItem;
            GetMoviesByType(selectedMovieType.Endpoint);
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if(selectedMovie == null) {
                return;
            }

            selectedMovie = (Movie)moviesListBox.SelectedItem;

            movieTitleLabel.Text = selectedMovie.Title;
            movieReleseYearLabel.Text = DateTime.SpecifyKind((DateTime)selectedMovie.ReleseDate, DateTimeKind.Local).ToString("yyyy");

            FavoriteMovie fm = new FavoriteMovie() {
                MovieId = selectedMovie.Id,
                UserId = user.Id
            };

            FavoriteMovie favoriteMovie = GlobalConfig.Connection.FindFavoriteMovieByIds(fm);
            if(favoriteMovie == null) {
                addRemoveFavoritesButton.Text = "Add to favorites";
            } else {
                addRemoveFavoritesButton.Text = "Remove from favorites";
            }

            movieCoverPictureBox.Load(selectedMovie.ImageUrl);
        }

        private void AddRemoveFavoritesButton_Click(object sender, EventArgs e) {

            FavoriteMovie fm = new FavoriteMovie() {
                Movie = selectedMovie,
                MovieId = selectedMovie.Id,
                User = user,
                UserId = user.Id
            };

            FavoriteMovie favoriteMovie = GlobalConfig.Connection.FindFavoriteMovieByIds(fm);

            if(favoriteMovie == null) {
                GlobalConfig.Connection.AddFavoriteMovie(fm);
                addRemoveFavoritesButton.Text = "Remove from favorites";
                movies.Add(selectedMovie);
            } else {
                GlobalConfig.Connection.RemoveFavoriteMovie(favoriteMovie);
                addRemoveFavoritesButton.Text = "Add to favorites";
                movies.Remove(selectedMovie);
            }

            PopulateListBox();
        }

        private void MovieDetailsButton_Click(object sender, EventArgs e) {

        }

        private void GetFavoriteMovies() {
            movies = new List<Movie>();

            List<FavoriteMovie> userFavoriteMovies = GlobalConfig.Connection.FindUserFavoriteMovies(user);
            if(userFavoriteMovies != null) {
                userFavoriteMovies.ForEach(fm => movies.Add(GlobalConfig.Connection.FindMovieById(fm.MovieId)));
                PopulateListBox();
            }

        }

        private async void GetTopRatedMovies() {

            movies = new List<Movie>();

            var movieIds = await api.GetTopRatedMovies();

            foreach(var movieId in movieIds) {
                GetListBoxMovies(movieId);
                PopulateListBox();
            }
        }

        private async void GetMostPopularMovies() {
            movies = new List<Movie>();

            var movieIds = await api.GetMostPopularMovies();

            foreach(var movieId in movieIds) {
                GetListBoxMovies(movieId);
                PopulateListBox();
            }
        }

        private async void GetMovieListByGanre(string endpoint) {

            movies = new List<Movie>();

            var movieIds = await api.GetPopularMoviesByGenre(endpoint);

            foreach(var movieId in movieIds) {
                GetListBoxMovies(movieId);
                PopulateListBox();
            }
        }

        private async void PopulateMovieTypeComboBox() {

            moviesTypeComboBox.DisplayMember = "description";
            moviesTypeComboBox.ValueMember = "endpoint";

            moviesTypeComboBox.Items.AddRange(movieTypes.ToArray());

            MovieTypes movieGenres = await api.GetPopularGenres();
            movieGenres.Genres.ToList().ForEach(genre => moviesTypeComboBox.Items.Add(genre));
        }

        private async void GetListBoxMovies(string movieId) {
            Movie movie = GlobalConfig.Connection.FindMovieById(movieId);

            if(movie != null) {
                movies.Add(movie);
            } else {
                MovieDetails movieDetails = await api.GetMovieDetails(movieId);
                movie = new Movie() {
                    Id = movieDetails.Id,
                    Title = movieDetails.Title.Title,
                    RunningTimeInMinutes = movieDetails.Title.RunningTimeInMinutes,
                    ImageUrl = movieDetails.Title.Image.Url,
                    ReleseDate = DateTime.Parse(movieDetails.ReleaseDate)
                };

                GlobalConfig.Connection.AddMovie(movie);

                movies.Add(movie);
            }
        }

        private void PopulateListBox() {
            if(movies.Count == 0) {
                return;
            }

            moviesListBox.DisplayMember = "Title";
            moviesListBox.ValueMember = "Id";
            moviesListBox.Items.Clear();
            moviesListBox.Items.AddRange(movies.ToArray());

            if(selectedMovie == null) {
                moviesListBox.SelectedIndex = 0;
                selectedMovie = new Movie();
                selectedMovie = (Movie)moviesListBox.SelectedItem;
                moviesListBox.SetSelected(0, true);
            }
        }

        private void GetMoviesByType(string endpoint) {
            switch(endpoint) {
                case "favorites":
                    GetFavoriteMovies();
                    break;
                case "top-rated-movies":
                    GetTopRatedMovies();
                    break;
                case "most-popular-movies":
                    GetMostPopularMovies();
                    break;
                default:
                    GetMovieListByGanre(endpoint);
                    break;
            }
        }
    }
}
