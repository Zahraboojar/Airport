using ManageAirportApp.DAL;
using System;

namespace ManageAitportApp.DAL
{
    public class DatabaseHelper
    {
        public static bool EnsureCreated()
        {
            try
            {
                using (var db = new AirportDBContext())
                {
                    db.Database.CreateIfNotExists();
                }
                return true;
            }
            catch (Exception ex)
            {
                //TODO: log or return error if need
                return false;
            }
        }
    }
}
