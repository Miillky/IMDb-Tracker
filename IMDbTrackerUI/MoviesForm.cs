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

        private Movie selectedMovie;
        private List<Movie> movie;
        private readonly List<MovieType> movieTypes;

        private string CurrentEndpointSlug;
        private const string FavoritesEndpointSlug = "favorites";
        private const string MostPopularEndpointSlug = "most-popular-movies";
        private const string AddToFavoritesText = "Add to favorites";
        private const string RemoveFromFavoritesText = "Remove from favorites";

        public MoviesForm() {
            InitializeComponent();

            movieTypes = new List<MovieType>() {
                new MovieType{ Description = "Favorites", Endpoint = FavoritesEndpointSlug },
                new MovieType{ Description = "Most popular", Endpoint = MostPopularEndpointSlug }
            };

            /*User = new User() {
                Id = 1,
                Username = "Milky",
                FirstName = "Vedran",
                LastName = "Milković",
                Email = "vedran.milkovic25@gmail.com",
                Password = "VM2$GdQVB0sgRBjVHP6Ro5MbkQ==$doGLdpFTZKIOqkmiihE0TAGWZVz10fV5bHDJ8NcNj2I=",
                APIKey = "d325262b71mshbfc5b66bf151c72p115614jsnad17a77df9b4",
                LastLogin = DateTime.UtcNow,
                PasswordResetToken = null,
                PasswordResetTokenValid = null
            };*/

            user = GlobalConfig.Connection.FindUserByUsername("Milky");

            api = new API(user);
        }

        private void MoviesForm_Load(object sender, EventArgs e) {

            PopulateMovieTypeComboBox();

            moviesTypeComboBox.SelectedIndex = 0;
        }

        private void FilterMoviesTextBox_TextChanged(object sender, EventArgs e) {
            string text = filterMoviesTextBox.Text;

            List<Movie> filteredMoviesList = movie.Where(movie => movie.Title.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            moviesListBox.Items.Clear();
            moviesListBox.Items.AddRange(filteredMoviesList.ToArray());
        }

        private void MoviesTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            MovieType selectedMovieType = (MovieType)moviesTypeComboBox.SelectedItem;
            CurrentEndpointSlug = selectedMovieType.Endpoint;
            GetMoviesByType(CurrentEndpointSlug);
            SetActiveListBoxItem();
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if(movie.Count == 0) {
                addRemoveFavoritesButton.Enabled = false; 
                movieDetailsButton.Enabled = false;
                return;
            }

            selectedMovie = (Movie)moviesListBox.SelectedItem;

            movieTitleLabel.Text = selectedMovie.Title;
            movieReleseYearLabel.Text = DateTime.SpecifyKind((DateTime)selectedMovie.ReleseDate, DateTimeKind.Local).ToString("yyyy");
            plotOutlineTextBox.Text = selectedMovie.PlotOutline;

            FavoriteMovie fm = new FavoriteMovie() {
                MovieId = selectedMovie.Id,
                UserId = user.Id
            };

            FavoriteMovie favoriteMovie = GlobalConfig.Connection.FindFavoriteMovieByIds(fm);
            if(favoriteMovie == null) {
                addRemoveFavoritesButton.Text = AddToFavoritesText;
            } else {
                addRemoveFavoritesButton.Text = RemoveFromFavoritesText;
            }

            movieCoverPictureBox.LoadAsync(selectedMovie.ImageUrl);

            addRemoveFavoritesButton.Enabled = true;
            movieDetailsButton.Enabled = true;
        }

        private void AddRemoveFavoritesButton_Click(object sender, EventArgs e) {

            FavoriteMovie fm = new FavoriteMovie() {
                MovieId = selectedMovie.Id,
                Movie = selectedMovie,
                UserId = user.Id,
                User = user
            };

            FavoriteMovie favoriteMovie = GlobalConfig.Connection.FindFavoriteMovieByIds(fm);

            if(favoriteMovie == null) {

                GlobalConfig.Connection.AddFavoriteMovie(fm);

                addRemoveFavoritesButton.Text = RemoveFromFavoritesText;

                movie.Add(selectedMovie); 

            } else {
                GlobalConfig.Connection.RemoveFavoriteMovie(favoriteMovie);

                addRemoveFavoritesButton.Text = AddToFavoritesText;

                movie.Remove(selectedMovie);
            }

            if(CurrentEndpointSlug == FavoritesEndpointSlug) {
                PopulateListBox();
            }
        }

        private void MovieDetailsButton_Click(object sender, EventArgs e) {
            MovieForm movieForm = new MovieForm(selectedMovie, user);
            movieForm.Show();
        }

        private void GetFavoriteMovies() {
            movie = new List<Movie>();

            List<FavoriteMovie> userFavoriteMovies = GlobalConfig.Connection.FindUserFavoriteMovies(user);
            if(userFavoriteMovies.Count > 0) {
                userFavoriteMovies.ForEach(fm => movie.Add(GlobalConfig.Connection.FindMovieById(fm.MovieId)));
            }

            PopulateListBox();
        }

        private async void GetMostPopularMovies() {
            movie = new List<Movie>();

            movie.Add(GlobalConfig.Connection.FindMovieById("tt6723592"));
            PopulateListBox();
            //var movieIds = await API.GetMostPopularMovies();
            //GetListBoxMovies(movieIds[0]);
            /*foreach(var movieId in movieIds) {
                GetListBoxMovies(movieId);
            }*/
        }

        private async void GetMovieListByGanre(string endpoint) {

            movie = new List<Movie>();

            var movieIds = await api.GetPopularMoviesByGenre(endpoint);

            /*foreach(var movieId in movieIds) {
                GetListBoxMovies(movieId);
            }*/
        }

        private async void PopulateMovieTypeComboBox() {

            moviesTypeComboBox.DisplayMember = "description";
            moviesTypeComboBox.ValueMember = "endpoint";

            moviesTypeComboBox.Items.AddRange(movieTypes.ToArray());

            //MovieTypes movieGenres = await API.GetPopularGenres();
            //movieGenres.Genres.ToList().ForEach(genre => moviesTypeComboBox.Items.Add(genre));
        }

        private async void GetListBoxMovies(string movieId) {
            Movie movie = GlobalConfig.Connection.FindMovieById(movieId);

            if(movie != null) {
                this.movie.Add(movie);
            } else {

                MovieDetails movieDetails = await api.GetMovieDetails(movieId);

                movie = new Movie() {
                    Id = movieDetails.Id,
                    Title = movieDetails.Title.Title,
                    ImageUrl = movieDetails.Title.Image.Url,
                    RunningTimeInMinutes = movieDetails.Title.RunningTimeInMinutes,
                    Rating = movieDetails.Ratings.Rating,
                    Genres = string.Join(", ", movieDetails.Genres),
                    Year = movieDetails.Title.Year,
                    ReleseDate = DateTime.Parse(movieDetails.ReleaseDate),
                    PlotOutline = movieDetails.PlotOutline.Text,
                    PlotSummary = movieDetails.PlotSummary.Text 
                };

                GlobalConfig.Connection.AddMovie(movie);

                this.movie.Add(movie);
            }

            PopulateListBox();
        }

        private void PopulateListBox() {

            moviesListBox.DisplayMember = "Title";
            moviesListBox.ValueMember = "Id";
            moviesListBox.Items.Clear();

            if(movie.Count == 0) {
                addRemoveFavoritesButton.Enabled = false;
                movieDetailsButton.Enabled = false;
                selectedMovie = null;
                return;
            }

            addRemoveFavoritesButton.Enabled = false;
            movieDetailsButton.Enabled = false;

            moviesListBox.Items.AddRange(movie.ToArray());
        }

        private void SetActiveListBoxItem() {
            if(movie.Count == 0) {
                selectedMovie = null;
                return;
            }

            moviesListBox.SelectedIndex = 0;

            if((Movie)moviesListBox.SelectedItem != selectedMovie) {
                selectedMovie = new Movie();
                selectedMovie = (Movie)moviesListBox.SelectedItem;
            }

            moviesListBox.SetSelected(0, true);
        }

        private void GetMoviesByType(string endpoint) {
            switch(endpoint) {
                case FavoritesEndpointSlug:
                    GetFavoriteMovies();
                    break;
                case MostPopularEndpointSlug:
                    GetMostPopularMovies();
                    break;
                default:
                    //GetMovieListByGanre(endpoint);
                    break;
            }
        }
    }
}
