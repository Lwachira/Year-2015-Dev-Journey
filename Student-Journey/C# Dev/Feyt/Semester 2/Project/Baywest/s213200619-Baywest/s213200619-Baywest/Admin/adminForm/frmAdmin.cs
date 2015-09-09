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
            frmLoginDetails loginDetails = new frmLoginDetails();
            loginDetails.ShowDialog();
        }

        private void metroCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            customer.ShowDialog();

        }
    }
}
