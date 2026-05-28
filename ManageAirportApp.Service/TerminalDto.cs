using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class TerminalDto : BaseTimeDto
    {
        [DvgDisplayName(PersionDictionary.Title)]
        public string Name { get; set; }
    }
}
