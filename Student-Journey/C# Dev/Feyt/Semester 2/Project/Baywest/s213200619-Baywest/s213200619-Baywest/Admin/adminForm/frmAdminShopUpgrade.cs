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
using s213200619_Baywest.Admin.adminClass;
using System.IO;

namespace s213200619_Baywest.Admin.adminForm
{
    public partial class frmAdminShopUpgrade : MetroForm
    {
        private adminShopUpgrade asu = new adminShopUpgrade();
        public frmAdminShopUpgrade()
        {
            InitializeComponent();
        }

        private void frmAdminShopUpgrade_Load(object sender, EventArgs e)
        {
            try
            {
                dgvShopUpgrade.DataSource = asu.GetAllShopUpgrade();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvShopUpgrade_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUpgradeID.Text = dgvShopUpgrade[0, e.RowIndex].Value.ToString();
                txtShopID.Text = dgvShopUpgrade[1, e.RowIndex].Value.ToString();
                txtServiceID.Text = dgvShopUpgrade[2, e.RowIndex].Value.ToString();


                dtStart.Value = DateTime.Parse(dgvShopUpgrade[3, e.RowIndex].Value.ToString());

                dtEnd.Value = DateTime.Parse(dgvShopUpgrade[4, e.RowIndex].Value.ToString());
                txtUpgradeTask.Text = dgvShopUpgrade[5, e.RowIndex].Value.ToString();
                txtMessage.Text = dgvShopUpgrade[6, e.RowIndex].Value.ToString();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int upgradeID;
                int shopID;
                int serviceID;
                string startDate;
                string endDate;
                string upgradeTask;
                string completionMessage;

                upgradeID = int.Parse(txtUpgradeID.Text.Trim());
                shopID = int.Parse(txtShopID.Text.Trim());
                serviceID = int.Parse(txtServiceID.Text.Trim());
                startDate = dtStart.Text.Trim();
                endDate = dtEnd.Text.Trim();
                upgradeTask = txtUpgradeTask.Text.Trim();
                completionMessage = txtMessage.Text.Trim();

                asu = new adminShopUpgrade(upgradeID, shopID, serviceID, startDate, endDate, upgradeTask, completionMessage);
                dgvShopUpgrade.DataSource = asu.InsertShopUpgrade();
                dgvShopUpgrade.DataSource = asu.GetAllShopUpgrade();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int upgradeID;
                int shopID;
                int serviceID;
                string startDate;
                string endDate;
                string upgradeTask;
                string completionMessage;

                upgradeID = int.Parse(txtUpgradeID.Text.Trim());
                shopID = int.Parse(txtShopID.Text.Trim());
                serviceID = int.Parse(txtServiceID.Text.Trim());
                startDate = dtStart.Text.Trim();
                endDate = dtEnd.Text.Trim();
                upgradeTask = txtUpgradeTask.Text.Trim();
                completionMessage = txtMessage.Text.Trim();

                asu = new adminShopUpgrade(upgradeID, shopID, serviceID, startDate, endDate, upgradeTask, completionMessage);
                dgvShopUpgrade.DataSource = asu.UpdateShopUpgrade();
                dgvShopUpgrade.DataSource = asu.GetAllShopUpgrade();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int upgradeID;
                int shopID;
                int serviceID;
                string startDate;
                string endDate;
                string upgradeTask;
                string completionMessage;

                upgradeID = int.Parse(txtUpgradeID.Text.Trim());
                shopID = int.Parse(txtShopID.Text.Trim());
                serviceID = int.Parse(txtServiceID.Text.Trim());
                startDate = dtStart.Text.Trim();
                endDate = dtEnd.Text.Trim();
                upgradeTask = txtUpgradeTask.Text.Trim();
                completionMessage = txtMessage.Text.Trim();
                StreamWriter file = new StreamWriter(@"Files\deletedShopUpgrade.txt", true);
                file.WriteLine(upgradeID.ToString() + "#" + shopID.ToString() + "#" + serviceID.ToString() + "#" + startDate.ToString() + "#" + endDate.ToString() + "#" + upgradeTask.ToString() + "#" + completionMessage.ToString());
                file.Close();
                asu = new adminShopUpgrade(upgradeID, shopID, serviceID, startDate, endDate, upgradeTask, completionMessage);
                dgvShopUpgrade.DataSource = asu.DeleteShopUpgrade();
                dgvShopUpgrade.DataSource = asu.GetAllShopUpgrade();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewShopUpgrade_Click(object sender, EventArgs e)
        {
            try
            {
                dgvShopUpgradeFile.DataSource = helperClass.DataTableFromTextFile(@"Files\newShopUpgrade.txt", '#');
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShopUpgradeFile_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUpgradeID.Text = dgvShopUpgradeFile[0, e.RowIndex].Value.ToString();
                txtShopID.Text = dgvShopUpgradeFile[1, e.RowIndex].Value.ToString();
                txtServiceID.Text = dgvShopUpgradeFile[2, e.RowIndex].Value.ToString();


                dtStart.Value = DateTime.Parse(dgvShopUpgradeFile[3, e.RowIndex].Value.ToString());

                dtEnd.Value = DateTime.Parse(dgvShopUpgradeFile[4, e.RowIndex].Value.ToString());
                txtUpgradeTask.Text = dgvShopUpgradeFile[5, e.RowIndex].Value.ToString();
                txtMessage.Text = dgvShopUpgradeFile[6, e.RowIndex].Value.ToString();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeletedCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnDeletedCustomer_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgvShopUpgradeFile.DataSource = helperClass.DataTableFromTextFile(@"Files\deletedShopUpgrade.txt", '#');
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
