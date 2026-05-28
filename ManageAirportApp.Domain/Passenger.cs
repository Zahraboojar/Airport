using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class Passenger: BaseUserEntity
    {
        public string Nationality { get; set; }
    }
}
