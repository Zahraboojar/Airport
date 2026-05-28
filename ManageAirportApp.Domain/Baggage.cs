using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class Baggage : BaseTimeEntity
    {
        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
        public decimal Weight { get; set; }
        public BaggageType Type { get; set; }
        public BaggageStatus Status { get; set; }
        public string TagNumber { get; set; }

    }
}
