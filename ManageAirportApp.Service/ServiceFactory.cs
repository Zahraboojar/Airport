using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public static class ServiceFactory<T> where T : class , new()
    {

        private static T serviceInstance;

        public static T Instance
        {
            get
            {
                if (serviceInstance == null)
                {
                    serviceInstance = new T();
                }
                return serviceInstance;
            }
        }
    }
}
