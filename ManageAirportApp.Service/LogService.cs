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
        protected static LogRepo logRepo;
        public LogService() : base (logRepo)
        {
            logRepo = new LogRepo();
        }
        public async Task<OperationResult> AddAsync(LogDto data)
        {
            var newLog = new Log
            {
                Action = EnumExtensions.GetLogAction(data.Action),
                TableName = data.TableName,
                Description = data.Description,
                AirportId = data.AirportId,
                CreatedById = LoginedUserService.EmployeeId
            };
            return await logRepo.AddAsync(newLog);
        }
        public async Task<OperationResult> DeleteLastMounthAsync()
        {
            DateTime thirtyDaysAgo = DateTime.Now.AddDays(-30);
            return await logRepo.DeleteLastMounthAsync(thirtyDaysAgo);
        }

        protected override LogDto MapEntityToDto(Log entity)
        {
            return new LogDto
            {
                Action = EnumExtensions.GetLogAction(entity.Action),
                TableName = entity.TableName,
                Description = entity.Description,
                AirportId = entity.AirportId,
                Id = entity.Id,
                DeletedBy = entity.DeletedBy,
                CreatedAt = entity.CreatedAt,
                CreationBy = entity.CreatedBy,
                CreationByNam = $"{entity.CreatedBy?.FirstName} {entity.CreatedBy?.LastName}",
            };
        }
    }
}
