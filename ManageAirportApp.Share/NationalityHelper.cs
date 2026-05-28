using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ManageAirportApp.Share
{
    public class NationalityHelper
    {
        public static List<string> GetAllCountryNames()
        {
            var countries = ReadFile<List<Country>>("countries+cities.json");

            return countries.Select(c => c.Name).ToList();
        }

        public static List<Country> GetAllCountryNamesAndCodes()
        {
            var data = ReadFile<List<Country>>("countries+cities.json");

            return data.ToList();
        }

        public static List<string> GetAllCitiesNames(string countryName)
        {
            var data = ReadFile<List<Country>>("countries+cities.json");

            var country = data.FirstOrDefault(c =>
                c.Name.Equals(countryName, StringComparison.OrdinalIgnoreCase));

            return country?.Cities ?? new List<string>();
        }
        private static TResult ReadFile<TResult>(string fileName)
        {
            string json = File.ReadAllText(fileName);
            var data = JsonConvert.DeserializeObject<TResult>(json);
            return data;
        }

        public static string GetCountryCode(string countryName)
        {
            if (string.IsNullOrWhiteSpace(countryName))
                return "IRN";

            var countries = GetAllCountryNamesAndCodes();

            var country = countries.FirstOrDefault(c => c.Name.Equals(countryName, StringComparison.OrdinalIgnoreCase));

            if (country != null && !string.IsNullOrEmpty(country.Code))
            {
                return country.Code;
            }

            return "IRN";
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public List<string> Cities { get; set; }
        public string Code { get; set; }
    }
}