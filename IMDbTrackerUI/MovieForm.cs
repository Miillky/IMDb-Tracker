using System;
using System.Windows.Forms;
using IMDbTrackerLibrary;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerUI {
    public partial class MovieForm : Form {
        private readonly Movie movie;
        private readonly User user;
        private MovieComment movieComment;
        public MovieForm(Movie movieModel, User userModel) {
            InitializeComponent();

            movie = movieModel;
            user = userModel;

            this.Text = $"{this.Text} - {movie.Title}";
            this.AcceptButton = saveMovieButton;

            movieComment = GlobalConfig.Connection.FindMovieComment(movie, user);
            if(movieComment != null) {
                movieCommentTextBox.Text = movieComment.Comment;
                saveMovieButton.Text = "Update";
            }
        }

        private void MovieForm_Load(object sender, EventArgs e) {
            movieTitleLabel.Text = movie.Title;
            movieReleseDateDateLabel.Text = DateTime.SpecifyKind((DateTime)movie.ReleseDate, DateTimeKind.Local).ToString("dd.MM.yyyy");
            movieCoverPictureBox.LoadAsync(movie.ImageUrl);
            movieGenresLabel.Text = movie.Genres;
            movieRunningTimeMinutesLabel.Text = $"{movie.RunningTimeInMinutes}min";
            movieRatingNumberLabel.Text = movie.Rating.ToString("N1");
            moviePlotOutlineTextBox.Text = movie.PlotSummary;
        }

        private void saveMovieButton_Click(object sender, EventArgs e) {
            if(movieComment == null) {   

                MovieComment movieComment = new MovieComment() {
                    MovieId = movie.Id,
                    Movie = movie,
                    UserId = user.Id,
                    User = user,
                    Comment = movieCommentTextBox.Text
                };

                GlobalConfig.Connection.AddMovieComment(movieComment);
                Helpers.ShowMessageBox("AddMovieComment");

            } else {

                movieComment.Comment = movieCommentTextBox.Text;
                GlobalConfig.Connection.UpdateMovieComment(movieComment);
                Helpers.ShowMessageBox("UpdateMovieComment");

            }        
        }
    }
}
