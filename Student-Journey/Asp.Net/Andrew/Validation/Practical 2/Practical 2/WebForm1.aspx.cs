using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    Session["Name"] = txtName.Text;
            //    Session["Deposit"] = txtDeposit.Text;
            //    Session["Years"] = txtYear.Text;
            //    Session["Interest"] = txtInterest.Text;
            //    Response.Redirect("WebForm2.aspx?");
            //}
        }

        protected void btnCalc_Click(object sender, EventArgs e)
        {
            Session["Name"] = txtName.Text;
            Session["Deposit"] = txtDeposit.Text;
            Session["Years"] = txtYear.Text;
            Session["Interest"] = txtInterest.Text;
            Response.Redirect("WebForm2.aspx?");
        }
    }
}