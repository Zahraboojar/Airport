using ManageAirportApp.Domain;
using ManageAirportApp.DAL;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageSchoolApp.Service
{
    public class LoginedUserService
    {
        EmployeeRepo employeeRepo = new EmployeeRepo();
        public static int EmployeeId { get; set; }
        public static Employee Employee { get; set; }

        public async Task<OperationResult> Login(string username, string password)
        {
            var result = await employeeRepo.Login(username, password);
            if (result.IsSuccess)
            {
                EmployeeId = result.Data.Id;
                Employee = result.Data;
                return OperationResult.Success();
            }
            return OperationResult.Failed(result.Message);

        }
    }
}
