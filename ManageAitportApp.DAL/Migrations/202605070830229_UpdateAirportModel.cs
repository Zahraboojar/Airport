namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAirportModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AirTraffics", "AirportId", "dbo.Airports");
            DropForeignKey("dbo.AirTraffics", "ControllerId", "dbo.Employees");
            DropForeignKey("dbo.AirTraffics", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Flights", "AircraftId", "dbo.Aircraft");
            DropForeignKey("dbo.Gates", "AirportId", "dbo.Airports");
            DropForeignKey("dbo.Baggages", "TicketId", "dbo.Tickets");
            DropForeignKey("dbo.Tickets", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Tickets", "PassengerId", "dbo.Passengers");
            DropForeignKey("dbo.CrewAssignments", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.CrewAssignments", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Settings", "AirportID", "dbo.Airports");
            DropIndex("dbo.Employees", new[] { "AirportId" });
            DropIndex("dbo.Flights", new[] { "DepartureAirportId" });
            DropIndex("dbo.Flights", new[] { "ArrivalAirportId" });
            DropIndex("dbo.Logs", new[] { "AirportId" });
            AlterColumn("dbo.Employees", "AirportId", c => c.Int(nullable: false));
            AlterColumn("dbo.Flights", "DepartureAirportId", c => c.Int(nullable: false));
            AlterColumn("dbo.Flights", "ArrivalAirportId", c => c.Int(nullable: false));
            AlterColumn("dbo.Logs", "AirportId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "AirportId");
            CreateIndex("dbo.Flights", "DepartureAirportId");
            CreateIndex("dbo.Flights", "ArrivalAirportId");
            CreateIndex("dbo.Logs", "AirportId");
            AddForeignKey("dbo.AirTraffics", "AirportId", "dbo.Airports", "Id");
            AddForeignKey("dbo.AirTraffics", "ControllerId", "dbo.Employees", "Id");
            AddForeignKey("dbo.AirTraffics", "FlightId", "dbo.Flights", "Id");
            AddForeignKey("dbo.Flights", "AircraftId", "dbo.Aircraft", "Id");
            AddForeignKey("dbo.Gates", "AirportId", "dbo.Airports", "Id");
            AddForeignKey("dbo.Baggages", "TicketId", "dbo.Tickets", "Id");
            AddForeignKey("dbo.Tickets", "FlightId", "dbo.Flights", "Id");
            AddForeignKey("dbo.Tickets", "PassengerId", "dbo.Passengers", "Id");
            AddForeignKey("dbo.CrewAssignments", "EmployeeId", "dbo.Employees", "Id");
            AddForeignKey("dbo.CrewAssignments", "FlightId", "dbo.Flights", "Id");
            AddForeignKey("dbo.Settings", "AirportID", "dbo.Airports", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Settings", "AirportID", "dbo.Airports");
            DropForeignKey("dbo.CrewAssignments", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.CrewAssignments", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Tickets", "PassengerId", "dbo.Passengers");
            DropForeignKey("dbo.Tickets", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Baggages", "TicketId", "dbo.Tickets");
            DropForeignKey("dbo.Gates", "AirportId", "dbo.Airports");
            DropForeignKey("dbo.Flights", "AircraftId", "dbo.Aircraft");
            DropForeignKey("dbo.AirTraffics", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.AirTraffics", "ControllerId", "dbo.Employees");
            DropForeignKey("dbo.AirTraffics", "AirportId", "dbo.Airports");
            DropIndex("dbo.Logs", new[] { "AirportId" });
            DropIndex("dbo.Flights", new[] { "ArrivalAirportId" });
            DropIndex("dbo.Flights", new[] { "DepartureAirportId" });
            DropIndex("dbo.Employees", new[] { "AirportId" });
            AlterColumn("dbo.Logs", "AirportId", c => c.Int());
            AlterColumn("dbo.Flights", "ArrivalAirportId", c => c.Int());
            AlterColumn("dbo.Flights", "DepartureAirportId", c => c.Int());
            AlterColumn("dbo.Employees", "AirportId", c => c.Int());
            CreateIndex("dbo.Logs", "AirportId");
            CreateIndex("dbo.Flights", "ArrivalAirportId");
            CreateIndex("dbo.Flights", "DepartureAirportId");
            CreateIndex("dbo.Employees", "AirportId");
            AddForeignKey("dbo.Settings", "AirportID", "dbo.Airports", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CrewAssignments", "FlightId", "dbo.Flights", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CrewAssignments", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tickets", "PassengerId", "dbo.Passengers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tickets", "FlightId", "dbo.Flights", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Baggages", "TicketId", "dbo.Tickets", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Gates", "AirportId", "dbo.Airports", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Flights", "AircraftId", "dbo.Aircraft", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AirTraffics", "FlightId", "dbo.Flights", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AirTraffics", "ControllerId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AirTraffics", "AirportId", "dbo.Airports", "Id", cascadeDelete: true);
        }
    }
}
