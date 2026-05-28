using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class Flight : BaseTimeEntity
    {
        public string FlightNumber { get; set; }
        public int DepartureAirportId { get; set; }
        public virtual Airport DepartureAirport { get; set; }
        public int ArrivalAirportId { get; set; }
        public virtual Airport ArrivalAirport { get; set; }
        public DateTime ScheduledDepartureTime { get; set; }
        public DateTime ScheduledArrivalTime { get; set; }
        public DateTime? ActualDepartureTime { get; set; }
        public DateTime? ActualArrivalTime { get; set; }
        public int AircraftId { get; set; }
        public virtual Aircraft Aircraft { get; set; }
        public FlightStatus Status { get; set; }
        public int GateId { get; set; }
        public virtual Gate Gate { get; set; }

    }
}
