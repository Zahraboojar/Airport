using ManageAirportApp.Service;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageAirportApp
{
    public partial class MenuControl : UserControl
    {
        public event Action ReloadFormRequested;

        Image menuIcon = ThemeManager.MenuIcon;

        private void MenuControl_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            lblTitle.Text = LoginedUserService.Employee.Airport.Name;
        }
        public MenuControl()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this.FindForm());
            SetImages();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (tlpMenuItem.Visible)
            {
                menuIcon = ThemeManager.MenuIcon;
            }
            else
            {
                menuIcon = ThemeManager.ExitIcon;
            }
            SetImages();
            tlpMenuItem.Visible = !tlpMenuItem.Visible;

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new FrmProfile().ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new FrmSetting().ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.FindForm().Name == nameof(FrmMain))
                new FrmLogin().Show();
            this.FindForm().Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemeManager.ReverseTheme(this.FindForm());
            SetImages();
            ReloadFormRequested?.Invoke();
        }
        private void SetImages()
        {
            btnMenu.BackgroundImage = menuIcon;
            btnBack.BackgroundImage = ThemeManager.LeftIcon;
            btnSetting.BackgroundImage = ThemeManager.SettingIcon;
            btnProfile.BackgroundImage = ThemeManager.UserIcon;
            btnThem.BackgroundImage = ThemeManager.ThemeIcon;
        }
    }
}
