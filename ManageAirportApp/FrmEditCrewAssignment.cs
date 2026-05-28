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

namespace ManageAirportApp
{
    public partial class FrmEditCrewAssignment : BaseFrm
    {
        public CrewAssignmentDto _crewAssigment = null;
        public FlightDto _flight;
        CrewAssignmentService service = ServiceFactory<CrewAssignmentService>.Instance;
        public FrmEditCrewAssignment(FlightDto flight)
        {
            _flight = flight;
            InitializeComponent();
        }

        public FrmEditCrewAssignment(FlightDto flight, CrewAssignmentDto crewAsigmentInfo)
        {
            _flight = flight;
            _crewAssigment = crewAsigmentInfo;
            InitializeComponent();
        }

        private async void FrmEditCrewAssignment_Load(object sender, EventArgs e)
        {
            if (_flight == null)
            {
                CustomMessageBox.Error(PersionDictionary.Flight + Messages.NotFound);
                Close();
                return;
            }
            await LoadFlightNumberToComboBox(combFlight, _flight.Id);

            int id = 0;
            if (_crewAssigment != null)
            {
                id = _crewAssigment.Id;
            }
            await LoadEmployeeUsernameToComboBox(CombEmployee, id);
            CombEmployeeRole.Items.AddRange(EnumExtensions.GetsEmployeeRole());
            if (_crewAssigment != null)
            {
                CombEmployeeRole.SelectedItem = EnumExtensions.GetEmployeeRole(_crewAssigment.Role.ToString());
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var crewAssigment = new CrewAssignmentDto
            {
                FlightId = _flight.Id,
                Role = EnumExtensions.GetEmployeeRole(CombEmployeeRole.SelectedItem.ToString()).ToString()
            };

            var sp = new SelectProperties();
            var employeeService = ServiceFactory<EmployeeService>.Instance;
            var employeeOP = await employeeService.GetByUsernameAsync(StringHelper.GetUsername(CombEmployee.SelectedItem.ToString()));
            if (employeeOP.IsSuccess)
            {
                crewAssigment.EmployeeId = employeeOP.Data.Id;
            }
            else
            {
                CustomMessageBox.Warning(employeeOP.Message);
                return;
            }

            OperationResult result;

            if (_crewAssigment  == null)
            {
                result = await service.AddAsync(crewAssigment);
            }
            else
            {
                result = await service.UpdateAsync(crewAssigment, _crewAssigment.Id);
            }
            CustomMessageBox.Message(result.Message, result.IsSuccess);
            Close();
        }
    }
}
