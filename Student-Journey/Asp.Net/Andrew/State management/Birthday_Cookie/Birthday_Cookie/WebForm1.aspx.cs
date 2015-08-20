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
            HttpCookie cook = Request.Cookies["Preferences"];

            if (cook["PersonalDetails"] == null)
            {
                lblCookie.Text = "Nothing Exist here ? ";
            }
            else
            {
                lblCookie.Text = cook["PersonalDetails"];
            }
        }

        protected void calBirthDay_SelectionChanged(object sender, EventArgs e)
        {
            lblMessage.Text = calBirthDay.SelectedDate.ToString("dd/MM/yyyy");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["PersonalDetails"];

            if (cookie == null)
            {
                cookie = new HttpCookie("Preferences");
            }

            cookie["PersonalDetails"] = calBirthDay.SelectedDate.ToString("dd/MM/yyyy");

            cookie.Expires = DateTime.Now.AddDays(30);

            Response.Cookies.Add(cookie);
        }
    }
}