using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class PassengerDto : BaseUserDto
    {
        [DvgDisplayName(PersionDictionary.Nationality)]
        public string Nationality { get; set; }
    }
}
