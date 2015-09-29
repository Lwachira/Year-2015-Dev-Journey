using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO.Net
{
    public partial class TableRelationships : System.Web.UI.Page
    {
        private string connctionString = WebConfigurationManager.ConnectionStrings["Pubs"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                CreateList();
            }
        }

        private void CreateList()
        {
            string sql = "Select au_lname,au_fname,au_id From Authors";
            SqlConnection con = new SqlConnection(connctionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(cmd);
            DataSet dsPubs = new DataSet();
        }
    }
}