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
    public class EmployeeService : BaseService<Employee, EmployeeRepo, EmployeeDto>, ICrudService<Employee, EmployeeDto>
    {
        static private EmployeeRepo repo = new EmployeeRepo();
        public EmployeeService() : base(repo)
        {
        }

        public async Task<OperationResult> AddAsync(EmployeeDto entity)
        {
            var validateResult = BaseUserValidation.ValidAll<EmployeeDto>(entity);
            if (validateResult.IsSuccess)
            {
                var employee = new Employee()
                {
                    AirportId = LoginedUserService.Employee.AirportId,
                    EmployeeType = EnumExtensions.GetEmployeeType(entity.EmployeeType),
                    UserName = entity.UserName,
                    Password = entity.Password,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    NationalCode = entity.NationalCode,
                    DateOfBirth = entity.DateOfBirth,
                    PhoneNumber = entity.PhoneNumber,
                    Address = entity.Address,
                    PassportNumber = entity.PassportNumber,
                    CreatedById = LoginedUserService.EmployeeId
                };
                return await _repo.AddAsync(employee);
            }
            return validateResult;
        }

        public async Task<OperationResult<Employee>> GetByUsernameAsync(string Username)
        {
            return await _repo.GetByUserNameAsync(Username);
        }

        public async Task<OperationResult> UpdateAsync(EmployeeDto entity, int id)
        {
            var employeeResult = await GetByIdAsync(id);
            if (employeeResult.IsSuccess)
            {
                var validateResult = BaseUserValidation.ValidAll<EmployeeDto>(entity);
                if (validateResult.IsSuccess)
                {
                    var existingEmployee = employeeResult.Data;

                    existingEmployee.AirportId = entity.AirportId;
                    existingEmployee.EmployeeType = EnumExtensions.GetEmployeeType(entity.EmployeeType);
                    existingEmployee.UserName = entity.UserName;
                    existingEmployee.Password = entity.Password;
                    existingEmployee.FirstName = entity.FirstName;
                    existingEmployee.LastName = entity.LastName;
                    existingEmployee.NationalCode = entity.NationalCode;
                    existingEmployee.DateOfBirth = entity.DateOfBirth;
                    existingEmployee.PhoneNumber = entity.PhoneNumber;
                    existingEmployee.Address = entity.Address;
                    existingEmployee.PassportNumber = entity.PassportNumber;
                    existingEmployee.UpdatedById = LoginedUserService.EmployeeId;
                    existingEmployee.UpdatedAt = DateTime.Now;

                    return await _repo.UpdateAsync(existingEmployee);
                }
                return validateResult;
            }
            else
            {
                return OperationResult.Failed(Messages.NotFound);
            }
        }

        protected override EmployeeDto MapEntityToDto(Employee entity)
        {
            return new EmployeeDto
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                NationalCode = entity.NationalCode,
                Address = entity.Address,
                PassportNumber = entity.PassportNumber,
                Airport = entity.Airport,
                AirportName = entity.Airport?.Name,
                AirportId = entity.AirportId == null ? 0 : (int)entity.AirportId,
                DateOfBirth = entity.DateOfBirth,
                Email = entity.Email,
                EmployeeType = EnumExtensions.GetEmployeeType(entity.EmployeeType),
                Password = entity.Password,
                PhoneNumber = entity.PhoneNumber,
                UserName = entity.UserName,
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
