using ManageAirportApp.Share;
using ManageAirportApp.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public interface IReadService<TEntity, TDto>
    {
        Task<OperationResult<TEntity>> GetByIdAsync(int id, bool isDeleted = false);
        Task<OperationResult<List<TDto>>> GetAllAsync(SelectProperties selectProperties);
    }
}