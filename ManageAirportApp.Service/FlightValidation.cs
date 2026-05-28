using ManageAirportApp.DAL;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class FlightValidation : BaseValidation
    {
        public static OperationResult IsValidGateOrAircraft(int gateCapacity, int aircraftCapacity)
        {
            if (gateCapacity >= aircraftCapacity) return OperationResult.Success();
            return OperationResult.Failed(Messages.InCorrectWeightOfGateAndAircraft);
        }
    }
}