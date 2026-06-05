using ManageAirportApp.Domain;
using Stimulsoft.Report;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class StimulsoftService
    {
        private void CopyCrack()
        {
            var baseDir = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);

            var stimulsoftDir = Path.Combine(baseDir, "Stimulsoft");

            if (!Directory.Exists(stimulsoftDir))
                Directory.CreateDirectory(stimulsoftDir);

            var srcAccount = Path.Combine("Reports", "Crack", "account.dat");
            var destAccount = Path.Combine(stimulsoftDir, "account.dat");

            if (File.Exists(srcAccount))
                File.Copy(srcAccount, destAccount, true);

            var srcLicense = Path.Combine("Reports", "Crack", "license.key");
            var destLicense = Path.Combine(stimulsoftDir, "license.key");

            if (File.Exists(srcLicense))
                File.Copy(srcLicense, destLicense, true);
        }

        public async Task ShowTicket(int ticketId)
        {
            try
            {
                var service = ServiceFactory<TicketService>.Instance;
                var result = await service.GetByIdAsync(ticketId);

                if (!result.IsSuccess || result.Data == null)
                    return;

                CopyCrack();

                var report = new StiReport();
                var reportPath = Path.Combine("Reports", "Ticket.mrt");

                if (!File.Exists(reportPath))
                    throw new FileNotFoundException($"فایل گزارش پیدا نشد : {reportPath}");

                report.Load(reportPath);

                var ticket = result.Data;
                var flight = ticket.Flight;
                var vars = report.Dictionary.Variables;

                if (vars.Contains("VarFullName"))
                    vars["VarFullName"].Value = $"{ticket.Passenger.FirstName} {ticket.Passenger.LastName}";

                if (vars.Contains("VarAircraft"))
                    vars["VarAircraft"].Value = flight.Aircraft.RegistrationNumber;

                if (vars.Contains("VarAircraftModel"))
                    vars["VarAircraftModel"].Value = flight.Aircraft.Model;

                if (vars.Contains("VarArrivalAirport"))
                    vars["VarArrivalAirport"].Value = $"{flight.ArrivalAirport.Region} / {flight.ArrivalAirport.City}";

                if (vars.Contains("VarDepartureAirport"))
                    vars["VarDepartureAirport"].Value = $"{flight.DepartureAirport.Region} / {flight.DepartureAirport.City}";

                if (vars.Contains("VarTerminalGate"))
                    vars["VarTerminalGate"].Value = $"{flight.Gate.Terminal.Name} / {flight.Gate.GateNumber}";

                if (vars.Contains("VarArrivalTime"))
                    vars["VarArrivalTime"].Value = flight.ScheduledArrivalTime.ToString("yyyy/MM/dd HH:mm");

                if (vars.Contains("VarClass"))
                    vars["VarClass"].Value = EnumExtensions.GetFlightClass(ticket.Class);

                if (vars.Contains("VarType"))
                    vars["VarType"].Value = EnumExtensions.GetTicketType(ticket.TicketType);

                if (vars.Contains("VarSeatNumber"))
                    vars["VarSeatNumber"].Value = ticket.SeatNumber.ToString();

                if (vars.Contains("VarTicketNumber"))
                    vars["VarTicketNumber"].Value = ticket.TicketNumber;

                if (vars.Contains("VarQRCode"))
                    vars["VarQRCode"].Value = ticket.TicketNumber;

                report.Render(false);
                report.Show();
            }
            catch (Exception ex)
            {
                // موقتاً برای دیباگ:
            }
        }
    }
}
