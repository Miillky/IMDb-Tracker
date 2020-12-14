using System;
using System.Collections.Generic;
using System.Linq;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess.Entity {
    class EntityConnector : IDataConnection {

        private readonly IMDbTrackerContext context = new IMDbTrackerContext();

        public void CreateTables() {
        }

        public void CreateUser(User model) {
            context.Users.Add(model);
            context.SaveChangesAsync();
        }

        public void UpdateUser(User model) {
            User user = context.Users.SingleOrDefault(u => u.Id == model.Id);
            if(user != null) {
                context.Entry(user).CurrentValues.SetValues(model);
                context.SaveChangesAsync();
            }
        }

        public void DeleteUser(User model) {
            context.Users.Attach(model);
            context.Users.Remove(model);
            context.SaveChangesAsync();
        }

        public User FindUserByUsername(string username) {
            return context.Users.Where(u => u.Username == username).SingleOrDefault();
        }

        public User FindUserByEmail(string email) {
            return context.Users.Where(u => u.Email == email).SingleOrDefault();
        }

        public bool UsernameExists(string username) {
            if(context.Users.Where(u => u.Username == username).SingleOrDefault() != null) {
                return true;
            }
            return false;
        }

        public bool EmailExists(string email, int userId) {
            if(userId > 0) {
                if(context.Users.Where(u => u.Email == email && u.Id == userId).SingleOrDefault() != null) {
                    return false;
                }
            }

            if(context.Users.Where(u => u.Email == email).SingleOrDefault() != null) {
                return true;
            }

            return false;
        }

        public bool APIKeyExists(string apiKey, int userId) {
            if(userId > 0) {
                if(context.Users.Where(u => u.APIKey == apiKey && u.Id == userId).SingleOrDefault() != null) {
                    return false;
                }
            }

            if(context.Users.Where(u => u.APIKey == apiKey).SingleOrDefault() != null) {
                return true;
            }
            return false;
        }

        public void SetPasswordResetToken(User model, string passwordResetToken, DateTime passwordResetTokenValid) {
            User user = context.Users.SingleOrDefault(u => u.Id == model.Id);
            if(user != null) {
                model.PasswordResetToken = passwordResetToken;
                model.PasswordResetTokenValid = passwordResetTokenValid;
                context.Entry(user).CurrentValues.SetValues(model);
                context.SaveChangesAsync();
            }
        }

        public (string, DateTime?) GetPasswordResetToken(User model) {
            User user = context.Users.Where(u => u.Id == model.Id).SingleOrDefault();
            return (user.PasswordResetToken, user.PasswordResetTokenValid);
        }

        public void AddShow(Show model) {
            context.Shows.Add(model);
            context.SaveChangesAsync();
        }

        public void AddShows(List<Show> shows) {
            shows.ForEach(show => context.Shows.Add(show));
            context.SaveChanges();
        }

        public Show FindShowById(string showId) {
            return context.Shows.Where(s => s.Id == showId).SingleOrDefault();
        }

        public void AddEpisode(Episode model) {
            context.Episodes.Add(model);
            context.SaveChangesAsync();
        }

        public void AddEpisodes(List<Episode> episodes) {
            episodes.ForEach(episode => context.Episodes.Add(episode));
            context.SaveChangesAsync();
        }

        public Episode FindEpisodeById(string episodeId) {
            return context.Episodes.Where(e => e.Id == episodeId).SingleOrDefault();
        }

        public void AddMovie(Movie model) {
            context.Movies.Add(model);
            context.SaveChanges();
        }

        public void AddMovies(List<Movie> movies) {
            movies.ForEach(movie => context.Movies.Add(movie));
            context.SaveChangesAsync();
        }

        public Movie FindMovieById(string movieId) {
            return context.Movies.Where(m => m.Id == movieId).SingleOrDefault();
        }

        public void AddFavoriteShow(Show model) {
            context.Shows.Add(model);
            context.SaveChangesAsync();
        }

        public void RemoveFavoriteShow(FavoriteShow model) {
            context.FavoriteShows.Attach(model);
            context.FavoriteShows.Remove(model);
            context.SaveChanges();
        }

        public FavoriteShow FindFavoriteShowByIds(FavoriteShow model) {
            return context.FavoriteShows.Where(fs => fs.ShowId == model.ShowId && fs.UserId == model.UserId).SingleOrDefault();
        }

        public List<FavoriteShow> FindUserFavoriteShows(User model) {
            return context.FavoriteShows.Where(fs => fs.UserId == model.Id).ToList();
        }

        public void AddFavoriteMovie(FavoriteMovie model) {
            context.FavoriteMovies.Add(model);
            context.SaveChangesAsync();
        }

        public void RemoveFavoriteMovie(FavoriteMovie model) {
            context.FavoriteMovies.Attach(model);
            context.FavoriteMovies.Remove(model);
            context.SaveChanges();    
        }

        public FavoriteMovie FindFavoriteMovieByIds(FavoriteMovie model) {
            return context.FavoriteMovies.Where(fm => fm.MovieId == model.MovieId && fm.UserId == model.UserId).SingleOrDefault();
        }

        public List<FavoriteMovie> FindUserFavoriteMovies(User model) {
            return context.FavoriteMovies.Where(fm => fm.UserId == model.Id).ToList();
        }

        public void AddShowComment(ShowComment model) {
            context.ShowComments.Add(model);
            context.SaveChangesAsync();
        }

        public void UpdateShowComment(ShowComment model) {
            ShowComment showComment = context.ShowComments.SingleOrDefault(u => u.Id == model.Id);
            if(showComment != null) {
                context.Entry(showComment).CurrentValues.SetValues(model);
                context.SaveChangesAsync();
            }
        }

        public ShowComment FindShowComment(Show show, User user) {
            return context.ShowComments.Where(sc => sc.ShowId == show.Id && sc.UserId == user.Id).SingleOrDefault();
        }

        public void AddEpisodeComment(EpisodeComment model) {
            context.EpisodeComments.Add(model);
            context.SaveChangesAsync();
        }

        public void UpdateEpisodeComment(EpisodeComment model) {
            EpisodeComment episodeComment = context.EpisodeComments.SingleOrDefault(u => u.Id == model.Id);
            if(episodeComment != null) {
                context.Entry(episodeComment).CurrentValues.SetValues(model);
                context.SaveChangesAsync();
            }
        }

        public EpisodeComment FindEpisodeComment(Episode episode, User user) {
            return context.EpisodeComments.Where(ec => ec.EpisodeId == episode.Id && ec.UserId == user.Id).SingleOrDefault();
        }

        public void AddMovieComment(MovieComment model) {
            context.MovieComments.Add(model);
            context.SaveChangesAsync();
        }

        public void UpdateMovieComment(MovieComment model) {
            MovieComment movieComment = context.MovieComments.SingleOrDefault(u => u.Id == model.Id);
            if(movieComment != null) {
                context.Entry(movieComment).CurrentValues.SetValues(model);
                context.SaveChangesAsync();
            }
        }

        public MovieComment FindMovieComment(Movie movie, User user) {
            return context.MovieComments.Where(mc => mc.MovieId == movie.Id && mc.UserId == user.Id).SingleOrDefault();
        }
    }
}