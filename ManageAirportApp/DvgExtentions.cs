using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Service;
using ManageAirportApp.Share;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageAirportApp
{
    public static class DvgExtentions
    {
        public static void BuildColumns<TEntity, TDto>(this DataGridView dvg, SelectProperties sp)
        {
            var dtoProperties = typeof(TDto).GetProperties();
            var entityProperties = typeof(TEntity).GetProperties();
            dvg.Columns.Clear();
            
            foreach (var property in dtoProperties)
            {
                var attributes = property.GetCustomAttributes<DvgDisplayNameAttribute>(true).FirstOrDefault();
                dvg.Columns.Add(new DataGridViewTextBoxColumn
                 {
                     DataPropertyName = property.Name,
                     HeaderText = attributes != null ? attributes.DisplayName: property.Name,
                    Name = property.Name,
                 });
                dvg.Columns[property.Name].Visible = attributes != null;
                
            }
            if (typeof(TEntity) == typeof(Log))
            {
                dvg.Columns["IsDeleted"].Visible = false;
                dvg.Columns["DeletedByName"].Visible = false;
                dvg.Columns["DeletedAt"].Visible = false;
            }

            if (LoginedUserService.Employee != null &&
                (LoginedUserService.Employee.EmployeeType == EmployeeType.Management
                || LoginedUserService.Employee.EmployeeType == EmployeeType.AirTrafficController)
                )
            {
                if (typeof(TEntity) == typeof(Terminal))
                {
                    dvg.Columns.Add(new DataGridViewButtonColumn
                    {
                        Name = "btnGates",
                        HeaderText = "نمایش گیت ها",
                        Text = "گیت ها",
                        UseColumnTextForButtonValue = true
                    });
                }
                if (typeof(TEntity) != typeof(Log))
                {
                    dvg.Columns.Add(new DataGridViewButtonColumn
                    {
                        Name = "btnUpdate",
                        HeaderText = "عملیات ویرایش",
                        Text = "ویرایش",
                        UseColumnTextForButtonValue = true
                    });
                    dvg.Columns.Add(new DataGridViewButtonColumn
                    {
                        Name = "btnDelete",
                        HeaderText = "عملیات حذف",
                        Text = "حذف",
                        UseColumnTextForButtonValue = true
                    });
                }

                if (sp.IsDeleted)
                {
                    dvg.Columns["btnDelete"].Visible = false;
                }

                if (sp.IsDeleted)
                {
                    dvg.Columns.Add(new DataGridViewButtonColumn
                    {
                        Name = "btnRestore",
                        HeaderText = "عملیات بازگردانی",
                        Text = "بازگردانی",
                        UseColumnTextForButtonValue = true
                    });
                }

                if (typeof(TEntity) == typeof(Flight))
                {
                    dvg.Columns.Add(new DataGridViewButtonColumn
                    {
                        Name = "btnEmployees",
                        HeaderText = "لیست کارکنان",
                        Text = "لیست کارکنان",
                        UseColumnTextForButtonValue = true
                    });
                }
                if (typeof(TEntity) == typeof(Ticket))
                {
                    dvg.Columns.Add(new DataGridViewButtonColumn
                    {
                        Name = "btnPrint",
                        HeaderText = "چاپ",
                        Text = "چاپ",
                        UseColumnTextForButtonValue = true
                    });
                }
            }
        }
        public static void Empty(this DataGridView dvg)
        {
            dvg.DataSource = null;
        }

        public static async Task<string> SetDataSourceAsync<TEntity, TService, TDto>(this DataGridView dvg, SelectProperties sp)
            where TService : class, IReadService<TEntity, TDto>, new()
        {
            var txt = SetPaginationText(sp.Limit, sp.Offset,0);
            try
            {
                var service = ServiceFactory<TService>.Instance;
                var operationResult = await service.GetAllAsync(sp);
                var countAll = await service.GetCountAllAsync();

                if (operationResult.IsSuccess)
                {
                    FillDvg<TEntity, TDto>(dvg, operationResult, sp);
                    txt = SetPaginationText(sp.Limit, sp.Offset, countAll.Data);
                }
                else
                {
                    CustomMessageBox.Error(operationResult.Message);
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Error($"خطای غیرمنتظره: {ex.Message}", "خطا");
                dvg.Empty();
            }
            return txt;
        }

        public static void FillDvg<TEntity, TDto>(this DataGridView dvg, OperationResult<List<TDto>> serviceData, SelectProperties sp, string tableName = "")
        {
            tableName = nameof(TEntity);
            if (serviceData.IsSuccess && serviceData.Data != null)
            {
                dvg.DataSource = serviceData.Data;
                DvgExtentions.BuildColumns<TEntity, TDto>(dvg, sp);
            }
            else
            {
                if (tableName.Length > 0)
                {
                    CustomMessageBox.Error($"{Messages.NotFoundTableData}{tableName}");
                }
                else
                {
                    CustomMessageBox.Error(Messages.NotFound);
                }
                dvg.Empty();
            }
        }
        private static string SetPaginationText(int limit, int offset, int count)
        {
            if (count <= 0)
            {
                return "1/1";
            }
            int allPages = 1;
            if (count != 0)
            {
                allPages = (int)Math.Ceiling((double)count / limit);
            }
            int currentPageNumber = 1;
            if (offset != 0)
            {
                currentPageNumber = (offset / limit) + 1;
            }

            currentPageNumber = Math.Max(1, currentPageNumber);
            currentPageNumber = Math.Min(allPages, currentPageNumber);

            return $"{currentPageNumber}/{allPages}";
        }

        public static DashboardType GetDashboardType(string btnName, out DashboardType _current)
        {
            switch (btnName)
            {
                case "dBtnFlights" : return _current = DashboardType.Flights;
                case "dBtnTickets": return _current = DashboardType.Tickets;
                case "dBtnPassengers": return _current = DashboardType.Passengers;
                case "dBtnEmployees": return _current = DashboardType.Employees;
                case "dBtnAirports": return _current = DashboardType.Airports;
                case "dBtnAircrafts": return _current = DashboardType.Aircrafts;
                case "dBtnTerminals": return _current = DashboardType.Terminal;
                case "dBtnBaggages": return _current = DashboardType.Baggages;
                case "dBtnAirTraffic": return _current = DashboardType.AirTraffic;
                default : return _current = DashboardType.Flights;

            }
        }

        public static async Task<OperationResult> DeleteEntityAsync<TService>(int id, bool isDeleted)
              where TService : class, IDeleteAndRestoreService, new()
        {
            var service = ServiceFactory<TService>.Instance;
            var result = await service.DeleteByIdAsync(id, isDeleted);

            return result;
        }

        public static async Task<OperationResult> RestoreEntityAsync<TService>(int id)
              where TService : class, IDeleteAndRestoreService, new()
        {
            var service = ServiceFactory<TService>.Instance;
            var result = await service.RestoreByIdAsync(id);

            return result;
        }

        public static async Task DvgBtnAction(DashboardType _current, object data, Actions action = Actions.Update)
        {
            var _sp = new SelectProperties();
            switch (_current)
            {
                case DashboardType.Flights:
                    if (!(data is FlightDto flight)) return;
                    if (action == Actions.Update)
                        new FrmEditFlight(flight).ShowDialog();
                    else if (action == Actions.Delete)
                    {
                        var result = await DvgExtentions.DeleteEntityAsync<FlightService>(flight.Id, _sp.IsDeleted);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    else if (action == Actions.Restore)
                    {
                        var result = await DvgExtentions.RestoreEntityAsync<FlightService>(flight.Id);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    else if (action == Actions.AddEmployee)
                    {
                        var frmCrewAssignment = new FrmCrewAssignments(flight);
                        frmCrewAssignment.ShowDialog();
                    }
                    break;

                case DashboardType.Tickets:

                    TicketDto ticket = data as TicketDto;
                    if (action == Actions.Update)
                        new FrmEditTicket(ticket).ShowDialog();
                    else if (action == Actions.Delete)
                    {
                        var result = await DvgExtentions.DeleteEntityAsync<TicketService>(ticket.Id, _sp.IsDeleted);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    else if (action == Actions.Restore)
                    {
                        var result = await DvgExtentions.RestoreEntityAsync<TicketService>(ticket.Id);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    break;

                case DashboardType.Passengers:

                    PassengerDto passenger = data as PassengerDto;
                    if (action == Actions.Update)
                        new FrmEditPassenger(passenger).ShowDialog();
                    else if (action == Actions.Delete)
                    {
                        var result = await DvgExtentions.DeleteEntityAsync<PassengerService>(passenger.Id, _sp.IsDeleted);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    else if (action == Actions.Restore)
                    {
                        var result = await DvgExtentions.RestoreEntityAsync<PassengerService>(passenger.Id);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    break;

                case DashboardType.Employees:

                    EmployeeDto employee = data as EmployeeDto;
                    if (action == Actions.Update)
                        new FrmEditEmployee(employee).ShowDialog();
                    else if (action == Actions.Delete)
                    {
                        var result = await DvgExtentions.DeleteEntityAsync<EmployeeService>(employee.Id, _sp.IsDeleted);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    else if (action == Actions.Restore)
                    {
                        var result = await DvgExtentions.RestoreEntityAsync<EmployeeService>(employee.Id);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    break;

                case DashboardType.Airports:

                    AirportDto airport = data as AirportDto;
                    if (action == Actions.Update)
                        new FrmEditAirport(airport).ShowDialog();
                    else if (action == Actions.Delete)
                    {
                        if (_sp.AirportId != airport.Id)
                        {
                            var result = await DvgExtentions.DeleteEntityAsync<AirportService>(airport.Id, _sp.IsDeleted);
                            CustomMessageBox.Message(result.Message, result.IsSuccess);
                        }
                        else
                        {
                            CustomMessageBox.Error(Messages.CantDeleteAirport);
                        }
                    }
                    else if (action == Actions.Restore)
                    {
                        var result = await DvgExtentions.RestoreEntityAsync<AirportService>(airport.Id);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    break;

                case DashboardType.Aircrafts:

                    AircraftDto aircraft = data as AircraftDto;
                    if (action == Actions.Update)
                        new FrmEditAircraft(aircraft).ShowDialog();
                    else if (action == Actions.Delete)
                    {
                        var result = await DvgExtentions.DeleteEntityAsync<AircraftService>(aircraft.Id, _sp.IsDeleted);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    else if (action == Actions.Restore)
                    {
                        var result = await DvgExtentions.RestoreEntityAsync<AircraftService>(aircraft.Id);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    break;

                case DashboardType.AirTraffic:

                    AirTrafficDto airTraffic = data as AirTrafficDto;
                    if (action == Actions.Delete)
                    {
                        var result = await DvgExtentions.DeleteEntityAsync<AirTrafficService>(airTraffic.Id, _sp.IsDeleted);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    else if (action == Actions.Restore)
                    {
                        var result = await DvgExtentions.RestoreEntityAsync<AirTrafficService>(airTraffic.Id);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    break;

                case DashboardType.Terminal:

                    TerminalDto terminal = data as TerminalDto;
                    if (action == Actions.Update)
                        new FrmEditTerminal(terminal).ShowDialog();
                    else if (action == Actions.Delete)
                    {
                        var result = await DvgExtentions.DeleteEntityAsync<TerminalService>(terminal.Id, _sp.IsDeleted);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    else if (action == Actions.Restore)
                    {
                        var result = await DvgExtentions.RestoreEntityAsync<TerminalService>(terminal.Id);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    break;

                case DashboardType.Baggages:

                    BaggageDto baggage = data as BaggageDto;
                    if (action == Actions.Update)
                        new FrmEditBaggage(baggage).ShowDialog();
                    else if (action == Actions.Delete)
                    {
                        var result = await DvgExtentions.DeleteEntityAsync<BaggageService>(baggage.Id, _sp.IsDeleted);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    else if (action == Actions.Restore)
                    {
                        var validateWeight = await BaggageValidation.IsValidWeight(baggage.Weight, baggage.Ticket.Class, baggage.Ticket);
                        if (validateWeight.IsSuccess)
                        {
                            var result = await DvgExtentions.RestoreEntityAsync<BaggageService>(baggage.Id);
                            CustomMessageBox.Message(result.Message, result.IsSuccess);
                        } else
                        {
                            CustomMessageBox.Error(validateWeight.Message);
                        }
                    }
                    break;
                case DashboardType.Gate:

                    GateDto gate = data as GateDto;
                    if (action == Actions.Update)
                        new FrmEditGate(gate).ShowDialog();
                    else if (action == Actions.Delete)
                    {
                        var result = await DvgExtentions.DeleteEntityAsync<GateService>(gate.Id, _sp.IsDeleted);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    else if (action == Actions.Restore)
                    {
                        var result = await DvgExtentions.RestoreEntityAsync<GateService>(gate.Id);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    break;

                case DashboardType.CrewAssignments:

                    if (!(data is object[] info)) return;
                    
                    CrewAssignmentDto crewAssignmentData = info[0] as CrewAssignmentDto;
                    FlightDto flightData = info[1] as FlightDto;

                    if (action == Actions.Delete)
                    {
                        var result = await DvgExtentions.DeleteEntityAsync<CrewAssignmentService>(crewAssignmentData.Id, _sp.IsDeleted);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    else if (action == Actions.Restore)
                    {
                        var result = await DvgExtentions.RestoreEntityAsync<CrewAssignmentService>(crewAssignmentData.Id);
                        CustomMessageBox.Message(result.Message, result.IsSuccess);
                    }
                    break;
            }
        }
    }
}
