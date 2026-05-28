using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public enum FlightStatus
    {
        Scheduled,
        OnTime,
        Delayed,
        Cancelled,
        Departed,
        Arrived
    }
}
