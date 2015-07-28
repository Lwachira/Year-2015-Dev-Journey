using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
namespace Web_Controls
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(typeof(BorderStyle));
            if (rdoOne.Checked)
            {
                myCell.BorderStyle = (BorderStyle)converter.ConvertFromString(rdoOne.Text);
            }
            else if (rdoTwo.Checked)
            {
                myCell.BorderStyle = (BorderStyle)converter.ConvertFromString(rdoTwo.Text);

            }
            else
            {
                myCell.BorderStyle = (BorderStyle)converter.ConvertFromString(rdoThree.Text);
            }

            lblMessage.Text = txtText.Text;
        }



        protected void lstColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCell.BackColor = ColorTranslator.FromHtml(lstColor.SelectedValue.ToString());
        }

        protected void btnIncrease_Click(object sender, EventArgs e)
        {
            lblMessage.Font.Size = FontUnit.Large;
        }

        protected void btnDecrease_Click(object sender, EventArgs e)
        {
            lblMessage.Font.Size = FontUnit.Small;
        }
    }
}