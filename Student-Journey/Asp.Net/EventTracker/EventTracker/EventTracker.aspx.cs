using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventTracker
{
    public partial class EventTracker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Log("<<Page_Load>>");
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {

            Log("Page_PreRender");
        }

        private void Log(string v)
        {
            lstEvents.Items.Add(v);
           
            //Select the last item from the lstEvent so the most recent entries are visible
            lstEvents.SelectedIndex = lstEvents.Items.Count - 1;
        }

        protected void CtrlChanged(object sender, EventArgs e)
        {
            string ctrlName = ((Control)sender).ID;
            Log(ctrlName + " Changed");
        }
    }
}