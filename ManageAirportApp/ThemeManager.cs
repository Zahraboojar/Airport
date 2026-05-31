using ManageAirportApp.Domain;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ManageAirportApp
{
    internal class ThemeManager : ThemeItems
    {
        static readonly Color darkBlue = Color.FromArgb(34, 49, 101);
        static readonly Color lightBlue = Color.FromArgb(114, 202, 235);
        static readonly Color darkBlue2 = Color.FromArgb(19, 32, 60);
        static readonly Color lightYellow = Color.FromArgb(246, 221, 147);

        static bool Theme = true ; // true = light, false = dark


        public static void ApplyTheme(Control parent)
        {
            LogoIcon = Properties.Resources.AirPlane2;
            if (Theme)
                SetLightTheme();
            else
            {
                SetDarkTheme();
                ReverseTheme(parent);
            }
        }
        public static void ReverseTheme(Control parent)
        {
            if (Theme)
                SetDarkTheme();
            else
                SetLightTheme();

            ChangeControlTheme(parent);
        }

        private static void ChangeControlTheme(Control parent)
        {
            if (parent != null)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is DataGridView grid)
                    {
                        ApplyThemeToDataGridView(grid);
                        continue;
                    }

                    c.ForeColor = ForeColor;

                    if (c.HasChildren)
                        ChangeControlTheme(c);

                    if (c.BackColor == darkBlue)
                    {
                        c.BackColor = lightBlue;
                    }
                    else if (c.BackColor == lightBlue)
                    {
                        c.BackColor = darkBlue;
                    }
                    else if (c.BackColor == lightYellow)
                    {
                        c.BackColor = darkBlue2;
                    }
                    else if (c.BackColor == darkBlue2)
                    {
                        c.BackColor = lightYellow;
                    }
                }
            }
        }
        private static void ApplyThemeToDataGridView(DataGridView grid)
        {
            grid.BackgroundColor = FormBackgroundColor;
            grid.BorderStyle = BorderStyle.None;

            grid.DefaultCellStyle.BackColor = BackgroundColor;
            grid.DefaultCellStyle.ForeColor = ForeColor;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, BackgroundColor);
            grid.DefaultCellStyle.SelectionForeColor = ForeColor;

            grid.AlternatingRowsDefaultCellStyle.BackColor =
                Theme ? Color.FromArgb(230, 230, 230) : Color.FromArgb(45, 45, 45);

            grid.ColumnHeadersDefaultCellStyle.BackColor = BackgroundColor;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = ForeColor;

            grid.RowHeadersDefaultCellStyle.BackColor = BackgroundColor;
            grid.RowHeadersDefaultCellStyle.ForeColor = ForeColor;
            grid.EnableHeadersVisualStyles = false; 
        }

        private static void SetLightTheme()
        {
            BackgroundColor = lightBlue;
            ForeColor = Color.Black;
            FormBackgroundColor = lightYellow;

            MenuIcon = Properties.Resources.menu;
            SettingIcon = Properties.Resources.setting;
            ExitIcon = Properties.Resources.exit;
            LeftIcon = Properties.Resources.left;
            RightIcon = Properties.Resources.right;
            UserIcon = Properties.Resources.user;
            TicketIcon = Properties.Resources.ticket;
            ThemeIcon = Properties.Resources.night;
            TrashIcon = Properties.Resources.trash;
            OpenTrashIcon = Properties.Resources.opentrash;
            RefreshIcon = Properties.Resources.refresh;

            Theme = true;
        }
        private static void SetDarkTheme()
        {
            BackgroundColor = darkBlue;
            ForeColor = Color.White;
            FormBackgroundColor = darkBlue2;

            MenuIcon = Properties.Resources.menuDark;
            SettingIcon = Properties.Resources.settingDark;
            ExitIcon = Properties.Resources.exitDark;
            LeftIcon = Properties.Resources.leftDark;
            RightIcon = Properties.Resources.rightDark;
            UserIcon = Properties.Resources.userDark;
            TicketIcon = Properties.Resources.ticketDark;
            ThemeIcon = Properties.Resources.lightDark;
            TrashIcon = Properties.Resources.trashDark;
            RefreshIcon = Properties.Resources.refreshDark;
            OpenTrashIcon = Properties.Resources.opentrashDark;


            Theme = false;
        }
    }
}
