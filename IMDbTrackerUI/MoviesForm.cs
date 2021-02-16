using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        private List<Movie> movies;
        private readonly List<MovieType> movieTypes;

        private string CurrentEndpointSlug;
        private const string FavoritesEndpointSlug = "favorites";
        private const string MostPopularEndpointSlug = "most-popular-movies";
        private const string AddToFavoritesText = "Add to favorites";
        private const string RemoveFromFavoritesText = "Remove from favorites";

        public MoviesForm(User model) {
            InitializeComponent();

            user = model;

            api = new API(user);

            movieTypes = new List<MovieType>() {
                new MovieType{ Description = "Favorites", Endpoint = FavoritesEndpointSlug },
                new MovieType{ Description = "Most popular", Endpoint = MostPopularEndpointSlug }
            };
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
            CurrentEndpointSlug = selectedMovieType.Endpoint;
            GetMoviesByType(CurrentEndpointSlug);
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if((Movie)moviesListBox.SelectedItem == selectedMovie) {
                return;
            }

            if(movies.Count == 0) {
                addRemoveFavoritesButton.Enabled = false; 
                movieDetailsButton.Enabled = false;
                return;
            }

            selectedMovie = (Movie)moviesListBox.SelectedItem;

            movieTitleLabel.Text = selectedMovie.Title;
            movieReleseYearLabel.Text = DateTime.SpecifyKind((DateTime)selectedMovie.ReleaseDate, DateTimeKind.Local).ToString("yyyy");
            moviePlotOutlineTextBox.Text = selectedMovie.PlotOutline;

            FavoriteMovie fm = new FavoriteMovie() {
                MovieId = selectedMovie.Id,
                Movie = selectedMovie,
                UserId = user.Id,
                User = user
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

                movies.Add(selectedMovie); 

            } else {

                GlobalConfig.Connection.RemoveFavoriteMovie(favoriteMovie);

                addRemoveFavoritesButton.Text = AddToFavoritesText;

                movies.Remove(selectedMovie);

                selectedMovie = null;
                
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
            movies = new List<Movie>();

            List<FavoriteMovie> userFavoriteMovies = GlobalConfig.Connection.FindUserFavoriteMovies(user);
            if(userFavoriteMovies.Count > 0) {
                userFavoriteMovies.ForEach(fm => movies.Add(GlobalConfig.Connection.FindMovieById(fm.MovieId)));
            }

            PopulateListBox();
        }

        private async void GetMostPopularMovies() {
            movies = new List<Movie>();

            var movieIds = await api.GetMostPopular("get-most-popular-movies");

            foreach(var movieId in movieIds) {
                Movie movie = GlobalConfig.Connection.FindMovieById(movieId);

                if(movie != null) {
                    movies.Add(movie);
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
                        ReleaseDate = DateTime.Parse(movieDetails.ReleaseDate),
                        PlotOutline = movieDetails.PlotOutline.Text,
                        PlotSummary = movieDetails.PlotSummary != null ? movieDetails.PlotSummary.Text : ""
                    };

                    GlobalConfig.Connection.AddMovie(movie);

                    movies.Add(movie);
                }

                PopulateListBox();
            }
        }

        private async void GetMovieListByGanre(string endpoint) {

            movies = new List<Movie>();

            var movieIds = await api.GetPopularMoviesByGenre(endpoint);

            foreach(var movieId in movieIds) {
                Movie movie = GlobalConfig.Connection.FindMovieById(movieId);

                if(movie != null) {
                    movies.Add(movie);
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
                        ReleaseDate = DateTime.Parse(movieDetails.ReleaseDate),
                        PlotOutline = movieDetails.PlotOutline.Text,
                        PlotSummary = movieDetails.PlotSummary.Text
                    };

                    GlobalConfig.Connection.AddMovie(movie);

                    movies.Add(movie);
                }

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

        private void PopulateListBox() {

            moviesListBox.DisplayMember = "Title";
            moviesListBox.ValueMember = "Id";
            moviesListBox.Items.Clear();

            if(movies.Count == 0) {
                addRemoveFavoritesButton.Enabled = false;
                movieDetailsButton.Enabled = false;
                selectedMovie = null;
                return;
            }

            moviesListBox.Items.AddRange(movies.ToArray());

            SetActiveListBoxItem();
        }

        private void SetActiveListBoxItem() {
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
                    GetMovieListByGanre(endpoint);
                    break;
            }
        }
    }
}
