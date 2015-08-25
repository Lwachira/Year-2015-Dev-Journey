using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_1__Validation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void valCustom_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                if (int.Parse(args.Value) > 0)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
            catch (Exception)
            {
                args.IsValid = false;
            }
        }
    }
}