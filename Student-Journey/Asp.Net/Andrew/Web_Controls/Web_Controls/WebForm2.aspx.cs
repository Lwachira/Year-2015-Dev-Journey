using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Controls
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDraw_Click(object sender, EventArgs e)
        {
            int rows = 0, cols = 0;

            try
            {
                rows = int.Parse(txtRow.Text);
                cols = int.Parse(txtCols.Text);
            }
            catch (Exception f)
            {
                lblError.Visible = true;
                lblError.Text = f.Message;

            }


            tblOne.Controls.Clear();
            try
            {
                for (int r = 0; r < rows; r++)
                {
                    TableRow tblRow = new TableRow();
                    tblOne.Controls.Add(tblRow);
                    for (int c = 0; c < cols; c++)
                    {
                        TableCell tblCell = new TableCell();
                        tblCell.Text = "Row " + r.ToString() + "Col " + c.ToString();
                        tblCell.BorderStyle = BorderStyle.Inset;
                        tblCell.BorderWidth = Unit.Pixel(1);
                        tblRow.Controls.Add(tblCell);

                    }
                }
            }
            catch (Exception)
            {


            }




        }
    }
}
