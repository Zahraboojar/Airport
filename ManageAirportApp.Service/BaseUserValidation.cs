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
    public class BaseUserValidation : BaseValidation
    {
        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        private static bool IsValidNationalCode(string nationalCode)
        {
            if (string.IsNullOrWhiteSpace(nationalCode) || nationalCode.Length != 10)
                return false;

            if (!long.TryParse(nationalCode, out _))
                return false; ;

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += int.Parse(nationalCode[i].ToString()) * (10 - i);
            }

            int remainder = sum % 11;
            int controlDigit = int.Parse(nationalCode[9].ToString());

            if (remainder < 2)
                return controlDigit == remainder;
            else
                return controlDigit == (11 - remainder);
        }
        private static bool IsValidMobile(string mobile)
        {
             return Regex.IsMatch(mobile, @"^09\d{9}$");
        }
        private static bool IsValidPassport(string passport)
        {
            return Regex.IsMatch(passport, @"^[A-Z]{1}\d{8}$");
        }
        private static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[\u0600-\u06FF\sa-zA-Z]{2,30}$");
        }
        public static OperationResult ValidAll<UserDto>(UserDto userDto)
           where UserDto : BaseUserDto
        {
            if (userDto == null)
                return OperationResult.Failed(Messages.NotFoundEntity);
            var messages = "";
            if (!IsValidEmail(userDto.Email))
            {
                messages += Environment.NewLine + Messages.InCurrectEmail;
            }
            if (!IsValidName(userDto.FirstName))
            {
                messages += Environment.NewLine + Messages.InCurrectFirstName;
            }
            if (!IsValidName(userDto.LastName))
            {
                messages += Environment.NewLine + Messages.InCurrectLastName;
            }
            if (!IsValidNationalCode(userDto.NationalCode))
            {
                messages += Environment.NewLine + Messages.InCurrectNationalCode;
            }
            if (!IsValidPassport(userDto.PassportNumber))
            {
                messages += Environment.NewLine + Messages.InCurrectPassportNumber;
            }
            if (!IsValidMobile(userDto.PhoneNumber))
            {
                messages += Environment.NewLine + Messages.InCurrectPhoneNumber;
            }

            if (messages.Length > 0) return OperationResult.Failed(messages);
            return OperationResult.Success();
        }
    }
}
