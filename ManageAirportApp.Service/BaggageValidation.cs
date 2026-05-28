using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class BaggageValidation : BaseValidation
    {
        public static async Task<OperationResult> IsValidWeight(decimal Weight, FlightClass flightClass, Ticket ticket = null)
        {
            decimal sumWeight = Weight;
            string message = "";
            if (ticket != null)
            {
                sumWeight += await SumWeight(ticket.Id);
            }
            switch(flightClass)
            {
                case FlightClass.First:
                    if (!(sumWeight >= 0 && sumWeight <= 50))
                        message = Messages.InCorrectWeight + " 0 تا 50";
                    break;
                case FlightClass.Business:
                    if (!(sumWeight >= 0 && sumWeight <= 40))
                        message = Messages.InCorrectWeight + " 0 تا 40";
                    break;
                case FlightClass.Economy:
                    if (!(sumWeight >= 0 && sumWeight <= 30))
                        message = Messages.InCorrectWeight + " 0 تا 30" ;
                    break;
            }
            if (message.Length > 0) 
            {

                message += Environment.NewLine + Messages.SumOfWeightEqual + (sumWeight - Weight).ToString();
                return OperationResult.Failed(message);
            }
            return OperationResult.Success();
        }
        public static async Task<decimal> SumWeight(int ticketId)
        {
            var tiketService = ServiceFactory<TicketService>.Instance;
            var ticketResult = await tiketService.GetByIdAsync(ticketId);
            if (ticketResult.IsSuccess)
            {
                var baggageService = ServiceFactory<BaggageService>.Instance;
                var baggageResult = await baggageService.GetAllEntityAsync(new SelectProperties());
                if (baggageResult.IsSuccess)
                {
                    var sumOfWeight = baggageResult.Data.Where(x => x.TicketId == ticketId).Sum(x => x.Weight);
                    return sumOfWeight;
                }
            }
            return 0;
        }
    }
}
