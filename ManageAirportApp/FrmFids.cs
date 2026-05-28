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
    public partial class FrmFids : Form
    {
        TerminalService terminalService = ServiceFactory<TerminalService>.Instance;
        GateService gateService = ServiceFactory<GateService>.Instance;
        Airport _airport = null;
        SelectProperties sP;
        public FrmFids(Airport airport)
        {
            InitializeComponent();
            _airport = airport;
            sP = new SelectProperties();
            sP.AirportId = _airport.Id;
        }
        private async void FrmFids_Load(object sender, EventArgs e)
        {
            var terminalResult = await terminalService.GetAllAsync(sP);
            if (terminalResult.IsSuccess)
            {
                foreach (var item in terminalResult.Data)
                {
                    var tablePanel = new TableLayoutPanel();
                    tablePanel.AutoSize = true;
                    tablePanel.RowCount = 1;
                    tablePanel.ColumnCount = 2;
                    tablePanel.Dock = DockStyle.Top;

                    var button = new Button();
                    button.Name = "button" + item.Id;
                    button.Text = item.Name;
                    button.Dock = DockStyle.Fill;

                    var combobox = new ComboBox();
                    combobox.Name = "comb"+item.Id;
                    combobox.Font = new Font("B Nazanin", 12);
                    combobox.ForeColor = Color.Black;
                    combobox.BackColor = Color.FromArgb(114, 202, 235);
                    combobox.Dock = DockStyle.Fill;
                    combobox.Text = item.Name;

                    button.Click += button_Click;
                    combobox.SelectedValueChanged += comboBox_SelectedValueChanged;

                    sP.TerminalId = item.Id;
                    var gateResult = await gateService.GetAllAsync(sP);
                    if (gateResult.IsSuccess)
                    {
                        foreach (var gateItem in gateResult.Data)
                        {
                            combobox.Items.Add(gateItem.GateNumber);
                        }
                    }
                    tablePanel.Controls.Add(button, 0, 0);
                    tablePanel.Controls.Add(combobox, 1, 0);

                    this.pnlTerminals.Controls.Add(tablePanel);
                }
            }
            sP.TerminalId = 0;
            sP.GateId = 0;
            await dvgData.SetDataSourceAsync<Flight, FlightService, FlightDto>(sP);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox clickedComboBox = sender as ComboBox;
            if (clickedComboBox != null)
            {
                var gateResult = await gateService.GetByGateNumberAsync(clickedComboBox.SelectedItem.ToString());
                if (gateResult.IsSuccess)
                {
                    sP.TerminalId = 0;
                    sP.GateId = gateResult.Data.Id;
                    await dvgData.SetDataSourceAsync<Flight, FlightService, FlightDto>(sP);
                }
            }
        }

        private async void button_Click(object sender, EventArgs e)
        {
            Button clickedbutton = sender as Button;
            if (clickedbutton != null)
            {
                var terminalResult = await terminalService.GetByNameAsync(clickedbutton.Text);
                if (terminalResult.IsSuccess)
                {
                    sP.GateId = 0;
                    sP.TerminalId = terminalResult.Data.Id;

                    await dvgData.SetDataSourceAsync<Flight, FlightService, FlightDto>(sP);
                }
            }
        }
    }
}
