using System;
using MetroFramework.Forms;
using s213200619_Baywest.Admin.adminForm;

namespace s213200619_Baywest.Admin.adminForm
{
    public partial class frmAdmin : MetroForm
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void metroLogin_Click(object sender, EventArgs e)
        {
            frmAdminLoginDetails loginDetails = new frmAdminLoginDetails();
            loginDetails.ShowDialog();
        }

        private void metroCustomer_Click(object sender, EventArgs e)
        {
            frmAdminCustomer customer = new frmAdminCustomer();
            customer.ShowDialog();

        }

        private void metroRentalAgreement_Click(object sender, EventArgs e)
        {
            frmAdminRental rental = new frmAdminRental();
            rental.ShowDialog();
        }

        private void metroShop_Click(object sender, EventArgs e)
        {
            frmAdminShop shop = new frmAdminShop();
            shop.ShowDialog();


        }
    }
}
