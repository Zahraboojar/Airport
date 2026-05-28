using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAitportApp.DAL
{
    public class GateRepo : BaseRepo<Gate>
    {
        public override async Task<OperationResult<List<Gate>>> GetAllAsync(SelectProperties selectProperties)
        {
            string txt = selectProperties.SearchText;
            int id = selectProperties.AirportId;
            int terminalId = selectProperties.TerminalId;
            if (id != 0)
            {
                var all = set
                        .Where(x => x.IsDeleted == selectProperties.IsDeleted &&
                        x.Terminal.AirportId == id)
                        .OrderBy(x => x.Id)
                        .Skip(selectProperties.Offset)
                        .Take(selectProperties.Limit);
                if (txt != "")
                {
                    all = all
                        .Where(x => x.GateNumber.Contains(txt) || x.Capacity.ToString().Contains(txt));
                        
                }
                else if (terminalId != 0)
                {
                    all = all
                        .Where(x => x.TerminalId == terminalId);
                }
                var listOfAll = await all.ToListAsync();

                return OperationResult<List<Gate>>.Success(listOfAll);
            }
            return await base.GetAllAsync(selectProperties);
        }

        public async Task<OperationResult<Gate>> GetByGateNumberAsync(string gateNumber)
        {
            var result = await set
                .Where(x => x.GateNumber == gateNumber)
                .FirstOrDefaultAsync();
            if (result == null)
                return OperationResult<Gate>.Failed(Messages.NotFound);
            return OperationResult<Gate>.Success(result);
        }

        public async Task<OperationResult<Gate>> GetLastAsync(SelectProperties sp)
        {
            var result = await set
                .Where(x => x.IsDeleted == sp.IsDeleted && x.Terminal.AirportId == sp.AirportId && x.TerminalId == sp.TerminalId)
                .OrderByDescending(x => x.Id)
                .FirstOrDefaultAsync();
            if (result == null)
                return OperationResult<Gate>.Failed(Messages.NotFound);
            return OperationResult<Gate>.Success(result);
        }
    }
}
