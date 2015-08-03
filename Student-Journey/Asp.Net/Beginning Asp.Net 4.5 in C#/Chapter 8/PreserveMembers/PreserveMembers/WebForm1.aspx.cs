using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PreserveMembers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string contents;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                contents = (string)ViewState["contents"];
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState["contents"] = contents;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            contents = txtValue.Text;
            txtValue.Text = "";

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            txtValue.Text += contents + "\t"; 
        }
    }
}