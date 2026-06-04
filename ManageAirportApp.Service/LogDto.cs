using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class LogDto : BaseDto
    {
        [DvgDisplayName(PersionDictionary.Action)]
        public string Action { get; set; }
        [DvgDisplayName(PersionDictionary.TableName)]
        public string TableName { get; set; }
        [DvgDisplayName(PersionDictionary.Description)]
        public string Description { get; set; }
        public int? AirportId { get; set; }
        public virtual Airport Airport { get; set; }
    }
}
