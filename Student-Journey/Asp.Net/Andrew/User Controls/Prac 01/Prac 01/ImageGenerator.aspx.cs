using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;
namespace Prac_01
{
    public partial class ImageGenerator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string name = Request.QueryString["Name"];
            string images = Request.QueryString["Image"];
            images = images + ".gif";
            Bitmap image = new Bitmap(400, 200);
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(Brushes.Yellow, 0, 0, 400, 200);
            g.DrawRectangle(Pens.Red, 0, 0, 399, 199);
            Font font = new Font("Arial", 20, FontStyle.Italic);
            g.DrawString(name, font, Brushes.Red, 10, 0);
            System.Drawing.Image icon = System.Drawing.Image.FromFile(Server.MapPath(images.ToString()));
            g.DrawImageUnscaled(icon, 345, 1);

            Response.ContentType = "image/gif";
            image.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Gif);
            g.Dispose();
            image.Dispose();



        }
    }
}