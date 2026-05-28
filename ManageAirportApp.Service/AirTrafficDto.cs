using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class AirTrafficDto : BaseDto
    {
        public int FlightId { get; set; }
        [DvgDisplayName(PersionDictionary.FlightNumber)]
        public string FlightNumber { get; set; }
        public virtual Flight Flight { get; set; }
        public int AirportId { get; set; }
        [DvgDisplayName(PersionDictionary.Airport)]
        public string AirportName { get; set; }
        public virtual Airport Airport { get; set; }
        [DvgDisplayName(PersionDictionary.EventType)]
        public string EventType { get; set; }
        [DvgDisplayName(PersionDictionary.EventTime)]
        public DateTime EventTime { get; set; }
        [DvgDisplayName(PersionDictionary.AirTrafficController)]
        public string ControllerFullName { get; set; }
        public virtual Employee Controller { get; set; }
        public int ControllerId { get; set; }
    }
}
