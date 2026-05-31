using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Service;
using ManageAirportApp.Share;
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
        private static Dictionary<System.Windows.Forms.ComboBox, List<int>> disabledItemsMap = new Dictionary<System.Windows.Forms.ComboBox, List<int>>();
        private static Dictionary<System.Windows.Forms.ComboBox, int> lastValidSelectedIndexMap = new Dictionary<System.Windows.Forms.ComboBox, int>();

        public static void ConfigureForDisabledItems(this System.Windows.Forms.ComboBox comb)
        {
            if (disabledItemsMap.ContainsKey(comb))
            {
                return;
            }

            comb.DrawItem += ComboBox_DrawItem;
            comb.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            comb.DropDownClosed += ComboBox_DropDownClosed;

            disabledItemsMap[comb] = new List<int>();
            lastValidSelectedIndexMap[comb] = -1;

            comb.DrawMode = DrawMode.OwnerDrawFixed;
        }

        public static void DisableItemsFromIndexToEnd(this System.Windows.Forms.ComboBox comb, int startIndex)
        {
            ConfigureForDisabledItems(comb);

            List<int> disabledIndexes = disabledItemsMap[comb];
            disabledIndexes.Clear();

            if (startIndex < 0 || startIndex >= comb.Items.Count)
            {
                comb.Invalidate();
                return;
            }

            for (int i = startIndex; i < comb.Items.Count; i++)
            {
                if (!disabledIndexes.Contains(i))
                {
                    disabledIndexes.Add(i);
                }
            }

            comb.Invalidate();
        }

        public static void DisableItemsInRange(this System.Windows.Forms.ComboBox comb, int startIndex, int endIndex)
        {
            ConfigureForDisabledItems(comb);

            List<int> disabledIndexes = disabledItemsMap[comb];
            disabledIndexes.Clear();

            startIndex = Math.Max(0, startIndex);
            endIndex = Math.Min(comb.Items.Count - 1, endIndex);

            if (startIndex > endIndex) return;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (!disabledIndexes.Contains(i))
                {
                    disabledIndexes.Add(i);
                }
            }
            comb.Invalidate();
        }

      
        public static void DisableItem(this System.Windows.Forms.ComboBox comb, int itemIndex)
        {
            ConfigureForDisabledItems(comb);

            List<int> disabledIndexes = disabledItemsMap[comb];

            if (itemIndex >= 0 && itemIndex < comb.Items.Count && !disabledIndexes.Contains(itemIndex))
            {
                disabledIndexes.Add(itemIndex);
                comb.Invalidate();
            }
        }

        public static void EnableItem(this System.Windows.Forms.ComboBox comb, int itemIndex)
        {
            if (!disabledItemsMap.ContainsKey(comb)) return;

            List<int> disabledIndexes = disabledItemsMap[comb];

            if (disabledIndexes.Contains(itemIndex))
            {
                disabledIndexes.Remove(itemIndex);
                comb.Invalidate();
            }
        }

        public static void EnableAllItems(this System.Windows.Forms.ComboBox comb)
        {
            if (!disabledItemsMap.ContainsKey(comb)) return;

            disabledItemsMap[comb].Clear();
            comb.Invalidate();
        }


        private static void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            System.Windows.Forms.ComboBox comb = sender as System.Windows.Forms.ComboBox;
            if (comb == null || e.Index < 0) return;

            if (!disabledItemsMap.ContainsKey(comb))
            {
                e.DrawBackground();
                e.Graphics.DrawString(comb.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds.Location);
                e.DrawFocusRectangle();
                return;
            }

            List<int> disabledIndexes = disabledItemsMap[comb];
            bool isDisabled = disabledIndexes.Contains(e.Index);

            using (Brush textBrush = new SolidBrush(isDisabled ? Color.Gray : e.ForeColor))
            {
                e.DrawBackground();
                e.Graphics.DrawString(comb.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds.Location);
                e.DrawFocusRectangle();
            }
        }

        private static void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comb = sender as System.Windows.Forms.ComboBox;
            if (comb == null) return;

            if (!disabledItemsMap.ContainsKey(comb)) return;

            int currentSelectedIndex = comb.SelectedIndex;
            List<int> disabledIndexes = disabledItemsMap[comb];
            int lastValidIndex = lastValidSelectedIndexMap[comb];

            if (currentSelectedIndex >= 0 && disabledIndexes.Contains(currentSelectedIndex))
            {
                comb.SelectedIndex = lastValidIndex;

                }
            else if (currentSelectedIndex >= 0)
            {
               
                lastValidSelectedIndexMap[comb] = currentSelectedIndex;
            }
            else
            {
               
                if (lastValidIndex != -1 && !disabledIndexes.Contains(lastValidIndex))
                {
                    
                }
                else if (comb.Items.Count > 0 && !disabledIndexes.Contains(0))
                {
                   
                    lastValidIndex = 0;
                    lastValidSelectedIndexMap[comb] = lastValidIndex;
                    comb.SelectedIndex = lastValidIndex;
                }
                else
                {
                    lastValidSelectedIndexMap[comb] = -1;
                }
            }
        }

        private static void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comb = sender as System.Windows.Forms.ComboBox;
            if (comb == null) return;

            if (!disabledItemsMap.ContainsKey(comb)) return;

            int lastValidIndex = lastValidSelectedIndexMap[comb];
            List<int> disabledIndexes = disabledItemsMap[comb];

            if (lastValidIndex != -1 && disabledIndexes.Contains(lastValidIndex))
            {
                int firstEnabledIndex = comb.Items.Cast<object>().Select((item, index) => new { item, index })
                                        .FirstOrDefault(x => !disabledIndexes.Contains(x.index))?.index ?? -1;

                if (firstEnabledIndex != -1)
                {
                    lastValidSelectedIndexMap[comb] = firstEnabledIndex;
                    comb.SelectedIndex = firstEnabledIndex;
                }
                else
                {
                    lastValidSelectedIndexMap[comb] = -1;
                    comb.SelectedIndex = -1; 
                }
            }
            else if (lastValidIndex == -1 && comb.Items.Count > 0 && !disabledIndexes.Contains(0))
            {
                lastValidSelectedIndexMap[comb] = 0;
                comb.SelectedIndex = 0;
            }
        }
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
            var sp = new SelectProperties();
            var service = ServiceFactory<GateService>.Instance;
            var gateresult = await service.GetByIdAsync(id);
            sp.TerminalId = terminalId;
            var data = await service.GetAllAvaliableAsync(sp, gateresult.Data);
            if (data.IsSuccess)
            {
                cmb.Items.Clear();

                foreach (var gate in data.Data)
                {
                    cmb.Items.Add(gate.GateNumber);
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
