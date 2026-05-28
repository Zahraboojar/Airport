using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageAitportApp.DAL;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class TicketService : BaseService<Ticket, TicketRepo, TicketDto>, ICrudService<Ticket, TicketDto>
    {
        static private TicketRepo repo = new TicketRepo();
        public TicketService() : base(repo)
        {
        }

        public async Task<OperationResult> AddAsync(TicketDto entity)
        {
            var validateResult = await TicketValidaton.IsValidSeatNumber(entity.SeatNumber, entity.Flight);
            if (validateResult.IsSuccess)
            {
                entity.TicketNumber = await GenerateUniqueItem.GererateTicketNumber(LoginedUserService.Employee.Airport);
                var ticket = new Ticket
                {
                    SeatNumber = entity.SeatNumber,
                    TicketNumber = entity.TicketNumber,
                    CreatedById = LoginedUserService.EmployeeId,
                    TicketType = EnumExtensions.GetTicketType(entity.TicketType),
                    PassengerId = entity.PassengerId,
                    FlightId = entity.FlightId,
                    Flight = null,
                    Class = EnumExtensions.GetFlightClass(entity.Class),
                    Price = entity.Price,
                    BookingDate = DateTime.Now
                };

                return await _repo.AddAsync(ticket);
            }
            return validateResult;
        }

        public async Task<OperationResult> UpdateAsync(TicketDto entity, int id)
        {
            var ticketResult = await GetByIdAsync(id);
            if (ticketResult.IsSuccess)
            {
                var validateResult = await TicketValidaton.IsValidSeatNumber(entity.SeatNumber, entity.Flight);
                if (validateResult.IsSuccess)
                {
                    var existingTicket = ticketResult.Data;

                    existingTicket.SeatNumber = entity.SeatNumber;
                    existingTicket.TicketNumber = entity.TicketNumber;
                    existingTicket.TicketType = EnumExtensions.GetTicketType(entity.TicketType);
                    existingTicket.PassengerId = entity.PassengerId;
                    existingTicket.FlightId = entity.FlightId;
                    existingTicket.Flight = null;
                    existingTicket.Class = EnumExtensions.GetFlightClass(entity.Class);
                    existingTicket.Price = entity.Price;
                    existingTicket.UpdatedById = LoginedUserService.EmployeeId;
                    existingTicket.UpdatedAt = DateTime.Now;

                    return await _repo.UpdateAsync(existingTicket);
                }
                return validateResult;
            }
            else
            {
                return OperationResult.Failed(Messages.NotFound);
            }
        }

        public async Task<OperationResult<Ticket>> GetByTicketNumberAsync(string ticketNumber)
        {
            return await _repo.GetByTicketNumberAsync(ticketNumber);
        }
        protected override TicketDto MapEntityToDto(Ticket entity)
        {
            return new TicketDto
            {
                TicketNumber = entity.TicketNumber,
                Class = EnumExtensions.GetFlightClass(entity.Class),
                Price = entity.Price,
                FlightId = entity.FlightId,
                Flight = entity.Flight,
                FlightNumber = entity.Flight?.FlightNumber,
                PassengerId = entity.PassengerId,
                Passenger = entity.Passenger,
                PassengerFullName = $"{entity.Passenger?.FirstName} {entity.Passenger?.LastName}" +
                    $"({entity.Passenger?.NationalCode})",
                SeatNumber = entity.SeatNumber,
                TicketType = EnumExtensions.GetTicketType(entity.TicketType),
                FlightClass = EnumExtensions.GetFlightClass(entity.Class),
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

        public async Task<OperationResult<bool>> GetByFlightAsync(SelectProperties sp, int flightId, int seatNumber)
        {
            return await _repo.GetByFlightAsync(sp, flightId, seatNumber);
        }
        public async Task<OperationResult<List<int>>> GetAllByFlightIdAsync(int flightId)
        {
            return await _repo.GetAllByFlightIdAsync(flightId);
        }
    }
}
