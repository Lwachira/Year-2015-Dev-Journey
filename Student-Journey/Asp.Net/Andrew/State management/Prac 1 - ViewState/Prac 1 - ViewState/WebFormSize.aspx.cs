using System;

namespace Prac_1___ViewState
{
    public partial class WebFormSize : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnIncrease_Click(object sender, EventArgs e)
        {
            int counter;
            if (ViewState["Size"] == null)
            {
                counter = 1;
            }
            else
            {
                counter = (int)ViewState["Size"] + 1;
            }
            ViewState["Size"] = counter;
            lblMessage.Text = "Size: " + counter.ToString();
            if (counter >= 20)
            {
                btnIncrease.Enabled = false;
            }
            else
            {
                btnDecrease.Enabled = true;
            }
        }

        protected void btnDecrease_Click(object sender, EventArgs e)
        {
            int counter;
            if (ViewState["Size"] == null)
            {
                counter = 1;
            }
            else
            {
                counter = (int)ViewState["Size"] - 1;
            }
            ViewState["Size"] = counter;
            lblMessage.Text = "Size: " + counter.ToString();
            if (counter <= 0)
            {
                btnDecrease.Enabled = false;
            }
            else
            {
                btnIncrease.Enabled = true;
            }
        }
    }
}