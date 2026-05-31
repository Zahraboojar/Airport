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
    public partial class FrmEditBaggage : BaseFrm
    {
        public BaggageDto _baggage = null;
        BaggageService service = ServiceFactory<BaggageService>.Instance;
        public FrmEditBaggage()
        {
            InitializeComponent();
        }
        public FrmEditBaggage(BaggageDto baggageInfo)
        {
            _baggage = baggageInfo;
            InitializeComponent();
        }
        private async void FrmEditBaggage_Load(object sender, EventArgs e)
        {
            combStatus.Items.AddRange(EnumExtensions.GetsBaggageStatus());
            combType.Items.AddRange(EnumExtensions.GetsBaggageType());
            int ticketId = 0;
            if (_baggage != null)
            {
                combStatus.SelectedItem = _baggage.Status;
                combTicket.SelectedItem = _baggage.Ticket;
                combType.SelectedItem = _baggage.Type;
                numericWeight.Value = _baggage.Weight;
                ticketId = _baggage.TicketId;
            }
            await ComboBoxHelper.LoadTicketToComboBox(combTicket, ticketId);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var baggage = new BaggageDto
            {
                Status = combStatus.SelectedItem.ToString(),
                Type = combType.SelectedItem.ToString(),
                Weight = numericWeight.Value,
            };
            if (combTicket.SelectedItem != null)
            {
                var ticketService = ServiceFactory<TicketService>.Instance;
                var ticketResult = await ticketService.GetByTicketNumberAsync(combTicket.SelectedItem.ToString());
                if (ticketResult.IsSuccess)
                {
                    baggage.TicketId = ticketResult.Data.Id;
                    baggage.Ticket = ticketResult.Data;

                } else
                {
                    CustomMessageBox.Warning(Messages.NotSelectedTicket);
                    return;
                }
            }
            else
            {
                CustomMessageBox.Warning(Messages.NotSelectedTicket);
                return;
            }

            OperationResult result;
            if (_baggage == null)
            {
                result = await service.AddAsync(baggage);
            } else
            {
                result = await service.UpdateAsync(baggage, _baggage.Id);
                
            }
            CustomMessageBox.Message(result.Message, result.IsSuccess);
            Close();
        }
    }
}
