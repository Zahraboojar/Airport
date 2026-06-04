using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageAitportApp.DAL;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class LogService : BaseGetMethods<Log, LogRepo, LogDto>, IAddService<Log, LogDto>
    {
        static private LogRepo repo = new LogRepo();
        public LogService() : base(repo)
        {
        }
        public async Task<OperationResult> AddAsync(LogDto data)
        {
            var newLog = new Log
            {
                Action = EnumExtensions.GetLogAction(data.Action),
                TableName = data.TableName,
                Description = data.Description,
                AirportId = LoginedUserService.Employee?.AirportId == null ? (int?)null : (int)LoginedUserService.Employee.AirportId,
                CreatedById = (LoginedUserService.EmployeeId > 0) ? LoginedUserService.EmployeeId : (int?)null
            };
            return await _repo.AddAsync(newLog);
        }
        public async Task<OperationResult> DeleteLastMounthAsync()
        {
            DateTime thirtyDaysAgo = DateTime.Now.AddDays(-30);
            return await _repo.DeleteLastMounthAsync(thirtyDaysAgo);
        }

        protected override LogDto MapEntityToDto(Log entity)
        {
            return new LogDto
            {
                Action = EnumExtensions.GetLogAction(entity.Action),
                TableName = entity.TableName,
                Description = entity.Description,
                AirportId = entity.AirportId ?? 0,
                Id = entity.Id,
                DeletedBy = entity.DeletedBy,
                CreatedAt = entity.CreatedAt,
                CreationBy = entity.CreatedBy,
                CreationByNam = $"{entity.CreatedBy?.FirstName} {entity.CreatedBy?.LastName}",
            };
        }
    }
}
