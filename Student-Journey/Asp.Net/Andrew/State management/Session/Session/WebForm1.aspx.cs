﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPage_Click(object sender, EventArgs e)
        {
            Person perosonOne = new Person(txtFName.Text, txtSName.Text);

            Session["Person"] = perosonOne;

            Response.Redirect("DisplayDetails.aspx");
        }
    }
}