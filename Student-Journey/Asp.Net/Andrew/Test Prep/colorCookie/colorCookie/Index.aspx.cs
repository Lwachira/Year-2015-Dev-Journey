using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace colorCookie
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie biscuit = Request.Cookies["Color"];
            if (biscuit == null)
            {
                biscuit = new HttpCookie("Color");
                biscuit["Theme"] = "Blue";

                Response.Cookies.Add(biscuit);
            }
            lblMessage.Text = biscuit["Theme"];
            lstColor.BackColor = Color.FromName(biscuit["Theme"]);
        }

        protected void lstColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            HttpCookie biscuit = Request.Cookies["Color"];
            biscuit["Theme"] = lstColor.Text;
            lblMessage.Text = biscuit["Theme"];
            lstColor.BackColor = Color.FromName(biscuit["Theme"]);
            biscuit.Expires = DateTime.Now.AddDays(10);
            Response.Cookies.Add(biscuit);
        }
    }
}