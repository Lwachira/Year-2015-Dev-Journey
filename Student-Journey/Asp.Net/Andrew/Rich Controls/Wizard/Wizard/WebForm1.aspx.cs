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
    }
}