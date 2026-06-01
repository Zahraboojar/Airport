using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public static class EnumExtensions
    {
        public static string[] GetRange<TEnum>() where TEnum : Enum
        {
            return Enum.GetNames(typeof(TEnum));
        }

        //AirTrafficsEventType
        public static AirTrafficsEventType GetAirTrafficsEventType(string eventType)
        {
            switch (eventType)
            {
                case PersionDictionary.LandingClearance:
                    return AirTrafficsEventType.LandingClearance;
                case PersionDictionary.HoldingPattern:
                    return AirTrafficsEventType.HoldingPattern;
                case PersionDictionary.ClearedForTakeoff:
                    return AirTrafficsEventType.ClearedForTakeoff;
                default:
                    return AirTrafficsEventType.ClearedForTakeoff;
            }
        }

        public static string GetAirTrafficsEventType(AirTrafficsEventType eventType)
        {
            switch (eventType)
            {
                case AirTrafficsEventType.LandingClearance:
                    return PersionDictionary.LandingClearance;
                case AirTrafficsEventType.HoldingPattern:
                    return PersionDictionary.HoldingPattern;
                case AirTrafficsEventType.ClearedForTakeoff:
                    return PersionDictionary.ClearedForTakeoff;
                default:
                    return PersionDictionary.ClearedForTakeoff;
            }
        }

        public static string[] GetsAirTrafficsEventType()
        {
            var array = new string[]
            {
                PersionDictionary.ClearedForTakeoff,
                PersionDictionary.HoldingPattern,
                PersionDictionary.LandingClearance
            };
            return array;
        }

        //baggage
        public static BaggageType GetBaggageType(string baggageType)
        {
            switch (baggageType)
            {
                case PersionDictionary.CarryOn:
                    return BaggageType.CarryOn;
                case PersionDictionary.Checked:
                    return BaggageType.Checked;
                default:
                    return BaggageType.CarryOn;
            }
        }
        public static string GetBaggageType(BaggageType baggageType)
        {
            switch (baggageType)
            {
                case BaggageType.CarryOn:
                    return PersionDictionary.CarryOn;
                case BaggageType.Checked:
                    return PersionDictionary.Checked;
                default:
                    return PersionDictionary.CarryOn;
            }
        }
        public static string[] GetsBaggageType()
        {
            var array = new string[]
            {
                PersionDictionary.CarryOn,
                PersionDictionary.Checked,
            };
            return array;
        }

        public static BaggageStatus GetBaggageStatus(string baggageStatus)
        {
            switch (baggageStatus)
            {
                case PersionDictionary.NotFound:
                    return BaggageStatus.NotFound;
                case PersionDictionary.Scanned:
                    return BaggageStatus.Scanned;
                case PersionDictionary.Loaded:
                    return BaggageStatus.Loaded;
                case PersionDictionary.Delivered:
                    return BaggageStatus.Delivered;
                default:
                    return BaggageStatus.Scanned;
            }
        }
        public static string GetBaggageStatus(BaggageStatus baggageStatus)
        {
            switch (baggageStatus)
            {
                case BaggageStatus.NotFound:
                    return PersionDictionary.NotFound;
                case BaggageStatus.Scanned:
                    return PersionDictionary.Scanned;
                case BaggageStatus.Loaded:
                    return PersionDictionary.Loaded;
                case BaggageStatus.Delivered:
                    return PersionDictionary.Delivered;
                default:
                    return PersionDictionary.NotFound;
            }
        }
        public static string[] GetsBaggageStatus()
        {
            var array = new string[]
            {
                PersionDictionary.NotFound,
                PersionDictionary.Scanned,
                PersionDictionary.Loaded,
                PersionDictionary.Delivered,
            };
            return array;
        }

        //employee
        public static EmployeeRole GetEmployeeRole(string employeeRole)
        {
            switch (employeeRole)
            {
                case PersionDictionary.None:
                    return EmployeeRole.None;
                case PersionDictionary.Pilot:
                    return EmployeeRole.Pilot;
                case PersionDictionary.CoPilot:
                    return EmployeeRole.CoPilot;
                case PersionDictionary.FlightAttendant:
                    return EmployeeRole.FlightAttendant;
                default:
                    return EmployeeRole.None;
            }
        }
        public static string GetEmployeeRole(EmployeeRole employeeRole)
        {
            switch (employeeRole)
            {
                case EmployeeRole.None:
                    return PersionDictionary.None;
                case EmployeeRole.Pilot:
                    return PersionDictionary.Pilot;
                case EmployeeRole.CoPilot:
                    return PersionDictionary.CoPilot;
                case EmployeeRole.FlightAttendant:
                    return PersionDictionary.FlightAttendant;
                default:
                    return PersionDictionary.None;
            }
        }
        public static string[] GetsEmployeeRole()
        {
            var array = new string[]
            {
                PersionDictionary.None,
                PersionDictionary.Pilot,
                PersionDictionary.CoPilot,
                PersionDictionary.FlightAttendant,
            };
            return array;
        }

        public static EmployeeType GetEmployeeType(string employeeType)
        {
            switch (employeeType)
            {
                case PersionDictionary.Management:
                    return EmployeeType.Management;
                case PersionDictionary.Pilot:
                    return EmployeeType.Pilot;
                case PersionDictionary.CabinCrew:
                    return EmployeeType.CabinCrew;
                case PersionDictionary.GroundStaff:
                    return EmployeeType.GroundStaff;
                case PersionDictionary.AirTrafficController:
                    return EmployeeType.AirTrafficController;
                default:
                    return EmployeeType.GroundStaff;
            }
        }
        public static string GetEmployeeType(EmployeeType employeeType)
        {
            switch (employeeType)
            {
                case EmployeeType.Management:
                    return PersionDictionary.Management;
                case EmployeeType.Pilot:
                    return PersionDictionary.Pilot;
                case EmployeeType.CabinCrew:
                    return PersionDictionary.CabinCrew;
                case EmployeeType.GroundStaff:
                    return PersionDictionary.GroundStaff;
                case EmployeeType.AirTrafficController:
                    return PersionDictionary.AirTrafficController;
                default:
                    return PersionDictionary.GroundStaff;
            }
        }

        public static string[] GetsEmployeeType()
        {
            var array = new string[]
            {
                PersionDictionary.Management,
                PersionDictionary.Pilot,
                PersionDictionary.CabinCrew,
                PersionDictionary.GroundStaff,
                PersionDictionary.AirTrafficController,
            };
            return array;
        }

        //Flight
        public static FlightStatus GetFlightStatus(string flightStatus)
        {
            switch (flightStatus)
            {
                case PersionDictionary.Scheduled:
                    return FlightStatus.Scheduled;
                case PersionDictionary.OnTime:
                    return FlightStatus.OnTime;
                case PersionDictionary.Delayed:
                    return FlightStatus.Delayed;
                case PersionDictionary.Cancelled:
                    return FlightStatus.Cancelled;
                case PersionDictionary.Departed:
                    return FlightStatus.Departed;
                case PersionDictionary.Arrived:
                    return FlightStatus.Arrived;
                default:
                    return FlightStatus.Scheduled;
            }
        }
        public static string GetFlightStatus(FlightStatus flightStatus)
        {
            switch (flightStatus)
            {
                case FlightStatus.Scheduled:
                    return PersionDictionary.Scheduled;
                case FlightStatus.OnTime:
                    return PersionDictionary.OnTime;
                case FlightStatus.Delayed:
                    return PersionDictionary.Delayed;
                case FlightStatus.Cancelled:
                    return PersionDictionary.Cancelled;
                case FlightStatus.Departed:
                    return PersionDictionary.Departed;
                case FlightStatus.Arrived:
                    return PersionDictionary.Arrived;
                default:
                    return PersionDictionary.Scheduled;
            }
        }

        public static string[] GetsFlightStatus()
        {
            var array = new string[]
            {
                PersionDictionary.Scheduled,
                PersionDictionary.OnTime,
                PersionDictionary.Delayed,
                PersionDictionary.Cancelled,
                PersionDictionary.Departed,
                PersionDictionary.Arrived,
            };
            return array;
        }

        //ticket
        public static FlightClass GetFlightClass(string flightClass)
        {
            switch (flightClass)
            {
                case PersionDictionary.Business:
                    return FlightClass.Business;
                case PersionDictionary.First:
                    return FlightClass.First;
                case PersionDictionary.Economy:
                    return FlightClass.Economy;
                default:
                    return FlightClass.Economy;
            }
        }
        public static string GetFlightClass(FlightClass flightClass)
        {
            switch (flightClass)
            {
                case FlightClass.Business:
                    return PersionDictionary.Business;
                case FlightClass.First:
                    return PersionDictionary.First;
                case FlightClass.Economy:
                    return PersionDictionary.Economy;
                default:
                    return PersionDictionary.Economy;
            }
        }

        public static string[] GetsFlightClass()
        {
            var array = new string[]
            {
                PersionDictionary.Business,
                PersionDictionary.First,
                PersionDictionary.Economy,
            };
            return array;
        }

        public static TicketType GetTicketType(string ticketType)
        {
            switch (ticketType)
            {
                case PersionDictionary.OneWay:
                    return TicketType.OneWay;
                case PersionDictionary.RoundTrip:
                    return TicketType.RoundTrip;
                default:
                    return TicketType.OneWay;
            }
        }
        public static string GetTicketType(TicketType ticketType)
        {
            switch (ticketType)
            {
                case TicketType.OneWay:
                    return PersionDictionary.OneWay;
                case TicketType.RoundTrip:
                    return PersionDictionary.RoundTrip;
                default:
                    return PersionDictionary.OneWay;
            }
        }

        public static string[] GetsTicketType()
        {
            var array = new string[]
            {
                PersionDictionary.OneWay,
                PersionDictionary.RoundTrip
            };
            return array;
        }

        public static Actions GetLogAction(string action)
        {
            switch (action)
            {
                case PersionDictionary.Add:
                    return Actions.Add;
                case PersionDictionary.Login:
                    return Actions.Login;
                case PersionDictionary.Profile:
                    return Actions.Profile;
                case PersionDictionary.Update:
                    return Actions.Update;
                case PersionDictionary.Restore:
                    return Actions.Restore;
                case PersionDictionary.Delete:
                    return Actions.Delete;
                case PersionDictionary.Add + " " + PersionDictionary.Employee:
                    return Actions.AddEmployee;
                default:
                    return Actions.Update;
            }
        }

        public static string GetLogAction(Actions action)
        {
            switch (action)
            {
                case Actions.Add:
                    return PersionDictionary.Add;
                case Actions.Profile:
                    return PersionDictionary.Profile;
                case Actions.Update:
                    return PersionDictionary.Update;
                case Actions.Restore:
                    return PersionDictionary.Restore;
                case Actions.Login:
                    return PersionDictionary.Login;
                case Actions.Delete:
                    return PersionDictionary.Delete;
                case Actions.AddEmployee:
                    return PersionDictionary.Add + " " + PersionDictionary.Employee;
                default:
                    return PersionDictionary.Update;
            }
        }
    }
}
