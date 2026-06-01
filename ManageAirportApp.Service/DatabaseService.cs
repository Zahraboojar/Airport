using ManageAitportApp.DAL;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class DatabaseService
    {
        public static async Task<bool> EnsureDatabaseCreatedAsync()
        {
            return await Task.Run(DatabaseHelper.EnsureCreated);
        }
    }
}
