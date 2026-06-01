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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ManageAirportApp
{
    public partial class FrmEditAirport : BaseFrm
    {
        public AirportDto _airport = null;
        AirportService service = ServiceFactory<AirportService>.Instance;
        public FrmEditAirport()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        public FrmEditAirport(AirportDto airportInfo)
        {
            _airport = airportInfo;
            InitializeComponent();
        }

        private void FrmEditAirport_Load(object sender, EventArgs e)
        {
            ComboBoxHelper.LoadCountryNamesToComboBox(combRegion);
            ComboBoxHelper.LoadCitiesNamesToComboBox(combCity, combRegion.SelectedItem.ToString());
            if (_airport != null)
            {
                txtIATA_Code.Text = _airport.IATA_Code;
                txtICAO_Code.Text = _airport.ICAO_Code;
                txtName.Text = _airport.Name;
                combCity.SelectedItem = _airport.City;
                combRegion.SelectedItem = _airport.Region;
            }
        }

        private void combRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxHelper.LoadCitiesNamesToComboBox(combCity, combRegion.SelectedItem.ToString());
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var airportDto = new AirportDto()
            {
                City = combCity.SelectedItem.ToString(),
                Region = combRegion.SelectedItem.ToString(),
                IATA_Code = txtIATA_Code.Text,
                ICAO_Code = txtICAO_Code.Text,
                Name = txtName.Text,
            };

            OperationResult result;

            if (_airport == null)
            {
                result = await service.AddAsync(airportDto);

            } else
            {
                result = await service.UpdateAsync(airportDto, _airport.Id);
            }

            if (result.IsSuccess)
            {
                CustomMessageBox.Success(result.Message);
                Close();
            }
            else
            {
                CustomMessageBox.Error(result.Message);
            }
        }
    }
}
