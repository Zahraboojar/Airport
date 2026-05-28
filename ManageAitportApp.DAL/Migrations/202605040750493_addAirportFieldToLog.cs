namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAirportFieldToLog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Logs", "AirportId", c => c.Int());
            CreateIndex("dbo.Logs", "AirportId");
            AddForeignKey("dbo.Logs", "AirportId", "dbo.Airports", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logs", "AirportId", "dbo.Airports");
            DropIndex("dbo.Logs", new[] { "AirportId" });
            DropColumn("dbo.Logs", "AirportId");
        }
    }
}
