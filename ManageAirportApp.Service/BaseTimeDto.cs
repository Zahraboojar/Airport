using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class BaseTimeDto : BaseDto
    {
        [DvgDisplayName(PersionDictionary.UpdatedTime)]
        public DateTime? UpdatedAt { get; set; }
        public virtual Employee UpdatedBy { get; set; }
        [DvgDisplayName(PersionDictionary.UpdatedBy)]
        public string UpdatedByName { get; set; }
        public int? UpdatedById { get; set; }
    }
}
