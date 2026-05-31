using ManageAirportApp.DAL;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAitportApp.DAL
{
    public interface IRepositoriesClasses<TEntity>
    {
        Task<OperationResult> AddAsync(TEntity data);
        Task<OperationResult> UpdateAsync(TEntity data);
        Task<OperationResult> SoftDeleteAsync(int id);
        Task<OperationResult> DeleteAsync(TEntity entity);
        Task<OperationResult<List<TEntity>>> GetAllAsync(SelectProperties selectProperties);
        Task<OperationResult<TEntity>> GetByIdAsync(int id = 0, bool isDeleted = false);
        Task<OperationResult<int>> GetCountAllAsync(bool isDeleted = false);
    }
}
