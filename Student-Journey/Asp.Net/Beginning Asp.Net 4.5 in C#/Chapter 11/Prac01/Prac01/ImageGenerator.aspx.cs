using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
namespace Prac01
{
    public partial class ImageGenerator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(300, 50);
            Graphics g = Graphics.FromImage(image);
            
        }
    }
}