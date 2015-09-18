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
    public partial class frmAddShopService : MetroForm
    {
        public frmAddShopService()
        {
            InitializeComponent();
        }

        private void frmShopService_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            int shopServiceID = int.Parse(txtShopServiceID.Text.Trim());
            int shopID = int.Parse(txtShopID.Text.Trim());
            int serviceID = int.Parse(txtServiceID.Text.Trim());
            string serviceName = txtServiceName.Text.Trim();

            try
            {
                StreamWriter myWriter = new StreamWriter(@"Files\newShopService.txt", true);
                myWriter.WriteLine(shopServiceID.ToString() + "#" + shopID.ToString() + "#" + serviceID.ToString() + "#" + serviceName.ToString());
                myWriter.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
