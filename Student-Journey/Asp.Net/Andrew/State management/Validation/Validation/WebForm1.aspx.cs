﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void cmdOk_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;

            lblMessage.Text = "cmd event handler executed";
        }
    }
}