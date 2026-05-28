namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDeletedByToAllTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AirTraffics", "DeletedBy", c => c.Int());
            AddColumn("dbo.Logs", "DeletedBy", c => c.Int());
            AddColumn("dbo.Settings", "DeletedBy", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "DeletedBy");
            DropColumn("dbo.Logs", "DeletedBy");
            DropColumn("dbo.AirTraffics", "DeletedBy");
        }
    }
}
