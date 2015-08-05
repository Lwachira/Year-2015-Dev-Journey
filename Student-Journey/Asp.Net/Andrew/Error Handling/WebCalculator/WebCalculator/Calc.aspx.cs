using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalculator
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void txtCal_Click(object sender, EventArgs e)
        {
            int num1 = 1;
            int num2 = 1;

            try
            {
                num1 = int.Parse(txtNum1.Text);
                num2 = int.Parse(txtNum2.Text);
            }
            catch (Exception ex)
            {

                lblMessage.Text = ex.Message;
            }



            try
            {
                if (int.Parse(txtNum1.Text) > 0 || int.Parse(txtNum1.Text) < 0 && int.Parse(txtNum2.Text) > 0 || int.Parse(txtNum2.Text) < 0)
                {
                    if (rdoListMath.SelectedItem.Text == "Add")
                    {
                        lblMessage.Text = (num1 + num2).ToString();
                    }
                    if (rdoListMath.SelectedItem.Text == "Subtract")
                    {
                        lblMessage.Text = (num1 - num2).ToString();
                    }

                    if (rdoListMath.SelectedItem.Text == "Divide")
                    {

                        lblMessage.Text = (num1 / num2).ToString();


                    }

                    if (rdoListMath.SelectedItem.Text == "Multiply")
                    {
                        lblMessage.Text = (num1 * num2).ToString();
                    }
                }


            }
            catch (DivideByZeroException)
            {
                lblMessage.Text = "Please dont divide by zero";
            }
            catch (Exception)
            {

                lblMessage.Text = "Please enter a number";

            }

           



            txtNum1.Text = "";
            txtNum2.Text = "";
        }
    }
}