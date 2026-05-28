using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class Terminal : BaseTimeEntity
    {
        public virtual Airport Airport { get; set; }
        public int AirportId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Gate> Gates { get; set; }
    }
}
