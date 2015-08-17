using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheQueryString
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((!this.IsPostBack))
            {
                lstItems.Items.Add("Ecno Sofa");
                lstItems.Items.Add("Supreme Leather Drapery");
                lstItems.Items.Add("Threadbare Carpet");
                lstItems.Items.Add("Antique Lamp");
                lstItems.Items.Add("Retro-Finish Jacuzzi");
            }
        }

        protected void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void btnViewInformation_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstItems.SelectedIndex == -1)
                {
                    lblError.Text = "You must select an item";
                }
                else
                {
                    string url = "QueryStringRecipient.aspx?";
                    url += "Item=" + Server.UrlEncode(lstItems.SelectedItem.ToString()) + "&";
                    url += "Mode=" + chkDetails.Checked.ToString();
                    Response.Redirect(url);
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}