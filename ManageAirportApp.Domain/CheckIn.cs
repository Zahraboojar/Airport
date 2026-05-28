using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class CheckIn : BaseTimeEntity
    {
        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
        public DateTime CheckInTime { get; set; }
        public string GateNumber { get; set; }
        public decimal? LuggageWeight { get; set; }
        public CheckInStatus Status { get; set; }
        public string Remarks { get; set; }
    }
}
