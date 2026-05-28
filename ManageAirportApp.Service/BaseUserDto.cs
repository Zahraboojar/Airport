using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class BaseUserDto : BaseTimeDto
    {
        [DvgDisplayName(PersionDictionary.FirstName)]
        public string FirstName { get; set; }
        [DvgDisplayName(PersionDictionary.LastName)]
        public string LastName { get; set; }
        [DvgDisplayName(PersionDictionary.NationalCode)]
        public string NationalCode { get; set; }
        [DvgDisplayName(PersionDictionary.DateOfBirth)]
        public DateTime DateOfBirth { get; set; }
        [DvgDisplayName(PersionDictionary.Email)]
        public string Email { get; set; }
        [DvgDisplayName(PersionDictionary.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [DvgDisplayName(PersionDictionary.Address)]
        public string Address { get; set; }
        [DvgDisplayName(PersionDictionary.PassportNumber)]
        public string PassportNumber { get; set; }
    }
}
