using System;
using System.Web.UI.WebControls;

namespace Cross_Page_Posting
{
    public partial class CrossPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        public string FullName
        {
            get { return txtFirstName.Text + " " + txtLastName.Text; }
        }
    }
}