using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class EmployeeDto : BaseUserDto
    {
        [DvgDisplayName(PersionDictionary.EmployeeType)]
        public string EmployeeType { get; set; }
        public int AirportId { get; set; }
        [DvgDisplayName(PersionDictionary.Airport)]
        public string AirportName { get; set; }
        public virtual Airport Airport { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
