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
    public partial class frmAdminShop : MetroForm
    {
        public adminShop asp = new adminShop();
        public frmAdminShop()
        {
            InitializeComponent();
        }

        private void frmAdminShop_Load(object sender, EventArgs e)
        {
            try
            {
                dgvShop.DataSource = asp.GetAllShop();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                int shopID = int.Parse(txtShopID.Text.Trim());
                string shopName = txtShopName.Text.Trim();
                string shopSize = txtShopSIze.Text.Trim();
                asp = new adminShop(shopID, shopName, shopSize);
                dgvShop.DataSource = asp.InsertShop();
                dgvShop.DataSource = asp.GetAllShop();
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
                int shopID = int.Parse(txtShopID.Text.Trim());
                string shopName = txtShopName.Text.Trim();
                string shopSize = txtShopSIze.Text.Trim();
                asp = new adminShop(shopID, shopName, shopSize);
                dgvShop.DataSource = asp.UpdateShop();
                dgvShop.DataSource = asp.GetAllShop();
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
                int shopID = int.Parse(txtShopID.Text.Trim());
                string shopName = txtShopName.Text.Trim();
                string shopSize = txtShopSIze.Text.Trim();
                StreamWriter file = new StreamWriter(@"Files\deletedShop.txt", true);
                file.WriteLine(shopID.ToString() + "#" + shopName.ToString() + "#" + shopSize.ToString());
                file.Close();
                asp = new adminShop(shopID, shopName, shopSize);
                dgvShop.DataSource = asp.DeleteShop();
                dgvShop.DataSource = asp.GetAllShop();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtShopID.Text = dgvShop[0, e.RowIndex].Value.ToString();
                txtShopName.Text = dgvShop[1, e.RowIndex].Value.ToString();
                txtShopSIze.Text = dgvShop[2, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShopFile_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtShopID.Text = dgvShopFile[0, e.RowIndex].Value.ToString();
                txtShopName.Text = dgvShopFile[1, e.RowIndex].Value.ToString();
                txtShopSIze.Text = dgvShopFile[2, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            frmShopService shopService = new frmShopService();
            shopService.ShowDialog();
        }

        private void btnShopInspection_Click(object sender, EventArgs e)
        {
            frmAdminShopInspection shopInspection = new frmAdminShopInspection();
            shopInspection.ShowDialog();
        }

        private void btnShopUpgrade_Click(object sender, EventArgs e)
        {
            frmAdminShopUpgrade shopUpgrade = new frmAdminShopUpgrade();
            shopUpgrade.ShowDialog();
        }

        private void dgvShop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                dgvShopFile.DataSource = helperClass.DataTableFromTextFile(@"Files\newShop.txt", '#');
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeletedShop_Click(object sender, EventArgs e)
        {
            try
            {
                dgvShopFile.DataSource = helperClass.DataTableFromTextFile(@"Files\deletedShop.txt", '#');

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
