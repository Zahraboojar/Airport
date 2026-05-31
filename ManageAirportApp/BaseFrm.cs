using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Service;
using ManageAirportApp.Share;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageAirportApp
{
    public partial class BaseFrm : Form
    {
        public BaseFrm()
        {
            ThemeManager.ApplyTheme(this);
            InitializeComponent();
        }

        private void BaseFrm_Load(object sender, EventArgs e)
        {
             foreach (Control control in this.Controls)
            {
                ThemeManager.ApplyTheme(control);
            }
        }

        
        public void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            FindAndAttachCloseButtons(this.Controls);
        }

        private void FindAndAttachCloseButtons(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button btn && btn.Tag != null && btn.Tag.ToString() == "close")
                {
                    btn.Click -= btnCancel_Click;
                    btn.Click += btnCancel_Click;
                }
                if (control.HasChildren)
                {
                    FindAndAttachCloseButtons(control.Controls);
                }
            }
        }
        
        protected DateTime CombineDateTime(DateTimePicker dp1, DateTimePicker dp2)
        {
            DateTime selectedDate = dp1.Value.Date;
            TimeSpan selectedTime = dp2.Value.TimeOfDay;
            return selectedDate.Add(selectedTime);
        }

        public List<string> ValidateSelections(params (int SelectedIndex, string ErrorMessage)[] items)
        {
            var errors = new List<string>();

            foreach (var item in items)
            {
                if (item.SelectedIndex < 0)
                {
                    errors.Add(item.ErrorMessage);
                }
            }

            return errors;
        }
    }
}
