using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class BaseDto
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public int? DeletedById { get; set; }
        public virtual Employee DeletedBy { get; set; }
        [DvgDisplayName(PersionDictionary.DeletedBy)]
        public string DeletedByName { get; set; }
        public virtual Employee CreationBy { get; set; }
        [DvgDisplayName(PersionDictionary.CreatedBy)]
        public string CreationByNam { get; set; }
        [DvgDisplayName(PersionDictionary.CreatedTime)]
        public DateTime CreatedAt { get; set; }
        [DvgDisplayName(PersionDictionary.DeletedTime)]
        public DateTime? DeletedAt { get; set; }
    }
}
