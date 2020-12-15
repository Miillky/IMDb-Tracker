namespace IMDbTrackerLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EpisodeComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EpisodeId = c.String(nullable: false, maxLength: 150),
                        UserId = c.Int(nullable: false),
                        Comment = c.String(nullable: false, maxLength: 500),
                        Episode_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Episodes", t => t.Episode_Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.Episode_Id);
            
            CreateTable(
                "dbo.Episodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EpisodeId = c.String(nullable: false, maxLength: 150),
                        ShowId = c.String(nullable: false, maxLength: 150),
                        Title = c.String(nullable: false, maxLength: 255),
                        ImageUrl = c.String(nullable: false, maxLength: 250),
                        EpisodeNumber = c.Int(nullable: false),
                        RunningTimeInMinutes = c.Int(nullable: false),
                        Season = c.Int(nullable: false),
                        Rating = c.Double(nullable: false),
                        Genres = c.String(nullable: false, maxLength: 250),
                        Year = c.Int(nullable: false),
                        ReleseDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        PlotOutline = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shows", t => t.ShowId, cascadeDelete: true)
                .Index(t => t.ShowId);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 150),
                        Title = c.String(nullable: false, maxLength: 255),
                        ImageUrl = c.String(nullable: false, maxLength: 250),
                        RunningTimeInMinutes = c.Int(nullable: false),
                        NumberOfEpisodes = c.Int(nullable: false),
                        SeriesStartYear = c.Int(nullable: false),
                        SeriesEndYear = c.Int(nullable: false),
                        Rating = c.Double(nullable: false),
                        Genres = c.String(nullable: false, maxLength: 250),
                        Year = c.Int(nullable: false),
                        ReleseDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        PlotOutline = c.String(nullable: false, maxLength: 500),
                        PlotSummary = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 150),
                        FirstName = c.String(nullable: false, maxLength: 150),
                        LastName = c.String(nullable: false, maxLength: 150),
                        Email = c.String(nullable: false, maxLength: 150),
                        Password = c.String(nullable: false, maxLength: 150),
                        APIKey = c.String(nullable: false, maxLength: 150),
                        LastLogin = c.DateTime(precision: 7, storeType: "datetime2"),
                        PasswordResetToken = c.String(maxLength: 32),
                        PasswordResetTokenValid = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FavoriteMovies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.String(nullable: false, maxLength: 150),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 150),
                        Title = c.String(nullable: false, maxLength: 250),
                        ImageUrl = c.String(nullable: false, maxLength: 250),
                        RunningTimeInMinutes = c.Int(nullable: false),
                        Rating = c.Double(nullable: false),
                        Genres = c.String(nullable: false, maxLength: 250),
                        Year = c.Int(nullable: false),
                        ReleseDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        PlotOutline = c.String(nullable: false, maxLength: 500),
                        PlotSummary = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FavoriteShows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShowId = c.String(nullable: false, maxLength: 150),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shows", t => t.ShowId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ShowId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.MovieComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.String(nullable: false, maxLength: 150),
                        UserId = c.Int(nullable: false),
                        Comment = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ShowComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShowId = c.String(nullable: false, maxLength: 150),
                        UserId = c.Int(nullable: false),
                        Comment = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Shows", t => t.ShowId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ShowId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShowComments", "UserId", "dbo.Users");
            DropForeignKey("dbo.ShowComments", "ShowId", "dbo.Shows");
            DropForeignKey("dbo.MovieComments", "UserId", "dbo.Users");
            DropForeignKey("dbo.MovieComments", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.FavoriteShows", "UserId", "dbo.Users");
            DropForeignKey("dbo.FavoriteShows", "ShowId", "dbo.Shows");
            DropForeignKey("dbo.FavoriteMovies", "UserId", "dbo.Users");
            DropForeignKey("dbo.FavoriteMovies", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.EpisodeComments", "UserId", "dbo.Users");
            DropForeignKey("dbo.EpisodeComments", "Episode_Id", "dbo.Episodes");
            DropForeignKey("dbo.Episodes", "ShowId", "dbo.Shows");
            DropIndex("dbo.ShowComments", new[] { "UserId" });
            DropIndex("dbo.ShowComments", new[] { "ShowId" });
            DropIndex("dbo.MovieComments", new[] { "UserId" });
            DropIndex("dbo.MovieComments", new[] { "MovieId" });
            DropIndex("dbo.FavoriteShows", new[] { "UserId" });
            DropIndex("dbo.FavoriteShows", new[] { "ShowId" });
            DropIndex("dbo.FavoriteMovies", new[] { "UserId" });
            DropIndex("dbo.FavoriteMovies", new[] { "MovieId" });
            DropIndex("dbo.Episodes", new[] { "ShowId" });
            DropIndex("dbo.EpisodeComments", new[] { "Episode_Id" });
            DropIndex("dbo.EpisodeComments", new[] { "UserId" });
            DropTable("dbo.ShowComments");
            DropTable("dbo.MovieComments");
            DropTable("dbo.FavoriteShows");
            DropTable("dbo.Movies");
            DropTable("dbo.FavoriteMovies");
            DropTable("dbo.Users");
            DropTable("dbo.Shows");
            DropTable("dbo.Episodes");
            DropTable("dbo.EpisodeComments");
        }
    }
}
