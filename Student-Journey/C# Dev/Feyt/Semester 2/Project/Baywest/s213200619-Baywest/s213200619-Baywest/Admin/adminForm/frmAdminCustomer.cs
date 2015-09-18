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
    public partial class frmAdminCustomer : MetroForm
    {
        private adminCustomer ac = new adminCustomer();
        public frmAdminCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            metroDgvCustomer.DataSource = ac.GetAllCustomer();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            metroDgvFileCustomer.DataSource = helperClass.DataTableFromTextFile(@"Files\NewUser.txt", '#');
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void metroDgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                metroTxtID.Text = metroDgvCustomer[0, e.RowIndex].Value.ToString();
                metroTxtCusName.Text = metroDgvCustomer[1, e.RowIndex].Value.ToString();
                metroTxtCusCell.Text = metroDgvCustomer[2, e.RowIndex].Value.ToString();
                metroTxtLoginID.Text = metroDgvCustomer[3, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void metroDgvFileCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                metroTxtID.Text = metroDgvFileCustomer[0, e.RowIndex].Value.ToString();
                metroTxtCusName.Text = metroDgvFileCustomer[1, e.RowIndex].Value.ToString();
                metroTxtCusCell.Text = metroDgvFileCustomer[2, e.RowIndex].Value.ToString();
                metroTxtLoginID.Text = metroDgvFileCustomer[3, e.RowIndex].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(metroTxtID.Text.Trim());
            string customerName = metroTxtCusName.Text.Trim();
            string customerCell = metroTxtCusCell.Text.Trim();
            int loginID = int.Parse(metroTxtLoginID.Text.Trim());
            ac = new adminCustomer(customerID, customerName, customerCell, loginID);
            metroDgvCustomer.DataSource = ac.InsertCustomer();
            metroDgvCustomer.DataSource = ac.GetAllCustomer();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(metroTxtID.Text.Trim());
            string customerName = metroTxtCusName.Text.Trim();
            string customerCell = metroTxtCusCell.Text.Trim();
            int loginID = int.Parse(metroTxtLoginID.Text.Trim());
            ac = new adminCustomer(customerID, customerName, customerCell, loginID);
            metroDgvCustomer.DataSource = ac.UpdateCustomer();
            metroDgvCustomer.DataSource = ac.GetAllCustomer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(metroTxtID.Text.Trim());
            string customerName = metroTxtCusName.Text.Trim();
            string customerCell = metroTxtCusCell.Text.Trim();
            int loginID = int.Parse(metroTxtLoginID.Text.Trim());
            StreamWriter file = new StreamWriter(@"Files\deletedCustomer.txt", true);

            file.WriteLine(customerID.ToString() + "#" + customerName.ToString() + "#" + customerCell.ToString() + "#" + loginID.ToString());
            file.Close();
            ac = new adminCustomer(customerID, customerName, customerCell, loginID);
            metroDgvCustomer.DataSource = ac.DeleteCustomer();
            metroDgvCustomer.DataSource = ac.GetAllCustomer();
        }

        private void btnDeletedCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                metroDgvFileCustomer.DataSource = helperClass.DataTableFromTextFile(@"Files\deletedCustomer.txt", '#');
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
