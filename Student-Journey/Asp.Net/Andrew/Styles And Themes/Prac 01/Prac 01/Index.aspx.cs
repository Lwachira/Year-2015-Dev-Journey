using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prac_01
{
    public partial class Index : System.Web.UI.Page
    {
        private static string myTheme;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            lblText.Text = txtFirstName.Text + " " + txtLastName.Text;
        }

        protected void rdoTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            myTheme = rdoTheme.SelectedValue;
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (myTheme != null && myTheme.Length != 0)
            {
                Page.Theme = myTheme;
            }
        }
    }
}