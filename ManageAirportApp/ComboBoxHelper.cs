using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Service;
using ManageAirportApp.Share;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageAirportApp
{
    public static class ComboBoxHelper
    {
        public static void LoadCountryNamesToComboBox(ComboBox cmb, string country = "Iran")
        {
            List<string> countries = NationalityHelper.GetAllCountryNames();

            cmb.Items.Clear();

            foreach (string countryName in countries)
            {
                cmb.Items.Add(countryName);
                if (countryName == country)
                    cmb.SelectedItem = country;
            }
        }
        public static void LoadCitiesNamesToComboBox(ComboBox cmb, string country = "Iran")
        {
            List<string> cities = NationalityHelper.GetAllCitiesNames(country);

            cmb.Items.Clear();

            foreach (string citiesName in cities)
            {
                cmb.Items.Add(citiesName);
            }
        }
        public static async Task LoadFlightNumberToComboBox(ComboBox cmb, int id = 0)
        {
            var sp = new SelectProperties();
            var service = ServiceFactory<FlightService>.Instance;
            var data = await service.GetAllAsync(sp);
            if (data.IsSuccess)
            {
                cmb.Items.Clear();

                foreach (var flight in data.Data)
                {
                    cmb.Items.Add(flight.FlightNumber);
                    if (id == flight.Id)
                    {
                        cmb.SelectedItem = flight.FlightNumber;
                    }
                }
            }
        }

        public static async Task LoadEmployeeUsernameToComboBox(ComboBox cmb, int id = 0)
        {
            var sp = new SelectProperties();
            var service = ServiceFactory<EmployeeService>.Instance;
            var data = await service.GetAllAsync(sp);
            if (data.IsSuccess)
            {
                cmb.Items.Clear();

                foreach (var employee in data.Data)
                {
                    var _fullName = $"{employee.FirstName} {employee.LastName}";
                    ;
                    var item = $"{_fullName}({employee.UserName})";
                    cmb.Items.Add(item);
                    if (id == employee.Id)
                    {
                        cmb.SelectedItem = item;
                    }
                }
            }
        }

        public static async Task LoadAirportNameToComboBox(ComboBox cmb, int id = 0, string cityName = "")
        {
            var sp = new SelectProperties();
            var service = ServiceFactory<AirportService>.Instance;
            var data = await service.GetAllAsync(sp);
            if (data.IsSuccess)
            {
                cmb.Items.Clear();

                foreach (var airport in data.Data)
                {
                    if (cityName == "" || cityName == airport.City)
                    {
                        cmb.Items.Add(airport.Name);
                    }
                    if (id != 0 && id == airport.Id)
                    {
                        cmb.SelectedItem = airport.Name;
                    }
                }
            }
        }
        public static async Task LoadAircraftToComboBox(ComboBox cmb, int id = 0)
        {
            var sp = new SelectProperties();
            var service = ServiceFactory<AircraftService>.Instance;
            var selected = await service.GetByIdAsync(id);
            var data = await service.GetAllAvailableAsync(sp, selected.Data);
            if (data.IsSuccess)
            {
                cmb.Items.Clear();

                foreach (var aircraft in data.Data)
                {
                    cmb.Items.Add(aircraft.RegistrationNumber);
                    if (id == aircraft.Id)
                    {
                        cmb.SelectedItem = aircraft.RegistrationNumber;
                    }
                }
            }
        }

        public static async Task LoadGateToComboBox(ComboBox cmb, int id = 0, int terminalId = 0)
        {
            var sp = new SelectProperties
            {
                AirportId = LoginedUserService.Employee?.AirportId ?? 0,
            };
            var service = ServiceFactory<GateService>.Instance;
            var gateresult = await service.GetByIdAsync(id);
            sp.TerminalId = terminalId;
            var data = await service.GetAllAsync(sp);
            if (data.IsSuccess)
            {
                cmb.Items.Clear();

                foreach (var gate in data.Data)
                {
                    cmb.Items.Add($"{gate.Terminal?.Name} - {gate.GateNumber}");
                    if (id == gate.Id)
                    {
                        cmb.SelectedItem = gate.GateNumber;
                    }
                }
            }
        }
        public static async Task LoadTicketToComboBox(ComboBox cmb, int ticketId = 0)
        {
            var sp = new SelectProperties();
            var service = ServiceFactory<TicketService>.Instance;
            var data = await service.GetAllAsync(sp);
            if (data.IsSuccess)
            {
                cmb.Items.Clear();

                foreach (TicketDto ticket in data.Data)
                {
                    cmb.Items.Add(ticket.TicketNumber);
                    if (ticketId == ticket.Id)
                    {
                        cmb.SelectedItem = ticket.TicketNumber;
                    }
                }
            }
        }
        public static async Task LoadTerminalToComboBox(ComboBox cmb, string name = "")
        {
            var sp = new SelectProperties();
            var service = ServiceFactory<TerminalService>.Instance;
            var data = await service.GetAllAsync(sp);
            if (data.IsSuccess)
            {
                cmb.Items.Clear();

                foreach (TerminalDto terminal in data.Data)
                {
                    cmb.Items.Add(terminal.Name);
                    if (name == terminal.Name)
                    {
                        cmb.SelectedItem = terminal.Name;
                    }
                }
            }
        }
        public static async Task LoadPassengerToComboBox(ComboBox cmb, int id = 0)
        {
            var sp = new SelectProperties();
            var service = ServiceFactory<PassengerService>.Instance;
            var data = await service.GetAllAsync(sp);
            if (data.IsSuccess)
            {
                cmb.Items.Clear();

                foreach (PassengerDto passenger in data.Data)
                {
                    var _fullName = $"{passenger.FirstName} {passenger.LastName}";
                    ;
                    var item = $"{_fullName}({passenger.NationalCode})";
                    cmb.Items.Add(item);
                    if (passenger.Id == id)
                    {
                        cmb.SelectedItem = item;
                    }
                }
            }
        }
        public static async Task LoadSeatNumberToComboBox(ComboBox cmb, Flight flight, int seatNumber = 0)
        {
            if (flight == null) return;
            var service = ServiceFactory<TicketService>.Instance;
            var data = await service.GetAllByFlightIdAsync(flight.Id);
            if (data.IsSuccess)
            {
                cmb.Items.Clear();
                if (flight.Aircraft != null)
                {
                    var issetSeatNumbers = ArrayOperations.CalculateDifference(flight.Aircraft.Capacity, data.Data.ToArray());
                    if (seatNumber != 0)
                    {
                        cmb.Items.Add(seatNumber.ToString());
                        cmb.SelectedItem = seatNumber.ToString();
                    }
                    foreach (var item in issetSeatNumbers)
                    {
                        cmb.Items.Add(item);
                        if (item == seatNumber)
                        {
                            cmb.SelectedItem = item;
                        }
                    }
                }
            }
        }
    }
}