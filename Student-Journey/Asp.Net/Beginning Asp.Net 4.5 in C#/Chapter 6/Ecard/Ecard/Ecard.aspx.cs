using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Text;
using System.ComponentModel;

namespace Ecard
{
    public partial class Ecard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //lstBackColor.Items.Add("White");
                //lstBackColor.Items.Add("Red");
                //lstBackColor.Items.Add("Green");
                //lstBackColor.Items.Add("Blue");
                //lstBackColor.Items.Add("Yellow");

                //lstFontName.Items.Add("Times New Roman");
                //lstFontName.Items.Add("Arial");
                //lstFontName.Items.Add("Verdana");
                //lstFontName.Items.Add("Tahoma");

                string[] colorArray = Enum.GetNames(typeof(KnownColor));
                lstBackColor.DataSource = colorArray;
                lstBackColor.DataBind();
                lstForeColor.DataSource = colorArray;
                lstForeColor.DataBind();

                InstalledFontCollection fonts = new InstalledFontCollection();

                foreach (FontFamily font in fonts.Families)
                {
                    lstFontName.Items.Add(font.Name);
                }

                string[] borderArray = Enum.GetNames(typeof(BorderStyle));
                lstBorder.DataSource = borderArray;
                lstBorder.DataBind();

                lstBorder.SelectedIndex = 0;

                imgDefault.ImageUrl = "defaultpic.png";


            }
        }

        protected void cmdUpdate_Click(object sender, EventArgs e)
        {
            UpdateCard();




        }

        protected void txtGreeting_TextChanged(object sender, EventArgs e)
        {

        }

        protected void controlChanged(object sender, EventArgs e)
        {
            UpdateCard();
        }

        private void UpdateCard()
        {
            pnlCard.BackColor = Color.FromName(lstBackColor.SelectedItem.Text);

            lblGreeting.Font.Name = lstFontName.SelectedItem.Text;

            try
            {
                if (int.Parse(txtFontSize.Text) > 0)
                {
                    lblGreeting.Font.Size = FontUnit.Point(int.Parse(txtFontSize.Text));
                }
            }
            catch (Exception f)
            {

                lblGreeting.Text = f.Message;
            }


            TypeConverter converter = TypeDescriptor.GetConverter(typeof(BorderStyle));

            pnlCard.BorderStyle = (BorderStyle)converter.ConvertFromString(lstBorder.SelectedItem.ToString());

            if (chkPicture.Checked)
            {
                imgDefault.Visible = true;
            }
            else
            {
                imgDefault.Visible = false;
            }

            lblGreeting.Text = txtGreeting.Text;

        }
    }
}