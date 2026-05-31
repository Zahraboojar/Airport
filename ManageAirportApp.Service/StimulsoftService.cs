using ManageAirportApp.Domain;
using Stimulsoft.Report;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class StimulsoftService
    {
        public void Show(StiReport report)
        {
            report.Render(false);
            report.Show();
        }

        private void CopyCrack()
        {
            var baseDir = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);

            var stimulsoftDir = Path.Combine(baseDir, "Stimulsoft");

            if (!Directory.Exists(stimulsoftDir))
            {
                Directory.CreateDirectory(stimulsoftDir);
            }

            var srcAccount = Path.Combine("Reports", "Crack", "account.dat");
            var destAccount = Path.Combine(stimulsoftDir, "account.dat");

            if (File.Exists(srcAccount))
            {
                File.Copy(srcAccount, destAccount, true);
            }

            var srcLicense = Path.Combine("Reports", "Crack", "license.key");
            var destLicense = Path.Combine(stimulsoftDir, "license.key");

            if (File.Exists(srcLicense))
            {
                File.Copy(srcLicense, destLicense, true);
            }
        }

        public async Task ShowTicket(int ticketId)
        {
            try
            {
                var service = ServiceFactory<TicketService>.Instance;

                var result = await service.GetByIdAsync(ticketId);

                if (!result.IsSuccess || result.Data == null)
                {
                    return;
                }

                CopyCrack();

                var report = new StiReport();

                var reportPath = Path.Combine("Reports", "Ticket.mrt");

                if (!File.Exists(reportPath))
                {
                    throw new FileNotFoundException(
                        $"فایل گزارش پیدا نشد : {reportPath}");
                }

                report.Load(reportPath);

                var ticket = result.Data;
                var flight = ticket.Flight;
                report.Dictionary.Variables["VarFullName"].Value =
                 $"{ticket.Passenger.FirstName} {ticket.Passenger.LastName}";

                report.Dictionary.Variables["VarAircraft"].Value =
                    flight.Aircraft.RegistrationNumber;

                report.Dictionary.Variables["VarAircraftModel"].Value =
                    flight.Aircraft.Model;

                report.Dictionary.Variables["VarArrivalAirport"].Value =
                    $"{flight.ArrivalAirport.Region} / {flight.ArrivalAirport.City}";

                report.Dictionary.Variables["VarDepartureAirport"].Value =
                    $"{flight.DepartureAirport.Region} / {flight.DepartureAirport.City}";

                report.Dictionary.Variables["VarTerminalGate"].Value =
                    $"{flight.Gate.Terminal.Name} / {flight.Gate.GateNumber}";

                report.Dictionary.Variables["VarArrivalTime"].Value =
                    flight.ScheduledArrivalTime.ToString("yyyy/MM/dd HH:mm");

                report.Dictionary.Variables["VarClass"].Value =
                    EnumExtensions.GetFlightClass(ticket.Class);

                report.Dictionary.Variables["VarType"].Value =
                    EnumExtensions.GetTicketType(ticket.TicketType);

                report.Dictionary.Variables["VarSeatNumber"].Value =
                    ticket.SeatNumber.ToString();

                report.Dictionary.Variables["VarTicketNumber"].Value =
                    ticket.TicketNumber;

                report.Dictionary.Variables["VarQRCode"].Value =
                    ticket.TicketNumber;

                Show(report);
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}