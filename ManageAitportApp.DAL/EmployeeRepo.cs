using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageAitportApp.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.DAL
{
    public class EmployeeRepo : BaseRepo<Employee>
    {
        public async Task<OperationResult<Employee>> Login(string username, string password)
        {
            var result = await set
                .Where(x => x.UserName == username && x.Password == password).SingleOrDefaultAsync();

            if (result == null)
            {
                return OperationResult<Employee>.Failed(Messages.InCorrectUserNameOrPassWord);
            }
            return OperationResult<Employee>.Success(result);
        }

        public override async Task<OperationResult<List<Employee>>> GetAllAsync(SelectProperties selectProperties)
        {
            string txt = selectProperties.SearchText;
            int id = selectProperties.AirportId;
            if (id != 0)
            {
                var all = set
                        .Where(x => x.IsDeleted == selectProperties.IsDeleted && x.AirportId == id)
                        .OrderBy(x => x.Id)
                        .Skip(selectProperties.Offset)
                        .Take(selectProperties.Limit);
                if (txt != "")
                {
                    all = all.Where(x => x.LastName.Contains(txt) || x.FirstName.Contains(txt) 
                        || x.PassportNumber.Contains(txt) || x.PhoneNumber.Contains(txt));
                }
                var listOfAll = await all.ToListAsync();
                return OperationResult<List<Employee>>.Success(listOfAll);
            }
            return await base.GetAllAsync(selectProperties);
        }

        public async Task<OperationResult<Employee>> GetByUserNameAsync(string username)
        {
            var result = await set
                .Where(x => x.UserName.Contains(username))
                .SingleOrDefaultAsync();
            if (result == null)
                return OperationResult<Employee>.Failed(Messages.NotFoundEntity);
            return OperationResult<Employee>.Success(result);
        }
    }
}
