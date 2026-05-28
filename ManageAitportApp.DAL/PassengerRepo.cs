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
    public class PassengerRepo : BaseRepo<Passenger>
    {
        public override async Task<OperationResult<List<Passenger>>> GetAllAsync(SelectProperties selectProperties)
        {
            string txt = selectProperties.SearchText;
            if (txt == "")
            {
                return await base.GetAllAsync(selectProperties);
            }
            List<Passenger> all = await set
                .Where(x => x.IsDeleted == selectProperties.IsDeleted && ( x.LastName.Contains(txt) ||
                x.FirstName.Contains(txt) || x.Email.Contains(txt) || x.PassportNumber.Contains(txt) ||
                x.NationalCode.Contains(txt) || x.PhoneNumber.Contains(txt) || x.Nationality.Contains(txt)))
                .OrderBy(x => x.Id)
                .Skip(selectProperties.Offset)
                .Take(selectProperties.Limit)
                .ToListAsync();
            return OperationResult<List<Passenger>>.Success(all);
        }

        public async Task<OperationResult<Passenger>> GetByNationalCode(string nationalCode)
        {
            var passenger = await set
                                .Where(x => x.NationalCode == nationalCode)
                                .FirstOrDefaultAsync();

            if (passenger == null)
                return OperationResult<Passenger>.Failed(Messages.NotFound);

            return OperationResult<Passenger>.Success(passenger);
        }
    }
}
