using System;
using System.Data.Entity;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess.Entity {
    public class IMDbTrackerContext : DbContext {
        public IMDbTrackerContext() : base("name=Entity") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<FavoriteShow> FavoriteShows { get; set; }
        public DbSet<FavoriteMovie> FavoriteMovies { get; set; }
        public DbSet<ShowComment> ShowComments { get; set; }
        public DbSet<MovieComment> MovieComments { get; set; }
        public DbSet<EpisodeComment> EpisodeComments { get; set; }
    }
}
