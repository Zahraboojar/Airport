using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class CrewAssignmentDto : BaseTimeDto
    {
        public int FlightId { get; set; }
        [DvgDisplayName(PersionDictionary.Flight)]
        public string FlightNumber { get; set; }
        public virtual Flight Flight { get; set; }
        public int EmployeeId { get; set; }
        [DvgDisplayName(PersionDictionary.Employee)]
        public string EmployeeFullName { get; set; }
        public virtual Employee Employee { get; set; }
        [DvgDisplayName(PersionDictionary.Role)]
        public string Role { get; set; }
    }
}
