using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class BaggageDto : BaseTimeDto
    {
        public int TicketId { get; set; }
        [DvgDisplayName(PersionDictionary.Ticket)]
        public string TicketNumber { get; set; }
        public virtual Ticket Ticket { get; set; }
        [DvgDisplayName(PersionDictionary.Weight)]
        public decimal Weight { get; set; }
        [DvgDisplayName(PersionDictionary.Type)]
        public string Type { get; set; }
        [DvgDisplayName(PersionDictionary.Status)]
        public string Status { get; set; }
        [DvgDisplayName(PersionDictionary.TagNumber)]
        public string TagNumber { get; set; }
    }
}
