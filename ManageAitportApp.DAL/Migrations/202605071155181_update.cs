namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Settings", new[] { "AirportID" });
            CreateIndex("dbo.Settings", "AirportId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Settings", new[] { "AirportId" });
            CreateIndex("dbo.Settings", "AirportID");
        }
    }
}
