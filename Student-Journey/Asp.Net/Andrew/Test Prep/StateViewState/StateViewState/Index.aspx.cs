using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateViewState
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["Size"] == null)
            {
                ViewState["Size"] = "1";
                lblMessage.Text = "1";
            }
        }

        protected void btnIncrease_Click(object sender, EventArgs e)
        {
            int x = 0;
            btnDecrease.Enabled = true;
            x = int.Parse(ViewState["Size"].ToString());
            if (x < 20)
            {
                x = x + 1;
                lblMessage.Text = x.ToString();
            }

            ViewState["Size"] = x.ToString();
            if (x == 20)
            {
                btnIncrease.Enabled = false;
            }
        }

        protected void btnDecrease_Click(object sender, EventArgs e)
        {
            int x;
            btnIncrease.Enabled = true;
            x = int.Parse(ViewState["Size"].ToString());
            if (x > 0)
            {
                x = x - 1;
                lblMessage.Text = x.ToString();
            }

            ViewState["Size"] = x.ToString();
            if (x == 0)
            {
                btnDecrease.Enabled = false;
            }
        }
    }
}