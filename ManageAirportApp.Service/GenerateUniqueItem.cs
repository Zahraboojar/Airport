using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public static class GenerateUniqueItem
    {
        public static async Task<string> GererateTicketNumber(Airport airport)
        {
            var iata = airport.Region;

            string ticketNumber = GenerateNumber(10);

            ticketNumber = $"{iata}-{ticketNumber}";

            var service = ServiceFactory<TicketService>.Instance;
            var ticketResult = await service.GetByTicketNumberAsync(ticketNumber);
            if (ticketResult.IsSuccess)
            {
                return await GererateTicketNumber(airport);
            }
            else
            {
                return ticketNumber;
            }
        }
        public static async Task<string> GenerateFlightNumber(Airport airport)
        {
            var code = NationalityHelper.GetCountryCode(airport.Region);
            var number = GenerateNumber(4);
            var flightNumber = $"{code}{number}";

            var service = ServiceFactory<FlightService>.Instance;
            var flightResult = await service.GetByFlightNumber(flightNumber);
            if (flightResult.IsSuccess)
            {
                return await GenerateFlightNumber(airport);
            }
            else
            {
                return flightNumber;
            }
        }
        public static string GenerateTagNumber(Airport airport)
        {
            var code = NationalityHelper.GetCountryCode(airport.Region);
            var number = GenerateNumber(6);

            return $"{code}-{DateTime.UtcNow:yyyyMMddHHmmss}-{number}";
        }
        private static string GenerateNumber(int length = 8)
        {
            Random random = new Random();
            string number = "";
            for (int i = 0; i < length; i++)
            {
                number += random.Next(0, 10).ToString();
            }
            return number;
        }

        public static async Task<string> GenerateGateNumber(int terminalId, int capacity)
        {
            var service = ServiceFactory<GateService>.Instance;
            var sp = new SelectProperties
            {
                TerminalId = terminalId,
                AirportId = LoginedUserService.Employee?.AirportId ?? 0,
            };
            int gateCount = await service.GetCountAllAsync(sp);

            int letterIndex = gateCount / 3;
            int numberIndex = (gateCount % 3) + 1;

            char letter = (char)('a' + letterIndex);

            return $"{letter}{numberIndex}";
        }
    }
}
