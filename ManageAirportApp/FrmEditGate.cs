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
    public partial class FrmEditGate : BaseFrm
    {
        private GateDto _gate = null;
        private int _terminalId = 0;
        GateService service = ServiceFactory<GateService>.Instance;
        public FrmEditGate()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        public FrmEditGate(int terminalId)
        {
            _terminalId = terminalId;
            InitializeComponent();
        }
        public FrmEditGate(GateDto gateInfo)
        {
            _gate = gateInfo;
            InitializeComponent();
        }

        private async void FrmEditGate_Load(object sender, EventArgs e)
        {
            string terminalName = "";
            var service = ServiceFactory<TerminalService>.Instance;
            var result = await service.GetByIdAsync(_terminalId);
            if (result.IsSuccess) { terminalName = result.Data.Name; }
            
            if (_gate != null)
            {
                lblGateNumber.Text = _gate.GateNumber;
                combTerminal.SelectedItem = _gate.Terminal.Name;
                numericCapacity.Value = _gate.Capacity;
                terminalName = _gate.Terminal.Name;
            }
            await ComboBoxHelper.LoadTerminalToComboBox(combTerminal, terminalName);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var gate = new GateDto
            {
                Capacity = (int)numericCapacity.Value
            };
            var terminalService = ServiceFactory<TerminalService>.Instance;
            var terminalResult = await terminalService.GetByNameAsync(combTerminal.SelectedItem.ToString());

            if (terminalResult.IsSuccess)
            {
                gate.TerminalId = terminalResult.Data.Id;
                gate.Terminal = terminalResult.Data;
            }
            else
            {
                CustomMessageBox.Error(PersionDictionary.Terminal + " " + Messages.NotFound);
                return;
            }
            OperationResult result;
            if (_gate != null)
            {
                gate.GateNumber = _gate.GateNumber;
                result = await service.UpdateAsync(gate, _gate.Id);
                CustomMessageBox.Message(result.Message, result.IsSuccess);
            } else
            {
                result = await service.AddAsync(gate);
                CustomMessageBox.Message(result.Message, result.IsSuccess);
                Close();
            }
        }
    }
}
