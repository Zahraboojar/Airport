using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class GateDto : BaseTimeDto
    {
        [DvgDisplayName(PersionDictionary.GateNumber)]
        public string GateNumber { get; set; }
        public virtual Gate Gate { get; set; }
        [DvgDisplayName(PersionDictionary.Terminal)]
        public string TerminalName { get; set; }
        public virtual Terminal Terminal { get; set; }
        public int TerminalId { get; set; }
        [DvgDisplayName(PersionDictionary.Capacity)]
        public int Capacity { get; set; }
    }
}
