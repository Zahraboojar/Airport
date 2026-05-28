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
    public class TerminalRepo : BaseRepo<Terminal>
    {
        public async override Task<OperationResult<List<Terminal>>> GetAllAsync(SelectProperties selectProperties)
        {
            var txt = selectProperties.SearchText;
            var id = selectProperties.AirportId;
            if (id != 0)
            {
                var all = set
                    .Where(x => x.IsDeleted == selectProperties.IsDeleted &&
                    x.AirportId == selectProperties.AirportId)
                    .OrderBy(x => x.Id)
                    .Skip(selectProperties.Offset)
                    .Take(selectProperties.Limit);
                if (txt != "")
                {
                    all = all
                        .Where(x => x.Name.Contains(selectProperties.SearchText));
                }
                var listOfAll = await all.ToListAsync();

                return OperationResult<List<Terminal>>.Success(listOfAll);
            }
            return await base.GetAllAsync(selectProperties);
        }

        public async Task<OperationResult<Terminal>> GetByNameAsync(string name)
        {
            var result = await set
                .Where(x => x.Name == name)
                .FirstOrDefaultAsync();
            if (result == null)
                return OperationResult<Terminal>.Failed(Messages.NotFound);
            return OperationResult<Terminal>.Success(result);
        }
    }
}
