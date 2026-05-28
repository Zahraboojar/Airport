namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditSettingAndAirportFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Airports", "Tel", c => c.String());
            CreateIndex("dbo.Settings", "AirportID");
            AddForeignKey("dbo.Settings", "AirportID", "dbo.Airports", "Id", cascadeDelete: true);
            DropColumn("dbo.Settings", "Tel");
            DropColumn("dbo.Settings", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "Title", c => c.String());
            AddColumn("dbo.Settings", "Tel", c => c.String());
            DropForeignKey("dbo.Settings", "AirportID", "dbo.Airports");
            DropIndex("dbo.Settings", new[] { "AirportID" });
            DropColumn("dbo.Airports", "Tel");
        }
    }
}
