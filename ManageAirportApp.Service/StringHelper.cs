using ManageAirportApp.DAL;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public static class StringHelper
    {
        public static string GetUsername(string txt)
        {
            string userName = "";

            int start = txt.IndexOf('(');
            int end = txt.IndexOf(')');

            if (start >= 0 && end > start)
            {
                userName = txt.Substring(start + 1, end - start - 1);
            }
            return userName;
        }
        public static OperationResult<string> IsEqualPassword(string pass, string rePass)
        {
            pass = pass.Trim();
            rePass = rePass.Trim();
            if (pass != "" && rePass != "")
            {
                if (rePass == pass)
                {
                    return OperationResult<string>.Success(pass);
                    
                }
            }
            return OperationResult<string>.Failed(Messages.InCorrectPassAndRePass);
        }
    }
}
