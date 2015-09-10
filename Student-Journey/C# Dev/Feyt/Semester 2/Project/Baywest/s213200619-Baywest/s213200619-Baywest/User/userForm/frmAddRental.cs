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
using System.IO;

namespace s213200619_Baywest.User.userForm
{
    public partial class frmAddRental : MetroForm
    {
        public frmAddRental()
        {
            InitializeComponent();
        }

        private void frmAddRental_Load(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            int rentalID = int.Parse(txtRentalID.Text.Trim());
            int customerID = int.Parse(txtCustomerID.Text.Trim());
            int shopID = int.Parse(txtShopID.Text.Trim());
            string rentalStarDate = dtRentalStartDate.Text;
            string rentalEndDate = dtRentalEndDate.Text;

            try
            {
                StreamWriter myWriter = new StreamWriter(@"Files\newRental.txt", true);
                myWriter.WriteLine(rentalID.ToString() + "#" + customerID.ToString() + "#" + shopID.ToString() + "#" + rentalStarDate.ToString() + "#" + rentalEndDate.ToString());
                myWriter.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
