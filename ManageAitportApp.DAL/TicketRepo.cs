using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAitportApp.DAL
{
    public class TicketRepo : BaseRepo<Ticket>
    {
        public override async Task<OperationResult<List<Ticket>>> GetAllAsync(SelectProperties selectProperties)
        {
            string txt = selectProperties.SearchText;
            int id = selectProperties.AirportId;
            if (id != 0)
            {
                var all = set
                        .Where(x => x.IsDeleted == selectProperties.IsDeleted && ( x.Flight.ArrivalAirportId == id ||
                        x.Flight.DepartureAirportId == id))
                        .OrderBy(x => x.Id)
                        .Skip(selectProperties.Offset)
                        .Take(selectProperties.Limit);
                if (txt != "")
                {

                    all = all
                        .Where(x => x.SeatNumber.ToString().Contains(txt)
                        || x.TicketNumber.Contains(txt) || x.Price.ToString().Contains(txt));
                }

                var listOfAll = await all.ToListAsync();

                return OperationResult<List<Ticket>>.Success(listOfAll);
            }
            return await base.GetAllAsync(selectProperties);
        }

        public async Task<OperationResult<List<int>>> GetAllByFlightIdAsync(int flightId)
        {
            var data = await set
                .Where(x => x.FlightId == flightId).Select(x => x.SeatNumber).ToListAsync();
            if (data == null)
                return OperationResult<List<int>>.Failed(Messages.NotFound);
            return OperationResult<List<int>>.Success(data);
            
        }

        public async Task<OperationResult<bool>> GetByFlightAsync(SelectProperties sp,int flightId, int seatNumber)
        {
            var result = await GetAllAsync(sp);
            if (result.IsSuccess)
            {
                var count = result.Data.Where(x => x.FlightId == flightId && x.SeatNumber == seatNumber).Count();
                if (count == 0)
                {
                    return OperationResult<bool>.Success(true);
                }
            }
            return OperationResult<bool>.Failed(Messages.IsSetSeatNumber);
        }

        public async Task<OperationResult<Ticket>> GetByTicketNumberAsync(string ticketNumber)
        {
            var result = await set
                .Where(x => x.TicketNumber == ticketNumber).SingleOrDefaultAsync();
            if (result == null)
            {
                return OperationResult<Ticket>.Failed(Messages.NotFoundEntity);
            }
            return OperationResult<Ticket>.Success(result);
        }
    }
}
