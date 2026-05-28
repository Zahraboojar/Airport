using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class Gate : BaseTimeEntity
    {
        public string GateNumber { get; set; }
        public int Capacity { get; set; }
        public int TerminalId { get; set; }
        public virtual Terminal Terminal { get; set; }
    }
}
