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
<<<<<<< HEAD
            frmAdminLoginDetails loginDetails = new frmAdminLoginDetails();
=======
            frmLoginDetails loginDetails = new frmLoginDetails();
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
            loginDetails.ShowDialog();
        }

        private void metroCustomer_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmAdminCustomer customer = new frmAdminCustomer();
=======
            frmCustomer customer = new frmCustomer();
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
            customer.ShowDialog();

        }

        private void metroRentalAgreement_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            frmAdminRental rental = new frmAdminRental();
=======
            frmRental rental = new frmRental();
>>>>>>> 064fcc474fdf023a259aa852b3154a726676540e
            rental.ShowDialog();
        }

        private void metroShop_Click(object sender, EventArgs e)
        {
            frmAdminShop shop = new frmAdminShop();
            shop.ShowDialog();


        }
    }
}
