using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Birthday_Cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void calBirthDay_SelectionChanged(object sender, EventArgs e)
        {
            lblMessage.Text = calBirthDay.SelectedDate.Day + calBirthDay.SelectedDate.Month + calBirthDay.SelectedDate.Year.ToString();
        }
    }
}