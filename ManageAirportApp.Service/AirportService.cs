using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageAitportApp.DAL;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class AirportService : BaseService<Airport, AirportRepo, AirportDto>, ICrudService<Airport, AirportDto>
    {
        static private AirportRepo repo = new AirportRepo();
        public AirportService() : base(repo)
        {
        }

        public async Task<OperationResult> AddAsync(AirportDto airportDto)
        {
            var validateResult = AirportValidation.ValidAll(airportDto);
            if (validateResult.IsSuccess)
            {

                var airport = new Airport
                {
                    Name = airportDto.Name,
                    City = airportDto.City,
                    Region = airportDto.Region,
                    IATA_Code = airportDto.IATA_Code,
                    ICAO_Code = airportDto.ICAO_Code,
                    CreatedById = LoginedUserService.EmployeeId
                };
                return await _repo.AddAsync(airport);
            }
            return validateResult;
        }

        public async Task<OperationResult<Airport>> GetByNameAsync(string name)
        {
            return await _repo.GetByNameAsync(name);
        }

        public async Task<OperationResult> UpdateAsync(AirportDto airportDto, int id)
        {
            var airportResult = await GetByIdAsync(id);
            if (airportResult.IsSuccess)
            {
                var validateResult = AirportValidation.ValidAll(airportDto);
                if (validateResult.IsSuccess)
                {

                    var existingAirport = airportResult.Data;

                    existingAirport.Name = airportDto.Name;
                    existingAirport.City = airportDto.City;
                    existingAirport.Region = airportDto.Region;
                    existingAirport.IATA_Code = airportDto.IATA_Code;
                    existingAirport.ICAO_Code = airportDto.ICAO_Code;

                    existingAirport.UpdatedById = LoginedUserService.EmployeeId;
                    existingAirport.UpdatedAt = DateTime.Now;

                    return await _repo.UpdateAsync(existingAirport);
                }
                return validateResult;
            }
            else
            {
                return OperationResult.Failed(Messages.NotFound);
            }
        }
        protected override AirportDto MapEntityToDto(Airport entity)
        {
            return new AirportDto
            {
                City = entity.City,
                Region = entity.Region,
                IATA_Code = entity.IATA_Code,
                ICAO_Code = entity.ICAO_Code,
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
