namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBaseCreationbyField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Aircraft", "CreatedById", c => c.Int());
            AddColumn("dbo.Employees", "CreatedById", c => c.Int());
            AddColumn("dbo.Airports", "CreatedById", c => c.Int());
            AddColumn("dbo.AirTraffics", "CreatedById", c => c.Int());
            AddColumn("dbo.Flights", "CreatedById", c => c.Int());
            AddColumn("dbo.Gates", "CreatedById", c => c.Int());
            AddColumn("dbo.Terminals", "CreatedById", c => c.Int());
            AddColumn("dbo.Baggages", "CreatedById", c => c.Int());
            AddColumn("dbo.Tickets", "CreatedById", c => c.Int());
            AddColumn("dbo.Passengers", "CreatedById", c => c.Int());
            AddColumn("dbo.CheckIns", "CreatedById", c => c.Int());
            AddColumn("dbo.CrewAssignments", "CreatedById", c => c.Int());
            AddColumn("dbo.Logs", "CreatedById", c => c.Int());
            AddColumn("dbo.Settings", "CreatedById", c => c.Int());
            CreateIndex("dbo.Aircraft", "CreatedById");
            CreateIndex("dbo.Employees", "CreatedById");
            CreateIndex("dbo.Airports", "CreatedById");
            CreateIndex("dbo.AirTraffics", "CreatedById");
            CreateIndex("dbo.Flights", "CreatedById");
            CreateIndex("dbo.Gates", "CreatedById");
            CreateIndex("dbo.Terminals", "CreatedById");
            CreateIndex("dbo.Baggages", "CreatedById");
            CreateIndex("dbo.Tickets", "CreatedById");
            CreateIndex("dbo.Passengers", "CreatedById");
            CreateIndex("dbo.CheckIns", "CreatedById");
            CreateIndex("dbo.CrewAssignments", "CreatedById");
            CreateIndex("dbo.Logs", "CreatedById");
            CreateIndex("dbo.Settings", "CreatedById");
            AddForeignKey("dbo.Airports", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Employees", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Aircraft", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.AirTraffics", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Flights", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Gates", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Terminals", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Baggages", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Tickets", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Passengers", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.CheckIns", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.CrewAssignments", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Logs", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Settings", "CreatedById", "dbo.Employees", "Id");
            DropColumn("dbo.Aircraft", "CreatedBy");
            DropColumn("dbo.Employees", "CreatedBy");
            DropColumn("dbo.Airports", "CreatedBy");
            DropColumn("dbo.AirTraffics", "CreatedBy");
            DropColumn("dbo.Flights", "CreatedBy");
            DropColumn("dbo.Gates", "CreatedBy");
            DropColumn("dbo.Terminals", "CreatedBy");
            DropColumn("dbo.Baggages", "CreatedBy");
            DropColumn("dbo.Tickets", "CreatedBy");
            DropColumn("dbo.Passengers", "CreatedBy");
            DropColumn("dbo.CheckIns", "CreatedBy");
            DropColumn("dbo.CrewAssignments", "CreatedBy");
            DropColumn("dbo.Logs", "CreatedBy");
            DropColumn("dbo.Settings", "CreatedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Settings", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Logs", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.CrewAssignments", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.CheckIns", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Passengers", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Baggages", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Terminals", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Gates", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Flights", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.AirTraffics", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Airports", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "CreatedBy", c => c.Int(nullable: false));
            AddColumn("dbo.Aircraft", "CreatedBy", c => c.Int(nullable: false));
            DropForeignKey("dbo.Settings", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Logs", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.CrewAssignments", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.CheckIns", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Passengers", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Tickets", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Baggages", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Terminals", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Gates", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Flights", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.AirTraffics", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Aircraft", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Employees", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Airports", "CreatedById", "dbo.Employees");
            DropIndex("dbo.Settings", new[] { "CreatedById" });
            DropIndex("dbo.Logs", new[] { "CreatedById" });
            DropIndex("dbo.CrewAssignments", new[] { "CreatedById" });
            DropIndex("dbo.CheckIns", new[] { "CreatedById" });
            DropIndex("dbo.Passengers", new[] { "CreatedById" });
            DropIndex("dbo.Tickets", new[] { "CreatedById" });
            DropIndex("dbo.Baggages", new[] { "CreatedById" });
            DropIndex("dbo.Terminals", new[] { "CreatedById" });
            DropIndex("dbo.Gates", new[] { "CreatedById" });
            DropIndex("dbo.Flights", new[] { "CreatedById" });
            DropIndex("dbo.AirTraffics", new[] { "CreatedById" });
            DropIndex("dbo.Airports", new[] { "CreatedById" });
            DropIndex("dbo.Employees", new[] { "CreatedById" });
            DropIndex("dbo.Aircraft", new[] { "CreatedById" });
            DropColumn("dbo.Settings", "CreatedById");
            DropColumn("dbo.Logs", "CreatedById");
            DropColumn("dbo.CrewAssignments", "CreatedById");
            DropColumn("dbo.CheckIns", "CreatedById");
            DropColumn("dbo.Passengers", "CreatedById");
            DropColumn("dbo.Tickets", "CreatedById");
            DropColumn("dbo.Baggages", "CreatedById");
            DropColumn("dbo.Terminals", "CreatedById");
            DropColumn("dbo.Gates", "CreatedById");
            DropColumn("dbo.Flights", "CreatedById");
            DropColumn("dbo.AirTraffics", "CreatedById");
            DropColumn("dbo.Airports", "CreatedById");
            DropColumn("dbo.Employees", "CreatedById");
            DropColumn("dbo.Aircraft", "CreatedById");
        }
    }
}
