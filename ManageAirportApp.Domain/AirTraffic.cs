using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class AirTraffic : BaseEntity
    {
        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        public int AirportId { get; set; }
        public virtual Airport Airport { get; set; }
        public AirTrafficsEventType EventType { get; set; }
        public DateTime EventTime { get; set; }
        public int ControllerId { get; set; }
        public virtual Employee Controller { get; set; }

    }
}
