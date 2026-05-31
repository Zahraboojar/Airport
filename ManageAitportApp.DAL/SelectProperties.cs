using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.DAL
{
    public class SelectProperties
    {
        public bool IsDeleted { get; set; } = false;
        public int Offset { get; set; } = 0;
        public int Limit { get; set; } = 10;
        public string SearchText { get; set; } = "";
        public int AirportId { get; set; } = 0;
        public int TerminalId { get; set; } = 0;
        public int GateId { get; set; } = 0;
    }
}
