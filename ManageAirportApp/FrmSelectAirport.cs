using ManageAirportApp.DAL;
using ManageAirportApp.Service;
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
    public partial class FrmSelectAirport : BaseFrm
    {
        public FrmSelectAirport()
        {
            InitializeComponent();
        }
        private async void FrmSelectAirport_Load(object sender, EventArgs e)
        {
            ComboBoxHelper.LoadCountryNamesToComboBox(combRegion);
            ComboBoxHelper.LoadCitiesNamesToComboBox(combCity);
            if (combCity.SelectedItem != null)
            {
                await ComboBoxHelper.LoadAirportNameToComboBox(combAirport, 0, combCity.SelectedItem.ToString());
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (combRegion.SelectedItem != null)
            {
                if (combCity.SelectedItem != null)
                {
                    if (combAirport.SelectedItem != null)
                    {
                        var airportService = ServiceFactory<AirportService>.Instance;
                        var airportResult = await airportService.GetByNameAsync(combAirport.SelectedItem.ToString());
                        if (airportResult.IsSuccess)
                        {
                            new FrmFids(airportResult.Data).ShowDialog();
                        }
                        else
                        {
                            CustomMessageBox.Error(PersionDictionary.Airport + " " + Messages.NotFound + " " + Messages.ReTry);
                        }
                    }
                    else
                    {
                        CustomMessageBox.Error(Messages.NotSelectedAirport);
                    }
                }
                else
                {
                    CustomMessageBox.Error(Messages.NotSelectedCity);

                }
            }
            else
            {
                CustomMessageBox.Error(Messages.NotSelectedRegion);

            }
        }

        private void combRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combRegion.SelectedItem != null)
            {
                ComboBoxHelper.LoadCitiesNamesToComboBox(combCity, combRegion.SelectedItem.ToString());
            }
        }

        private async void combCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combCity.SelectedItem != null)
            {
                await ComboBoxHelper.LoadAirportNameToComboBox(combAirport, 0, combCity.SelectedItem.ToString());
            }
        }
    }
}
