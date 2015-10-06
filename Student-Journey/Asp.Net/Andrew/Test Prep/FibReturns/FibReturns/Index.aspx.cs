using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FibReturns
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnDoIT_Click(object sender, EventArgs e)
        {
            int i = 0;
            int Fib1 = 0;
            int Fib2 = 1;
            int temp;

            lstFib.Items.Clear();

            if (int.Parse(txtFrom.Text) == 1 && int.Parse(txtTo.Text) == 1)
            {
                lstFib.Items.Add(Fib1.ToString());
            }
            else if (int.Parse(txtFrom.Text) == 1 && int.Parse(txtTo.Text) >= 2)
            {
                lstFib.Items.Add(Fib1.ToString());
                lstFib.Items.Add(Fib2.ToString());
            }
            else if (int.Parse(txtFrom.Text) == 2)
            {
                lstFib.Items.Add(Fib2.ToString());
            }

            for (i = 3; i <= int.Parse(txtTo.Text); i++)
            {
                temp = Fib2;
                Fib2 = Fib1 + Fib2;
                Fib1 = temp;
                if (i >= int.Parse(txtFrom.Text))
                {
                    lstFib.Items.Add(Fib2.ToString());
                }
            }
        }
    }
}