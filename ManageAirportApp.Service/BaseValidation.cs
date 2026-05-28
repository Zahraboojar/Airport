using ManageAirportApp.DAL;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class BaseValidation
    {
        public static bool IsNullOrEmpty(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            } else
            {
                var result = Regex.IsMatch(str, @"^[\p{L}\s‌-]{2,50}$");
                if (!result) return false;
            }
            return true;
        }
        public static bool IsValidCapacity(int capacity)
        {
            if (capacity >= 1 && capacity <= 1000)
                return true;
            return false;
        }
        public static bool IsNotNullData(params object[] data)
        {
            foreach (var item in data)
            {
                if (item == null) return false;

                if (item is string str)
                {
                    if (!IsNullOrEmpty(str)) 
                    {
                        return false;
                    }
                } else if (item is int || item is decimal || item is float || item is double)
                {
                    if ((int)item > 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
