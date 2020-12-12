namespace IMDbTrackerLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FavoriteMovie",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MovieId = c.String(nullable: false, maxLength: 150),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movie", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Movie",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 150),
                        Title = c.String(nullable: false, maxLength: 255),
                        ImageUrl = c.String(nullable: false, maxLength: 255),
                        RunningTimeInMinutes = c.Int(nullable: false),
                        ReleseDate = c.DateTime(precision: 7, storeType: "datetime2"),
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
                "dbo.FavoriteShow",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ShowId = c.String(nullable: false, maxLength: 150),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Show", t => t.ShowId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ShowId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Show",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 150),
                        Title = c.String(nullable: false, maxLength: 255),
                        ImageUrl = c.String(nullable: false, maxLength: 255),
                        ReleseDate = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FavoriteShow", "UserId", "dbo.Users");
            DropForeignKey("dbo.FavoriteShow", "ShowId", "dbo.Show");
            DropForeignKey("dbo.FavoriteMovie", "UserId", "dbo.Users");
            DropForeignKey("dbo.FavoriteMovie", "MovieId", "dbo.Movie");
            DropIndex("dbo.FavoriteShow", new[] { "UserId" });
            DropIndex("dbo.FavoriteShow", new[] { "ShowId" });
            DropIndex("dbo.FavoriteMovie", new[] { "UserId" });
            DropIndex("dbo.FavoriteMovie", new[] { "MovieId" });
            DropTable("dbo.Show");
            DropTable("dbo.FavoriteShow");
            DropTable("dbo.Users");
            DropTable("dbo.Movie");
            DropTable("dbo.FavoriteMovie");
        }
    }
}
