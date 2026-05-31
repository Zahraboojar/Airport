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
    public partial class FrmEditAircraft : BaseFrm
    {
        public AircraftDto _aircraft = null;
        AircraftService service = ServiceFactory<AircraftService>.Instance;
        public FrmEditAircraft()
        {
            InitializeComponent();
        }
        public FrmEditAircraft(AircraftDto aircraftInfo)
        {
            _aircraft = aircraftInfo;
            InitializeComponent();
        }

        private void FrmEditAircraft_Load(object sender, EventArgs e)
        {
            if (_aircraft != null)
            {
                txtMenuFactorerName.Text = _aircraft.ManufacturerName;
                txtModel.Text = _aircraft.Model;
                numCapacity.Value = _aircraft.Capacity;
                txtRegisterationNum.Text = _aircraft.RegistrationNumber;
                
            }
        }

        private async void txtSubmit_Click(object sender, EventArgs e)
        {
            AircraftDto aircraft = new AircraftDto
            {
                ManufacturerName = txtMenuFactorerName.Text,
                Model = txtModel.Text,
                RegistrationNumber = txtRegisterationNum.Text,
                Capacity = (int)numCapacity.Value

            };
            if (_aircraft == null)
            {
                var result = await service.AddAsync(aircraft);
                CustomMessageBox.Message(result.Message, result.IsSuccess);
                Close();
            }
            else
            {
                var result = await service.UpdateAsync(aircraft, _aircraft.Id);
                CustomMessageBox.Message(result.Message, result.IsSuccess);
            }
        }

    }
}
