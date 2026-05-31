using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class AirportDto : BaseTimeDto
    {
        [DvgDisplayName(PersionDictionary.AirportName)]
        public string Name { get; set; }
        [DvgDisplayName(PersionDictionary.City)]
        public string City { get; set; }
        [DvgDisplayName(PersionDictionary.Region)]
        public string Region { get; set; }
        [DvgDisplayName(PersionDictionary.IATA_Code)]
        public string IATA_Code { get; set; }
        [DvgDisplayName(PersionDictionary.ICAO_Code)]
        public string ICAO_Code { get; set; }
        public string Logo {  get; set; }
    }
}
