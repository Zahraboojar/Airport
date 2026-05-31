using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Service;
using ManageAirportApp.Share;
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
    public partial class FrmEditEmployee : BaseFrm
    {
        public EmployeeDto _employee = null;
        EmployeeService service = ServiceFactory<EmployeeService>.Instance;
        public FrmEditEmployee()
        {
            InitializeComponent();
        }
        public FrmEditEmployee(EmployeeDto employeeInfo)
        {
            _employee = employeeInfo;
            InitializeComponent();
        }

        private async void FrmEditEmployee_Load(object sender, EventArgs e)
        {
            combType.Items.AddRange(EnumExtensions.GetsEmployeeType());
            int selectedAirportId = 0;
            if (_employee != null) {
                selectedAirportId = _employee.AirportId;
                combType.SelectedItem = _employee.EmployeeType;
                txtFirstName.Text = _employee.FirstName;
                txtLastName.Text = _employee.LastName;
                txtMobile.Text = _employee.PhoneNumber;
                txtEmail.Text = _employee.Email;
                txtNationalCode.Text = _employee.NationalCode;
                txtPassportNum.Text = _employee.PassportNumber;
                txtUserName.Text = _employee.UserName;
                rTxtAddress.Text = _employee.Address;
                datePicker.Value = _employee.DateOfBirth;
                if (LoginedUserService.EmployeeId == _employee.Id)
                {
                    txtUserName.Enabled = true;
                    txtPassword.Enabled = true;
                    txtRepassword.Enabled = true;
                }
            } else
            {
                txtUserName.Enabled = true;
                txtPassword.Enabled = true;
                txtRepassword.Enabled = true;
            }
            await ComboBoxHelper.LoadAirportNameToComboBox(combAirport, selectedAirportId);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (combType.SelectedIndex >= 0  && combAirport.SelectedIndex >= 0)
            {
                var employee = new EmployeeDto
                {
                    EmployeeType = combType.SelectedItem.ToString(),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    NationalCode = txtNationalCode.Text,
                    PassportNumber = txtPassportNum.Text,
                    UserName = txtUserName.Text,
                    Address = rTxtAddress.Text,
                    DateOfBirth = datePicker.Value,
                    Email = txtEmail.Text,
                    PhoneNumber = txtMobile.Text,
                };

                //find airport
                var airportService = ServiceFactory<AirportService>.Instance;
                var airportResult = await airportService.GetByNameAsync(combAirport.SelectedItem.ToString());
                if (airportResult.IsSuccess)
                {
                    employee.AirportId = airportResult.Data.Id;
                } else
                {
                    CustomMessageBox.Error(airportResult.Message);
                    return;
                }
                var passResult = StringHelper.IsEqualPassword(txtPassword.Text, txtRepassword.Text);
                if (passResult.IsSuccess)
                {
                    employee.Password = passResult.Data;
                } else
                {
                    if (passResult.Message == Messages.EmptyPassfield) return;
                    CustomMessageBox.Error(passResult.Message);
                    return;
                }

                OperationResult result;

                if (_employee == null)
                {

                    result = await service.AddAsync(employee);
                }
                else
                {
                    result = await service.UpdateAsync(employee, _employee.Id);
                }
                CustomMessageBox.Message(result.Message, result.IsSuccess);
                Close();
            }
            else
            {
                CustomMessageBox.Warning(Messages.NotSelectedAirport + Messages.Or + Messages.NotSelectedRole);
            }
        }
    }
}
