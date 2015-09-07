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
using s213200619_Baywest.User.userClass;

namespace s213200619_Baywest.User.userForm
{
    public partial class frmRental : MetroForm
    {
        private userCustomer uc = new userCustomer();
        private userRental ur = new userRental();
        public frmRental(userCustomer uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void frmRental_Load(object sender, EventArgs e)
        {
            metrodgvRental.DataSource = ur.GetRental(uc.CustomerID);
        }

        private void metrodgvRental_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRentalID.Text = metrodgvRental[0, e.RowIndex].Value.ToString();
                txtCustomerID.Text = metrodgvRental[1, e.RowIndex].Value.ToString();
                txtShopID.Text = metrodgvRental[2, e.RowIndex].Value.ToString();




                DateTime result = DateTime.Parse(metrodgvRental[3, e.RowIndex].Value.ToString());
                metroRentalStartDate.Value = result;

                result = DateTime.Parse(metrodgvRental[4, e.RowIndex].Value.ToString());
                metroRentalEndDate.Value = result;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ur = new userRental(int.Parse(txtRentalID.Text), int.Parse(txtCustomerID.Text), int.Parse(txtShopID.Text), metroRentalStartDate.Text, metroRentalEndDate.Text);
            frmShop shop = new frmShop(ur);
            shop.ShowDialog();
        }
    }
}
