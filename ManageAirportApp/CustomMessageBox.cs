using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageAirportApp
{
    public static class CustomMessageBox
    {
        public static DialogResult Error(string message, string title = "خطا")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult Success(string message, string title = "تایید")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public static DialogResult Confirm(string message, string title = "آیا مطمئن هستید ؟")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static DialogResult Warning(string message, string title = "هشدار")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult MoreInformation(string message, string title = "اطلاعات تکمیلی")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult Message(string message, bool IsSuccess)
        {
            string title = "";
            MessageBoxIcon icon = MessageBoxIcon.Information;
            if (IsSuccess)
            {
                title = "انجام شد";
                icon = MessageBoxIcon.Asterisk;
            } else
            {
                title = "انجام نشد";
                icon = MessageBoxIcon.Error;
            }
            return MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        internal static void Success(object welcome)
        {
            throw new NotImplementedException();
        }
    }
}
