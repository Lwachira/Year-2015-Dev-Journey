using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ErrorHandeling
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal N1, N2;

                N1 = decimal.Parse(txtFirstNum.Text);
                N2 = decimal.Parse(txtSecondNum.Text);

                lblMesage.Text = Calculate(N1, N2);
            }
            catch (Exception ex)
            {
                lblMesage.Text = ex.Message;
            }
        }

        protected string Calculate(decimal num1, decimal num2)
        {
            decimal Answer = 0;
            if (rdMath.SelectedIndex == 0)
            {
                Answer = num1 + num2;
            }
            else if (rdMath.SelectedIndex == 1)
            {
                Answer = num1 - num2;
            }
            else if (rdMath.SelectedIndex == 2)
            {
                Answer = num1 * num2;
            }
            else
            {
                Answer = num1 / num2;
            }

            return Answer.ToString();
        }
    }
}