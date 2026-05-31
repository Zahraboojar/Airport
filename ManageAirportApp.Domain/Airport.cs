using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class Airport : BaseTimeEntity
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Tel { get; set; }
        public string IATA_Code { get; set; }
        public string ICAO_Code { get; set; }
        public string Logo { get; set; }

    }
}
