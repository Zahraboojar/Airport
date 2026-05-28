using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class TicketValidaton : BaseValidation
    {
        public static async Task<OperationResult> IsValidSeatNumber(int seatNumber, Flight flight)
        {
            if (flight == null) return OperationResult.Failed(PersionDictionary.Flight + " " + Messages.NotFound);
            if (seatNumber >= 1 && seatNumber <= flight.Aircraft.Capacity)
            {
                var sp = new SelectProperties{
                    AirportId = LoginedUserService.Employee.AirportId == null ? 0 : (int)LoginedUserService.Employee.AirportId
                };
                var service = ServiceFactory<TicketService>.Instance;
                var result = await service.GetByFlightAsync(sp, flight.Id, seatNumber);
                if (result.IsSuccess) return OperationResult.Success();
                else return OperationResult.Failed(Messages.IsSetSeatNumber);
            }

            return OperationResult.Failed(Messages.SeatNumberOutOfRange);
        }
    }
}
