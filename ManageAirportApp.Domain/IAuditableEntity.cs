using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Domain
{
    public interface IAuditableEntity
    {
        int Id { get; set; }
        bool IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }
        int? DeletedById { get; set; }
        Employee DeletedBy { get; set; }
    }
}
