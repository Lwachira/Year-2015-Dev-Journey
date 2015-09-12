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

namespace s213200619_Baywest.User.userForm
{
    public partial class frmAddShopInspection : MetroForm
    {
        public frmAddShopInspection()
        {
            InitializeComponent();
        }

        private void frmAddShopInspection_Load(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            int inspectionID = int.Parse(txtShopInspectionID.Text.Trim());
            int shopID = int.Parse(txtShopID.Text.Trim());
            int serviceID = int.Parse(txtServiceID.Text.Trim());
            string startDate = dtStart.Text.Trim();
            string endDate = dtEnd.Text.Trim();

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
