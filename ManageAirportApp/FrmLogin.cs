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
            ThemeManager.ApplyTheme(this);
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
                this.Hide();
                mainForm.ShowDialog();

                Close();
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
            
        }

        private void btnFIDS_Click(object sender, EventArgs e)
        {
            new FrmSelectAirport().ShowDialog();
        }

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private async void btn_Click(object sender, EventArgs e)
        {
            var employeeService = ServiceFactory<EmployeeService>.Instance;
            var employeeResult = await employeeService.GetByUsernameAsync("ali");
            var airportService = ServiceFactory<AirportService>.Instance;
            var airportResult = await airportService.GetAllEntityAsync(new SelectProperties());
            if (!employeeResult.IsSuccess)
            {
                int airportId = 0;
                if (!airportResult.IsSuccess)
                {
                    var airportDto = new AirportDto
                    {
                        City = "Tehran",
                        Region = "Iran",
                        CreationBy = null,
                        IATA_Code = "IRN",
                        ICAO_Code = "GYDR",
                        Name = "فرودگاه مهرآباد",
                    };
                    var airresult = await airportService.AddAsync(airportDto);
                    if (airresult.IsSuccess)
                    {
                        var data = await airportService.GetByNameAsync(airportDto.Name);
                        if (data.IsSuccess)
                        {
                            airportId = data.Data.Id;
                        }
                    }
                    
                } else
                {
                    airportId = airportResult.Data[0].Id;
                }
                var employeeDto = new EmployeeDto
                {
                    Address = "",
                    AirportId = airportId,
                    Email = "ali@gmail.com",
                    LastName = "alavi",
                    FirstName = "ali",
                    UserName = "ali",
                    PassportNumber = "A12345678",
                    NationalCode = "1250902452",
                    Password = "123",
                    PhoneNumber = "09135467689",
                    DateOfBirth = DateTime.Now,
                    CreationBy = null,
                    EmployeeType = EnumExtensions.GetEmployeeType(EmployeeType.Management),
                };
                
                var result = await employeeService.AddAsync(employeeDto);
                if (result.IsSuccess)
                {
                    var loginService = new LoginedUserService();
                    var loginResult = await loginService.Login("ali", "123");
                    if (loginResult.IsSuccess)
                    {

                        CustomMessageBox.Success(Messages.Welcome +
                            Environment.NewLine + "username = ali , password = 123");
                        this.Hide();
                        new FrmMain().ShowDialog();

                        Close();
                    }
                }
            } else
            {
                CustomMessageBox.Error("کاربر مهمان قبلا ایجاد شده " + Environment.NewLine + "username = ali , password = 123");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemeManager.ReverseTheme(this.FindForm());
            btnThem.BackgroundImage = ThemeManager.ThemeIcon;
        }
    }
}