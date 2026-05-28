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
using static System.Net.Mime.MediaTypeNames;

namespace ManageAitportApp.DAL
{
    public class LogRepo : BaseRepo<Log>
    {
        public async Task<OperationResult> DeleteLastMounthAsync(DateTime thirtyDaysAgo)
        {
            var logs = await airportDB.Logs
            .Where(x => x.CreatedAt < thirtyDaysAgo)
            .ToListAsync();

            airportDB.Logs.RemoveRange(logs);

            await airportDB.SaveChangesAsync();

            return OperationResult.Success();
        }
        public override async Task<OperationResult<List<Log>>> GetAllAsync(SelectProperties selectProperties)
        {
            int id = selectProperties.AirportId;
            if (id != 0)
            {
                List<Log> all = await set
                    .Where(x => x.IsDeleted == selectProperties.IsDeleted && x.AirportId == id)
                    .OrderBy(x => x.Id)
                    .Skip(selectProperties.Offset)
                    .Take(selectProperties.Limit)
                    .ToListAsync();
                return OperationResult<List<Log>>.Success(all);
            }
            return await base.GetAllAsync(selectProperties);
        }

    }
}
