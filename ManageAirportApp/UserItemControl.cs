using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
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
    public partial class UserItemControl : UserControl
    {
        private FlightDto _flight;
        private CrewAssignmentDto _crewAssignment;
        bool _isDeleted;
        public Image Profile { get; set; } = Properties.Resources.userImage;

        public UserItemControl(FlightDto flight, CrewAssignmentDto crewAssignment, bool isDeleted = false)
        {
            _crewAssignment = crewAssignment;
            _flight = flight;
            _isDeleted = isDeleted;
            InitializeComponent();
        }

        private void UserItemControl_Load(object sender, EventArgs e)
        {
            btnRestore.Visible = _isDeleted;
            this.BackColor = ThemeManager.BackgroundColor;
            lblEmail.Text = _crewAssignment.Employee.Email;
            lblPhoneNumber.Text = _crewAssignment.Employee.PhoneNumber;
            lblname.Text = $"{_crewAssignment.Employee.FirstName} {_crewAssignment.Employee.LastName}";
            lblPassportNumber.Text = _crewAssignment.Employee.PassportNumber;
            lblId.Text = _crewAssignment.Employee.Id.ToString();
            picture.Image = Profile;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var result = CustomMessageBox.Confirm(Messages.ConfirmDelete, PersionDictionary.Delete);
            if (result == DialogResult.Yes)
            {
                if (btnRestore.Visible) {
                    var service = ServiceFactory<CrewAssignmentService>.Instance;
                    var crewResult = await service.DeleteByIdAsync(_crewAssignment.Id, true);
                    CustomMessageBox.Message(crewResult.Message, crewResult.IsSuccess);
                }
                else
                {
                    await DvgExtentions.DvgBtnAction(DashboardType.CrewAssignments, new object[] { _crewAssignment, _flight }, Actions.Delete);
                }
            }
        }

        private async void btnRestor_Click(object sender, EventArgs e)
        {
            var result = CustomMessageBox.Confirm(Messages.ConfirmRestore, PersionDictionary.Restore);
            if (result == DialogResult.Yes)
            {
                await DvgExtentions.DvgBtnAction(DashboardType.CrewAssignments, new object[] { _crewAssignment, _flight }, Actions.Restore);
            }
        }
    }
}
