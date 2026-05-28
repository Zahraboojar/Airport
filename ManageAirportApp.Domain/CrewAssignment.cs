using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class CrewAssignment : BaseTimeEntity
    {
        public int FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public EmployeeRole Role { get; set; }
    }
}
