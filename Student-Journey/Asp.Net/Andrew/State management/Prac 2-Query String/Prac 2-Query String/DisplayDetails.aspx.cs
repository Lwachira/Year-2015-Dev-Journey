using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac_2_Query_String
{
    public partial class DisplayDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Name: " + Request.QueryString["Item"];
            //lblMessage.Text += "<br/>Full Record: " + Request.QueryString["Mode"];
        }
    }
}