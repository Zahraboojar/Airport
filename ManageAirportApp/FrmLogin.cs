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
    public partial class FrmLogin : BaseFrm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            FrmMain mainForm = new FrmMain();
            ThemeManager.ApplyTheme(mainForm);
            var loginService = new LoginedUserService();
            var result = await loginService.Login(txtUserName.Text,txtPassword.Text);
            if (result.IsSuccess)
            {
                CustomMessageBox.Success(Messages.Welcome);
                mainForm.Show();

                this.Hide();
            } else
            {
                CustomMessageBox.Error(Messages.InCorrectUserNameOrPassWord);
            }
        }

        private async void FrmLogin_Load(object sender, EventArgs e)
        {
            if (LoginedUserService.Employee != null)
            {
                lblTitle.Text = LoginedUserService.Employee.Airport.Name;
                return;
            }
            lblTitle.Text = "تنظیم نشده";
            //var employeeService = ServiceFactory<EmployeeService>.Instance;
            //var employeeResult = await employeeService.GetByIdAsync();
            //var airportService = ServiceFactory<AirportService>.Instance;
            //var airporteResult = await airportService.GetByIdAsync(1);
            //if (!employeeResult.IsSuccess)
            //{
            //    var airportDto = new AirportDto
            //    {
            //        City = "Tehran",
            //        Region = "Iran",
            //        CreationBy = null,
            //        IATA_Code = "IRN",
            //        ICAO_Code = "GYDR",
            //        Name = "فرودگاه مهرآباد",
            //    };
            //    var employeeDto = new EmployeeDto
            //    {
            //        Address = "",
            //        AirportId = 1,
            //        Email = "ali@gmail.com",
            //        LastName = "alavi",
            //        FirstName = "ali",
            //        UserName = "ali",
            //        PassportNumber = "A12345678",
            //        NationalCode = "1250902452",
            //        Password = "123",
            //        PhoneNumber = "09135467689",
            //        DateOfBirth = DateTime.Now,
            //        CreationBy = null,
            //        EmployeeType = EnumExtensions.GetEmployeeType(EmployeeType.Management),
            //    };
            //    await airportService.AddAsync(airportDto);
            //    await employeeService.AddAsync(employeeDto);
            //}
        }

        private void btnFIDS_Click(object sender, EventArgs e)
        {
            new FrmSelectAirport().ShowDialog();
        }
    }
}