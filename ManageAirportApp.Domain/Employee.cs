using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ManageAirportApp.Domain
{
    public class Employee : BaseUserEntity
    {
        public EmployeeType EmployeeType { get; set; }
        public int? AirportId { get; set; }
        public virtual Airport Airport { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UsersStatus Status { get; set; } 

    }
}
