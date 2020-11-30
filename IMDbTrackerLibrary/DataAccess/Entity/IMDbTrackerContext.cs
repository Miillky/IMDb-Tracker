using System.Data.Entity;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess.Entity {
    public class IMDbTrackerContext : DbContext {
        public IMDbTrackerContext() : base("name=Entity") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
