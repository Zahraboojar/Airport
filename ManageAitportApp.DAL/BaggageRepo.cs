using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAitportApp.DAL
{
    public class BaggageRepo : BaseRepo<Baggage>
    {
        public override async Task<OperationResult<List<Baggage>>> GetAllAsync(SelectProperties selectProperties)
        {
            string txt = selectProperties.SearchText;
            int id = selectProperties.AirportId;
            if (id != 0)
            {
                var all = set
                        .Where(x => x.IsDeleted == selectProperties.IsDeleted && (x.Ticket.Flight.ArrivalAirportId == id ||
                        x.Ticket.Flight.DepartureAirportId == id))
                        .OrderBy(x => x.Id)
                        .Skip(selectProperties.Offset)
                        .Take(selectProperties.Limit);
                if (txt != "")
                {
                    all = all.Where(x => x.TagNumber.Contains(txt) || x.Ticket.TicketNumber.Contains(txt));
                }
                var listOfAll = await all.ToListAsync();
                return OperationResult<List<Baggage>>.Success(listOfAll);
            }

            return await base.GetAllAsync(selectProperties);
        }
    }
}
