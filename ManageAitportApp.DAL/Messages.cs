using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.DAL
{
    public static class Messages
    {

        public static string Welcome = "خوش آمدید";
        public static string NotSelectedRegion = "کشوری انتخاب نشده";
        public static string NotSelectedCity = "شهری انتخاب نشده";
        public static string InCorrectPassWord => "گذرواژه اشتباه میباشد";
        public static string InCorrectPassAndRePass => "گذرواژه با تکرار آن مطابقت ندارد";
        public static string InCorrectUserName => "نام کاربری اشتباه میباشد";
        public static string ReTry => "لطفا دوباره تلاش کنید";
        public static string SystemError => "خطای سیستمی";
        public static string InCorrectUserNameOrPassWord => "گذرواژه یا نام کاربری اشتباه است";
        public static string Emptyfield => "فیلدی نباید خالی باشد";
        public static string EmptyEmailfield => "فیلد ایمیل خالی است";
        public static string DuplicateNationalCode => "کد ملی تکراری است";
        public static string DuplicateRegistrationNumber => "شماره ثبت هواپیما تکراری است";
        public static string AddedSuccessfully => "با موفقیت ثبت شد";
        public static string DeletedSuccessfully => "با موفقیت حذف شد";
        public static string UpdatedSuccessfully => "با موفقیت ویرایش شد";
        public static string AddedUnSuccessfully => "عملیات ثبت با خطا مواجه شد . دوباره تلاش کنید";
        public static string DeletedUnSuccessfully => "عملیات حذف با خطا مواجه شد . دوباره تلاش کنید";
        public static string UpdatedUnSuccessfully => "عملیات ویرایش با خطا مواجه شد . دوباره تلاش کنید";
        public static string RestoreSuccessfully => "با موفقیت بازگردانی شد ";
        public static string RestoreUnSuccessfully => "عملیات بازگردانی با خطا مواجه شد . دوباره تلاش کنید";
        public static string NotFound => "پیدا نشد";
        public static string CantDeleteAirport => "نمیتوانید فرودگاه خود را حذف کنید";
        public static string NotFoundRow => "رکوردی یافت نشد";
        public static string NotFoundEntity => "موجودیت پیدا نشد";
        public static string ConfirmExit => "آیا میخواهید خارج شوید ؟";
        public static string NotFoundTableData => "خطا در دریافت اطلاعات ";
        public static string ConfirmDelete => "آیا مطمئن هستید؟ حذف شود ؟ ";
        public static string ConfirmRestore => "آیا مطمئن هستید؟ بازگردانی شود ؟ ";
        public static string NotSelectedFlight => "پروازی انتخاب نشده";
        public static string NotSelectedTicket => "بلیطی انتخاب نشده";
        public static string NotSelectedAirport => "فرودگاهی انتخاب نشده";
        public static string NotSelectedAAirport => "فرودگاه مبدا انتخاب نشده";
        public static string NotSelectedDAirport => "فرودگاه مقصد انتخاب نشده";
        public static string NotSelectedType => "نوعی انتخاب نشده";
        public static string NotSelectedRole => "سمتی انتخاب نشده";
        public static string NotSelectedAircraft => "هواپیمایی انتخاب نشده";
        public static string NotSelectedGate => "گیتی انتخاب نشده";
        public static string NotSelectedStatus => "وضعیتی انتخاب نشده";
        public static string MustNotEqualAirports => "فرودگاه مبدا و مقصد نباید برابر باشند";
        public static string Or => " یا ";

        public static string InCurrectEmail = "فرمت ایمیل نادرست است";
        public static string InCurrectNationalCode = "کدملی نادرست است";
        public static string InCurrectMobile = "شماره تلفن نادرست است";
        public static string InCurrectPassportNumber = "شماره پاسپورت نادرست است";
        public static string InCurrect = "نادرست است";
        public static string InCurrectName = "نام نادرست است";
        public static string InCurrectIATA = "کد یاتا درست نیست";
        public static string InCurrectICAO = "کد پیکو نادرست است";
        public static string IsSetSeatNumber = "این شماره صندلی از قبل رزرو شده است";
        public static string InCurrectCapacity = "ظرفیت باید در محدوده 1 تا 1000 باشد";
        public static string InCurrectManufacturerName = "فیلد سازنده هواپیما را درست وارد کنید";
        public static string InCurrectModel = "فیلد سازنده هواپیما را درست وارد کنید";
        public static string InCurrectRegistrationNumber = "فیلد شماره ثبت هواپیما را درست وارد کنید";
        public static string InCurrectPhoneNumber = "شماره موبایل درست  نیست";
        public static string InCurrectLastName = "نام خانوادگی را درست وارد کنید";
        public static string InCurrectFirstName = "نام را درست وارد کنید";
        public static string InCorrectWeight = "وزن باید در این محدوده مجاز است =>";
        public static string InCorrectWeightOfGateAndAircraft = "ظرفیت گیت نسبت به ظرفیت هواپیما کمتر است . گیت دیگر یا هواپیمای دیگر انتخاب کنید";
        public static string SeatNumberOutOfRange = "شماره صندلی نادرست است. (خارج از محدوده)";
        public static string YouCantDeleteYourSelf = "نمی توانید خودتان را حذف کنید";
        public static string SumOfWeightEqual = "جمع بار چمدان ها یا بار ها برای این بلیت برابر است با ";
    }
}
