using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageAitportApp.DAL;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class TerminalService : BaseService<Terminal, TerminalRepo, TerminalDto>, ICrudService<Terminal, TerminalDto>
    {
        static private TerminalRepo repo = new TerminalRepo();
        public TerminalService() : base(repo)
        {
        }

        public async Task<OperationResult> AddAsync(TerminalDto entity)
        {
            var terminal = new Terminal
            {
                AirportId = LoginedUserService.Employee.AirportId == null ? 0 : (int)LoginedUserService.Employee.AirportId,
                Name = entity.Name,
                CreatedById = LoginedUserService.EmployeeId
            };
            var result = await _repo.AddAsync(terminal);
            if (result.IsSuccess)
            {
                await SetLogs.SetTerminal(Actions.Add, "یک ترمینال اضافه شد");
            }
            return result;
        }

        public async Task<OperationResult<Terminal>> GetByNameAsync(string name)
        {
            return await _repo.GetByNameAsync(name);
        }

        public async Task<OperationResult> UpdateAsync(TerminalDto entity, int id)
        {
            var terminalResult = await GetByIdAsync(id);
            if (terminalResult.IsSuccess)
            {

                var existingterminal = terminalResult.Data;

                existingterminal.Name = entity.Name;
                existingterminal.UpdatedAt = DateTime.Now;
                existingterminal.UpdatedById = LoginedUserService.EmployeeId;

                var result = await _repo.UpdateAsync(existingterminal);
                if (result.IsSuccess)
                {
                    await SetLogs.SetTerminal(Actions.Update, $"ترمینال {entity.Name} ویرایش شد");
                }
                return result;
            }
            return OperationResult.Failed(Messages.NotFoundEntity);
        }
        protected override TerminalDto MapEntityToDto(Terminal entity)
        {
            return new TerminalDto
            {
                Name = entity.Name,
                Id = entity.Id,
                DeletedBy = entity.DeletedBy,
                CreatedAt = entity.CreatedAt,
                CreationBy = entity.CreatedBy,
                DeletedAt = entity.DeletedAt,
                CreationByNam = $"{entity.CreatedBy?.FirstName} {entity.CreatedBy?.LastName}",
                DeletedById = entity.DeletedById,
                DeletedByName = $"{entity.DeletedBy?.FirstName} {entity.DeletedBy?.LastName}",
                IsDeleted = entity.IsDeleted,
                UpdatedAt = entity.UpdatedAt,
                UpdatedBy = entity.UpdatedBy,
                UpdatedById = entity.UpdatedById,
                UpdatedByName = $"{entity.UpdatedBy?.FirstName} {entity.UpdatedBy?.LastName}",
            };
        }
    }
}
