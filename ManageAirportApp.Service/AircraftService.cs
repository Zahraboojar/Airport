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
    public class AircraftService : BaseService<Aircraft, AircraftRepo, AircraftDto>, ICrudService<Aircraft, AircraftDto>
    {
        static private AircraftRepo repo = new AircraftRepo();
        public AircraftService() : base(repo)
        {
        }

        public async Task<OperationResult> UpdateAsync(AircraftDto aircraftDto, int id)
        {
            var aircraftResult = await GetByIdAsync(id);
            if (aircraftResult.IsSuccess)
            {
                var validateResult = AircraftValidation.ValidAll(aircraftDto);
                if (validateResult.IsSuccess)
                {
                    var existingAircraft = aircraftResult.Data;

                    existingAircraft.ManufacturerName = aircraftDto.ManufacturerName;
                    existingAircraft.Capacity = aircraftDto.Capacity;
                    existingAircraft.Model = aircraftDto.Model;
                    existingAircraft.RegistrationNumber = aircraftDto.RegistrationNumber;
                    existingAircraft.UpdatedById = LoginedUserService.EmployeeId;
                    existingAircraft.UpdatedAt = DateTime.Now;

                    return await _repo.UpdateAsync(existingAircraft);
                }
                return validateResult;
            }
            else
            {
                return OperationResult.Failed(Messages.NotFound);
            }
        }

        public async Task<OperationResult> AddAsync(AircraftDto aircraftDto)
        {
            var validateResult = AircraftValidation.ValidAll(aircraftDto);
            if (validateResult.IsSuccess)
            {
                var aircraft = new Aircraft
                {
                    ManufacturerName = aircraftDto.ManufacturerName,
                    RegistrationNumber = aircraftDto.RegistrationNumber,
                    Model = aircraftDto.Model,
                    Capacity = aircraftDto.Capacity,
                    CreatedById = LoginedUserService.EmployeeId
                };
                return await _repo.AddAsync(aircraft);
            }
            return validateResult;
        }

        public async Task<OperationResult<Aircraft>> GetByRegistrationNumberAsync(string registrationNumber)
        {
            return await _repo.GetByRegistrationNumberAsync(registrationNumber);
        }
        public async Task<OperationResult<List<Aircraft>>> GetAllAvailableAsync(SelectProperties selectProperties, Aircraft selectedAircraft = null)
        {
            var flightService = ServiceFactory<FlightService>.Instance;
            var allFlights = await flightService.GetAllEntityAsync(new SelectProperties());
            if (allFlights.IsSuccess)
            {
                var result = allFlights.Data.Where(x => x.Status == FlightStatus.Scheduled || x.Status == FlightStatus.Departed)
                    .Select(x => x.Id).ToArray();
                var list = await ArrayOperations.GetAvailableAircrafts(result);
                if (selectedAircraft != null)
                {
                    list.Add(selectedAircraft);
                }
                return OperationResult<List<Aircraft>>.Success(list);
            }
            return OperationResult<List<Aircraft>>.Failed(Messages.NotFound);
        }
        protected override AircraftDto MapEntityToDto(Aircraft entity)
        {
            return new AircraftDto
            {
                ManufacturerName = entity.ManufacturerName,
                RegistrationNumber = entity.RegistrationNumber,
                Model = entity.Model,
                Capacity = entity.Capacity,
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