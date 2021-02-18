using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using IMDbTrackerLibrary;
using IMDbTrackerLibrary.Models;
using IMDbTrackerLibrary.Models.API;

namespace IMDbTrackerUI {

    public partial class ShowsForm : Form {
        private readonly User user;
        private readonly API api;

        private Show selectedShow;
        private ShowSeason selectedSeason;
        private List<Show> shows;
        private List<ShowSeason> seasons;
        private readonly List<ShowType> showTypes;

        private string CurrentEndpointSlug;
        private const string FavoritesEndpointSlug = "favorites";
        private const string MostPopularEndpointSlug = "most-popular-shows";
        private const string AddToFavoritesText = "Add to favorites";
        private const string RemoveFromFavoritesText = "Remove from favorites";

        public ShowsForm(User userModel) {
            InitializeComponent();

            user = userModel;

            api = new API(user);

            showTypes = new List<ShowType>() {
                new ShowType{ Description = "Favorites", Endpoint = FavoritesEndpointSlug },
                new ShowType{ Description = "Most popular", Endpoint = MostPopularEndpointSlug }
            };
        }

        private void ShowsForm_Load(object sender, EventArgs e) {
            showsTypeComboBox.DisplayMember = "description";
            showsTypeComboBox.ValueMember = "endpoint";
            showsTypeComboBox.Items.AddRange(showTypes.ToArray());
            showsTypeComboBox.SelectedIndex = 0;
        }

        private void FilterShowsTextBox_TextChanged(object sender, EventArgs e) {
            string text = filterShowsTextBox.Text;

            List<Show> filteredShowsList = shows.Where(show => show.Title.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            showsListBox.Items.Clear();
            showsListBox.Items.AddRange(filteredShowsList.ToArray());
        }

        private void ShowsTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ShowType selectedShowType = (ShowType)showsTypeComboBox.SelectedItem;
            CurrentEndpointSlug = selectedShowType.Endpoint;
            GetShowsByType(CurrentEndpointSlug);
        }

        private void ShowsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if((Show)showsListBox.SelectedItem == selectedShow) {
                return;
            }

            if(shows.Count == 0) {
                addRemoveFavoritesButton.Enabled = false;
                showSeasonEpisodesButton.Enabled = false;
                return;
            }
            
            selectedShow = (Show)showsListBox.SelectedItem;

            GetShowSeasons(selectedShow.Id);

            showTitleLabel.Text = selectedShow.Title;

            string showStartYear = selectedShow.SeriesStartYear.ToString();
            string showEndYear = selectedShow.SeriesEndYear.ToString();

            if(selectedShow.SeriesEndYear > 0) {
                showStartEndYearsLabel.Text = $"{showStartYear} - {showEndYear}";
            } else {
                showStartEndYearsLabel.Text = showStartYear;
            }

            showPlotOutlineTextBox.Text = selectedShow.PlotOutline;

            FavoriteShow fs = new FavoriteShow() {
                ShowId = selectedShow.Id,
                Show = selectedShow,
                UserId = user.Id,
                User = user
            };

            FavoriteShow favoriteShow = GlobalConfig.Connection.FindFavoriteShowByIds(fs);
            if(favoriteShow == null) {
                addRemoveFavoritesButton.Text = AddToFavoritesText;
            } else {
                addRemoveFavoritesButton.Text = RemoveFromFavoritesText;
            }

            showCoverPictureBox.LoadAsync(selectedShow.ImageUrl);

            addRemoveFavoritesButton.Enabled = true;
        }

        private void SeasonsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if(seasons.Count == 0) {
                showSeasonEpisodesButton.Enabled = false;
                return;
            }

            selectedSeason = (ShowSeason)seasonsListBox.SelectedItem;

