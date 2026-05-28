using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class Setting : BaseEntity
    {
        public int AirportId { get; set; }
        public virtual Airport Airport { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
        public string Link { get; set; }

    }
}
