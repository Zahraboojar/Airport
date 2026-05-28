namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedb1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Aircraft", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.AirTraffics", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Gates", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Terminals", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Baggages", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Tickets", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Passengers", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.CheckIns", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.CrewAssignments", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Logs", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Settings", "CreatedById", "dbo.Employees");
            DropIndex("dbo.Aircraft", new[] { "CreatedById" });
            DropIndex("dbo.Employees", new[] { "CreatedById" });
            DropIndex("dbo.Airports", new[] { "CreatedById" });
            DropIndex("dbo.AirTraffics", new[] { "CreatedById" });
            DropIndex("dbo.Flights", new[] { "CreatedById" });
            DropIndex("dbo.Gates", new[] { "CreatedById" });
            DropIndex("dbo.Terminals", new[] { "CreatedById" });
            DropIndex("dbo.Baggages", new[] { "CreatedById" });
            DropIndex("dbo.Tickets", new[] { "CreatedById" });
            DropIndex("dbo.Passengers", new[] { "CreatedById" });
            DropIndex("dbo.CheckIns", new[] { "CreatedById" });
            DropIndex("dbo.CrewAssignments", new[] { "CreatedById" });
            DropIndex("dbo.Logs", new[] { "CreatedById" });
            DropIndex("dbo.Settings", new[] { "CreatedById" });
            AlterColumn("dbo.Aircraft", "CreatedById", c => c.Int());
            AlterColumn("dbo.Employees", "CreatedById", c => c.Int());
            AlterColumn("dbo.Airports", "CreatedById", c => c.Int());
            AlterColumn("dbo.AirTraffics", "CreatedById", c => c.Int());
            AlterColumn("dbo.Flights", "CreatedById", c => c.Int());
            AlterColumn("dbo.Gates", "CreatedById", c => c.Int());
            AlterColumn("dbo.Terminals", "CreatedById", c => c.Int());
            AlterColumn("dbo.Baggages", "CreatedById", c => c.Int());
            AlterColumn("dbo.Tickets", "CreatedById", c => c.Int());
            AlterColumn("dbo.Passengers", "CreatedById", c => c.Int());
            AlterColumn("dbo.CheckIns", "CreatedById", c => c.Int());
            AlterColumn("dbo.CrewAssignments", "CreatedById", c => c.Int());
            AlterColumn("dbo.Logs", "CreatedById", c => c.Int());
            AlterColumn("dbo.Settings", "CreatedById", c => c.Int());
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
            AddForeignKey("dbo.Aircraft", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.AirTraffics", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Gates", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Terminals", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Baggages", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Tickets", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Passengers", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.CheckIns", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.CrewAssignments", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Logs", "CreatedById", "dbo.Employees", "Id");
            AddForeignKey("dbo.Settings", "CreatedById", "dbo.Employees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Settings", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Logs", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.CrewAssignments", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.CheckIns", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Passengers", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Tickets", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Baggages", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Terminals", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Gates", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.AirTraffics", "CreatedById", "dbo.Employees");
            DropForeignKey("dbo.Aircraft", "CreatedById", "dbo.Employees");
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
            AlterColumn("dbo.Settings", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Logs", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.CrewAssignments", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.CheckIns", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Passengers", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Tickets", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Baggages", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Terminals", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Gates", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Flights", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.AirTraffics", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Airports", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "CreatedById", c => c.Int(nullable: false));
            AlterColumn("dbo.Aircraft", "CreatedById", c => c.Int(nullable: false));
            CreateIndex("dbo.Settings", "CreatedById");
            CreateIndex("dbo.Logs", "CreatedById");
            CreateIndex("dbo.CrewAssignments", "CreatedById");
            CreateIndex("dbo.CheckIns", "CreatedById");
            CreateIndex("dbo.Passengers", "CreatedById");
            CreateIndex("dbo.Tickets", "CreatedById");
            CreateIndex("dbo.Baggages", "CreatedById");
            CreateIndex("dbo.Terminals", "CreatedById");
            CreateIndex("dbo.Gates", "CreatedById");
            CreateIndex("dbo.Flights", "CreatedById");
            CreateIndex("dbo.AirTraffics", "CreatedById");
            CreateIndex("dbo.Airports", "CreatedById");
            CreateIndex("dbo.Employees", "CreatedById");
            CreateIndex("dbo.Aircraft", "CreatedById");
            AddForeignKey("dbo.Settings", "CreatedById", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Logs", "CreatedById", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CrewAssignments", "CreatedById", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CheckIns", "CreatedById", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Passengers", "CreatedById", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tickets", "CreatedById", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Baggages", "CreatedById", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Terminals", "CreatedById", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Gates", "CreatedById", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AirTraffics", "CreatedById", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Aircraft", "CreatedById", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
