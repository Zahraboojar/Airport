namespace ManageAitportApp.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Airports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Region = c.String(),
                        IATA_Code = c.String(),
                        ICAO_Code = c.String(),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AirTraffics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlightId = c.Int(nullable: false),
                        AirportId = c.Int(nullable: false),
                        EventType = c.Int(nullable: false),
                        EventTime = c.DateTime(nullable: false),
                        ControllerId = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airports", t => t.AirportId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.ControllerId, cascadeDelete: true)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .Index(t => t.FlightId)
                .Index(t => t.AirportId)
                .Index(t => t.ControllerId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeType = c.Int(nullable: false),
                        AirportId = c.Int(),
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NationalCode = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        PassportNumber = c.String(),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airports", t => t.AirportId)
                .Index(t => t.AirportId);
            
            CreateTable(
                "dbo.Flights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlightNumber = c.String(),
                        DepartureAirportId = c.Int(),
                        ArrivalAirportId = c.Int(),
                        ScheduledDepartureTime = c.DateTime(nullable: false),
                        ScheduledArrivalTime = c.DateTime(nullable: false),
                        ActualDepartureTime = c.DateTime(),
                        ActualArrivalTime = c.DateTime(),
                        AircraftId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        GateID = c.Int(nullable: false),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aircrafts", t => t.AircraftId, cascadeDelete: true)
                .ForeignKey("dbo.Airports", t => t.ArrivalAirportId)
                .ForeignKey("dbo.Airports", t => t.DepartureAirportId)
                .Index(t => t.DepartureAirportId)
                .Index(t => t.ArrivalAirportId)
                .Index(t => t.AircraftId);
            
            CreateTable(
                "dbo.Aircrafts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManufacturerName = c.String(),
                        Model = c.String(),
                        Capacity = c.Int(nullable: false),
                        RegistrationNumber = c.String(),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Baggages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TicketId = c.Int(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Type = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        TagNumber = c.String(),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tickets", t => t.TicketId, cascadeDelete: true)
                .Index(t => t.TicketId);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PassengerId = c.Int(nullable: false),
                        FlightId = c.Int(nullable: false),
                        SeatNumber = c.Int(nullable: false),
                        Class = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        BookingDate = c.DateTime(nullable: false),
                        TicketNumber = c.String(),
                        IsExpiered = c.Boolean(nullable: false),
                        TicketType = c.Int(nullable: false),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .ForeignKey("dbo.Passengers", t => t.PassengerId, cascadeDelete: true)
                .Index(t => t.PassengerId)
                .Index(t => t.FlightId);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nationality = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NationalCode = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        PassportNumber = c.String(),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CrewAssignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlightId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Role = c.Int(nullable: false),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Flights", t => t.FlightId, cascadeDelete: true)
                .Index(t => t.FlightId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Gates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GateNumber = c.String(),
                        Terminal = c.String(),
                        Capacity = c.Int(),
                        AircraftId = c.Int(nullable: false),
                        DeletedAt = c.DateTime(),
                        DeletedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aircrafts", t => t.AircraftId, cascadeDelete: true)
                .Index(t => t.AircraftId);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Action = c.Int(nullable: false),
                        TableName = c.Int(nullable: false),
                        Description = c.String(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AirportID = c.Int(nullable: false),
                        Tel = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Email = c.String(),
                        Logo = c.String(),
                        Link = c.String(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gates", "AircraftId", "dbo.Aircrafts");
            DropForeignKey("dbo.CrewAssignments", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.CrewAssignments", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Baggages", "TicketId", "dbo.Tickets");
            DropForeignKey("dbo.Tickets", "PassengerId", "dbo.Passengers");
            DropForeignKey("dbo.Tickets", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.AirTraffics", "FlightId", "dbo.Flights");
            DropForeignKey("dbo.Flights", "DepartureAirportId", "dbo.Airports");
            DropForeignKey("dbo.Flights", "ArrivalAirportId", "dbo.Airports");
            DropForeignKey("dbo.Flights", "AircraftId", "dbo.Aircrafts");
            DropForeignKey("dbo.AirTraffics", "ControllerId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "AirportId", "dbo.Airports");
            DropForeignKey("dbo.AirTraffics", "AirportId", "dbo.Airports");
            DropIndex("dbo.Gates", new[] { "AircraftId" });
            DropIndex("dbo.CrewAssignments", new[] { "EmployeeId" });
            DropIndex("dbo.CrewAssignments", new[] { "FlightId" });
            DropIndex("dbo.Tickets", new[] { "FlightId" });
            DropIndex("dbo.Tickets", new[] { "PassengerId" });
            DropIndex("dbo.Baggages", new[] { "TicketId" });
            DropIndex("dbo.Flights", new[] { "AircraftId" });
            DropIndex("dbo.Flights", new[] { "ArrivalAirportId" });
            DropIndex("dbo.Flights", new[] { "DepartureAirportId" });
            DropIndex("dbo.Employees", new[] { "AirportId" });
            DropIndex("dbo.AirTraffics", new[] { "ControllerId" });
            DropIndex("dbo.AirTraffics", new[] { "AirportId" });
            DropIndex("dbo.AirTraffics", new[] { "FlightId" });
            DropTable("dbo.Settings");
            DropTable("dbo.Logs");
            DropTable("dbo.Gates");
            DropTable("dbo.CrewAssignments");
            DropTable("dbo.Passengers");
            DropTable("dbo.Tickets");
            DropTable("dbo.Baggages");
            DropTable("dbo.Aircrafts");
            DropTable("dbo.Flights");
            DropTable("dbo.Employees");
            DropTable("dbo.AirTraffics");
            DropTable("dbo.Airports");
        }
    }
}
