namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDeletedAtToAllTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AirTraffics", "DeletedAt", c => c.DateTime());
            AddColumn("dbo.Logs", "DeletedAt", c => c.DateTime());
            AddColumn("dbo.Settings", "DeletedAt", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "DeletedAt");
            DropColumn("dbo.Logs", "DeletedAt");
            DropColumn("dbo.AirTraffics", "DeletedAt");
        }
    }
}
