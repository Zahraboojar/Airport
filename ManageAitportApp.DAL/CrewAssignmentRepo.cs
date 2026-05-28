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
    public class CrewAssignmentRepo : BaseRepo<CrewAssignment>
    {
        public override async Task<OperationResult<List<CrewAssignment>>> GetAllAsync(SelectProperties selectProperties)
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
                    all = all.Where(x => x.Flight.FlightNumber.Contains(txt) || x.Employee.FirstName.Contains(txt) ||
                        x.Employee.LastName.Contains(txt));
                }
                var listOfAll = await all.ToListAsync();
                return OperationResult<List<CrewAssignment>>.Success(listOfAll);
            }
            return await base.GetAllAsync(selectProperties);
        }
    }
}
