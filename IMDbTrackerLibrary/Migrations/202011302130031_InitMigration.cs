namespace IMDbTrackerLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PasswordResetKey", c => c.String(maxLength: 32));
            DropColumn("dbo.Users", "ResetPasswordKey");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "ResetPasswordKey", c => c.String(maxLength: 32));
            DropColumn("dbo.Users", "PasswordResetKey");
        }
    }
}
