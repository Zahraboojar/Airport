using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class FlightDto : BaseTimeDto
    {
        [DvgDisplayName(PersionDictionary.FlightNumber)]
        public string FlightNumber { get; set; }
        public int TerminalId { get; set; }
        [DvgDisplayName(PersionDictionary.Terminal)]
        public string TerminalName { get; set; }
        public virtual Terminal Terminal { get; set; }
        public int DepartureAirportId { get; set; }
        [DvgDisplayName(PersionDictionary.DepartureAirport)]
        public string DepartureAirportName { get; set; }
        public virtual Airport DepartureAirport { get; set; }
        public int ArrivalAirportId { get; set; }
        [DvgDisplayName(PersionDictionary.ArrivalAirport)]
        public string ArrivalAirportName { get; set; }
        public virtual Airport ArrivalAirport { get; set; }
        [DvgDisplayName(PersionDictionary.ScheduledDepartureTime)]
        public DateTime ScheduledDepartureTime { get; set; }
        [DvgDisplayName(PersionDictionary.ScheduledArrivalTime)]
        public DateTime ScheduledArrivalTime { get; set; }
        [DvgDisplayName(PersionDictionary.ActualDepartureTime)]
        public DateTime? ActualDepartureTime { get; set; }
        [DvgDisplayName(PersionDictionary.ActualArrivalTime)]
        public DateTime? ActualArrivalTime { get; set; }
        public int AircraftId { get; set; }
        [DvgDisplayName(PersionDictionary.Aircraft)]
        public string AircraftRegisterNum { get; set; }
        public virtual Aircraft Aircraft { get; set; }
        [DvgDisplayName(PersionDictionary.Status)]
        public string Status { get; set; }
        public int GateId { get; set; }
        [DvgDisplayName(PersionDictionary.Gate)]
        public string GateNumber { get; set; }
        public virtual Gate Gate { get; set; }
    }
}
