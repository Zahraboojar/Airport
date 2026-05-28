using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public static class PersionDictionary
    {
        public const string Update = "ویرایش";
        public const string Delete = "حذف";
        public const string Add = "اضافه";
        public const string Restore = "بازگردانی";
        public const string CreatedBy = "ایجاد شده توسط";
        public const string CreatedTime = "تاریخ ایجاد";
        public const string UpdatedTime = "تاریخ اخرین ویرایش";
        public const string DeletedTime = "تاریخ حذف";
        public const string DeletedBy = "حذف شده توسط";
        public const string UpdatedBy = "ویرایش شده توسط";
        //flight
        public const string FlightNumber = "شماره پرواز";
        public const string DepartureAirport = "فرودگاه مبدا";
        public const string ArrivalAirport = "فرودگاه مقصد";
        public const string ScheduledDepartureTime = " زمان برنامه‌ریزی شده برای پرواز";
        public const string ScheduledArrivalTime = "زمان برنامه‌ریزی شده برای رسیدن";
        public const string ActualDepartureTime = "زمان واقعی پرواز";
        public const string ActualArrivalTime = "زمان واقعی رسیدن";
        public const string Flight = "پرواز";
        // Airport
        public const string AirportName = "نام فرودگاه";
        public const string City = "شهر";
        public const string Region = "کشور";
        public const string IATA_Code = "کد سه حرفی یاتا";
        public const string ICAO_Code = "کد چهار حرفی پیکو";
        public const string Airport = "فرودگاه";
        // Aircraft
        public const string Model = "مدل";
        public const string Manufacturer = "سازنده هواپیما";
        public const string Capacity = "ظرفیت";
        public const string RegistrationNumber = "شماره ثبت";
        public const string Aircraft = "هواپیما";
        //Passenger
        public const string FirstName = "نام";
        public const string Address = "آدرس";
        public const string NationalCode = "کد ملی";
        public const string LastName = "نام خانوادگی";
        public const string DateOfBirth = "تاریخ تولد";
        public const string PassportNumber = "شماره پاسپورت";
        public const string Nationality = "ملیت";
        public const string Email = "ایمیل";
        public const string PhoneNumber = "شماره تماس";
        public const string Passenger = "مسافر";
        // Ticket
        public const string Ticket = "بلیط";
        public const string SeatNumber = "شماره صندلی";
        public const string Class = "کلاس پروازی ";
        public const string Price = "قیمت";
        public const string BookingDate = "تاریخ و زمان رزرو";
        public const string TicketNumber = "شماره";
        //Gate const
        public const string Gate = "گیت";
        public const string GateNumber = "شماره گیت";
        public const string Terminal = "ترمینال";
        //Employee
        public const string Employee = "کارمند";
        public const string Username = "نام کاربری";
        public const string Password = "گذرواژه";
        public const string EmployeeType = "سمت / شغل";
        //Assignment
        public const string Assignment = "پرواز خاص";
        public const string Role = "نقش";
        //Baggage
        public const string Baggage = "بار / چمدان";
        public const string Weight = "وزن";
        public const string Type = "نوع ";
        public const string Status = "وضعیت";
        public const string TagNumber = "شماره تگ بار";
        //AirTrafficControl
        public const string AirTrafficControl = "کنترل ترافیک هوایی";
        public const string EventType = "نوع رویداد";
        public const string EventTime = "زمان رویداد";
        //Log
        public const string Log = "گزارش";
        public const string Action = "عملیات";
        public const string TableName = "نام جدول";
        public const string Description = "توضیحات";
        //Setting
        public const string Logo = "لوگو";
        public const string Link = "لینک";
        public const string Title = "عنوان";
        public const string Tel = "شماره تلفن";

        //enum
        //AirTrafficsEventType
        public const string ClearedForTakeoff = " اجازه‌ی برخاست صادر شود";
        public const string HoldingPattern = "در مسیر مشخص منتظر نگه داشته شود";
        public const string LandingClearance = "اجازه‌ی فرود صادر شود";

        //BaggageType
        public const string CarryOn = "‌بار دستی (چمدان) ";
        public const string Checked = "‌بار تحویلی";

        //Baggage Status
        public const string Scanned = "اسکن شده";
        public const string Loaded = "بارگیری شده";
        public const string Delivered = "به مقصد رسیده";
        public const string NotFound = "پیدا نشده";
        //EmployeeType
        public const string Management = "مدیریت";
        public const string CabinCrew = "مهمانداران";
        public const string GroundStaff = "پرسنل زمینی (محوطه فرودگاه)";
        public const string AirTrafficController = "کنترلر ترافیک هوایی";
        //EmployeeRole
        public const string None = "نامشخص _";
        public const string Pilot = "خلبان";
        public const string CoPilot = "کمک خلبان";
        public const string FlightAttendant = "مهماندار";

        //FlightStatus
        public const string Scheduled = "برنامه ریزی شده";
        public const string OnTime = "به موقع";
        public const string Delayed = "با تاخیر";
        public const string Cancelled = "لغو شده";
        public const string Departed = "پرواز کرده";
        public const string Arrived = "فرودآمده";

        //FlightClass
        public const string Economy = "اقتصادی";
        public const string Business = "کاری";
        public const string First = "درجه یک";

        //TicketType
        public const string OneWay = "یک طرفه";
        public const string RoundTrip = "دو طرفه";

        public const string Profile = "پروفایل";
    }
}
