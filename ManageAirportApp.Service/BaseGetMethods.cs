using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageAitportApp.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public abstract class BaseGetMethods<TEntity, TRepo, TDto> : IReadService<TEntity, TDto>
           where TEntity : class, IAuditableEntity
           where TRepo : IRepositoriesClasses<TEntity>
    {
        protected TRepo _repo;

        public BaseGetMethods(TRepo repo)
        {
            _repo = repo;
        }

        public async Task<OperationResult<TEntity>> GetByIdAsync(int id, bool IsDeleted = false)
        {
            return await _repo.GetByIdAsync(id, IsDeleted);
        }
        public virtual async Task<OperationResult<List<TDto>>> GetAllAsync(SelectProperties selectProperties)
        {
            var result = await _repo.GetAllAsync(selectProperties);

            if (!result.IsSuccess)
                return OperationResult<List<TDto>>.Failed(result.Message);

            var dtoList = result.Data.Select(MapEntityToDto).ToList();

            return OperationResult<List<TDto>>.Success(dtoList);
        }
        
        public virtual async Task<OperationResult<List<TEntity>>> GetAllEntityAsync(SelectProperties selectProperties)
        {
            var result = await _repo.GetAllAsync(selectProperties);

            if (!result.IsSuccess)
                return OperationResult<List<TEntity>>.Failed(result.Message);

            return OperationResult<List<TEntity>>.Success(result.Data);
        }
        protected abstract TDto MapEntityToDto(TEntity entity);
    }
}
