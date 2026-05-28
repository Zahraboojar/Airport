using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class AircraftDto : BaseTimeDto
    {
        [DvgDisplayName(PersionDictionary.Manufacturer)]
        public string ManufacturerName { get; set; }
        [DvgDisplayName(PersionDictionary.Model)]
        public string Model { get; set; }
        [DvgDisplayName(PersionDictionary.Capacity)]
        public int Capacity { get; set; }
        [DvgDisplayName(PersionDictionary.RegistrationNumber)]
        public string RegistrationNumber { get; set; }
    }
}
