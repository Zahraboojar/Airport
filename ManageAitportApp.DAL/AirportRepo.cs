using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageAitportApp.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ManageAirportApp.DAL
{
    public class AirportRepo : BaseRepo<Airport>
    {
        public override async Task<OperationResult<List<Airport>>> GetAllAsync(SelectProperties selectProperties)
        {
            var txt = selectProperties.SearchText;
            if (txt == "")
            {
                return await base.GetAllAsync(selectProperties);
            }
            List<Airport> all = await set
                .Where(x => x.IsDeleted == selectProperties.IsDeleted && (x.Name.Contains(txt)
                || x.IATA_Code.Contains(txt) || x.City.Contains(txt) ||
                x.Region.Contains(txt) || x.ICAO_Code.Contains(txt)))
                .OrderBy(x => x.Id)
                .Skip(selectProperties.Offset)
                .Take(selectProperties.Limit)
                .ToListAsync();
            return OperationResult<List<Airport>>.Success(all);
        }

        public async Task<OperationResult<Airport>> GetByNameAsync(string name)
        {
            var result = await set
                .Where(x => x.Name == name)
                .FirstOrDefaultAsync();
            if (result == null)
                return OperationResult<Airport>.Failed(Messages.NotFound);
            return OperationResult<Airport>.Success(result);
        }
    }
}
