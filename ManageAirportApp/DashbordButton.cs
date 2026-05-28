using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageAirportApp
{
    public class DashbordButton : Button
    {
        private readonly Image darkBluePic = Properties.Resources.menuitemselected;
        private readonly Image lightBluePic = Properties.Resources.menuitem1;

        public DashbordButton()
        {
            BackgroundImage = lightBluePic;
            ForeColor = Color.Black;
            Font = new Font("B Nazanin", 14, FontStyle.Bold);
            TextAlign = ContentAlignment.MiddleCenter;
            Dock = DockStyle.Fill;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            Color foreColor = Color.White;
            Color otherForeColor = Color.Black;
            Image image = darkBluePic;
            Image otherImage = lightBluePic;

            if (ThemeManager.ForeColor == Color.White)
            {
                foreColor = Color.Black;
                otherForeColor = Color.White;
                image = lightBluePic;
                otherImage = darkBluePic;
            }

            this.ForeColor = foreColor;
            this.BackgroundImage = image;

                Control parentContainer = this.Parent;

            if (parentContainer != null)
            {
                foreach (Control control in parentContainer.Controls)
                {
                    if (control is DashbordButton && control != this)
                    {
                        DashbordButton otherButton = (DashbordButton)control;

                        otherButton.BackgroundImage = otherImage;
                        otherButton.ForeColor = otherForeColor;
                    }
                }
            } 
        }
    }
}
