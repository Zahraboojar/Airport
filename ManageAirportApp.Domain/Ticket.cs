using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class Ticket : BaseTimeEntity
    {
        public int PassengerId { get; set; }
        public virtual Passenger Passenger { get; set; }
        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        public int SeatNumber { get; set; }
        public FlightClass Class { get; set; }
        public int Price { get; set; }
        public DateTime BookingDate { get; set; }
        public string TicketNumber { get; set; }
        public bool IsExpiered { get; set; }
        public TicketType TicketType { get; set; }

    }
}
