using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac_2_Query_String
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPage_Click(object sender, EventArgs e)
        {
            string url = "DisplayDetails.aspx?";
            url += "Item=" + txtFirstName.Text + " " + txtLastName.Text;

            Response.Redirect(url);
        }
    }
}