using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multi_Select
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnDo_Click(object sender, EventArgs e)
        {
            txtValues.Text = "";
            foreach (ListItem item in lstNumbers.Items)
            {
                if (item.Selected)
                {
                    txtValues.Text = txtValues.Text + "\n" + item.Text;
                }
            }
        }
    }
}