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
                var gateNumberData = separateLettersNumbers(_gate.GateNumber);
                combLetters.SelectedItem = gateNumberData[0];
                combNumbers.SelectedItem = gateNumberData[1];

                ComboBoxHelper.DisableItemsFromIndexToEnd(combLetters, combLetters.SelectedIndex + 1);
                ComboBoxHelper.DisableItemsFromIndexToEnd(combNumbers, combNumbers.SelectedIndex + 1);

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
                GateNumber = combLetters.SelectedItem + combNumbers.SelectedItem.ToString(),
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
                result = await service.UpdateAsync(gate, _gate.Id);
                CustomMessageBox.Message(result.Message, result.IsSuccess);
            } else
            {
                result = await service.AddAsync(gate);
                CustomMessageBox.Message(result.Message, result.IsSuccess);
                Close();
            }
        }
        protected string[] separateLettersNumbers(string gateNumber)
        {
            string[] data = new string[2];
            data[0] = gateNumber.Substring(0,1);
            data[1] = gateNumber.Substring(1,1);
            return data;
        }

        private async void combTerminal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sp = new SelectProperties
            {
                AirportId = LoginedUserService.Employee.AirportId == null ? 0 : (int)LoginedUserService.Employee.AirportId,
            };
            var terminalService = ServiceFactory<TerminalService>.Instance;
            var terminal = await terminalService.GetByNameAsync(combTerminal.SelectedItem.ToString());
            if (terminal.IsSuccess)
            {
                sp.TerminalId = terminal.Data.Id;
                var result = await service.GetLastAsync(sp);
                if (result.IsSuccess)
                {
                    var data = separateLettersNumbers(result.Data.GateNumber);
                    var indexOfLetter = combLetters.Items.IndexOf(data[0]);
                    var indexOfNumber = combLetters.Items.IndexOf(data[1]);
                    ComboBoxHelper.DisableItemsFromIndexToEnd(combLetters, indexOfLetter + 2);
                    ComboBoxHelper.DisableItemsFromIndexToEnd(combNumbers, indexOfNumber + 2);
                }
                else
                {
                    ComboBoxHelper.DisableItemsFromIndexToEnd(combLetters, 1);
                    ComboBoxHelper.DisableItemsFromIndexToEnd(combNumbers, 1);
                }
            }
        }
    }
}
