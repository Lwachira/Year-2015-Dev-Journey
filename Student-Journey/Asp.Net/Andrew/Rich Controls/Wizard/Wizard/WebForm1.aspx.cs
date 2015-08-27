using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wizard
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
            lblSurname.Text = txtSurname.Text;
            lblBirth.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date.Year > 2015 || e.Day.Date.Year < 2015)
            {
                e.Day.IsSelectable = false;
                e.Cell.BackColor = Color.Black;
            }
            else
            {
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblDate.Text = Calendar1.SelectedDate.ToLongDateString();
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Wizard1.ActiveStepIndex = Wizard1.ActiveStepIndex - 1;
            txtName.Text = "";
            txtSurname.Text = "";
            DateTime myDate = new DateTime(2015, 01, 01);
            Calendar1.VisibleDate = myDate;
            Calendar1.SelectedDate = myDate;
        }
    }
}