using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IMDbTrackerLibrary;
using IMDbTrackerLibrary.Models;
using IMDbTrackerLibrary.Models.API;

namespace IMDbTrackerUI {
    public partial class EpisodesForm : Form {
        private User user;
        private API api;
        private Show show;
        private ShowSeason season;
        private Episode selectedEpisode;
        private List<Episode> episodes;

        public EpisodesForm(User userModel, ShowSeason seasonModel, Show showModel) {
            InitializeComponent();

            user = userModel;
            show = showModel;
            season = seasonModel;

            this.Text = $"{this.Text} - {show.Title} - Episodes - Season {season.Season}";
            this.AcceptButton = episodeDetailsButton;

            api = new API(user);
        }

        private void EpisodesForm_Load(object sender, EventArgs e) {
            GetSeasonEpisodes();
        }

        private void EpisodeDetailsButton_Click(object sender, EventArgs e) {
            EpisodeForm episodeForm = new EpisodeForm(user, selectedEpisode);
            episodeForm.Show();
        }

        private void SeasonsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if((Episode)episodesListBox.SelectedItem == selectedEpisode) {
                return;
            }

            selectedEpisode = (Episode)episodesListBox.SelectedItem;

            showTitleLabel.Text = show.Title;
            seasonLabel.Text = $"Season {selectedEpisode.Season.ToString()}";
            episodeTitleLabel.Text = selectedEpisode.Title;

            episodeCoverPictureBox.LoadAsync(selectedEpisode.ImageUrl);

            episodeDetailsButton.Enabled = true;
        }

        private async void GetSeasonEpisodes() {
            episodes = new List<Episode>();

            foreach(var ep in season.Episodes) {
                Episode episode = GlobalConfig.Connection.FindEpisodeById(ep.Id);

                if(episode != null) {
                    episodes.Add(episode);
                } else {

                    EpisodeDetails episodeDetails = await api.GetEpisodeDetails(ep.Id);

                    episode = new Episode() {
                        EpisodeId = episodeDetails.Id,
                        ShowId = show.Id,
                        Show = show,
                        Title = episodeDetails.Title.Title,
                        EpisodeNumber = episodeDetails.Title.Episode,
                        ImageUrl = episodeDetails.Title.Image.Url,
                        RunningTimeInMinutes = episodeDetails.Title.RunningTimeInMinutes,
                        Season = episodeDetails.Title.Season,
                        Rating = episodeDetails.Ratings.Rating,
                        Genres = string.Join(", ", episodeDetails.Genres),
                        Year = episodeDetails.Title.Year,
                        ReleseDate = DateTime.Parse(episodeDetails.ReleaseDate),
                        PlotOutline = episodeDetails.PlotOutline.Text,
                    };

                    GlobalConfig.Connection.AddEpisode(episode);

                    episodes.Add(episode);

                }

                PopulateListBox();   
                
            }
        }

        private void PopulateListBox() {

            episodesListBox.DisplayMember = "Title";
            episodesListBox.ValueMember = "Id";
            episodesListBox.Items.Clear();

            if(episodes.Count == 0) {
                episodeDetailsButton.Enabled = false;
                selectedEpisode = null;
                return;
            }

            episodesListBox.Items.AddRange(episodes.ToArray());

            SetActiveListBoxItem();
        }

        private void SetActiveListBoxItem() {
            if((Episode)episodesListBox.SelectedItem != selectedEpisode) {
                selectedEpisode = new Episode();
                selectedEpisode = (Episode)episodesListBox.SelectedItem;
            }

            episodesListBox.SetSelected(0, true);
        }
    }
}
