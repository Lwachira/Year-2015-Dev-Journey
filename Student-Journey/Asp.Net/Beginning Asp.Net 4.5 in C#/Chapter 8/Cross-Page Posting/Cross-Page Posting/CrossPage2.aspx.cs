using System;

namespace Cross_Page_Posting
{
    public partial class CrossPage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                lblMessage.Text = "You came from the previous page titled " + PreviousPage.Title;
            }

            CrossPage1 myPage1 = PreviousPage as CrossPage1;
            if (PreviousPage != null)
            {
                lblMessage.Text = "You typed in this: " + myPage1.FullName;
            }
        }
    }
}