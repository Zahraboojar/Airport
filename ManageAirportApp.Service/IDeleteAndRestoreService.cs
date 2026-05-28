using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public interface IDeleteAndRestoreService
    {
        Task<OperationResult> DeleteByIdAsync(int id, bool isDeleted);
        Task<OperationResult> RestoreByIdAsync(int id);
    }
}
