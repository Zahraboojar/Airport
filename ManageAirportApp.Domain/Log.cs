using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class Log : BaseEntity
    {
        public Actions Action { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
        public int AirportId { get; set; }
        public virtual Airport Airport { get; set; } 

    }
}
