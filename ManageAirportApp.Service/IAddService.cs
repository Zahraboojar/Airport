using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public interface IAddService<TEntity, TDto> : IReadService<TEntity, TDto>
    {
        Task<OperationResult> AddAsync(TDto entity);
    }
}
