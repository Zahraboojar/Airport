using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class BaseTimeEntity : BaseEntity
    {
        public DateTime ?UpdatedAt { get; set; }
        public int? UpdatedById { get; set; }
        public virtual Employee UpdatedBy { get; set; }
    }
}
