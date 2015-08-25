using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hi " + Session["Name"].ToString();
            lblDisplay.Text = "A Deposit of " + Session["Deposit"].ToString() + " Invested for " + Session["Years"].ToString() + " years";
            lblDisplay.Text += " at " + Session["Interest"] + " % " + "will yield the below returns";

            CalculateReturn();
        }

        private void CalculateReturn()
        {
            lstBoxDisplay.Text = "Year \t\t Value";
        }
    }
}