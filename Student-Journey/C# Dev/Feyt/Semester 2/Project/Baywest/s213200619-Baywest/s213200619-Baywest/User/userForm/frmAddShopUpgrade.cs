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
    public partial class frmAddShopUpgrade : MetroForm
    {
        public frmAddShopUpgrade()
        {
            InitializeComponent();
        }

        private void frmAddShopUpgrade_Load(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            int upgradeID = int.Parse(txtShopUpgradeID.Text.Trim());
            int shopID = int.Parse(txtShopID.Text.Trim());
            int serviceID = int.Parse(txtServiceID.Text.Trim());
            string startDate = dtStart.Text.Trim();
            string endDate = dtEnd.Text.Trim();
            string upgradeTask = txtUpgradeTask.Text.Trim();
            string completionTask = txtMessage.Text.Trim();
            try
            {
                StreamWriter myWriter = new StreamWriter(@"Files\newShopUpgrade.txt", true);
                myWriter.WriteLine(upgradeID.ToString() + "#" + shopID.ToString() + "#" + serviceID.ToString() + "#" + startDate.ToString() + "#" + endDate.ToString() + "#" + upgradeTask.ToString() + "#" + completionTask.ToString());
                myWriter.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
