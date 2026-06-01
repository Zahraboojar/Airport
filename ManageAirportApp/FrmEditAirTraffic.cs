using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Service;
using ManageSchoolApp.Service;
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
    public partial class FrmEditAirTraffic : BaseFrm
    {
        Flight _flight = null;
        AirTrafficService service = ServiceFactory<AirTrafficService>.Instance;
        public FrmEditAirTraffic()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private async void FrmEditAirTraffic_Load(object sender, EventArgs e)
        {
            await ComboBoxHelper.LoadFlightNumberToComboBox(combFlight);
            combEvent.Items.AddRange(EnumExtensions.GetsAirTrafficsEventType());
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (_flight == null)
            {
                FlightService flightService = ServiceFactory<FlightService>.Instance;
                if (combFlight.SelectedItem != null)
                {
                    var flightResult = await flightService.GetByFlightNumber(combFlight.SelectedItem.ToString());
                    if (flightResult.IsSuccess)
                    {
                        _flight = flightResult.Data;
                    }
                    else
                    {
                        CustomMessageBox.Warning(Messages.NotSelectedFlight);
                        return;
                    }
                }
                else
                {
                    CustomMessageBox.Warning(Messages.NotSelectedFlight);
                    return;
                }
            }
            var airtraffic = new AirTrafficDto
            {
                EventType = EnumExtensions.GetAirTrafficsEventType(combEvent.SelectedItem.ToString()).ToString(),
                FlightId = _flight.Id,
            };

            var result = await service.AddAsync(airtraffic);
            CustomMessageBox.Message(result.Message, result.IsSuccess);
        }
    }
}
