using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public class BaseEntity : IAuditableEntity
    {
        public int Id { get; set; }
        public int? CreatedById { get; set; }
        public virtual Employee CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int? DeletedById { get; set; }
        public virtual Employee DeletedBy { get; set; }
        public DateTime CreatedAt { get; private set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; }
    }
}
