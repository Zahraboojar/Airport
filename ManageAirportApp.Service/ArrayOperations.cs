using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public static class ArrayOperations
    {
        public static int[] CalculateDifference(int lenght, int[] itemsToRemove)
        {
            int[] firstArray = Enumerable.Range(1, lenght).ToArray();

            int[] result = firstArray.Except(itemsToRemove).ToArray();

            return result;
        }
        public static async Task<List<Aircraft>> GetAvailableAircrafts(int[] UnAvailableItemIds)
        {
            var service = ServiceFactory<AircraftService>.Instance;

            var aircraftResult = await service.GetAllEntityAsync(new SelectProperties());

            if (aircraftResult.IsSuccess && aircraftResult.Data != null)
            {
                var allAircraftIds = aircraftResult.Data.Select(x => x.Id).ToList();

                var availableAircrafts = aircraftResult.Data
                                            .Where(aircraft => !UnAvailableItemIds.Contains(aircraft.Id))
                                            .ToList();

                return availableAircrafts;
            }
            else
            {
                return new List<Aircraft>();
            }
        }

        internal static async Task<List<Gate>> GetAvailableGate(int[] UnAvailableItemIds)
        {
            var service = ServiceFactory<GateService>.Instance;

            var gateResult = await service.GetAllEntityAsync(new SelectProperties());

            if (gateResult.IsSuccess && gateResult.Data != null)
            {
                var allAircraftIds = gateResult.Data.Select(x => x.Id).ToList();

                var availableGates = gateResult.Data
                                            .Where(gate => !UnAvailableItemIds.Contains(gate.Id))
                                            .ToList();

                return availableGates;
            }
            else
            {
                return new List<Gate>();
            }
        }
    }
}
