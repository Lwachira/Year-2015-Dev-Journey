using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecard
{
    public partial class Ecard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                lstBackColor.Items.Add("White");
                lstBackColor.Items.Add("Red");
                lstBackColor.Items.Add("Green");
                lstBackColor.Items.Add("Blue");
                lstBackColor.Items.Add("Yellow");

                lstFontName.Items.Add("Times New Roman");
                lstFontName.Items.Add("Arial");
                lstFontName.Items.Add("Verdana");
                lstFontName.Items.Add("Tahoma");

                ListItem item = new ListItem();
                item.Text = BorderStyle.None.ToString();

            }
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}