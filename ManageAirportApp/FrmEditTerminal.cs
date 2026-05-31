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
    public partial class FrmEditTerminal : BaseFrm
    {
        TerminalDto _terminal;
        TerminalService service = ServiceFactory<TerminalService>.Instance;

        public FrmEditTerminal()
        {
            InitializeComponent();
        }
        public FrmEditTerminal(TerminalDto terminal)
        {
            _terminal = terminal;
            InitializeComponent();
        }

        private void FrmEditTerminal_Load(object sender, EventArgs e)
        {
            if (_terminal != null)
            {
                txtName.Text = _terminal.Name;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var treminal = new TerminalDto
            {
                Name = txtName.Text
            };

            OperationResult result;
            if (_terminal != null)
            {
                result = await service.UpdateAsync(treminal, _terminal.Id);
                CustomMessageBox.Message(result.Message, result.IsSuccess);
            } else
            {
                result = await service.AddAsync(treminal);
                CustomMessageBox.Message(result.Message, result.IsSuccess);
                Close();
            }
        }
    }
}
