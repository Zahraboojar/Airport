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
    public partial class FrmEditFlight : BaseFrm
    {
        public FlightDto _flight = null;
        FlightService service = ServiceFactory<FlightService>.Instance;
        public FrmEditFlight()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        public FrmEditFlight(FlightDto flightInfo)
        {
            _flight = flightInfo;
            InitializeComponent();
        }

        private async void FrmEditFlight_Load(object sender, EventArgs e)
        {
            int aircraftId, aAirportId, dAirportId, gateId;
            aircraftId = aAirportId = dAirportId = gateId = 0;

            combStatus.Items.AddRange(EnumExtensions.GetsFlightStatus());

            if (_flight != null)
            {
                aircraftId = _flight.AircraftId;
                gateId = _flight.GateId;
                aAirportId = _flight.ArrivalAirportId;
                dAirportId = _flight.DepartureAirportId;
                combStatus.SelectedItem = _flight.Status;

                dpSADate.Value = dpSATime.Value = _flight.ScheduledArrivalTime;
                dpSDDate.Value = dpSDTime.Value = _flight.ScheduledDepartureTime;

                if (_flight.ActualDepartureTime != null && _flight.ActualArrivalTime != null)
                {
                    dpADate.Value = dpATime.Value = _flight.ActualArrivalTime.Value;
                    dpDDate.Value = dpDTime.Value = _flight.ActualDepartureTime.Value;
                }
                dpSADate.Enabled = dpSATime.Enabled = dpSDDate.Enabled = dpSDTime.Enabled = false;
            } else
            {
                dpADate.Enabled = dpATime.Enabled = dpDDate.Enabled = dpDTime.Enabled = false;
            }
            await ComboBoxHelper.LoadAircraftToComboBox(combAircraft, aircraftId);
            await ComboBoxHelper.LoadAirportNameToComboBox(combAAirport, aAirportId);
            await ComboBoxHelper.LoadAirportNameToComboBox(combDAirport, dAirportId);
            await ComboBoxHelper.LoadGateToComboBox(combGate, gateId);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var errors = ValidateSelections(
                (combAircraft.SelectedIndex, Messages.NotSelectedAircraft),
                (combAAirport.SelectedIndex, Messages.NotSelectedAAirport),
                (combDAirport.SelectedIndex, Messages.NotSelectedDAirport),
                (combGate.SelectedIndex, Messages.NotSelectedGate),
                (combStatus.SelectedIndex, Messages.NotSelectedStatus)
            );

            if (errors.Any())
            {
                CustomMessageBox.Error(string.Join(Environment.NewLine, errors));
                return;
            }
            else
            {
                var flight = new FlightDto();

                //airport
                var airportService = ServiceFactory<AirportService>.Instance;
                var aAirportResult = await airportService.GetByNameAsync(combAAirport.SelectedItem.ToString());
                var dAirportResult = await airportService.GetByNameAsync(combDAirport.SelectedItem.ToString());
                if (aAirportResult.IsSuccess && dAirportResult.IsSuccess)
                {
                    if (dAirportResult.Data.Id == aAirportResult.Data.Id)
                    {
                        CustomMessageBox.Warning(Messages.MustNotEqualAirports);
                        return;
                    }
                    flight.DepartureAirportId = dAirportResult.Data.Id;
                    flight.ArrivalAirportId = aAirportResult.Data.Id;
                    flight.ArrivalAirport = aAirportResult.Data;
                }
                else
                {
                    CustomMessageBox.Error(aAirportResult.Message + Environment.NewLine + dAirportResult.Message);
                    return;
                }

                //gate
                var gateService = ServiceFactory<GateService>.Instance;

                var gateResult = await gateService.GetByGateNumberAsync(SeperateGateNumber(combGate.SelectedItem.ToString()));
                if (gateResult.IsSuccess)
                {
                    flight.GateId = gateResult.Data.Id;
                    flight.Gate = gateResult.Data;
                }
                else
                {
                    CustomMessageBox.Error(gateResult.Message);
                    return;
                }

                //aircraft
                var aircraftService = ServiceFactory<AircraftService>.Instance;
                var aircraftResult = await aircraftService.GetByRegistrationNumberAsync(combAircraft.SelectedItem.ToString());
                if (aircraftResult.IsSuccess)
                {
                    flight.AircraftId = aircraftResult.Data.Id;
                    flight.Aircraft = aircraftResult.Data;
                }
                else
                {
                    CustomMessageBox.Error(gateResult.Message);
                    return;
                }

                flight.Status = combStatus.SelectedItem.ToString();

                flight.ScheduledArrivalTime = CombineDateTime(dpSADate, dpSATime);
                flight.ScheduledDepartureTime = CombineDateTime(dpSDDate, dpSDTime);

                //add / update
                OperationResult result;
                if (_flight != null)
                {
                    flight.ActualArrivalTime = CombineDateTime(dpADate, dpATime);
                    flight.ActualDepartureTime = CombineDateTime(dpDDate, dpDTime);

                    result = await service.UpdateAsync(flight, _flight.Id);
                    CustomMessageBox.Message(result.Message, result.IsSuccess);
                }
                else
                {
                    result = await service.AddAsync(flight);
                    CustomMessageBox.Message(result.Message, result.IsSuccess);
                    Close();
                }
                
            }

        }
        private string SeperateGateNumber(string input)
        {
            string[] parts = input.Split('-');

            if (parts.Length > 1)
            {
                string result = parts[1].Trim();
                return result;
            }
            return "";
        }
        
    }
}
