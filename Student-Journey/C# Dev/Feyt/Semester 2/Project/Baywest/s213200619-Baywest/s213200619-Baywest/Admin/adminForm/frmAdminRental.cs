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
    public partial class frmAdminRental : MetroForm
    {
        private adminRentalAgreement ara = new adminRentalAgreement();

        public frmAdminRental()
        {
            InitializeComponent();
        }

        private void frmRental_Load(object sender, EventArgs e)
        {
            metroDgvRental.DataSource = ara.GetAllRental();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroDgvRental_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRentalID.Text = metroDgvRental[0, e.RowIndex].Value.ToString();
                txtCustID.Text = metroDgvRental[1, e.RowIndex].Value.ToString();
                txtShopID.Text = metroDgvRental[2, e.RowIndex].Value.ToString();
                txtStartDate.Text = metroDgvRental[3, e.RowIndex].Value.ToString();
                txtEndDate.Text = metroDgvRental[4, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int rentalID = int.Parse(txtRentalID.Text.Trim());
            int customerID = int.Parse(txtCustID.Text.Trim());
            int shopID = int.Parse(txtShopID.Text.Trim());
            string rentalStartDate = txtStartDate.Text.Trim();
            string rentalEndDate = txtEndDate.Text.Trim();

            try
            {
                ara = new adminRentalAgreement(rentalID, customerID, shopID, rentalStartDate, rentalEndDate);
                metroDgvRental.DataSource = ara.InsertRental();
                metroDgvRental.DataSource = ara.GetAllRental();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int rentalID = int.Parse(txtRentalID.Text.Trim());
            int customerID = int.Parse(txtCustID.Text.Trim());
            int shopID = int.Parse(txtShopID.Text.Trim());
            string rentalStartDate = txtStartDate.Text.Trim();
            string rentalEndDate = txtEndDate.Text.Trim();
            try
            {
                StreamWriter file = new StreamWriter(@"Files\deletedRental.txt", true);

                file.WriteLine(rentalID.ToString() + "#" + customerID.ToString() + "#" + shopID.ToString() + "#" + rentalStartDate.ToString() + "#" + rentalEndDate.ToString());
                file.Close();
                ara = new adminRentalAgreement(rentalID, customerID, shopID, rentalStartDate, rentalEndDate);
                metroDgvRental.DataSource = ara.DeleteRental();
                metroDgvRental.DataSource = ara.GetAllRental();
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
                metroDgvFileRental.DataSource = helperClass.DataTableFromTextFile(@"Files\deletedRental.txt", '#');
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                metroDgvFileRental.DataSource = helperClass.DataTableFromTextFile(@"Files\newRental.txt", '#');
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void metroDgvFileRental_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRentalID.Text = metroDgvFileRental[0, e.RowIndex].Value.ToString();
                txtCustID.Text = metroDgvFileRental[1, e.RowIndex].Value.ToString();
                txtShopID.Text = metroDgvFileRental[2, e.RowIndex].Value.ToString();
                txtStartDate.Text = metroDgvFileRental[3, e.RowIndex].Value.ToString();
                txtEndDate.Text = metroDgvFileRental[4, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rentalID = int.Parse(txtRentalID.Text.Trim());
            int customerID = int.Parse(txtCustID.Text.Trim());
            int shopID = int.Parse(txtShopID.Text.Trim());
            string rentalStartDate = txtStartDate.Text.Trim();
            string rentalEndDate = txtEndDate.Text.Trim();
            try
            {
                ara = new adminRentalAgreement(rentalID, customerID, shopID, rentalStartDate, rentalEndDate);
                metroDgvRental.DataSource = ara.UpdateRental();
                metroDgvRental.DataSource = ara.GetAllRental();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
