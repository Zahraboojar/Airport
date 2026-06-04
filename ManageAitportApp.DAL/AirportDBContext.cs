using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ManageAirportApp.DAL
{
    public class AirportDBContext : DbContext
    {
        public AirportDBContext() : base("Data Source=.;Initial Catalog=AirportDB;Integrated Security=True;Encrypt=False")
        {
        }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<AirTraffic> AirTraffics { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Baggage> Baggages { get; set; }
        public DbSet<CrewAssignment> CrewAssignments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Terminal> Terminals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gate>()
            .Property(g => g.GateNumber)
            .HasMaxLength(2)
            .IsRequired();

            base.OnModelCreating(modelBuilder);
            // ====== Flight ======
            modelBuilder.Entity<Flight>()
                .HasRequired(f => f.DepartureAirport)
                .WithMany()
                .HasForeignKey(f => f.DepartureAirportId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight>()
                .HasRequired(f => f.ArrivalAirport)
                .WithMany()
                .HasForeignKey(f => f.ArrivalAirportId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight>()
                .HasRequired(f => f.Aircraft)
                .WithMany()
                .HasForeignKey(f => f.AircraftId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flight>()
                .HasRequired(f => f.Gate)
                .WithMany()
                .HasForeignKey(f => f.GateId)
                .WillCascadeOnDelete(false);

            // ====== Aircraft ======
            modelBuilder.Entity<Aircraft>()
                .HasKey(a => a.Id);

            // ====== Employee ======
            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Airport)
                .WithMany()
                .HasForeignKey(e => e.AirportId)
                .WillCascadeOnDelete(false);

            // ====== CrewAssignment (M:N between Flight and Employee) ======
            modelBuilder.Entity<CrewAssignment>()
                .HasRequired(ef => ef.Employee)
                .WithMany()
                .HasForeignKey(ef => ef.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CrewAssignment>()
                .HasRequired(ef => ef.Flight)
                .WithMany()
                .HasForeignKey(ef => ef.FlightId)
                .WillCascadeOnDelete(false);

            // ====== Gate ======

            modelBuilder.Entity<Gate>()
                .HasRequired(g => g.Terminal)
                .WithMany(t => t.Gates)
                .HasForeignKey(g => g.TerminalId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gate>()
            .HasIndex(g => new { g.TerminalId, g.GateNumber })
            .IsUnique();

            // ====== Terminal ======
            modelBuilder.Entity<Terminal>()
                .HasRequired(g => g.Airport)
                .WithMany()
                .HasForeignKey(g => g.AirportId)
                .WillCascadeOnDelete(false);

            // ====== AirTraffic ======
            modelBuilder.Entity<AirTraffic>()
                .HasRequired(at => at.Flight)
                .WithMany()
                .HasForeignKey(at => at.FlightId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AirTraffic>()
                .HasRequired(at => at.Airport)
                .WithMany()
                .HasForeignKey(at => at.AirportId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AirTraffic>()
                .HasRequired(at => at.Controller)
                .WithMany()
                .HasForeignKey(at => at.ControllerId)
                .WillCascadeOnDelete(false);

            // ====== Ticket ======
            modelBuilder.Entity<Ticket>()
                .HasRequired(t => t.Passenger)
                .WithMany()
                .HasForeignKey(t => t.PassengerId)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Ticket>()
                .HasRequired(t => t.Flight)
                .WithMany()
                .HasForeignKey(t => t.FlightId)
                .WillCascadeOnDelete(false);

            // ====== Baggage ======
            modelBuilder.Entity<Baggage>()
                .HasRequired(b => b.Ticket)
                .WithMany()
                .HasForeignKey(b => b.TicketId)
                .WillCascadeOnDelete(false);

            // ====== Log ======
            modelBuilder.Entity<Log>()
                .HasOptional(l => l.Airport)
                .WithMany()
                .HasForeignKey(l => l.AirportId)
                .WillCascadeOnDelete(false);

            //====== employee =======
            modelBuilder.Entity<Employee>()
              .HasOptional(e => e.UpdatedBy) 
              .WithMany()
              .HasForeignKey(e => e.UpdatedById)
              .WillCascadeOnDelete(false);


            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.DeletedBy)
                .WithMany()
                .HasForeignKey(e => e.DeletedById)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.CreatedBy)
                .WithMany()
                .HasForeignKey(e => e.CreatedById)
                .WillCascadeOnDelete(false);
        }

    }
}
