using System;
using System.Windows.Forms;
using IMDbTrackerLibrary;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerUI {
    public partial class EpisodeForm : Form {
        private readonly Episode episode;
        private readonly User user;
        private EpisodeComment episodeComment;
        public EpisodeForm(User userModel, Episode episodeModel) {
            InitializeComponent();

            episode = episodeModel;
            user = userModel;

            this.Text = $"{this.Text} - {episode.Title}";
            this.AcceptButton = saveEpisodeButton;

            episodeComment = GlobalConfig.Connection.FindEpisodeComment(episode, user);
            if(episodeComment != null) {
                episodeCommentTextBox.Text = episodeComment.Comment;
                saveEpisodeButton.Text = "Update";
            }
        }

        private void EpisodeForm_Load(object sender, EventArgs e) {
            episodeCoverPictureBox.LoadAsync(episode.ImageUrl);

            episodeTitleLabel.Text = episode.Title;
            episodeReleseDateDateLabel.Text = Helpers.FormatReleseDate(episode.ReleseDate);
            episodeGenresLabel.Text = episode.Genres;
            episodeRunningTimeMinutesLabel.Text = $"{episode.RunningTimeInMinutes}min";
            episodeRatingNumberLabel.Text = Helpers.FormatRating(episode.Rating);
            episodePlotOutlineTextBox.Text = episode.PlotOutline;
        }

        private void SaveEpisodeButton_Click(object sender, EventArgs e) {
            if(episodeComment == null) {   

                EpisodeComment ec = new EpisodeComment() {
                    EpisodeId = episode.EpisodeId,
                    Episode = episode,
                    UserId = user.Id,
                    User = user,
                    Comment = episodeCommentTextBox.Text
                };

                GlobalConfig.Connection.AddEpisodeComment(ec);
                Helpers.ShowMessageBox("AddEpisodeComment");

            } else {

                episodeComment.Comment = episodeCommentTextBox.Text;
                GlobalConfig.Connection.UpdateEpisodeComment(episodeComment);
                Helpers.ShowMessageBox("UpdateEpisodeComment");

            }        
        }
    }
}
