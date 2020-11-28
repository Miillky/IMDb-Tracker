using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDbTrackerLibrary.Models;

namespace IMDbTrackerLibrary.DataAccess.Entity {
    class UserContext : DbContext {
        public UserContext() : base("name=ENTITY") { }
        DbSet<User> EmpList { get; set; }
    }
}
