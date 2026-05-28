namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAirportDB : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gates", "FK_dbo.Gates_dbo.Aircrafts_AircraftId");
            DropIndex("dbo.Gates", new[] { "AircraftId" });
            AddColumn("dbo.Gates", "AirportId", c => c.Int(nullable: false));
            CreateIndex("dbo.Gates", "AirportId");
            AddForeignKey("dbo.Gates", "AirportId", "dbo.Airports", "Id", cascadeDelete: true);
            DropColumn("dbo.Gates", "AircraftId");
        }

        public override void Down()
        {
            AddColumn("dbo.Gates", "AircraftId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Gates", "AirportId", "dbo.Airports");
            DropIndex("dbo.Gates", new[] { "AirportId" });
            DropColumn("dbo.Gates", "AirportId");
            CreateIndex("dbo.Gates", "AircraftId");
            AddForeignKey("dbo.Gates", "AircraftId", "dbo.Aircraft", "Id", cascadeDelete: true);
        }
    }
}
