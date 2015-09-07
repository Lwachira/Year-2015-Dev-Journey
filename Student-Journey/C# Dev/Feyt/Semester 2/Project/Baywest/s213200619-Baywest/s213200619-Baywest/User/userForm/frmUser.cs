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
using s213200619_Baywest.Admin.adminClass;

namespace s213200619_Baywest.User.userForm
{
    public partial class frmUser : MetroForm
    {
        private userCustomer uc = new userCustomer();
        private classLoginDetails cl = new classLoginDetails();

        int customerID;
        string customerName;
        string customerCellNumber;
        int loginID;
        public frmUser(classLoginDetails cl)
        {
            InitializeComponent();
            this.cl = cl;


        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            metrodgvUser.DataSource = uc.GetUser(int.Parse(cl.LoginID.ToString()));

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uc = new userCustomer(customerID, customerName, customerCellNumber, loginID);
            frmRental rental = new frmRental(uc);
            rental.ShowDialog();
        }

        private void metrodgvUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                customerID = int.Parse(metrodgvUser[0, e.RowIndex].Value.ToString());
                customerName = metrodgvUser[1, e.RowIndex].Value.ToString();
                customerCellNumber = metrodgvUser[2, e.RowIndex].Value.ToString();
                loginID = int.Parse(metrodgvUser[3, e.RowIndex].Value.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
