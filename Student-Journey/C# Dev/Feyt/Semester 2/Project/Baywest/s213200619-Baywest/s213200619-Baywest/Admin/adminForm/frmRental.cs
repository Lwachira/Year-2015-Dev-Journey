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

namespace s213200619_Baywest.Admin.adminForm
{
    public partial class frmRental : MetroForm
    {
        private adminRentalAgreement ara = new adminRentalAgreement();

        public frmRental()
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
    }
}
