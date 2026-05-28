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
    public partial class FrmCrewAssignments : BaseFrm
    {
        SelectProperties _sp = new SelectProperties();
        CrewAssignmentService service = ServiceFactory<CrewAssignmentService>.Instance;
        FlightDto _flight = null;
        public FrmCrewAssignments(FlightDto flight)
        {
            _flight = flight;
            InitializeComponent();
        }

        private async void FrmCrewAssignments_Load(object sender, EventArgs e)
        {
            _sp.AirportId = LoginedUserService.Employee.AirportId == null ? 0 : (int)LoginedUserService.Employee.AirportId;
            if (_flight == null)
            {
                CustomMessageBox.Error(PersionDictionary.Flight + Messages.NotFound);
                Close();
            }
            await LoadData(_sp);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_flight != null)
            {
                new FrmEditCrewAssignment(_flight).ShowDialog();
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            _sp.SearchText = string.Empty;
            await LoadData(_sp);
        }

        private async void btnTrash_Click(object sender, EventArgs e)
        {
            _sp.IsDeleted = !_sp.IsDeleted;
            txtSearch.Text = "";
            await LoadData(_sp);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length > 0)
            {
                _sp.SearchText = txtSearch.Text.Trim();
                await LoadData(_sp);
            }
        }
        private async Task LoadData(SelectProperties sp)
        {
            flowLayoutPanelEmployees.Controls.Clear();
            var result = await service.GetAllAsync(sp);
            if (result.IsSuccess)
            {
                if (result.Data.Count > 0)
                {
                    foreach (var item in result.Data)
                    {
                        var userControl = new UserItemControl(_flight, item, sp.IsDeleted);
                        userControl.Margin = new Padding(5);
                        userControl.Width = flowLayoutPanelEmployees.ClientSize.Width - 25;
                        flowLayoutPanelEmployees.Controls.Add(userControl);
                    }
                    return;
                }
            }
            CustomMessageBox.Warning(Messages.NotFoundRow);
        }

        private void flowLayoutPanelEmployees_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelEmployees.SuspendLayout();

            int newWidth = flowLayoutPanelEmployees.ClientSize.Width - 35;

            if (newWidth > 0)
            {
                foreach (Control ctrl in flowLayoutPanelEmployees.Controls)
                {
                    ctrl.Width = newWidth;
                }
            }

            flowLayoutPanelEmployees.ResumeLayout();
        }
    }
}
