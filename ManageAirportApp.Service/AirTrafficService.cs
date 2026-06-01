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
    public class AirTrafficService : BaseService<AirTraffic, AirTrafficRepo, AirTrafficDto>, IAddService<AirTraffic, AirTrafficDto>
    {
        static private AirTrafficRepo repo = new AirTrafficRepo();
        public AirTrafficService() : base(repo)
        {
        }

        public async Task<OperationResult> AddAsync(AirTrafficDto airTrafficDto)
        {
            var airTraffic = new AirTraffic()
            {
                AirportId = LoginedUserService.Employee.AirportId == null ? 0 : (int)LoginedUserService.Employee.AirportId,
                FlightId = airTrafficDto.FlightId,
                ControllerId = LoginedUserService.EmployeeId,
                EventType = EnumExtensions.GetAirTrafficsEventType(airTrafficDto.EventType),
                EventTime = airTrafficDto.EventTime,
                CreatedById = LoginedUserService.EmployeeId
            };
            var result = await _repo.AddAsync(airTraffic);
            if (result.IsSuccess)
            {
                await SetLogs.SetAirTraffic(Actions.Add, "یک مورد اضافه شد");
            }
            return result;
        }
        protected override AirTrafficDto MapEntityToDto(AirTraffic entity)
        {
            return new AirTrafficDto
            {
                Airport = entity.Airport,
                AirportName = entity.Airport?.Name,
                FlightId = entity.FlightId,
                ControllerId = entity.ControllerId,
                EventType = EnumExtensions.GetAirTrafficsEventType(entity.EventType),
                EventTime = entity.EventTime,
                AirportId = entity.AirportId,
                Controller = entity.Controller,
                ControllerFullName =$"{entity.Controller?.FirstName} {entity.Controller?.LastName}({entity.Controller?.NationalCode})",
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
            };
        }
    }
}
