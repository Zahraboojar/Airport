namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_IsDeleted_Field : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Airports", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.AirTraffics", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Employees", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Flights", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Aircrafts", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Baggages", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Tickets", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Passengers", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.CrewAssignments", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Gates", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Logs", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Settings", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "IsDeleted");
            DropColumn("dbo.Logs", "IsDeleted");
            DropColumn("dbo.Gates", "IsDeleted");
            DropColumn("dbo.CrewAssignments", "IsDeleted");
            DropColumn("dbo.Passengers", "IsDeleted");
            DropColumn("dbo.Tickets", "IsDeleted");
            DropColumn("dbo.Baggages", "IsDeleted");
            DropColumn("dbo.Aircrafts", "IsDeleted");
            DropColumn("dbo.Flights", "IsDeleted");
            DropColumn("dbo.Employees", "IsDeleted");
            DropColumn("dbo.AirTraffics", "IsDeleted");
            DropColumn("dbo.Airports", "IsDeleted");
        }
    }
}
