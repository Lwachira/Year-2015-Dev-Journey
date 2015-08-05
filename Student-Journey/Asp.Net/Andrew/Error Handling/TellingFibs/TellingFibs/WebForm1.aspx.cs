using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TellingFibs
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFib_Click(object sender, EventArgs e)
        {



            try
            {
                int start = int.Parse(txtStrtNum.Text);
                int end = int.Parse(txtEndNum.Text);
                GetFib(start, end);
            }
            catch (Exception ex)
            {

                txtresult.Text = ex.Message;

            }
        }

        private void GetFib(int start, int end)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < end; i++)
            {
                int temp = a;
                a = b;
                b = temp + a;
                if (i == start)
                {
                    txtresult.Text += b + "\n";

                }
            }

        }


    }
}