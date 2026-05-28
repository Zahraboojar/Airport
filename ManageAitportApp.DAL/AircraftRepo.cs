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
    public class AircraftRepo : BaseRepo<Aircraft>
    {
        public override async Task<OperationResult<List<Aircraft>>> GetAllAsync(SelectProperties selectProperties)
        {
            string txt = selectProperties.SearchText;
            if (txt == "")
            {
                return await base.GetAllAsync(selectProperties);
            }
            List<Aircraft> all = await set
                .Where(x => x.IsDeleted == selectProperties.IsDeleted && ( x.ManufacturerName.Contains(txt)
                || x.Model.Contains(txt) || x.RegistrationNumber.Contains(txt)))
                .OrderBy(x => x.Id)
                .Skip(selectProperties.Offset)
                .Take(selectProperties.Limit)
                .ToListAsync();
            return OperationResult<List<Aircraft>>.Success(all);
        }

        public async Task<OperationResult<Aircraft>> GetByRegistrationNumberAsync(string registrationNumber)
        {
            var result = await set
                .Where(x => x.RegistrationNumber == registrationNumber)
                .FirstOrDefaultAsync();
            if (result == null)
                return OperationResult<Aircraft>.Failed(Messages.NotFound);
            return OperationResult<Aircraft>.Success(result);
        }
    }
}
