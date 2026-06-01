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
    public class BaggageService : BaseService<Baggage, BaggageRepo, BaggageDto>, ICrudService<Baggage, BaggageDto>
    {
        static private BaggageRepo repo = new BaggageRepo();
        public BaggageService() : base(repo)
        {
        }

        public async Task<OperationResult> AddAsync(BaggageDto entity)
        {
            entity.TagNumber = GenerateUniqueItem.GenerateTagNumber(entity.Ticket.Flight.ArrivalAirport);
            var validateResult = await BaggageValidation.IsValidWeight(entity.Weight, entity.Ticket.Class, entity.Ticket);
            if (validateResult.IsSuccess)
            {

                var baggage = new Baggage
                {
                    TagNumber = entity.TagNumber,
                    TicketId = entity.TicketId,
                    Ticket = null,
                    Weight = entity.Weight,
                    Type = EnumExtensions.GetBaggageType(entity.Type),
                    Status = EnumExtensions.GetBaggageStatus(entity.Status),
                    CreatedById = LoginedUserService.EmployeeId
                };
                var result = await _repo.AddAsync(baggage);
                if (result.IsSuccess)
                {
                    await SetLogs.SetBaggage(Actions.Add, $"یک چمدان به بلیط {entity.TicketNumber} اضافه شد");
                }
                return result;
            }
            return validateResult;
        }

        public async Task<OperationResult> UpdateAsync(BaggageDto entity, int id)
        {
            var baggageResult = await GetByIdAsync(id);
            if (baggageResult.IsSuccess)
            {
                decimal validateWeight = 0;
                if (baggageResult.Data.Weight != entity.Weight)
                {
                    validateWeight = entity.Weight - baggageResult.Data.Weight;
                }
                var validateResult = await BaggageValidation.IsValidWeight(validateWeight, entity.Ticket.Class, entity.Ticket);
                if (validateResult.IsSuccess)
                {

                    var existingBaggage = baggageResult.Data;

                    existingBaggage.Weight = entity.Weight;
                    existingBaggage.Ticket = null;
                    existingBaggage.Type = EnumExtensions.GetBaggageType(entity.Type);
                    existingBaggage.Status = EnumExtensions.GetBaggageStatus(entity.Status);
                    existingBaggage.TicketId = entity.TicketId;

                    existingBaggage.UpdatedById = LoginedUserService.EmployeeId;
                    existingBaggage.UpdatedAt = DateTime.Now;

                    var result = await _repo.UpdateAsync(existingBaggage);
                    if (result.IsSuccess)
                    {
                        await SetLogs.SetBaggage(Actions.Update, $" چمدان {entity.TagNumber} به بلیط {entity.TicketNumber} اضافه شد");
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

        protected override BaggageDto MapEntityToDto(Baggage entity)
        {
            return new BaggageDto
            {
                Status = EnumExtensions.GetBaggageStatus(entity.Status),
                TagNumber = entity.TagNumber,
                Weight = entity.Weight,
                Type = EnumExtensions.GetBaggageType(entity.Type),
                Ticket = entity.Ticket,
                TicketNumber = entity.Ticket?.TicketNumber,
                TicketId = entity.TicketId,
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
