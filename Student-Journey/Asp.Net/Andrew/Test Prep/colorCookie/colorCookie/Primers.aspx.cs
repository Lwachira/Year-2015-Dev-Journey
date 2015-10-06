using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace colorCookie
{
    public partial class Primers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["Primer"] == null)
            {
                ViewState["Primer"] = "2";
                lblMessage.Text = "2";
                btnPrev.Enabled = false;
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            int Primer;
            btnPrev.Enabled = true;
            Primer = int.Parse(ViewState["Primer"].ToString());
            if (Primer == 2)
            {
                Primer = 3;
            }
            else
            {
                do
                {
                    Primer += 2;
                } while (CheckPrimer(Primer) == false);
            }
            lblMessage.Text = Primer.ToString();
            ViewState["Primer"] = Primer.ToString();
        }

        private bool CheckPrimer(int primer)
        {
            int count = 1;
            int divisor = 2;
            do
            {
                if (primer % divisor == 0)

                    count++;
                divisor++;
            } while (count == 1 && divisor != primer);
            if (count == 1)
                return true;
            else
            {
                return false;
            }
        }

        protected void btnPrev_Click(object sender, EventArgs e)
        {
            int Primer;
            Primer = int.Parse(ViewState["Primer"].ToString());
            if (Primer == 3)
            {
                ViewState["Primer"] = "2";
                lblMessage.Text = "2";
                btnPrev.Enabled = false;
            }
            else
            {
                do
                {
                    Primer -= 2;
                } while (CheckPrimer(Primer) == false);
            }

            lblMessage.Text = Primer.ToString();
            ViewState["Primer"] = Primer.ToString();
        }
    }
}