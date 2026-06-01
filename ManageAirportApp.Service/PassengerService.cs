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
    public class PassengerService : BaseService<Passenger, PassengerRepo, PassengerDto>, ICrudService<Passenger, PassengerDto>
    {
        static private PassengerRepo repo = new PassengerRepo();
        public PassengerService() : base(repo)
        {
        }

        public async Task<OperationResult> AddAsync(PassengerDto entity)
        {
            var validateResult = BaseUserValidation.ValidAll<PassengerDto>(entity);
            if (validateResult.IsSuccess)
            {
                var passenger = new Passenger()
                {
                    Nationality = entity.Nationality,
                    FirstName = entity.FirstName,
                    LastName = entity.LastName,
                    NationalCode = entity.NationalCode,
                    DateOfBirth = entity.DateOfBirth,
                    PhoneNumber = entity.PhoneNumber,
                    Email = entity.Email,
                    Address = entity.Address,
                    PassportNumber = entity.PassportNumber,
                    CreatedById = LoginedUserService.EmployeeId
                };
                var result = await _repo.AddAsync(passenger);
                if (result.IsSuccess)
                {
                    await SetLogs.SetPassenger(Actions.Add, "یک مسافر اضافه شد");
                }
                return result;
            }
            return validateResult;
        }

        public async Task<OperationResult<Passenger>> GetByNationalCode(string nationalCode)
        {
            return await _repo.GetByNationalCode(nationalCode);
        }

        public async Task<OperationResult> UpdateAsync(PassengerDto entity, int id)
        {
            var passengerResult = await GetByIdAsync(id);
            if (passengerResult.IsSuccess)
            {
                var validateResult = BaseUserValidation.ValidAll<PassengerDto>(entity);
                if (validateResult.IsSuccess)
                {
                    var existingPassenger = passengerResult.Data;

                    existingPassenger.Nationality = entity.Nationality;
                    existingPassenger.FirstName = entity.FirstName;
                    existingPassenger.LastName = entity.LastName;
                    existingPassenger.NationalCode = entity.NationalCode;
                    existingPassenger.DateOfBirth = entity.DateOfBirth;
                    existingPassenger.PhoneNumber = entity.PhoneNumber;
                    existingPassenger.Address = entity.Address;
                    existingPassenger.PassportNumber = entity.PassportNumber;
                    existingPassenger.Email = entity.Email;
                    existingPassenger.UpdatedById = LoginedUserService.EmployeeId;
                    existingPassenger.UpdatedAt = DateTime.Now;

                    var result = await _repo.UpdateAsync(existingPassenger);
                    if (result.IsSuccess)
                    {
                        await SetLogs.SetPassenger(Actions.Update, $"مسافر {entity.FirstName} {entity.LastName} ویرایش شد");
                    }
                    return result;
                }
                return validateResult;
            }
            else
            {
                return OperationResult.Failed(Messages.NotFound);
            }
        }

        protected override PassengerDto MapEntityToDto(Passenger entity)
        {
            return new PassengerDto
            {
                Nationality = entity.Nationality,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                NationalCode = entity.NationalCode,
                DateOfBirth = entity.DateOfBirth,
                Address = entity.Address,
                PassportNumber = entity.PassportNumber,
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber,
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
