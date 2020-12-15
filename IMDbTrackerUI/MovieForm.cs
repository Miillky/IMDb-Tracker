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
            movieCoverPictureBox.LoadAsync(movie.ImageUrl);

            movieTitleLabel.Text = movie.Title;
            movieReleseDateDateLabel.Text = Helpers.FormatReleseDate(movie.ReleseDate);
            movieGenresLabel.Text = movie.Genres.TrimEnd(',');
            movieRunningTimeMinutesLabel.Text = $"{movie.RunningTimeInMinutes}min";
            movieRatingNumberLabel.Text = Helpers.FormatRating(movie.Rating);
            moviePlotOutlineTextBox.Text = movie.PlotSummary;
        }

        private void SaveMovieButton_Click(object sender, EventArgs e) {
            if(movieComment == null) {   

                MovieComment mc = new MovieComment() {
                    MovieId = movie.Id,
                    Movie = movie,
                    UserId = user.Id,
                    User = user,
                    Comment = movieCommentTextBox.Text
                };

                GlobalConfig.Connection.AddMovieComment(mc);
                Helpers.ShowMessageBox("AddMovieComment");

            } else {

                movieComment.Comment = movieCommentTextBox.Text;
                GlobalConfig.Connection.UpdateMovieComment(movieComment);
                Helpers.ShowMessageBox("UpdateMovieComment");

            }        
        }
    }
}
