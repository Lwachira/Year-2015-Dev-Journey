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
    public partial class frmShopService : MetroForm
    {
        private adminShopService asps = new adminShopService();
        public frmShopService()
        {
            InitializeComponent();
        }

        private void frmShopService_Load(object sender, EventArgs e)
        {
            dgvShopService.DataSource = asps.GetAllShopService();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvShopService_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtShopServiceID.Text = dgvShopService[0, e.RowIndex].Value.ToString();
                txtShopID.Text = dgvShopService[1, e.RowIndex].Value.ToString();
                txtServiceID.Text = dgvShopService[2, e.RowIndex].Value.ToString();
                txtServiceName.Text = dgvShopService[3, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShopServiceFile_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtShopServiceID.Text = dgvShopServiceFile[0, e.RowIndex].Value.ToString();
                txtShopID.Text = dgvShopServiceFile[1, e.RowIndex].Value.ToString();
                txtServiceID.Text = dgvShopServiceFile[2, e.RowIndex].Value.ToString();
                txtServiceName.Text = dgvShopServiceFile[3, e.RowIndex].Value.ToString();
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
                int shopServiceID = int.Parse(txtShopServiceID.Text.Trim());
                int shopID = int.Parse(txtShopID.Text.Trim());
                int serviceID = int.Parse(txtServiceID.Text.Trim());
                string serviceName = txtServiceName.Text.Trim();

                asps = new adminShopService(shopServiceID, shopID, serviceID, serviceName);
                dgvShopService.DataSource = asps.InsertShopService();
                dgvShopService.DataSource = asps.GetAllShopService();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int shopServiceID = int.Parse(txtShopServiceID.Text.Trim());
                int shopID = int.Parse(txtShopID.Text.Trim());
                int serviceID = int.Parse(txtServiceID.Text.Trim());
                string serviceName = txtServiceName.Text.Trim();

                asps = new adminShopService(shopServiceID, shopID, serviceID, serviceName);
                dgvShopService.DataSource = asps.UpdateShopService();
                dgvShopService.DataSource = asps.GetAllShopService();
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
                int shopServiceID = int.Parse(txtShopServiceID.Text.Trim());
                int shopID = int.Parse(txtShopID.Text.Trim());
                int serviceID = int.Parse(txtServiceID.Text.Trim());
                string serviceName = txtServiceName.Text.Trim();
                StreamWriter file = new StreamWriter(@"Files\deletedShopService.txt", true);
                file.WriteLine(shopServiceID.ToString() + "#" + shopID.ToString() + "#" + serviceID.ToString() + "#" + serviceName.ToString());
                file.Close();
                asps = new adminShopService(shopServiceID, shopID, serviceID, serviceName);
                dgvShopService.DataSource = asps.DeleteShopService();
                dgvShopService.DataSource = asps.GetAllShopService();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                dgvShopServiceFile.DataSource = helperClass.DataTableFromTextFile(@"Files\newShopService.txt", '#');
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeletedCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                dgvShopServiceFile.DataSource = helperClass.DataTableFromTextFile(@"Files\deletedShopService.txt", '#');
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
