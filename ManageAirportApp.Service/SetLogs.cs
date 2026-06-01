using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public static class SetLogs
    {
        private static readonly LogService logService = ServiceFactory<LogService>.Instance;
        public static async Task<OperationResult> Set(Actions action, string tableName = "Flight", string desc = "")
        {
            var log = new LogDto
            {
                Action = EnumExtensions.GetLogAction(action),
                Description = desc,
                TableName = tableName
            };
            return await logService.AddAsync(log);
        }
        public static async Task<OperationResult> SetFlight(Actions action, string desc)
        {
            return await Set(action, PersionDictionary.Flight, desc);
        }
        public static async Task<OperationResult> SetTicket(Actions action, string desc)
        {
            return await Set(action, PersionDictionary.Ticket, desc);
        }
        public static async Task<OperationResult> SetAirport(Actions action, string desc)
        {
            return await Set(action, PersionDictionary.Airport, desc);
        }
        public static async Task<OperationResult> SetAircraft(Actions action, string desc)
        {
            return await Set(action, PersionDictionary.Aircraft, desc);
        }
        public static async Task<OperationResult> SetAirTraffic(Actions action, string desc)
        {
            return await Set(action, PersionDictionary.AirTrafficControl, desc);
        }
        public static async Task<OperationResult> SetBaggage(Actions action, string desc)
        {
            return await Set(action, PersionDictionary.Baggage, desc);
        }
        public static async Task<OperationResult> SetCrewAssignment(Actions action, string desc)
        {
            return await Set(action, PersionDictionary.CrewAssignment, desc);
        }
        public static async Task<OperationResult> SetEmployee(Actions action, string desc)
        {
            return await Set(action, PersionDictionary.Employee, desc);
        }
        public static async Task<OperationResult> SetPassenger(Actions action, string desc)
        {
            return await Set(action, PersionDictionary.Passenger, desc);
        }
        public static async Task<OperationResult> SetGate(Actions action, string desc)
        {
            return await Set(action, PersionDictionary.Gate, desc);
        }
        public static async Task<OperationResult> SetTerminal(Actions action, string desc)
        {
            return await Set(action, PersionDictionary.Terminal, desc);
        }
        public static async Task<OperationResult> SetLogin(string desc = "وارد حساب کاربری اش شد")
        {
            return await Set(Actions.Login, "", desc + " " + LoginedUserService.Employee.UserName);
        }
        public static async Task<OperationResult> SetProfile(string desc ="پروفایل خود را ویرایش کرد")
        {
            return await Set(Actions.Profile, "", desc + " " + LoginedUserService.Employee.UserName);
        }
    }
}
