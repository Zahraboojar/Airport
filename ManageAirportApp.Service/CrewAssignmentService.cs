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
    public class CrewAssignmentService : BaseService<CrewAssignment, CrewAssignmentRepo, CrewAssignmentDto>, ICrudService<CrewAssignment, CrewAssignmentDto>
    {
        static private CrewAssignmentRepo repo = new CrewAssignmentRepo();
        public CrewAssignmentService() : base(repo)
        {
        }

        public async Task<OperationResult> AddAsync(CrewAssignmentDto entity)
        {
            var crewAssignment = new CrewAssignment()
            {
                Role = EnumExtensions.GetEmployeeRole(entity.Role),
                FlightId = entity.FlightId,
                EmployeeId = entity.EmployeeId,
                CreatedById = LoginedUserService.EmployeeId
            };
            var result = await _repo.AddAsync(crewAssignment);
            if (result.IsSuccess)
            {
                await SetLogs.SetCrewAssignment(Actions.Add,
                    $"کارمند {entity.EmployeeFullName} در پرواز {entity.FlightNumber} به {entity.Role} اختصاص داده شد");
            }
            return result;
        }

        public async Task<OperationResult> UpdateAsync(CrewAssignmentDto entity, int id)
        {
            var crewAssignmentResult = await GetByIdAsync(id);
            if (crewAssignmentResult.IsSuccess)
            {

                var existingCrewAssignment = crewAssignmentResult.Data;

                existingCrewAssignment.Role = EnumExtensions.GetEmployeeRole(entity.Role);
                existingCrewAssignment.EmployeeId = entity.EmployeeId;
                existingCrewAssignment.FlightId = entity.FlightId;
                existingCrewAssignment.UpdatedById = LoginedUserService.EmployeeId;
                existingCrewAssignment.UpdatedAt = DateTime.Now;

                var result = await _repo.UpdateAsync(existingCrewAssignment);
                if (result.IsSuccess)
                {
                    await SetLogs.SetCrewAssignment(Actions.Update,
                        $"کارمند {entity.EmployeeFullName} در پرواز {entity.FlightNumber} سمت به {entity.Role}  ویرایش شد");
                }
                return result;
            }
            else
            {
                return OperationResult.Failed(Messages.NotFound);
            }
        }

        protected override CrewAssignmentDto MapEntityToDto(CrewAssignment entity)
        {
            return new CrewAssignmentDto
            {
                Role = EnumExtensions.GetEmployeeRole(entity.Role),
                FlightId = entity.FlightId,
                EmployeeId = entity.EmployeeId,
                EmployeeFullName = $"{entity.Employee?.FirstName} {entity.Employee?.LastName}({entity.Employee?.NationalCode})",
                Employee = entity.Employee,
                Flight = entity.Flight,
                FlightNumber = entity.Flight?.FlightNumber,
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
