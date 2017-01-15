namespace Gighub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notifications", "OriginalVenue", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notifications", "OriginalVenue");
        }
    }
}
