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
    public partial class FrmEditPassenger : BaseFrm
    {
        public PassengerDto _passenger = null;
        PassengerService service = ServiceFactory<PassengerService>.Instance;
        public FrmEditPassenger()
        {
            InitializeComponent();
        }
        public FrmEditPassenger(PassengerDto passengerInfo)
        {
            _passenger = passengerInfo;
            InitializeComponent();
        }

        private void FrmEditPassenger_Load(object sender, EventArgs e)
        {
            string nationality = "Iran";
            if (_passenger != null)
            {
                txtEmail.Text = _passenger.Email;
                txtFirstName.Text = _passenger.FirstName;
                txtLastName.Text = _passenger.LastName;
                txtNationalCode.Text = _passenger.NationalCode;
                txtPassportNum.Text = _passenger.PassportNumber;
                txtPhoneNumber.Text = _passenger.PhoneNumber;
                rTxtAdrress.Text = _passenger.Address;
                datePicker.Value = _passenger.DateOfBirth;
                nationality = _passenger.Nationality;
            }
            ComboBoxHelper.LoadCountryNamesToComboBox(combNationality, nationality);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var passenger = new PassengerDto
            {
                Address = rTxtAdrress.Text,
                DateOfBirth = datePicker.Value,
                Email = txtEmail.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                NationalCode = txtNationalCode.Text,
                PassportNumber = txtPassportNum.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Nationality = combNationality.SelectedItem.ToString()
            };
            OperationResult result;

            if (_passenger != null)
            {
                result = await service.UpdateAsync(passenger, _passenger.Id);
                CustomMessageBox.Message(result.Message, result.IsSuccess);
            }
            else
            {
                result = await service.AddAsync(passenger);
                CustomMessageBox.Message(result.Message, result.IsSuccess);
                Close();
            }
            
        }
    }
}
