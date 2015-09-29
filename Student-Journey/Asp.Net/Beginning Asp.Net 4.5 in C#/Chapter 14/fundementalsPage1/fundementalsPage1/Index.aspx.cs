using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace fundementalsPage1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> fruit = new List<string>();
            fruit.Add("Kiwi");
            fruit.Add("Pear");
            fruit.Add("Mango");
            lstFruits.DataSource = fruit;
            lstFruits.DataBind();
        }
    }
}