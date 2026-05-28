using ManageAirportApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAitportApp.DAL
{
    public static class DbContextFactory
    {
        public static AirportDBContext Create()
        {
            return new AirportDBContext();
        }
    }
}
