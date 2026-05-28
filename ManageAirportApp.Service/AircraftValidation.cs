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
    public class AircraftValidation : BaseValidation
    {
        private static bool IsValidManufacturerName(string manufacturerName)
        {
            string pattern = @"^[\p{L}\s‌-]{2,50}$";
            return Regex.IsMatch(manufacturerName, pattern);
        }

        private static bool IsValidModel(string model)
        {
            string pattern = @"^[\p{L}\s-]{1,50}$";
            return Regex.IsMatch(model, pattern);
        }
        private static bool IsValidRegistrationNumber(string registrationNumber)
        {
            string pattern = @"^[a-zA-Z0-9-]{5,10}$";
            return Regex.IsMatch(registrationNumber, pattern);
        }
        public static OperationResult ValidAll(AircraftDto aircraftDto)
        {
            var messages = "";
            if (!IsValidCapacity(aircraftDto.Capacity))
            {
                messages += Environment.NewLine + Messages.InCurrectCapacity;
            }
            if (! IsValidManufacturerName(aircraftDto?.ManufacturerName))
            {
                messages += Environment.NewLine + Messages.InCurrectManufacturerName;
            }
            if (IsValidModel(aircraftDto?.Model))
            {
                messages += Environment.NewLine + Messages.InCurrectModel;
            }
            if (!IsValidRegistrationNumber(aircraftDto?.RegistrationNumber))
            {
                messages += Environment.NewLine + Messages.InCurrectRegistrationNumber;
            }
            
            if (messages.Length > 0) return OperationResult.Failed(messages);
            return OperationResult.Success();
        }
    }
}
