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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string image = "";
            string message;



            message = txtMessage.Text;
            image = rdoImage.SelectedValue.ToString();
            imgPic.ImageUrl = "ImageGenerator.aspx?Name=" + message + "&Image=" + image;
            imgPic.Visible = true;
        }
    }
}