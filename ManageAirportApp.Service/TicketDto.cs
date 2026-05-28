using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageAirportApp.Domain;

namespace ManageAirportApp.Service
{
    public class TicketDto : BaseTimeDto
    {
        public int PassengerId { get; set; }

        [DvgDisplayName(PersionDictionary.Passenger)]
        public string PassengerFullName { get; set; }
        public virtual Passenger Passenger { get; set; }
        public int FlightId { get; set; }
        [DvgDisplayName(PersionDictionary.Flight)]
        public string FlightNumber { get; set; }
        [DvgDisplayName(PersionDictionary.Class)]
        public string FlightClass { get; set; }
        public virtual Flight Flight { get; set; }
        [DvgDisplayName(PersionDictionary.SeatNumber)]
        public int SeatNumber { get; set; }
        [DvgDisplayName(PersionDictionary.Class)]
        public string Class { get; set; }
        [DvgDisplayName(PersionDictionary.Price)]
        public int Price { get; set; }
        [DvgDisplayName(PersionDictionary.TicketNumber)]
        public string TicketNumber { get; set; }
        [DvgDisplayName(PersionDictionary.Type)]
        public string TicketType { get; set; }
    }
}