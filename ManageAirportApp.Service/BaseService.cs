using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageAitportApp.DAL;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public abstract class BaseService<TEntity, TRepo, TDto> : BaseGetMethods<TEntity, TRepo, TDto> , IDeleteAndRestoreService
           where TEntity : class, IAuditableEntity
           where TRepo : IRepositoriesClasses<TEntity>
    {

        public BaseService(TRepo repo) : base(repo) 
        {
        }

        public async Task<OperationResult> DeleteByIdAsync(int id, bool isDeleted)
        {
            var result = await GetByIdAsync(id, isDeleted);
            if (result.IsSuccess)
            {
                if (isDeleted) {
                    return await _repo.DeleteAsync(result.Data);
                }
                else
                {
                    var resultToSoftDelete = result.Data;

                    resultToSoftDelete.IsDeleted = true;
                    resultToSoftDelete.DeletedAt = DateTime.Now;
                    resultToSoftDelete.DeletedById = LoginedUserService.EmployeeId;

                    return await _repo.SoftDeleteAsync(resultToSoftDelete.Id);
                }
            }
            else
            {
                return OperationResult.Failed(Messages.NotFound);
            }
        }

        public async Task<OperationResult> RestoreByIdAsync(int id)
        {
            var result = await GetByIdAsync(id, true);
            if (result.IsSuccess)
            {
                var resultToRestore = result.Data;

                resultToRestore.IsDeleted = false;
                resultToRestore.DeletedAt = null;
                resultToRestore.DeletedBy = null;

                var result2 = await _repo.UpdateAsync(resultToRestore);

                if (result2.IsSuccess)
                {
                    result2.Message = Messages.RestoreSuccessfully;
                } else
                {
                    result2.Message = Messages.RestoreUnSuccessfully;
                }
                    return result2;
            }
            else
            {
                return OperationResult.Failed(Messages.NotFound);
            }
        }
    }
}
