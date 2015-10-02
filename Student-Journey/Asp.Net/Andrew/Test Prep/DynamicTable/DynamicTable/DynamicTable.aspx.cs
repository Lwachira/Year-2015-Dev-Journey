using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicTable
{
    public partial class DynamicTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnDraw_Click(object sender, EventArgs e)
        {
            int rows = int.Parse(txtRows.Text);
            int cols = int.Parse(txtCols.Text);

            dTable.BorderWidth = 1;
            for (int i = 0; i < rows; i++)
            {
                TableRow row = new TableRow();
                dTable.Controls.Add(row);
                for (int c = 0; c < cols; c++)
                {
                    TableCell cell = new TableCell();
                    cell.Text = "Row " + i.ToString() + " Col " + c.ToString();
                    cell.BorderStyle = BorderStyle.Solid;
                    row.Controls.Add(cell);
                }
            }

            dTable.Visible = true;
        }
    }
}