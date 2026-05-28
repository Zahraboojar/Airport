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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageAirportApp
{
    public partial class BaseFrm : Form
    {
        public BaseFrm()
        {
            ThemeManager.ApplyTheme(this);
            InitializeComponent();
        }

        private void BaseFrm_Load(object sender, EventArgs e)
        {
             foreach (Control control in this.Controls)
            {
                ThemeManager.ApplyTheme(control);
            }
        }

        protected void LoadCountryNamesToComboBox(ComboBox cmb, string country = "Iran")
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
        protected void LoadCitiesNamesToComboBox(ComboBox cmb, string country = "Iran")
        {
            List<string> cities = NationalityHelper.GetAllCitiesNames(country);

            cmb.Items.Clear();

            foreach (string citiesName in cities)
            {
                cmb.Items.Add(citiesName);
            }
        }
        public void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FindAndAttachCloseButtons(this.Controls);
        }

        private void FindAndAttachCloseButtons(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button btn && btn.Tag != null && btn.Tag.ToString() == "close")
                {
                    btn.Click -= btnCancel_Click;
                    btn.Click += btnCancel_Click;
                }
                if (control.HasChildren)
                {
                    FindAndAttachCloseButtons(control.Controls);
                }
            }
        }
        protected async Task LoadFlightNumberToComboBox(ComboBox cmb, int id = 0)
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

        protected async Task LoadEmployeeUsernameToComboBox(ComboBox cmb, int id = 0)
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

        protected async Task LoadAirportNameToComboBox(ComboBox cmb, int id = 0, string cityName = "")
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
        protected DateTime CombineDateTime(DateTimePicker dp1, DateTimePicker dp2)
        {
            DateTime selectedDate = dp1.Value.Date;
            TimeSpan selectedTime = dp2.Value.TimeOfDay;
            return selectedDate.Add(selectedTime);
        }

        public List<string> ValidateSelections(params (int SelectedIndex, string ErrorMessage)[] items)
        {
            var errors = new List<string>();

            foreach (var item in items)
            {
                if (item.SelectedIndex < 0)
                {
                    errors.Add(item.ErrorMessage);
                }
            }

            return errors;
        }
    }
}
