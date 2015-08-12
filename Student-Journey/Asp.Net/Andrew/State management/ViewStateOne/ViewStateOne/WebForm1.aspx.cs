using System;

namespace ViewStateOne
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIncrement_Click(object sender, EventArgs e)
        {
            //int counter;
            //if (ViewState["Counter"] == null)
            //{
            //    counter = 1;
            //}
            //else
            //{
            //    counter = (int)ViewState["Counter"] + 1;
            //}

            //ViewState["Counter"] = counter;
            //lblCounter.Text = "Counter: " + counter.ToString();


            Customer cust = new Customer("John", "Snow");
            ViewState["CurrentCustomer"] = cust;


            lblCounter.Text = "Customer Details: " + cust.FirstName + " Last Name: " + cust.LastName;

        }
    }
}