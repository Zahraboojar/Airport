using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Service;
using ManageAirportApp.Share;
using ManageSchoolApp.Service;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ManageAirportApp
{
    public partial class FrmSetting : BaseFrm
    {
        AirportService service = ServiceFactory<AirportService>.Instance;
        string imageLoc = string.Empty;

        public FrmSetting()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            Airport airport = null;

            if (LoginedUserService.Employee != null && LoginedUserService.Employee.AirportId != null)
            {
                airport = LoginedUserService.Employee.Airport;
            }

            if (airport != null)
            {
                ComboBoxHelper.LoadCountryNamesToComboBox(combRegion);

                if (combRegion.Items.Count > 0)
                {
                    combRegion.SelectedItem = airport.Region;
                    ComboBoxHelper.LoadCitiesNamesToComboBox(combCity, combRegion.SelectedItem?.ToString());
                    combCity.SelectedItem = airport.City;
                }

                txtIATA_Code.Text = airport.IATA_Code;
                txtICAO_Code.Text = airport.ICAO_Code;
                txtName.Text = airport.Name;

                if (!string.IsNullOrEmpty(airport.Logo))
                {
                    string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", airport.Logo);

                    if (File.Exists(logoPath))
                    {
                        if (picLogo.Image != null)
                        {
                            picLogo.Image.Dispose();
                            picLogo.Image = null;
                        }

                        picLogo.Image = Image.FromFile(logoPath);
                        picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            else
            {
                CustomMessageBox.Error(Messages.NotFoundData);
                Close();
            }
        }

        private async void btnSet_Click(object sender, EventArgs e)
        {
            var airportDto = new AirportDto()
            {
                City = combCity.SelectedItem?.ToString(),
                Region = combRegion.SelectedItem?.ToString(),
                IATA_Code = txtIATA_Code.Text,
                ICAO_Code = txtICAO_Code.Text,
                Name = txtName.Text,
                Logo = imageLoc
            };

            var result = await service.UpdateAsync(airportDto, LoginedUserService.Employee.Airport.Id);

            if (result.IsSuccess)
            {
                var employeeAirport = LoginedUserService.Employee.Airport;

                employeeAirport.City = airportDto.City;
                employeeAirport.Region = airportDto.Region;
                employeeAirport.IATA_Code = airportDto.IATA_Code;
                employeeAirport.ICAO_Code = airportDto.ICAO_Code;
                employeeAirport.Name = airportDto.Name;

                if (!string.IsNullOrEmpty(airportDto.Logo))
                    employeeAirport.Logo = airportDto.Logo;

                if (menuControl1 != null && menuControl1 is MenuControl myMenuControl)
                {
                    myMenuControl.MenuControl_Load(sender, e);
                }
                CustomMessageBox.Success(result.Message);
                Close();
            }
            else
            {
                CustomMessageBox.Error(result.Message);
            }
        }

        private void btnChangeLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "لطفاً یک تصویر انتخاب کنید";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string destFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

                        if (!Directory.Exists(destFolder))
                            Directory.CreateDirectory(destFolder);

                        string fileName = Path.GetFileName(openFileDialog.FileName);
                        string destPath = Path.Combine(destFolder, fileName);

                        File.Copy(openFileDialog.FileName, destPath, true);

                        imageLoc = fileName;

                        if (picLogo.Image != null)
                        {
                            picLogo.Image.Dispose();
                            picLogo.Image = null;
                        }

                        picLogo.Image = Image.FromFile(destPath);
                        picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch (Exception imgEx)
                    {
                        CustomMessageBox.Error("خطا در بارگذاری تصویر انتخابی: " + imgEx.Message, "خطا");
                        imageLoc = string.Empty;
                        picLogo.Image = null;
                    }
                }
            }
        }
    }
}
