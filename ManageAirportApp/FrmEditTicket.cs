using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Service;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageAirportApp
{
    public partial class FrmEditTicket : BaseFrm
    {
        public TicketDto _ticket = null;
        int seatNumber = 0;
        TicketService service = ServiceFactory<TicketService>.Instance;
        public FrmEditTicket()
        {
            InitializeComponent();
        }
        public FrmEditTicket(TicketDto ticketInfo)
        {
            _ticket = ticketInfo;
            InitializeComponent();
        }
        private async void FrmEditTicket_Load(object sender, EventArgs e)
        {
            combFlightClass.Items.AddRange(EnumExtensions.GetsFlightClass());
            combType.Items.AddRange(EnumExtensions.GetsTicketType());
            int flightId = 0;
            int passengerId = 0;
            if (_ticket != null)
            {
                passengerId = _ticket.PassengerId;
                flightId = _ticket.FlightId;
                numericPrice.Value = _ticket.Price;
                seatNumber = _ticket.SeatNumber;
                combType.SelectedItem = _ticket.TicketType;
                combFlightClass.SelectedItem = _ticket.Class;
                seatNumber = _ticket.SeatNumber;
            }
            await LoadFlightNumberToComboBox(comFlights, flightId);
            await LoadPassengerToComboBox(combPassengers, passengerId);
        }

        private async Task LoadSeatNumberToComboBox(ComboBox cmb, Flight flight, int seatNumber = 0)
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

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var ticket = new TicketDto
            {
                Class = combFlightClass.SelectedItem.ToString(),
                TicketType = combType.SelectedItem.ToString(),
                Price = (int)numericPrice.Value,
            };
            if (combSeatNum.SelectedItem != null && int.TryParse(combSeatNum.SelectedItem.ToString(), out int sNum))
            {
                ticket.SeatNumber = sNum;
            } else
            {
                CustomMessageBox.Error(Messages.SeatNumberOutOfRange);
                return;
            }
            //flight
            var flightService = ServiceFactory<FlightService>.Instance;
            var flightResult = await flightService.GetByFlightNumber(comFlights.SelectedItem.ToString());
            if (flightResult.IsSuccess)
            {
                ticket.FlightId = flightResult.Data.Id;
                ticket.Flight = flightResult.Data;
            } else
            {
                CustomMessageBox.Error(PersionDictionary.Flight + " " + Messages.NotFound);
                return;
            }

            //passenger
            var passengerService = ServiceFactory<PassengerService>.Instance;
            var nationalCode = combPassengers.SelectedItem.ToString();
            nationalCode = nationalCode
                .Substring(nationalCode.IndexOf('(') + 1, nationalCode.IndexOf(')') - nationalCode.IndexOf('(') - 1);

            var passengerResult = await passengerService.GetByNationalCode(nationalCode);
            if (passengerResult.IsSuccess)
            {
                ticket.PassengerId = passengerResult.Data.Id;
            }
            else
            {
                CustomMessageBox.Error(PersionDictionary.Passenger + " " + Messages.NotFound);
                return;
            }

            //add or update
            OperationResult result;
            if (_ticket != null)
            {
                result = await service.UpdateAsync(ticket, _ticket.Id); 
            } else
            {
                result = await service.AddAsync(ticket);
            }
            CustomMessageBox.Message(result.Message, result.IsSuccess);
        }

        protected async Task LoadPassengerToComboBox(ComboBox cmb, int id = 0)
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

        private async void comFlights_SelectedIndexChanged(object sender, EventArgs e)
        {
            var flightService = ServiceFactory<FlightService>.Instance;
            var flightResult = await flightService.GetByFlightNumber(comFlights.SelectedItem.ToString());
            if (flightResult.IsSuccess)
            {
                await LoadSeatNumberToComboBox(combSeatNum, flightResult.Data, seatNumber);
            } else
            {
                combSeatNum.Items.Clear();
            }
        }
    }
}
