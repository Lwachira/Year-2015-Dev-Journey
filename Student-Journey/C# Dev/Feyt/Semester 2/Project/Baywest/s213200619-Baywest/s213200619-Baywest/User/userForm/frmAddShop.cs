using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace s213200619_Baywest.User.userForm
{
    public partial class frmAddShop : MetroForm
    {
        public frmAddShop()
        {
            InitializeComponent();
        }

        private void frmAddShop_Load(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            int shopID = int.Parse(txtShopID.Text.Trim());
            string shopName = txtShopName.Text.Trim();
            string shopSize = txtShopSize.Text.Trim();


            try
            {
                StreamWriter myWriter = new StreamWriter(@"Files\newShop.txt", true);
                myWriter.WriteLine(shopID.ToString() + "#" + shopName.ToString() + "#" + shopSize.ToString());
                myWriter.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
