   using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageAitportApp.DAL;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class FlightService : BaseService<Flight, FlightRepo, FlightDto>, ICrudService<Flight, FlightDto>
    {
        static private FlightRepo repo = new FlightRepo();
        public FlightService() : base(repo)
        {
        }

        public async Task<OperationResult> AddAsync(FlightDto entity)
        {
            var validateResult = FlightValidation.IsValidGateOrAircraft(entity.Gate.Capacity, entity.Aircraft.Capacity);
            if (validateResult.IsSuccess)
            {
                entity.FlightNumber = await GenerateUniqueItem.GenerateFlightNumber(entity.ArrivalAirport);

                var flight = new Flight
                {
                    ScheduledArrivalTime = entity.ScheduledArrivalTime,
                    ScheduledDepartureTime = entity.ScheduledDepartureTime,
                    AircraftId = entity.AircraftId,
                    ArrivalAirportId = entity.ArrivalAirportId,
                    CreatedById = LoginedUserService.EmployeeId,
                    DepartureAirportId = entity.DepartureAirportId,
                    FlightNumber = entity.FlightNumber,
                    GateId = entity.GateId,

                };
                return await _repo.AddAsync(flight);
            }
            return validateResult;
        }

        public async Task<OperationResult> UpdateAsync(FlightDto entity, int id)
        {
            var flightResult = await GetByIdAsync(id);
            if (flightResult.IsSuccess)
            {

                var existingFlight = flightResult.Data;

                existingFlight.ActualArrivalTime = entity.ActualArrivalTime;
                existingFlight.ArrivalAirport = null;
                existingFlight.ActualDepartureTime = entity.ActualDepartureTime;
                existingFlight.AircraftId = entity.AircraftId;
                existingFlight.Aircraft = null;
                existingFlight.ArrivalAirportId = entity.ArrivalAirportId;
                existingFlight.DepartureAirportId = entity.DepartureAirportId;
                existingFlight.FlightNumber = entity.FlightNumber;
                existingFlight.GateId = entity.GateId;
                existingFlight.Gate = null;
                existingFlight.UpdatedById = LoginedUserService.EmployeeId;
                existingFlight.UpdatedAt = DateTime.Now;

                return await _repo.UpdateAsync(existingFlight);
            }
            else
            {
                return OperationResult.Failed(Messages.NotFound);
            }
        }
        public async Task<OperationResult<Flight>> GetByFlightNumber(string flightNumber)
        {
            return await _repo.GetByFlightNumber(flightNumber);
        }
        protected override FlightDto MapEntityToDto(Flight entity)
        {
            return new FlightDto
            {
                FlightNumber = entity.FlightNumber,
                DepartureAirportId = entity.DepartureAirportId,
                DepartureAirport = entity.DepartureAirport,
                DepartureAirportName = entity.DepartureAirport?.Name,
                ArrivalAirportId = entity.ArrivalAirportId,
                ArrivalAirport = entity.ArrivalAirport,
                ArrivalAirportName = entity.ArrivalAirport?.Name,
                ScheduledDepartureTime = entity.ScheduledDepartureTime,
                ScheduledArrivalTime = entity.ScheduledArrivalTime,
                ActualDepartureTime = entity.ActualDepartureTime,
                ActualArrivalTime = entity.ActualArrivalTime,
                AircraftId = entity.AircraftId,
                Aircraft = entity.Aircraft,
                AircraftRegisterNum = entity.Aircraft?.RegistrationNumber,
                Status = EnumExtensions.GetFlightStatus(entity.Status),
                GateId = entity.GateId,
                Gate = entity.Gate,
                GateNumber = entity.Gate?.GateNumber,
                Terminal = entity.Gate?.Terminal,
                TerminalName = entity.Gate?.Terminal?.Name,
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
