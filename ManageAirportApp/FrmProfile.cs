using ManageAirportApp.DAL;
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
    public partial class FrmProfile : BaseFrm
    {
        EmployeeService service = ServiceFactory<EmployeeService>.Instance;
        public FrmProfile()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            var data = LoginedUserService.Employee;
            txtEmail.Text = data.Email;
            txtFirstName.Text = data.FirstName;
            txtLastName.Text = data.LastName;
            txtMobile.Text = data.PhoneNumber;
            txtPassportNum.Text = data.PassportNumber;
            txtUserName.Text = data.UserName;
            rTxtAddress.Text = data.Address;
            txtNationalCode.Text = data.NationalCode;
            datePicker.Value = data.DateOfBirth;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var employee = new EmployeeDto
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                UserName = txtUserName.Text,
                DateOfBirth = datePicker.Value,
                Address = rTxtAddress.Text,
                NationalCode = txtNationalCode.Text,
                PassportNumber = txtPassportNum.Text,
                PhoneNumber = txtMobile.Text,
                EmployeeType = EnumExtensions.GetEmployeeType(LoginedUserService.Employee.EmployeeType),
            };
            var passResult = StringHelper.IsEqualPassword(txtPassword.Text, txtRepassword.Text);
            if (passResult.IsSuccess)
            {
                employee.Password = passResult.Data;
            }
            else
            {
                if (passResult.Message != Messages.EmptyPassfield)
                {
                    CustomMessageBox.Error(passResult.Message);
                    return;
                }
            }
            var result = await service.UpdateAsync(employee, LoginedUserService.EmployeeId);
            if (result.IsSuccess)
            {
                CustomMessageBox.Success(result.Message);
                Close();
            } else
            {
                CustomMessageBox.Error(result.Message);
            }
        }
    }
}
