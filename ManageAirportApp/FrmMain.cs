 using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Service;
using ManageAirportApp.Share;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageAirportApp
{
    public partial class FrmMain : BaseFrm
    {
        private SelectProperties _sp;
        Form frmAdd;
        private DashboardType _current;

        public FrmMain()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            _sp = new SelectProperties();
            menuControl.ReloadFormRequested += () =>
            {
                btnLeft.BackgroundImage = ThemeManager.LeftIcon;
                btnRight.BackgroundImage = ThemeManager.RightIcon;
            };
        }
        private async void FrmMain_Load(object sender, EventArgs e)
        {
            var airportId = LoginedUserService.Employee.AirportId;
            if (airportId == null)
            {
                _sp.AirportId = 0;
            } else
            {
                _sp.AirportId = (int)airportId;
            }
            DvgExtentions.GetDashboardType(dBtnFlights.Name, out _current);
            await LoadCurrentGrid(_sp);
            frmAdd = new FrmEditFlight();
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            _sp.Offset += _sp.Limit;
            var selectedDBtn = LoadCurrentGrid(_sp);

        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            _sp.Offset -= _sp.Limit;
            var selectedDBtn = LoadCurrentGrid(_sp);

        }
        private async void DashBoardBtn_ClickAsync(object sender, EventArgs e)
        {
            _sp.Offset = 0;
            if (sender is Control btn)
            {
                DvgExtentions.GetDashboardType(btn.Name, out _current);
                await LoadCurrentGrid(_sp);
            }
        }
        private async Task LoadCurrentGrid(SelectProperties sp, int airportId = 0)
        {
            string txt = lblPagination.Text;
            switch (_current)
            {
                case DashboardType.Flights:
                    txt = await mainDvg.SetDataSourceAsync<Flight, FlightService, FlightDto>(sp);
                    frmAdd = new FrmEditFlight();
                    break;

                case DashboardType.Tickets:
                    txt = await mainDvg.SetDataSourceAsync<Ticket, TicketService, TicketDto>(sp);
                    frmAdd = new FrmEditTicket();
                    break;

                case DashboardType.Passengers:
                    txt = await mainDvg.SetDataSourceAsync<Passenger, PassengerService, PassengerDto>(sp);
                    frmAdd = new FrmEditPassenger();
                    break;

                case DashboardType.Employees:
                    txt = await mainDvg.SetDataSourceAsync<Employee, EmployeeService, EmployeeDto>(sp);
                    frmAdd = new FrmEditEmployee();
                    break;

                case DashboardType.Airports:
                    txt = await mainDvg.SetDataSourceAsync<Airport, AirportService, AirportDto>(sp);
                    frmAdd = new FrmEditAirport();
                    break;

                case DashboardType.Aircrafts:
                    txt = await mainDvg.SetDataSourceAsync<Aircraft, AircraftService, AircraftDto>(sp);
                    frmAdd = new FrmEditAircraft();
                    break;

                case DashboardType.AirTraffic:
                    txt = await mainDvg.SetDataSourceAsync<AirTraffic, AirTrafficService, AirTrafficDto>(sp);
                    frmAdd = new FrmEditAirTraffic();
                    mainDvg.Columns["btnUpdate"].Visible = false;
                    break;

                case DashboardType.Terminal:
                    txt = await mainDvg.SetDataSourceAsync<Terminal, TerminalService, TerminalDto>(sp);
                    frmAdd = new FrmEditTerminal();
                    break;

                case DashboardType.Gate:
                    txt = await mainDvg.SetDataSourceAsync<Gate, GateService, GateDto>(sp);
                    frmAdd = new FrmEditGate(sp.TerminalId);
                    break;

                case DashboardType.Baggages:
                    txt = await mainDvg.SetDataSourceAsync<Baggage, BaggageService, BaggageDto>(sp);
                    frmAdd = new FrmEditBaggage();
                    break;
            }
            lblPagination.Text = txt;
            ChangeBtnEnabled();
        }
        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadCurrentGrid(_sp);
            txtSearch.Text = "";
        }

        private async void btnAdd_ClickAsync(object sender, EventArgs e)
        {
            frmAdd.ShowDialog();
            //fill dvg
            await LoadCurrentGrid(_sp);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            _sp.SearchText = txtSearch.Text;
            await LoadCurrentGrid(_sp);
            _sp.SearchText = "";
            if (mainDvg.Rows.Count == 0)
            {
                CustomMessageBox.Warning(Messages.NotFoundRow);
            }
        }

        private async void mainDvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var data = mainDvg.Rows[e.RowIndex].DataBoundItem;

                if (mainDvg.Columns[e.ColumnIndex].Name == "btnUpdate")
                {
                    if (data is EmployeeDto employee && LoginedUserService.EmployeeId == employee.Id)
                    {
                        new FrmProfile().ShowDialog();
                        return;
                    }
                    await DvgExtentions.DvgBtnAction(_current, data, Actions.Update);
                }

                if (mainDvg.Columns[e.ColumnIndex].Name == "btnDelete")
                {
                    if (data is EmployeeDto employee && LoginedUserService.EmployeeId == employee.Id)
                    {
                        CustomMessageBox.Warning(Messages.YouCantDeleteYourSelf);
                        return;
                    }
                    var result = CustomMessageBox.Confirm(Messages.ConfirmDelete, PersionDictionary.Delete);
                    if (result == DialogResult.Yes)
                    {
                        await DvgExtentions.DvgBtnAction(_current, data, Actions.Delete);
                    }
                }

                if (mainDvg.Columns[e.ColumnIndex].Name == "btnRestore")
                {
                    var result = CustomMessageBox.Confirm(Messages.ConfirmRestore, PersionDictionary.Restore);
                    if (result == DialogResult.Yes)
                    {
                        await DvgExtentions.DvgBtnAction(_current, data, Actions.Restore);
                    }
                }
                if (mainDvg.Columns[e.ColumnIndex].Name == "btnEmployees")
                {
                    await DvgExtentions.DvgBtnAction(_current, data, Actions.AddEmployee);
                }
                if (mainDvg.Columns[e.ColumnIndex].Name == "btnPrint")
                {
                    var stim = new StimulsoftService();
                    var ticket = data as TicketDto;
                    if (ticket != null)
                    {
                        await stim.ShowTicket(ticket.Id);
                    }
                }
                if (mainDvg.Columns[e.ColumnIndex].Name == "btnGates")
                {
                    TerminalDto terminal = data as TerminalDto;
                    if (terminal != null)
                    {
                        _sp.TerminalId = terminal.Id;
                        _current = DashboardType.Gate;
                    }
                }

                await LoadCurrentGrid(_sp);
            }
        }

        private async void btnAll_Click(object sender, EventArgs e)
        {
            if (_sp.IsDeleted)
            {
                btnTrash.BackgroundImage = ThemeManager.TrashIcon;
            } else
            {
                btnTrash.BackgroundImage = ThemeManager.OpenTrashIcon;
            }
            btnAdd.Visible = !btnAdd.Visible;
            _sp.IsDeleted = !_sp.IsDeleted;
            await LoadCurrentGrid(_sp);
        }
        private void mainDvg_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, mainDvg.RowHeadersWidth, e.RowBounds.Height);

            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void ChangeBtnEnabled()
        {
            var parts = lblPagination.Text.Split('/');
            int all = 1, pagenumber = 1;

            int.TryParse(parts[0], out pagenumber);
            int.TryParse(parts[1], out all);
            if (all == 1 && pagenumber == 1)
            {
                btnLeft.Enabled = false;
                btnRight.Enabled = false;
            }
            else if (all > pagenumber)
            {
                btnLeft.Enabled = true;
                btnRight.Enabled = true;
                if (pagenumber == 1)
                {
                    btnRight.Enabled = false;
                }
            }
            else if (all == pagenumber)
            {
                btnLeft.Enabled = false;
                if (pagenumber > 1)
                    btnRight.Enabled = true;
            }
        }
    }
}
