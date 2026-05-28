using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class SettingDto : BaseDto
    {
        public int AirportId { get; set; }
        [DvgDisplayName(PersionDictionary.Airport)]
        public string AirportName { get; set; }
        public virtual Airport Airport { get; set; }
        [DvgDisplayName(PersionDictionary.Description)]
        public string Description { get; set; }
        [DvgDisplayName(PersionDictionary.Email)]
        public string Email { get; set; }
        [DvgDisplayName(PersionDictionary.Logo)]
        public string Logo { get; set; }
        [DvgDisplayName(PersionDictionary.Link)]
        public string Link { get; set; }
    }
}
