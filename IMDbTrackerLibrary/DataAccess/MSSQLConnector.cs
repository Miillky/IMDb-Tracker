using System;
using System.Collections.Generic;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess {
    class MSSQLConnector : IDataConnection {

        private string db = GlobalConfig.ConnectionString();

        public void CreateTables() {
            throw new NotImplementedException();
        }
        public void CreateUser(User model) {
            throw new NotImplementedException();
        }

        public void UpdateUser(User model) {
            throw new NotImplementedException();
        }

        public void DeleteUser(User model) {
            throw new NotImplementedException();
        }

        public void CreateUsersTable() {
            throw new NotImplementedException();
        }

        public User FindUserByUsername(string username) {
            throw new NotImplementedException();
        }

        public User FindUserByEmail(string email) {
            throw new NotImplementedException();
        }

        public bool UsernameExists(string username) {
            throw new NotImplementedException();

        }

        public bool EmailExists(string email, int userId) {
            throw new NotImplementedException();
        }

        public bool APIKeyExists(string apiKey, int userId) {
            throw new NotImplementedException();
        }

        public void SetPasswordResetToken(User model, string passwordResetKey, DateTime passwordResetTokenValid) {
            throw new NotImplementedException();
        }

        public (string, DateTime?) GetPasswordResetToken(User model) {
            throw new NotImplementedException();
        }

        public void AddShow(Show model) {
            throw new NotImplementedException();
        }

        public Show FindShowById(string showId) {
            throw new NotImplementedException();
        }

        public void AddMovie(Movie model) {
            throw new NotImplementedException();
        }

        public Movie FindMovieById(string showId) {
            throw new NotImplementedException();
        }

        public void AddFavoriteShow(Show model) {
            throw new NotImplementedException();
        }

        public void RemoveFavoriteShow(FavoriteShow model) {
            throw new NotImplementedException();
        }

        public FavoriteShow FindFavoriteShowByIds(FavoriteShow model) {
            throw new NotImplementedException();
        }

        public void AddFavoriteMovie(FavoriteMovie model) {
            throw new NotImplementedException();
        }

        public void RemoveFavoriteMovie(FavoriteMovie model) {
            throw new NotImplementedException();
        }

        public FavoriteMovie FindFavoriteMovieByIds(FavoriteMovie model) {
            throw new NotImplementedException();
        }

        public void AddShows(List<Show> shows) {
            throw new NotImplementedException();
        }

        public void AddMovies(List<Movie> movies) {
            throw new NotImplementedException();
        }

        public List<FavoriteShow> FindUserFavoriteShows(User model) {
            throw new NotImplementedException();
        }

        public List<FavoriteMovie> FindUserFavoriteMovies(User model) {
            throw new NotImplementedException();
        }

        public void AddEpisode(Episode model) {
            throw new NotImplementedException();
        }

        public void AddEpisodes(List<Episode> episodes) {
            throw new NotImplementedException();
        }

        public Episode FindEpisodeById(string episodeId) {
            throw new NotImplementedException();
        }

        public ShowComment FindShowComment(Show show, User user) {
            throw new NotImplementedException();
        }

        public EpisodeComment FindEpisodeComment(Episode epside, User user) {
            throw new NotImplementedException();
        }

        public MovieComment FindMovieComment(Movie movie, User user) {
            throw new NotImplementedException();
        }

        public void AddShowComment(ShowComment model) {
            throw new NotImplementedException();
        }

        public void AddEpisodeComment(EpisodeComment model) {
            throw new NotImplementedException();
        }

        public void AddMovieComment(MovieComment model) {
            throw new NotImplementedException();
        }

        public void UpdateShowComment(ShowComment model) {
            throw new NotImplementedException();
        }

        public void UpdateEpisodeComment(EpisodeComment model) {
            throw new NotImplementedException();
        }

        public void UpdateMovieComment(MovieComment model) {
            throw new NotImplementedException();
        }
    }
}
