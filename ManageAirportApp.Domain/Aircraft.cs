using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class Aircraft : BaseTimeEntity
    {
        public string ManufacturerName { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public string RegistrationNumber { get; set; }

    }
}