            addRemoveFavoritesButton.Enabled = true;
            showSeasonEpisodesButton.Enabled = true;
        }

        private void AddRemoveFavoritesButton_Click(object sender, EventArgs e) {
            FavoriteShow fs = new FavoriteShow() {
                ShowId = selectedShow.Id,
                Show = selectedShow,
                UserId = user.Id,
                User = user
            };

            FavoriteShow favoriteShow = GlobalConfig.Connection.FindFavoriteShowByIds(fs);

            if(favoriteShow == null) {

                GlobalConfig.Connection.AddFavoriteShow(fs);

                addRemoveFavoritesButton.Text = RemoveFromFavoritesText;

                shows.Add(selectedShow);

            } else {

                GlobalConfig.Connection.RemoveFavoriteShow(favoriteShow);

                addRemoveFavoritesButton.Text = AddToFavoritesText;

                shows.Remove(selectedShow);

                seasonsListBox.Items.Clear();
                selectedSeason = null;
                selectedShow = null;
            }

            if(CurrentEndpointSlug == FavoritesEndpointSlug) {
                PopulateShowsListBox();
            }
        }

        private void ShowSeasonButton_Click(object sender, EventArgs e) {
            EpisodesForm episodesForm = new EpisodesForm(user, selectedSeason, selectedShow);
            episodesForm.Show();
        }

        private void GetFavoriteShows() {
            shows = new List<Show>();

            List<FavoriteShow> userFavoriteShows = GlobalConfig.Connection.FindUserFavoriteShows(user);
            if(userFavoriteShows.Count > 0) {
                userFavoriteShows.ForEach(fs => shows.Add(GlobalConfig.Connection.FindShowById(fs.ShowId)));
            }

            PopulateShowsListBox();
        }

        private async void GetMostPopularShows() {
            shows = new List<Show>();

            var showIds = await api.GetMostPopular("get-most-popular-tv-shows");

            foreach(var showId in showIds) {
                Show show = GlobalConfig.Connection.FindShowById(showId);

                if(show != null) {
                    shows.Add(show);
                } else {

                    ShowDetails showDetails = await api.GetShowDetails(showId);

                    show = new Show() {
                        Id = showDetails.Id,
                        Title = showDetails.Title.Title,
                        ImageUrl = showDetails.Title.Image.Url,
                        RunningTimeInMinutes = showDetails.Title.RunningTimeInMinutes,
                        NumberOfEpisodes = showDetails.Title.NumberOfEpisodes,
                        SeriesStartYear = showDetails.Title.SeriesStartYear,
                        SeriesEndYear = showDetails.Title.SeriesEndYear,
                        Rating = showDetails.Ratings.Rating,
                        Genres = string.Join(", ", showDetails.Genres),
                        Year = showDetails.Title.Year,
                        ReleaseDate = DateTime.Parse(showDetails.ReleaseDate),
                        PlotOutline = showDetails.PlotOutline != null ? showDetails.PlotOutline.Text : "",
                        PlotSummary = showDetails.PlotSummary != null ? showDetails.PlotSummary.Text : ""
                    };

                    GlobalConfig.Connection.AddShow(show);

                    shows.Add(show);
                }

                PopulateShowsListBox();
            } 
        }

        private async void GetShowSeasons(string showId) {
            seasons = new List<ShowSeason>();

            List<ShowSeason> showSeasons = await api.GetShowSeasons(showId);
            seasons = showSeasons;

            PopulateSeasonsListBox();
        }

        private void PopulateShowsListBox() {
            showsListBox.DisplayMember = "Title";
            showsListBox.ValueMember = "Id";
            showsListBox.Items.Clear();

            if(shows.Count == 0) {
                selectedShow = null;
                addRemoveFavoritesButton.Enabled = false;
                showSeasonEpisodesButton.Enabled = false;
                return;
            }

            showsListBox.Items.AddRange(shows.ToArray());

            SetActiveShowsListBoxItem();
        }

        private void PopulateSeasonsListBox() {
            seasonsListBox.DisplayMember = "season";
            seasonsListBox.ValueMember = "season";
            seasonsListBox.Items.Clear();

            if(seasons.Count == 0) {
                selectedShow = null;
                addRemoveFavoritesButton.Enabled = false;
                showSeasonEpisodesButton.Enabled = false;
                return;
            }

            seasonsListBox.Items.AddRange(seasons.ToArray());

            SetActiveSeasonsListBoxItem();
        }

        private void SetActiveShowsListBoxItem() {

            showsListBox.SetSelected(0, true);

            if((Show)showsListBox.SelectedItem != selectedShow) {
                selectedShow = new Show();
                selectedShow = (Show)showsListBox.SelectedItem;
            }
        }

        private void SetActiveSeasonsListBoxItem() {

            showsListBox.SelectedIndex = 0;

            if((ShowSeason)seasonsListBox.SelectedItem != selectedSeason) {
                selectedSeason = new ShowSeason();
                selectedSeason = (ShowSeason)seasonsListBox.SelectedItem;
            }

            seasonsListBox.SetSelected(0, true);
        }

        private void GetShowsByType(string endpoint) {
            switch(endpoint) {
                case FavoritesEndpointSlug:
                    GetFavoriteShows();
                    break;
                case MostPopularEndpointSlug:
                    GetMostPopularShows();
                    break;
            }
        }
    }
}
