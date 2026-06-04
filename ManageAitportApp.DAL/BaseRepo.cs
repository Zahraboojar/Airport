using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ManageAitportApp.DAL
{
    public class BaseRepo<TEntity> : IRepositoriesClasses<TEntity> where TEntity : class, IAuditableEntity
    {
        protected readonly AirportDBContext airportDB ;
        protected DbSet<TEntity> set;
        public BaseRepo()
        {
            airportDB = DbContextFactory.Create();
            set = airportDB.Set<TEntity>();
        }

        public async Task<OperationResult> AddAsync(TEntity entity)
        {
            set.Add(entity);
            await airportDB.SaveChangesAsync();
            return OperationResult.Success(Messages.AddedSuccessfully);
        }

        public async Task<OperationResult> SoftDeleteAsync(int id)
        {
            await airportDB.SaveChangesAsync();
            return OperationResult.Success(Messages.DeletedSuccessfully);

        }
        public async Task<OperationResult> DeleteAsync(TEntity entity)
        {
            set.Remove(entity);
            await airportDB.SaveChangesAsync();
            return OperationResult.Success(Messages.DeletedSuccessfully);

        }

        public virtual async Task<OperationResult<TEntity>> GetByIdAsync(int id, bool isDeleted)
        {
            var entity = await set
                                .Where(x => x.Id == id && x.IsDeleted == isDeleted)
                                .SingleOrDefaultAsync();

            if (entity == null)
                return OperationResult<TEntity>.Failed(Messages.NotFound);

            return OperationResult<TEntity>.Success(entity);
        }

        public virtual async Task<OperationResult<List<TEntity>>> GetAllAsync(SelectProperties selectProperties)
        {
            List<TEntity> all = await set
                    .Where(x => x.IsDeleted == selectProperties.IsDeleted)
                    .OrderBy(x => x.Id)
                    .Skip(selectProperties.Offset)
                    .Take(selectProperties.Limit)
                    .ToListAsync();

            return OperationResult<List<TEntity>>.Success(all);
        }

        public async Task<OperationResult> UpdateAsync(TEntity data)
        {
            await airportDB.SaveChangesAsync();

            return OperationResult.Success(Messages.UpdatedSuccessfully);
        }

        public virtual async Task<int> GetCountAllAsync(SelectProperties sp)
        {
            var count = await set.Where(x => x.IsDeleted == sp.IsDeleted).CountAsync();

            return count;
        }
    }
}
