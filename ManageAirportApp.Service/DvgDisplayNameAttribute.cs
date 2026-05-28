using System;

namespace ManageAirportApp.Service
{
    public class DvgDisplayNameAttribute : Attribute
    {
        public string DisplayName { get;}
        public DvgDisplayNameAttribute(string displayName = null)
        {
            DisplayName = displayName;
        }

    }
}