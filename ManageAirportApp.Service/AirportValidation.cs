using ManageAirportApp.DAL;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class AirportValidation : BaseValidation
    {
        private static bool IsValidName(string name)
        {
            string pattern = @"^[\p{L}\s‌-]{2,50}$";
            return Regex.IsMatch(name, pattern);
        }
        private static bool IsValidICAO(string icao)
        {
            string pattern = @"^[\p{L}\s‌-]{4}$";
            return Regex.IsMatch(icao, pattern);
        }
        private static bool IsValidIATA(string iata)
        {
            string pattern = @"^[\p{L}\s‌-]{3}$";
            return Regex.IsMatch(iata, pattern);
        }
        public static OperationResult ValidAll(AirportDto airportDto)
        {
            var messages = "";
            if (!IsValidIATA(airportDto.IATA_Code))
            {
                messages += Environment.NewLine + Messages.InCurrectIATA;
            } 
            if (! IsValidICAO(airportDto.ICAO_Code))
            {
                messages += Environment.NewLine + Messages.InCurrectICAO;
            }
            if (!IsValidName(airportDto.Name))
            {
                messages += Environment.NewLine + Messages.InCurrectName;
            }

            if (messages.Length > 0)  return OperationResult.Failed(messages);
            return OperationResult.Success();
        }
    }
}
