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
    public partial class frmAddUser : MetroForm
    {
        string myUser;
        public frmAddUser(string myUser)
        {
            InitializeComponent();
            this.myUser = myUser;
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            txtLoginID.Text = myUser;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            int customerID;
            string customerName;
            string customerCell;
            int loginID;


            customerID = int.Parse(txtCustomerID.Text.Trim());
            customerName = txtCustomerName.Text.Trim();
            customerCell = txtCustomerCellNumber.Text.Trim();
            loginID = int.Parse(txtLoginID.Text.Trim());

            try
            {
                StreamWriter myWriter = new StreamWriter(@"Files\NewUser.txt", true);
                myWriter.WriteLine(customerID.ToString() + "#" + customerName.ToString() + "#" + customerCell.ToString() + "#" + loginID.ToString());
                myWriter.Close();
                MessageBox.Show("Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}
