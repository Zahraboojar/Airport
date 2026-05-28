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
    public class FlightRepo : BaseRepo<Flight>
    {
        public override async Task<OperationResult<List<Flight>>> GetAllAsync(SelectProperties selectProperties)
        {
            string txt = selectProperties.SearchText;
            int id = selectProperties.AirportId;
            int terminalId = selectProperties.TerminalId;
            int gateId = selectProperties.GateId;

            if (id != 0)
            {
                var all = set
                        .Where(x => x.IsDeleted == selectProperties.IsDeleted && (x.DepartureAirportId == id ||
                        x.ArrivalAirportId == id))
                        .OrderBy(x => x.Id)
                        .Skip(selectProperties.Offset)
                        .Take(selectProperties.Limit);
                if (txt != "")
                {
                    all = all
                        .Where(x => x.FlightNumber.Contains(txt) ||
                        x.Gate.GateNumber.Contains(txt) || x.ArrivalAirport.Name.Contains(txt)
                        || x.DepartureAirport.Name.Contains(txt));
                }
                else if (terminalId != 0)
                {
                    all = all
                        .Where(x => x.Gate.TerminalId == terminalId);
                }
                else if (gateId != 0)
                {
                    all = all
                        .Where(x => x.GateId == gateId);
                }
                var data = await all.ToListAsync();
                return OperationResult<List<Flight>>.Success(data);
            }
            return await base.GetAllAsync(selectProperties);
        }

        public async Task<OperationResult<Flight>> GetByFlightNumber(string flightNumber)
        {
            var result = await set
                .Where(x => x.FlightNumber == flightNumber).SingleOrDefaultAsync();
            if (result == null)
            {
                return OperationResult<Flight>.Failed(Messages.NotFoundEntity);
            }
            return OperationResult<Flight>.Success(result);
        }
    }
}
