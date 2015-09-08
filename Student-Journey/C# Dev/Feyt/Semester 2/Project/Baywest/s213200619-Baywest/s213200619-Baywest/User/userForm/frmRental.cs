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
        int rentalID;
        int customerID;
        int shopID;
        string rentalStartDate;
        string rentalEndDate;
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
                rentalID = int.Parse(metrodgvRental[0, e.RowIndex].Value.ToString());
                customerID = int.Parse(metrodgvRental[1, e.RowIndex].Value.ToString());
                shopID = int.Parse(metrodgvRental[2, e.RowIndex].Value.ToString());




                DateTime result = DateTime.Parse(metrodgvRental[3, e.RowIndex].Value.ToString());
                metroRentalStartDate.Value = result;
                rentalStartDate = result.ToString();

                result = DateTime.Parse(metrodgvRental[4, e.RowIndex].Value.ToString());
                metroRentalEndDate.Value = result;
                rentalEndDate = result.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ur = new userRental(rentalID, customerID, shopID, rentalStartDate, rentalEndDate);
                frmShop shop = new frmShop(ur);
                shop.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
