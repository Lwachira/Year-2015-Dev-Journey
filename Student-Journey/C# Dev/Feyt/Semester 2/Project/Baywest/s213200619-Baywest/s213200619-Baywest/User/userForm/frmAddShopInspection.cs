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
            string inspectionTask = txtInspectionTask.Text.Trim();
            string message = txtMessage.Text.Trim();

            try
            {
                StreamWriter myWriter = new StreamWriter(@"Files\newShopInspection.txt", true);
                myWriter.WriteLine(inspectionID.ToString() + "#" + shopID.ToString() + "#" + serviceID.ToString() + "#" + startDate.ToString() + "#" + endDate.ToString() + "#" + inspectionTask.ToString() + "#" + message.ToString());
                myWriter.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
