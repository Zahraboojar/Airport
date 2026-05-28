using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public interface ICrudService<TEntity, TDto> : IAddService<TEntity, TDto>
    {
        Task<OperationResult> UpdateAsync(TDto entity, int id);

    }
}
