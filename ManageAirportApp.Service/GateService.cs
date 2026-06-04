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
    public class GateService : BaseService<Gate, GateRepo, GateDto>, ICrudService<Gate, GateDto>
    {
        static private GateRepo repo = new GateRepo();
        public GateService() : base(repo)
        {
        }

        public async Task<OperationResult> AddAsync(GateDto entity)
        {
            entity.GateNumber = await GenerateUniqueItem.GenerateGateNumber(entity.TerminalId, entity.Capacity);
            var gate = new Gate()
            {
                GateNumber = entity.GateNumber,
                Capacity = entity.Capacity,
                TerminalId = entity.TerminalId,
                Terminal = null,
                CreatedById = LoginedUserService.EmployeeId
            };
            var result = await _repo.AddAsync(gate);
            if (result.IsSuccess)
            {
                await SetLogs.SetGate(Actions.Add, $" گیت به ترمینال {entity.Terminal.Name} اضافه شد");
            }
            return result;
        }

        public async Task<OperationResult<Gate>> GetByGateNumberAsync(string gateNumber)
        {
            return await _repo.GetByGateNumberAsync(gateNumber);
        }

        public async Task<OperationResult<Gate>> GetLastAsync(SelectProperties sp)
        {
            return await _repo.GetLastAsync(sp);
        }
        public async Task<OperationResult> UpdateAsync(GateDto entity, int id)
        {
            var gateResult = await GetByIdAsync(id);
            if (gateResult.IsSuccess)
            {

                var existingGate = gateResult.Data;

                existingGate.Capacity = entity.Capacity;
                existingGate.TerminalId = entity.TerminalId;
                existingGate.UpdatedById = LoginedUserService.EmployeeId;
                existingGate.UpdatedAt = DateTime.Now;

                var result = await _repo.UpdateAsync(existingGate);
                if (result.IsSuccess)
                {
                    await SetLogs.SetGate(Actions.Update, $"گیت {entity.GateNumber} ویرایش شد");
                }
                return result;
            }
            else
            {
                return OperationResult.Failed(Messages.NotFound);
            }
        }

        protected override GateDto MapEntityToDto(Gate entity)
        {
            return new GateDto
            {
                GateNumber = entity.GateNumber,
                Capacity = entity.Capacity,
                TerminalId = entity.TerminalId,
                Terminal = entity.Terminal,
                TerminalName = entity.Terminal?.Name,
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
