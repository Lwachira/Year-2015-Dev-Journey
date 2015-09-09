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
            if (rdOne.Checked)
            {
                image = rdOne.Text;
            }
            else if (rdTwo.Checked)
            {
                image = rdTwo.Text;
            }
            else if (rdThree.Checked)
            {
                image = rdThree.Text;

            }
            else
            {

            }


            message = txtMessage.Text;

            imgPic.ImageUrl = "ImageGenerator.aspx?Name=" + message;
            imgPic.Visible = true;
        }
    }
}