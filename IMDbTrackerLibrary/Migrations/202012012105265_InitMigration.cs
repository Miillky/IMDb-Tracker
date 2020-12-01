namespace IMDbTrackerLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FavoriteMovies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 150),
                        Password = c.String(nullable: false, maxLength: 150),
                        FirstName = c.String(nullable: false, maxLength: 150),
                        LastName = c.String(nullable: false, maxLength: 150),
                        Email = c.String(nullable: false, maxLength: 150),
                        APIKey = c.String(nullable: false, maxLength: 150),
                        LastLogin = c.DateTime(precision: 7, storeType: "datetime2"),
                        PasswordResetKey = c.String(maxLength: 32),
                        PasswordResetKeyValid = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FavoriteShows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FavoriteShows", "UserId", "dbo.Users");
            DropForeignKey("dbo.FavoriteMovies", "UserId", "dbo.Users");
            DropIndex("dbo.FavoriteShows", new[] { "UserId" });
            DropIndex("dbo.FavoriteMovies", new[] { "UserId" });
            DropTable("dbo.FavoriteShows");
            DropTable("dbo.Users");
            DropTable("dbo.FavoriteMovies");
        }
    }
}
