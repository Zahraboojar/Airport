using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
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
    public partial class FrmLogs : BaseFrm
    {
        public FrmLogs()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private async void FrmLogs_Load(object sender, EventArgs e)
        {
            var sp = new SelectProperties
            {
                AirportId = LoginedUserService.Employee.AirportId == null ? 0 : (int)LoginedUserService.Employee.AirportId,
                Limit = 0,
                Offset = 0,
            };
            await mainDvg.SetDataSourceAsync<Log, LogService, LogDto>(sp);
        }
    }
}
